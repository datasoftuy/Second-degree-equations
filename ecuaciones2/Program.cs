using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ecuaciones2
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 0, b = 0, c = 0, x1 = 0, x2 = 0;

            Console.WriteLine("Sistemas de ecuaciones de segundo grado");
            
            Console.Write("Ingrese a ");
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("Ingrese b ");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("Ingrese c ");
            double.TryParse(Console.ReadLine(), out c);

            x1 = ((-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a));
            x1 = ((-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a));

            Console.WriteLine("x1 " + x1);
            Console.WriteLine("x2 " + x2);
            Console.ReadKey();
        }
    }
}