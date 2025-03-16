using System;

namespace Assignment2
{
	public class Student
	{
		public int id;
		public void ShowID()
		{
			Console.WriteLine(id);
		}

		public static void Test()
		{
			Console.WriteLine("You accessed a static class method");
		}
	}
	public class Program
	{
		static void Main()
		{
			Student st1 = new Student();
			st1.id = 12345;
			st1.ShowID();
			Student.Test();
		}
	}
}

