using System;

namespace GrundernaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            double area1 = circle1.getArea();
            double area2 = circle2.getArea();

            double volume1 = circle1.getVolume();
            double volume2 = circle2.getVolume();

            double circum1 = circle1.getCircumference();
            double circum2 = circle2.getCircumference();


            Console.WriteLine($"Arean är {area1}\nVolymen är {volume1}\nOmkretsen är {circum1}\n");
            Console.WriteLine($"Arean2 är {area2}\nVolymen2 är {volume2}\nOmkretsen2 är {circum2}");
        }
    }
}