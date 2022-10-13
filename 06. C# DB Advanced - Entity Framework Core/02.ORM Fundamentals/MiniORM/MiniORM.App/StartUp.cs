namespace MiniORM.App
{
    using System.Linq;
    using Data;
    using Data.Entities;

    public class StartUp
    {
        public static void Main()
        {
            //var connectionString = @"Server=DESKTOP-MFH0NH3\SQLEXPRESS\SQLEXPRESS;Database=MiniORM;Integrated Security=True";

            //SoftUniDbContext db = new SoftUniDbContext(connectionString);

            SoftUniDbContext db = new SoftUniDbContext(Configuration.ConnectionString);

            db.Employees.Add(new Employee("Gosho", "Inserted", db.Departments.First().Id, true));

            Employee employee = db.Employees.Last();
            employee.FirstName = "Modified";

            db.SaveChanges();
        }
    }
}
