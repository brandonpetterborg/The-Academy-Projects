using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub119
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee1.SayName();
            Console.ReadLine();
        }
    }
}
