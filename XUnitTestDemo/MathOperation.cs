﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestDemo
{
    public static class MathOperation
    {
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }
        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }
        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }

        public static int Minimum(int a, int b, int c)
        {
            int min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            return min;
        }

        public static Guid ConvertStringToGuid(this string id)
        {
            if (Guid.TryParse(id, out Guid idAsGuid))
                return idAsGuid;
            else
                throw new Exception("can't convert string to guid");
        }
    }
}
