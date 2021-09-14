using System;

namespace EmployeeWageCompute_CS
{/// <summary>
///Creating EmployeeWageCompute template for finding employeewage
/// </summary>
    class EmployeeWageCompute
    {
        //UC8 to multiple company Employee Wage Calculation for a month
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        //Creating method for checking employee attendance
        Random random = new Random();
        public int empAttendance()
        {
            int empAttendance = random.Next(0, 3);
            return empAttendance;
        }

        //creating method to calculate employee wage
        public void empWage(string company, int empRatePerHr,int numOfWorkingDays, int maxWorkingHrs)
        {
            //local variables
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 1;
            
            while (totalEmpHrs <= maxWorkingHrs && totalWorkingDays <= numOfWorkingDays)
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
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Total employee wage for {0} company is {1}:" , company, + totalEmpWage);
        }

        static void Main(string[] args)
        {
            EmployeeWageCompute emp1 = new EmployeeWageCompute();
            emp1.empWage("cognizant",40,20,80);
            emp1.empWage("Accenture", 38, 20, 85);
            Console.ReadLine();   
        }
    }
}