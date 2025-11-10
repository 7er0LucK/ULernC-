using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULernC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LeapYear(315, 1864));
            Console.ReadKey();
        }

        static string ReplaceValue(int value1, int value2)
       /* Expr1. Как поменять местами значения двух переменных?
          Можно ли это сделать без ещё одной временной переменной.
          Стоит ли так делать? */
        {
         /* value2 = value1 + value2;
            value1 = value2 - value1;
            value2 = value2 - value1; */

            (value1, value2) = (value2, value1);

            string Value = $"A = {value1}, B = {value2}";
            return Value;
        }

        static int ReversValue(int value)
       /* Expr2. Задается натуральное трехзначное число
          (гарантируется, что трехзначное).
          Развернуть его, т.е. получить трехзначное число,
          записанное теми же цифрами в обратном порядке. */
        {
           /* int a, b, c;
              a = value / 100;
              b = value % 100 / 10;
              c = value % 10;
              int RotateValue = c*100 + b*10 + a; */

            var RotateValue = int.Parse(new string(value.ToString().Reverse().ToArray()));
            return RotateValue;
        }

        static int AngleDegree(int value)
       /* Expr3.Задано время Н часов(ровно).
          Вычислить угол в градусах между часовой и минутной стрелками.
          Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов.
          Не использовать циклы. */
        {
            int hour = 6 - Math.Abs(6 - (value % 12));
            int degree = hour * 30;
            return degree;
        }

        static int SimpleDely(int N, int X, int Y)
       /* Expr4. Найти количество чисел меньших N,
          которые имеют простые делители X или Y. */
        {
            N = N - 1;
            int delys = (N / X) + (N / Y) - (N / (X * Y));
            return delys;
            int years = (year2/4) - ((year1-1)/4);
            int hundyears = year2 / 100 - year1 / 100;
            int leap = years - (hundyears - (hundyears / 4));
            return leap;
        }

        static int LeapYear(int year1, int year2)
       /* Expr5. Найти количество високосных лет на отрезке [a, b] 
          не используя циклы.*/
        {
            int years = (year2 / 4) - ((year1 - 1) / 4);
            int hundyears = year2 / 100 - year1 / 100;
            int leap = years - (hundyears - (hundyears / 4));
            return leap;
        }

        static int DotToLine(int dotA, int dotB)
       /* Expr6. Посчитать расстояние от точки до прямой, 
          заданной двумя разными точками.*/
        {
            return dotA * dotB;
        }
    }
}

namespace RomanSakutin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}