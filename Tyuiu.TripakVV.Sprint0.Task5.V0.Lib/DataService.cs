﻿namespace Tyuiu.TripakVV.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static int Multipication(int a, int b)
        {
            return a * b;
        }
        public static double Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Переменная b = {0} на ноль делить нельзя", b);
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }
}
