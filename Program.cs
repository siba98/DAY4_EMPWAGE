using System;
using Day4.UC9;
using Day4.UC10;
using Day4.UCLast_FinalSolution;

namespace Day4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problems");

            UC1_EmployeeAttendance.GetAttendance();
            //We have to create object if static keyword is not used like:
            //UC1_EmployeeAttendance obj = new UC1_EmployeeAttendance();
            //obj.GetAttendance();
            UC2_CalculatingEmpWage.CalEmpWage();
            UC3_PartTimeEmpWage.PartTimeEmpWage();
            UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();
            UC5_CalculateWagesFor20DaysInMonth.CalculateWagesFor20DaysInMonth();
            UC6_CalculateWageTill100HrsOr20IsReached.CalculateWageTill100HrsOr20IsReached();
            UC7_ComputeEmpWageUsingClassMethod.ComputeEmpWage();
            UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("HCL", 30, 22, 176);

            //#region UC9
            //EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            //EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            //dMart.computeEmpWage();
            //Console.WriteLine(dMart.toString());
            //reliance.computeEmpWage();
            //Console.WriteLine(reliance.toString());
            //#endregion

            //#region UC10
            //EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            //empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            //empWageBuilder.computeEmpWage();
            //#endregion

            #region UCLast_FinalSolution
            EmpWageBuilder empWageBuild = new EmpWageBuilder();
            empWageBuild.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuild.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuild.computeEmpWage();
            #endregion

            Console.ReadKey();
        }
    }
}
