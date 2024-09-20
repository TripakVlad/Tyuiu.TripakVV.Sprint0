using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TripakVV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.TripakVV.Sprint0.Task2.V0
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Влад"));
            Console.ReadKey();
        }
    }
}