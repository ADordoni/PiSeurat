using System;
using System.Collections.Generic;
using System.Linq;

namespace PiSeurat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para expresar el grado de aproximación al número pi:");
            double radio = int.Parse(Console.ReadLine());

            List<ParNum> list1 = new List<ParNum>();
            List<ParNum> list2 = new List<ParNum>();
            double x;
            double y;

            for (x = 0; x <= radio; x++)
            {
                for (y = 0; y <= radio; y++)
                {
                    ParNum punto = new ParNum(x, y);

                    bool circulo = punto.Circulo(x, y, radio);
                    list1.Add(punto);
                    if (circulo == true)
                    {
                        list2.Add(punto);
                    }
                }
            }
            double square = list1.Count();
            double circle = list2.Count();
            double pi = 4 * (circle / square);

            Console.WriteLine($"Pi = {pi}");
        }
    }
    class ParNum
    {
        double i;
        double j;

        public ParNum(double num1, double num2)
        {
            i = num1;
            j = num2;
        }
        public bool Circulo(double num1, double num2, double radio)
        {
            double lado1 = num1 - radio;
            double lado2 = num2 - radio;
            double i = lado1 * lado1 + lado2 * lado2;
            double j = Math.Sqrt(i);
            if (j <= radio)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }    
}
