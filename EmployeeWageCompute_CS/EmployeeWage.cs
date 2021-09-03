using System;

namespace EmployeeWageCompute_CS
{/// <summary>
///Creating EmployeeWageCompute template for finding employeewage
/// </summary>
    class EmployeeWageCompute
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            //UC4 Daily Employee Wage Calculation using switch

            //local variables
            int empHrs = 0;
            int empWage = 0;

            //Predefined random class for generating random values
            Random random = new Random();

            //Next method() 0-initial value,3-number of element from 0
            int empCheck = random.Next(0, 3);
            Console.WriteLine("Checking employee status" + empCheck);

            //Selection Switch statement
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 4;
                    break;
            }

            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Daily employee wage is:"  + empWage);
            Console.ReadLine();
        }
    }
}
