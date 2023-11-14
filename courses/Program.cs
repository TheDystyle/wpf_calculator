using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character("qwerty");
            c.Health = 777;
            
            Console.WriteLine(c.Health);
            Console.WriteLine(c.Race);

            Calculator calc = new Calculator();

            //double cut = c.CalcTriangleSquare(ab: 10, bc: 20, corner: 50);
            //Console.WriteLine(cut);

            //int[] myArr = { 1, 1, 1, 1, 1, 1, 1, 1,1,1 };

            //void ReturnSumArra(int[] inputArr)
            //{
            //    int sum = 0;
            //    foreach (int i in myArr)
            //    {
            //        sum += i;
            //    }
            //    Console.WriteLine(sum);
            //}

            //ReturnSumArra(myArr);

            // method 1
            //Console.WriteLine("Enter a number, please.");
            //string line = Console.ReadLine();

            //int number;

            //bool wasParsed = int.TryParse(line, out number);
            //if (wasParsed)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("It's not a number!");
            //}


            // method 2
            //Console.WriteLine("Enter a number, please.");
            //string line = Console.ReadLine();

            //bool wasParsed = int.TryParse(line, out int number);
            //if (wasParsed)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("It's not a number!");
            //}

            //method 3

            //if(calc.TryDivide(10, 0, out double res))
            //{
            //    Console.WriteLine(res);
            //}
            //else
            //{
            //    Console.WriteLine("Wrong parameter");
            //};

            // method 4

            //if (Calculator.TryDivide(5, 0, out double res))
            //{
            //    Console.WriteLine(res);
            //}
            //else
            //{
            //    Console.WriteLine("Wrong parameter");
            //};

            //Calculator.Average(2,1,2,1,2,1,5);

            //method 5

            //Character c1 = new Character();
            //Character c2 = new Character();

            //Console.WriteLine($"c1.speed = {c1.PrintSpeed()}");
            //Console.WriteLine($"c2.speed = {c2.PrintSpeed()}");

            //c1.IncreaseSpeed();
            //c2.IncreaseSpeed();
            //c2.IncreaseSpeed();
            //c2.IncreaseSpeed();
            //c2.IncreaseSpeed();

            //Console.WriteLine($"c1.speed = {c1.PrintSpeed()}");
            //Console.WriteLine($"c2.speed = {c2.PrintSpeed()}");

        }
    }
}
