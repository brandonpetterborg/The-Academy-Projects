using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub123
{
    public class Employee : Person
    {
        

        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        

        public override void SayName()
        {
            Console.WriteLine("name: [" + FirstName + " " + LastName + "]");
            
        }
        public static Employee operator= (Employee employee, EmployeeId employeeId)
        {
            employeeId.Equals(employeeId);
            
        }
    }
}
