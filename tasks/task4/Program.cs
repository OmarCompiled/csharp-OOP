using System;

namespace Task4
{
	public class Circle
	{
		int radius;
		public Circle(int radius)
		{
			if(radius > 0) {this.radius = radius; Console.WriteLine("Radius Set successfully.");}
			else {this.radius = 1; Console.WriteLine("Radius Cannot be less than 1!\nRadius set to 1.");}
		}
		public int Radius
		{
 	 	  get{return radius;}
			set
			{
				if(value > 0) {radius = value; Console.WriteLine("Radius Reset Successfully.");}
			}
		}

		public static void PrintRadii(params Circle[] circles) 
		{
			int index = 1;
			foreach(Circle circle in circles)
			{
				Console.WriteLine($"circle{index}: {circle.Radius}");
				index++;
			}
		}
	}
	public class Program
	{
		static void Main()
		{
			Circle circle1 = new Circle(1);
			Circle circle2 = new Circle(3);
			Circle circle3 = new Circle(5);
			Circle.PrintRadii(circle1, circle2, circle3);

		}
	}
}

// Circle class with a static mehod taking in a params array of circles and printing their radii and an instance method that prints the radius
