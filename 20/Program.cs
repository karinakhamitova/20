using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        delegate void MyDelegate(double r);
        static void Main(string[] args)
        {
          
            MyDelegate myDelegate = LengthCrl;
            myDelegate += SquareCrl;
            myDelegate += VolumeCrl;
            double r = Convert.ToDouble(Console.ReadLine());
            myDelegate(r);
            Console.ReadKey();

        }
        static void LengthCrl(double r) => Console.WriteLine($"Длина - {2 * Math.PI * r:.00}");
        static void SquareCrl(double r) => Console.WriteLine($"Площадь - {Math.PI * r * r:.00}");
        static void VolumeCrl(double r) => Console.WriteLine($"Объем - {Math.PI * r * r * r * 4 / 3:.00}");

    }

}
