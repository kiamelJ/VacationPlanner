using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using VacationPlanner.Models;

namespace VacationPlanner
{
    public class Handler
    {
        public static bool MainMenu()
        {

            Console.Clear();
            Console.WriteLine("Choose role:\r\n");
            Console.WriteLine("1) Employee");
            Console.WriteLine("2) Manager");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nYour choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    MakeReport();
                    return true;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Hello Manager. Make your choice:\r\n");
                    Console.WriteLine("1) Search for all application by employee name");
                    Console.WriteLine("2) Search by month of registration");
                    Console.WriteLine("3) Exit");
                    Console.Write("\r\nYour choice: ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            SearchByName();
                            return true;
                        case "2":
                            SearchByMonth();
                            return true;
                        case "3":
                            return false;
                        default:
                            return true;
                    }

                case "3":
                    return false;
                default:
                    return true;
            }
        }

        public static void MakeReport()
        {
            Console.Clear();
            VPContext context = new VPContext();
            Console.WriteLine("Hello Employee.\r\n");
            Console.WriteLine("Enter your name for leave application (list of available names below):\r\n");

            var employeeList = context.Employees.ToList();
            foreach (var item in employeeList)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\r\nEnter name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter type of vacation/leave (VAB, Semester, Tjänstledighet):");
            var type = Console.ReadLine();

            Console.WriteLine("Enter start date of vacation/leave (YYYY-MM-DD):");
            CultureInfo provider = CultureInfo.InvariantCulture;
            var start = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(start, "yyyy-MM-dd", provider);

            Console.WriteLine("Enter end date of vacation/leave (YYYY-MM-DD):");
            var end = Console.ReadLine();
            DateTime endDate = DateTime.ParseExact(end, "yyyy-MM-dd", provider);

            var employee = context.Employees.Single(e => e.Name == name);

            Vacation vacation = new Vacation()
            {
                Type = type,
                Name = name,
                StartDate = startDate,
                EndDate = endDate,
                //RegDate = new DateTime(2022, 03, 29, 15, 30, 00),
                RegDate = DateTime.Now,
                Employee = employee

            };
            context.Vacations.Add(vacation);
            context.SaveChanges();
        }

        public static void SearchByName()
        {
            VPContext context = new VPContext();
            Console.Clear();
            Console.WriteLine("Search registered vacation/leave application (list of employees below):\r\n");
            var employeeList = context.Employees.ToList();
            foreach (var item in employeeList)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\r\nEnter name: ");
            var name = Console.ReadLine();
            Console.Clear();

            var employee = from e in context.Vacations
                           where e.Name == name
                           select e;

            foreach (var item in employee)
            {
                Console.WriteLine($"Employee name: {item.Name}");
                Console.WriteLine($"Leave/Vacation: {item.Type}");
                Console.WriteLine($"Start date: {item.StartDate.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"End date: {item.EndDate.ToString("yyyy-MM-dd")}");
                Console.WriteLine(new string('-', (40)));
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void SearchByMonth()
        {
            VPContext context = new VPContext();
            Console.Clear();
            Console.WriteLine("Please enter month to get data (1-12):");
            var month = Int32.Parse(Console.ReadLine());
            var date2 = context.Vacations.Where(d => d.RegDate.Month == month);

            foreach (var item in date2)
            {
                Console.WriteLine($"Employee name: {item.Name}");
                Console.WriteLine($"Start date: {item.StartDate.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"End date: {item.EndDate.ToString("yyyy-MM-dd")}");
                Console.WriteLine($"Days applied for: {(item.EndDate - item.StartDate).TotalDays + 1}");
                Console.WriteLine($"Date of registration: {item.RegDate.ToString("yyyy-MM-dd HH:mm")}");
                Console.WriteLine(new string('-', (40)));
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
