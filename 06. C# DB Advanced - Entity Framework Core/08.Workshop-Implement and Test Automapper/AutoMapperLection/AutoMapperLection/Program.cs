using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AutoMapperLection
{
    class Program
    {
        static void Main(string[] args)
        {
            //AutoMapper
            //Newtonsoft.Json

            Person person = new Person()
            {
                FirstName = "Petar",
                LastName = "Petrov",
                Age = 20,
                Courses = new List<PersonCourse>()
                {
                    new PersonCourse()
                    {
                        Name ="DB"
                    },
                    new PersonCourse()
                    {
                        Name = "ASP.NET"
                    }
                }
            };

            //Student student = new Student()
            //{
            //    FirstName = person.FirstName,
            //    LastName = person.LastName
            //};

            Mapper.Initialize(cfg =>  // инициализира се само 1 път в началото на проекта
            {
                cfg.CreateMap<Person, Student>() // кое към кое да мапне
                .ForMember(dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}")) //да мапне разликите
                .ForMember(dest => dest.FirstName, opt => opt.Ignore()); //игнорираме firstname

                cfg.CreateMap<PersonCourse, StudentCourse>();
            });

            var student = Mapper.Map<Student>(person); //създаваме обекта и кои пропартита да вземе

            Console.WriteLine(JsonConvert.SerializeObject(student)); // прави го на 1 string във фомата ма json
        }
    }
}
