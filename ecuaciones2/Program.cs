using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leapyear
{
    class Program
    {
        static void Main(string[] args)
        {




            bool salir = false;
            string otravez;
            while (salir != true)
            {

                // Consultar esto:  double.TryParse(Console.ReadLine(), out c);


               double a , b , c , x1 , x2;
                Console.Clear();

                Console.WriteLine("Sistemas de ecuaciones de segundo grado");

                Console.Write("Ingrese a ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese b ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese c ");
                c = Convert.ToDouble(Console.ReadLine());


                x1 = ((-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a));
                x2 = ((-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a));




                // Codigo solo para verificar valor de x1 y x2
                Console.WriteLine("x1 " + x1);
                Console.WriteLine("x2 " + x2);

                Console.WriteLine("Desea calcular otra ecuacion s/n");
                otravez = Console.ReadLine().ToLower();
                if (otravez == "n")
                {
                    salir = true;
                }
            }









        }
    }
}

                









