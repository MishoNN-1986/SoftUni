using _01._HospitalDatabase.Data;
using System;

namespace _01._HospitalDatabase
{
    public class StartUp //add reference to HospitalDatabase.Data
    {
        public static void Main(string[] args) ////class library не можем да ги вмъкнем 1 в друг, за това ги правим с точки
        {
            //var db = new HospitalContext(); // така е без миграция
            //db.Database.EnsureCreated();

            //може вместо отделни проекти да има папка Data, и в нея папка Models
            //Microsoft.EntityFrameworkCore.SqlServer.Design
            //Microsoft.EntityFrameworkCore.Tools
            //package manager console (PowerShell)
            //default project: 01. HospitalDatabase.Data
            //build project
            //add-migration InitialCreate - името (подготвя се полето, но все още я няма базата)
            //remove-migration (трием последната)
            //update-database (може и името от history, и връща към нея)- след всяко add, за да ни добави промените в базата
            //20220314111056_InitialCreate - тук са ни описани таблиците
            //dbo._EFMigrationHistory в базата за историята
            //Add-Migration AddedDoctorEntity
            //update-database
        }
    }
}
