using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courses
{
    public class Calculator
    {
        public static double CalcTriangleSquare(double ab, double bc, double ac)
        {
            double p = (ab + bc + ac) / 2;
            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
        }
        public static double CalcTriangleSquare(double a, double b)
        {
            return 0.5 * a * b;
        }
        public static double CalcTriangleSquare(double ab, double bc, int alpha, bool isInRadians = false)
        {
            if(isInRadians)
            {
                return 0.5 * ab * bc * Math.Sin(alpha);
            }
            else
            {
                double rads = alpha * Math.PI / 180;
                return 0.5 * ab * bc * Math.Sin(rads); 
            }
           
        }
        //public static double CalcTriangleSquare(double ab, double bc, int alpha)
        //{
        //        double rads = alpha * Math.PI / 180;
        //        return 0.5 * ab * bc * Math.Sin(rads);    
        //}


        public static bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0;
            if (divisor == 0)
            {
                return false;
            }
            result = divisible / divisor;
            return true;
        }

        public static void Average(params int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            Console.WriteLine(sum/numbers.Length);
        }
    }
}