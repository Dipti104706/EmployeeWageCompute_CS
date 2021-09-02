using System;

namespace EmployeeWageCompute_CS
{
    class EmployeeWageCompute
    {
        static void Main(string[] args)
        {
            //UC2 Daily Employee Wage Calculation

            //Constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            //Predefined random class for generating random values
            Random random = new Random();

            //Next method() 0-initial value,2-number of element from 0
            int empCheck = random.Next(0, 2);
            Console.WriteLine("Checking employee status" + empCheck);

            //Selection statement
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            empWage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Daily employee wage is" + empWage);
            Console.ReadLine();
        }
    }
}
