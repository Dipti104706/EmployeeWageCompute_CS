using System;

namespace EmployeeWageCompute_CS
{/// <summary>
///Creating EmployeeWageCompute template for finding employeewage
/// </summary>
    class EmployeeWageCompute
    {
        //UC7 Refactor the code to write method for Employee Wage Calculation for a month
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;

        //Creating method for checking employee attendance
        public static int empAttendance()
        {
            Random random = new Random();
            int empAttendance = random.Next(0, 3);
            return empAttendance;
        }

        //creating method to calculate employee wage
        public static void empWage()
        {
            //local variables
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 1;
            

            while (totalEmpHrs <= MAX_WORKING_HRS && totalWorkingDays <= NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                int empCheck = empAttendance();
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
            Console.WriteLine("Total employee wage:" + totalEmpWage);
        }

        static void Main(string[] args)
        {
            EmployeeWageCompute.empWage();
            Console.ReadLine();
        }
    }
}