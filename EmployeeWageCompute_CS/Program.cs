using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute_CS
{
    class EmployeeWageCompute
    {
        static void Main(string[] args)
        {
            //UC1 Employee Wage

            //Constants
            int IS_PRESENT = 1;

            //Predefined random class for generating random values
            Random random = new Random();

            //Next method() 0-initial value,2-number of element from 0
            int empCheck = random.Next(0, 2);
            Console.WriteLine("Checking employee status" + empCheck);

            //Selection statement
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadLine();
        }
    }
}
