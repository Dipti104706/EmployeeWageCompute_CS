using System;

namespace EmployeeWageCompute_CS
{/// <summary>
///Creating EmployeeWageCompute template for finding employeewage
/// </summary>
    class EmployeeWageCompute
    {
        static void Main(string[] args)
        {
            //UC3 Daily Employee Wage Calculation with part-time

            //Constants
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //local variables
            int empHrs = 0;
            int empWage = 0;

            //Predefined random class for generating random values
            Random random = new Random();

            //Next method() 0-initial value,3-number of element from 0
            int empCheck = random.Next(0, 3);
            Console.WriteLine("Checking employee status" + empCheck);

            //Selection statement
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }

            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Daily employee wage is:"  + empWage);
            Console.ReadLine();
        }
    }
}
