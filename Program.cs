using System;

namespace Day4
{
    class Program
    {
        public static void Main(string[] args)
        {

            //UC1_EmployeeAttendance.GetAttendance();
            //We have to create object if static keyword is not used like:
            //UC1_EmployeeAttendance obj = new UC1_EmployeeAttendance();
            //obj.GetAttendance();
            //UC2_CalculatingEmpWage.CalEmpWage();
            //UC3_PartTimeEmpWage.PartTimeEmpWage();
            //UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();
            //UC5_CalculateWagesFor20DaysInMonth.CalculateWagesFor20DaysInMonth();
            //UC6_CalculateWageTill100HrsOr20IsReached.CalculateWageTill100HrsOr20IsReached();
            UC7_ComputeEmpWageUsingClassMethod.ComputeEmpWage();
            //UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("HCL",30,22,176);



            Console.ReadKey();
        }
    }
}
