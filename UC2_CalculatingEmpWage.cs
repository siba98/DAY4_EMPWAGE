using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class UC2_CalculatingEmpWage
    {
        public static void CalEmpWage()
        {
            //Constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;

            Console.WriteLine("EmpWage : " + empWage);
        }
    }
}
