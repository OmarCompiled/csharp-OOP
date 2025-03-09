using System;

namespace Test
{
    public class Program
    {
        static void Main()
        {
            Circle circle = new Circle();
            circle.Radius = 10;
            Console.WriteLine(circle.Radius);
            circle.Radius = -4;
            Console.WriteLine(circle.Radius);
        }
    }

    public class Circle
    {
        double radius;

        public double Radius
        {
            get {return radius;}
            set 
            {
                if(value > 0)
                {
                    radius = value;
                    Console.WriteLine("Radius Set!");
                } else
                {
                    radius = 0;
                    Console.WriteLine("Cannot set radius to negative number!");
                }
            }
        }
    }
}