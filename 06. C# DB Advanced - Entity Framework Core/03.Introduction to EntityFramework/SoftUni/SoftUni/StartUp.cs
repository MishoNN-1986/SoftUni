using System;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;

namespace SoftUni
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //public StartUp
            //Ctrl + Q -> Console or Power Shell (NuGet)
            //Install-Package Microsoft.EntityFrameworkCore.Tools –v 3.1.3
            //Install-Package Microsoft.EntityFrameworkCore.SqlServer –v 3.1.3 // Provider
            //Install-Package Microsoft.EntityFrameworkCore.SqlServer.Design
            //Scaffold-DbContext -Connection "Server=.;Database=SoftUni;Integrated Security=True;" -Provider Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data/Models
            //partial ги премахваме ctrl + shift + H -> replace in files
            //променяме имената на класовете в ед.ч.
            //слагаме this. в конструкторите и премахваме и virtual(структурираме редовете в класовете), защото още не сме взели lazy loading, а сега сме с eager loading
            //all DBContexts(no virtual) in folder Data
            //папка Models извън Data, като оправяме namespace навсякъде
            // In MSSQL - Tools => SQL Server Profiler - заявката която даваме

            using (var context = new SoftUniContext())
            {
                var result = GetEmployeesFullInformation(context);
                //Console.WriteLine(result);

                result = GetEmployeesWithSalaryOver50000(context);
                //Console.WriteLine(result);

                result = GetEmployeesFromResearchAndDevelopment(context);
                //Console.WriteLine(result);

                result = AddNewAddressToEmployee(context);
                //Console.WriteLine(result);

                result = GetEmployeesInPeriod(context);
                //Console.WriteLine(result);

                result = GetAddressesByTown(context);
                //Console.WriteLine(result);

                result = GetEmployee147(context);
                //Console.WriteLine(result);

                result = GetDepartmentsWithMoreThan5Employees(context);
                //Console.WriteLine(result);

                result = GetLatestProjects(context);
                //Console.WriteLine(result);

                result = IncreaseSalaries(context);
                //Console.WriteLine(result);

                result = GetEmployeesByFirstNameStartingWithSa(context);
                //Console.WriteLine(result);

                result = DeleteProjectById(context);
                //Console.WriteLine(result);

                result = RemoveTown(context);
                Console.WriteLine(result);
            }

        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Select(e => new //анонимен обект (може и с var, който е AnonymosType), иначе може и без Select, но праща излишни неща в заявката(взимаме само тези колони, които ни трябват)
                {
                    e.FirstName,
                    e.LastName,
                    e.MiddleName,
                    e.JobTitle,
                    e.Salary,
                    e.EmployeeId
                })
                .OrderBy(x => x.EmployeeId)
                .ToList(); // с ToList данните са материализирани и заредени, иначе ще стане чак във foreach, при извикване ползва само 1 заявка, иначе за всяко извикване отделна заявка в SQL Server Profiler

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:F2}");
            }

            return sb.ToString().Trim();
        }

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Where(s => s.Salary > 50000)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .OrderBy(f => f.FirstName)
                .ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:F2}");
            }

            return sb.ToString().Trim();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Where(d => d.Department.Name == "Research and Development")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Department.Name,
                    e.Salary
                })
                .OrderBy(s => s.Salary)
                .ThenByDescending(f => f.FirstName)
                .ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} from Research and Development - {employee.Salary:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var address = new Address //insert
            {
                AddressText = "Vitoshka 15", // ctrl + space
                TownId = 4
            };

            //context.Addresses.Add(address);

            var nakov = context.Employees.FirstOrDefault(x => x.LastName == "Nakov");
            nakov.Address = address; //автоматично добавя адреса (update)

            context.SaveChanges();

            var employeeAddresses = context.Employees
                .OrderByDescending(a => a.AddressId)
                .Select(a => a.Address.AddressText)
                .Take(10)
                .ToList();

            foreach (var employeeAdress in employeeAddresses)
            {
                sb.AppendLine($"{employeeAdress}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Where(p => p.EmployeesProjects.Any(s => s.Project.StartDate.Year >= 2001 && s.Project.StartDate.Year <= 2001))
                .Select(e => new
                {
                    EmployeeFullName = e.FirstName + " " + e.LastName,
                    ManagerFullName = e.Manager.FirstName + " " + e.Manager.LastName,
                    Projects = e.EmployeesProjects.Select(p => new
                    {
                        ProjectName = p.Project.Name,
                        StartDate = p.Project.StartDate,
                        EndDate = p.Project.EndDate
                    }).ToList()
                })
                .Take(10)
                .ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.EmployeeFullName} - Manager: {employee.ManagerFullName}");

                foreach (var project in employee.Projects)
                {
                    var startDate = project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                    var endDate = project.EndDate.HasValue ?
                        project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                        : "not finished";

                    sb.AppendLine($"--{project.ProjectName} - {startDate} - {endDate}");
                }
            }

            return sb.ToString().TrimEnd();

        }

        public static string GetAddressesByTown(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var addresses = context.Addresses
                .Select(a => new
                {
                    a.AddressText,
                    TownName = a.Town.Name,
                    EmployeesCount = a.Employees.Count
                })
                .OrderByDescending(e => e.EmployeesCount)
                .ThenBy(t => t.TownName)
                .ThenBy(a => a.AddressText)
                .Take(10)
                .ToList();

            foreach (var address in addresses)
            {
                sb.AppendLine($"{address.AddressText}, {address.TownName} - {address.EmployeesCount} employees");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            const int EmployeeId = 147;

            StringBuilder sb = new StringBuilder();

            var employee = context.Employees
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    ProjectNames = e.EmployeesProjects
                        .Select(p => p.Project.Name)
                        .ToList(),
                    e.EmployeeId
                })
                .FirstOrDefault(e => e.EmployeeId == EmployeeId);

            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

            foreach (var project in employee.ProjectNames)
            {
                sb.AppendLine(project);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var departments = context.Departments
                .Select(d => new
                {
                    DepartmentName = d.Name,
                    employeesCount = d.Employees.Count,
                    ManagerFirstName = d.Manager.FirstName,
                    ManagerLastName = d.Manager.LastName,
                    Employees = d.Employees
                        .Select(e => new
                        {
                            e.FirstName,
                            e.LastName,
                            e.JobTitle
                        })
                        .OrderBy(e => e.FirstName)
                        .ThenBy(e => e.LastName)
                        .ToList()
                })
                .Where(e => e.employeesCount > 5)
                .OrderBy(e => e.Employees.Count) //
                .ThenBy(d => d.DepartmentName)
                .ToList();

            foreach (var department in departments)
            {
                sb.AppendLine($"{department.DepartmentName} - {department.ManagerFirstName}  {department.ManagerLastName}");

                foreach (var employee in department.Employees)
                {
                    sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var projects = context.Projects
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.StartDate
                })
            .OrderBy(p => p.Name)
            .ThenBy(s => s.StartDate)
            .Take(10)
            .ToList();

            foreach (var project in projects)
            {
                sb.AppendLine(project.Name)
                    .AppendLine(project.Description)
                    .AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture));
            }

            return sb.ToString().TrimEnd();
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            string[] departments = new string[] { "Engineering", "Tool Design", "Marketing", "Information Services" };
            decimal salaryIncrease = 0.12m;

            var employees = context.Employees
                .Where(e => departments.Contains(e.Department.Name))
                .ToList();

            foreach (var employee in employees)
            {
                employee.Salary += employee.Salary * salaryIncrease;
            }

            context.SaveChanges();


            StringBuilder sb = new StringBuilder();

            var employeesWithIncreaseSalary = context.Employees
                .Where(e => departments.Contains(e.Department.Name))
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            foreach (var employee in employeesWithIncreaseSalary)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} ({employee.Salary:F2})");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    e.Salary
                })
                .Where(f => EF.Functions.Like(f.FirstName, "Sa%"))//по-добре е написана функцията във MSSQL .Where(e => e.FirstName.StartsWith("Sa"))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:F2})");
            }

            return sb.ToString().TrimEnd();
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            //трием първо в mapping table референциите, после при нас

            var project = context.Projects
                .FirstOrDefault(p => p.ProjectId == 2);

            var employeeProjects = context.EmployeesProjects
                .Where(p => p.ProjectId == 2)
                .ToList();

            //context.EmployeesProjects.RemoveRange(employeeProjects); // същото като foreach

            foreach (var employeeProject in employeeProjects)
            {
                context.EmployeesProjects.Remove(employeeProject);
            }

            context.Projects.Remove(project);

            context.SaveChanges();

            var projects = context.Projects
                .Select(p => p.Name)
                .Take(10)
                .ToList();

            foreach (var currentProject in projects)
            {
                sb.AppendLine(currentProject);
            }

            return sb.ToString().TrimEnd();
        }

        public static string RemoveTown(SoftUniContext context)
        {
            Town town = context.Towns.FirstOrDefault(t => t.Name == "Seattle");

            var addresses = context.Addresses
                .Where(a => a.TownId == town.TownId)
                .ToList();

            foreach (var employee in context.Employees)
            {
                if (addresses.Contains(employee.Address))
                {
                    employee.Address = null;
                }
            }

            context.Addresses.RemoveRange(addresses);
            context.Towns.Remove(town);
            context.SaveChanges();

            if (addresses.Count == 1)
            {
                return "1 address in Seattle was deleted";
            }
            else
            {
                return $"{addresses.Count} addresses in Seattle was deleted";
            }
        }
    }
}
