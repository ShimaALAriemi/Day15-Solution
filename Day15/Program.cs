using System.Reflection;
using System.Xml.Linq;

namespace Day15
{
    internal class Program
    {
        public static void Print<T>(T val) 
        {
            Console.WriteLine(typeof(T));
            Console.WriteLine(val);
        }
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee{Id = 1 , Name = "Shaima" , Gender = 'f', TotalSales =299999m },
                new Employee{Id = 2, Name = "Ali" , Gender = 'm', TotalSales =29999m},
                 new Employee{Id = 3, Name = "Bader" , Gender = 'm', TotalSales =9000000m }
            };
            Report report = new Report();
            report.TotalSalesGreaterThan5000(employees);
            report.TotalSalesGreaterThan5000LessThan3000(employees);
            report.TotalSalesGreaterLessThan30000(employees);

            report.TotalSales(employees, "Total Sales Greater Than 5000", (emp) => emp.TotalSales > 50000);

            Print("Rabab");
            Print(9);
            Print('S');


        }
    }
}