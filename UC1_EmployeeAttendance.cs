﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class UC1_EmployeeAttendance
    {
        public static void GetAttendance()
        {
            //Constants                   
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
            Console.ReadKey();
        }

    }
}
