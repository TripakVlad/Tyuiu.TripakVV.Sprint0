using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.TripakVV.Sprint0.Task6.V0.Lib;

namespace Tyuiu.TripakVV.Sprint0.Task6.V0
{
    class Programm
    {
        static void Main(string[] args)
        {
            int[] arraynums = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arraynums));

            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(arraynums));

            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(arraynums));

            Console.ReadKey();
        }
    }
}