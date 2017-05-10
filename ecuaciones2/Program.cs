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
            // Consultar esto:  double.TryParse(Console.ReadLine(), out c);


            double a = 0, b = 0, c = 0, x1 = 0, x2 = 0;

            Console.WriteLine("Sistemas de ecuaciones de segundo grado");
            
            Console.Write("Ingrese a ");
            a = Convert.ToInt64(Console.ReadLine());
            
           

            Console.Write("Ingrese b ");
            b = Convert.ToInt64(Console.ReadLine());
           

            Console.Write("Ingrese c ");
            c = Convert.ToInt64(Console.ReadLine());
            

            x1 = ((-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a));
            x2 = ((-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a));



            
            // Codigo solo para verificar valor de x1 y x2
            Console.WriteLine("x1 " + x1);
            Console.WriteLine("x2 " + x2);
            Console.ReadKey();
        }
    }
}