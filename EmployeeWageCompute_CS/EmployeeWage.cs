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
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        static void Main(string[] args)
        {
            //UC5 Daily Employee Wage Calculation for a month

            //local variables
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 1;

            while (totalEmpHrs <= MAX_WORKING_HRS && totalWorkingDays <=NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                //Predefined random class for generating random values
                Random random = new Random();

                //Next method() 0-initial value,3-number of element from 0
                int empCheck = random.Next(0, 3);

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

                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total employee wage:" +totalEmpWage);
            Console.ReadLine();
        }
    }
}