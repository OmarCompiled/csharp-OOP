using System;

namespace Assignment_One
{
	public class Student
	{
		public int id;
		public string name;
		
		public Student()
		{
			Console.WriteLine("Object Created!");
		}

		public Student(int id, string name)
		{
			this.id   = id;
			this.name = name;
		}
		
		~Student()
		{
			Console.WriteLine("Object Destroyed!");
		}

		public void Print()
		{
			Console.WriteLine($"id: {this.id} -- name: {this.name}");
		}

	}

	public class Program
	{
		static void Main()
		{
			Student student_one = new Student();
			student_one.id 	 = 54321;
			student_one.name = "Omar";

			Student student_two = new Student(12345, "Abbas");
			student_one.Print();
			student_two.Print();
		}
	}
}
