using System;

namespace Test
{
	public class Program
	{
		static void Main() 
		{
			Student omar   = new Student(1000308352, "Omar Tamer");
			Student abbas  = new Student(1000204890, "Abbas Helmy");
			Student khaled = new Student(1000276488, "Khaled Waleed");

		Student[] students = {omar, abbas, khaled};
		Console.WriteLine("Student ID  Student Name");
		foreach(Student st in students) {
				st.showStudentInfo();
			}	
		}
	}
	public class Student
	{
		private int id;
		private string name;

		public Student(int id, string name) {
			this.id = id;
			this.name = name;
		}

		public int ID
		{
			get {return id;}
			set {id = value;}
		}

		public string Name
		{
			get {return name;}
			set {name = value;}
		}
		
		public void showStudentInfo() {
			Console.WriteLine($"{this.id}  {this.name}");
		}
	}	
}
