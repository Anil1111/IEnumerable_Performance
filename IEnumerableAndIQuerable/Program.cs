using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIQuerable
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities ent = new NorthwindEntities();
            IQueryable<Employee> emp = ent.Employees;
            IEnumerable<Employee> temp = emp.Where(x => x.EmployeeID  == 5);

            foreach(var x in temp)

            {
                Console.WriteLine(x.FirstName);
            }
            Console.ReadLine();
        }
    }
}
