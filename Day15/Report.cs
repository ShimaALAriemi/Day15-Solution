using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    internal class Report
    {
        public delegate bool salesConditions(Employee emp);
        public void TotalSalesGreaterThan5000(Employee[] em)
        {
            Console.WriteLine("Total Sales Greater Than 5000");
            Console.WriteLine("__________________________________________________\n");
            foreach (Employee emp in em)
                if (emp.TotalSales > 50000)
                    Console.WriteLine($"{emp.Id} | {emp.Name} | {emp.Gender} | {emp.TotalSales}");
        }

        public void TotalSalesGreaterThan5000LessThan3000(Employee[] em)
        {
            Console.WriteLine("\nTotal Sales Greater Than 5000 Less Than 3000");
            Console.WriteLine("__________________________________________________\n");

            foreach (Employee emp in em)
                if (emp.TotalSales <= 50000 && emp.TotalSales >= 30000)
                    Console.WriteLine($"{emp.Id} | {emp.Name} | {emp.Gender} | {emp.TotalSales}");
        }

        public void TotalSalesGreaterLessThan30000(Employee[] em)
        {
            Console.WriteLine("\nTotal Sales Greater Less Than 30000");
            Console.WriteLine("__________________________________________________\n");

            foreach (Employee emp in em)
                if (emp.TotalSales < 30000)
                    Console.WriteLine($"{emp.Id} | {emp.Name} | {emp.Gender} | {emp.TotalSales}");
            Console.WriteLine();
        }

        public void TotalSales(Employee[] emp, string title, salesConditions conditions) 
        {
            Console.WriteLine(title);
            Console.WriteLine("____________________________________");
            foreach (Employee employee in emp)
            {
                if (conditions(employee)) 
                {
                    Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.Gender} | {employee.TotalSales}");
                }
            }
        }
    }
}
