namespace SoftJail.DataProcessor
{

    using Data;
    using Newtonsoft.Json;
    using SoftJail.Data.Models;
    using SoftJail.Data.Models.Enums;
    using SoftJail.DataProcessor.ImportDto;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    public class Deserializer
    {
        private const string InvalidDataMessage = "Invalid Data";

        public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
        {
            var allDepartments = JsonConvert.DeserializeObject<Department[]>(jsonString);

            var validDepartments = new List<Department>();
            var sb = new StringBuilder();

            foreach (var department in allDepartments)
            {
                var isValid = IsValid(department) &&
                    department.Cells.All(IsValid);

                if (isValid)
                {
                    validDepartments.Add(department);
                    sb.AppendLine($"Imported {department.Name} with {department.Cells.Count} cells");
                }

                else
                {
                    sb.AppendLine(InvalidDataMessage);
                }
            }

            context.Departments.AddRange(validDepartments);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            var prisonersDto = JsonConvert.DeserializeObject<PrisonerDto[]>(jsonString);

            var validPrisoners = new List<Prisoner>();

            var sb = new StringBuilder();

            foreach (var dto in prisonersDto)
            {
                var isValid = IsValid(dto) &&
                    dto.Mails.All(IsValid);

                if (isValid)
                {
                    var prisoner = new Prisoner
                    {
                        FullName = dto.FullName,
                        Nickname = dto.Nickname,
                        Age = dto.Age,
                        IncarcerationDate = DateTime.ParseExact(
                            dto.IncarcerationDate,
                            "dd/MM/yyyy",
                            CultureInfo.InvariantCulture),
                        ReleaseDate = dto.ReleaseDate == null // може да е null, за това или тернарен оператор, или го извежаме преди това
                             ? (DateTime?)null //new DateTime?()
                             : DateTime.ParseExact(
                                 dto.ReleaseDate,
                                 "dd/MM/yyyy",
                                 CultureInfo.InvariantCulture),
                        Bail = dto.Bail,
                        CellId = dto.CellId,
                        Mails = dto.Mails
                        .Select(m =>
                        new Mail
                        {
                            Description = m.Description,
                            Sender = m.Sender,
                            Address = m.Address

                        })
                        .ToArray()
                    };

                    validPrisoners.Add(prisoner);
                    sb.AppendLine($"Imported {prisoner.FullName} {prisoner.Age} years old");
                }

                else
                {
                    sb.AppendLine(InvalidDataMessage);
                }
            }
            context.Prisoners.AddRange(validPrisoners);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportOfficersPrisoners(SoftJailDbContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(OfficerDto[]), new XmlRootAttribute("Officers"));

            var allOfficers = (OfficerDto[])serializer.Deserialize(new StringReader(xmlString));

            var validOfficers = new List<Officer>();
            var sb = new StringBuilder();

            foreach (var dto in allOfficers)
            {
                var isWeaponValid = Enum.TryParse(dto.Weapon, out Weapon weapon);
                var isPositionValid = Enum.TryParse(dto.Position, out Position position);

                var isValid = IsValid(dto) && isWeaponValid && isPositionValid;

                if (isValid)
                {
                    var officer = new Officer
                    {
                        FullName = dto.Name,
                        Salary = dto.Money,
                        Position = position,
                        Weapon = weapon,
                        DepartmentId = dto.DepartmentId,
                        OfficerPrisoners = dto.Prisoners
                        .Select(p =>
                        new OfficerPrisoner
                        {
                           PrisonerId = p.Id
                        })
                        .ToArray()
                    };

                    validOfficers.Add(officer);
                    sb.AppendLine($"Imported {officer.FullName} ({officer.OfficerPrisoners.Count} prisoners)");
                }

                else
                {
                    sb.AppendLine(InvalidDataMessage);
                }
            }

            context.Officers.AddRange(validOfficers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object entity)
        {
            var validationContext = new ValidationContext(entity);
            var validationResult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(entity, validationContext, validationResult, true);

            return isValid;
        }
    }
}