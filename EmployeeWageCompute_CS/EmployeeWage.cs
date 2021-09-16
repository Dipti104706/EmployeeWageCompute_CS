using System;

namespace EmployeeWageCompute_CS
{/// <summary>
///Creating EmployeeWageCompute template for finding employeewage
/// </summary>
    class EmployeeWageCompute
    {
        //UC9 to ability to save totalwage for each company
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        string company;
        int empRatePerHr;
        int numOfWorkingDays;
        int maxWorkingHrs;
        int totalEmpWage;

        public EmployeeWageCompute(string company, int empRatePerHr, int numOfWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }

        //Creating method for checking employee attendance
        Random random = new Random();
        public int empAttendance()
        {
            int empAttendance = random.Next(0, 3);
            return empAttendance;
        }

        //creating method to calculate employee wage
        public void empWage()
        {
            //local variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            
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
                //Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHr;
            Console.WriteLine("Total employee wage for {0} company is {1}:" , company, + totalEmpWage);
        }

        //public override string ToString()
        //{
        //    return "Total employee wage for company" + this.company + "is:" + this.totalEmpWage;
        //}
        static void Main(string[] args)
        {
            EmployeeWageCompute Cognizant = new EmployeeWageCompute("Cognizant", 40, 20, 80);
            Cognizant.empWage();
            //Console.WriteLine(Cognizant.ToString());
            EmployeeWageCompute Accenture = new EmployeeWageCompute("Accenture", 55, 20, 80);
            Accenture.empWage();
            //Console.WriteLine(Accenture.ToString());
            Console.ReadLine();   
        }
    }
}