﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsAssignment1
{
    public class Math
    {
        public static int MyDivInt(int a, int b)
        {
            return a%b;
        }
        public static decimal MyDivDec(decimal a, decimal b)
        {
            return Convert.ToInt32( a / b);
        }
        public static string MyDivString(string a, string b)
        {
            return a+b;        
        }



    }
}
