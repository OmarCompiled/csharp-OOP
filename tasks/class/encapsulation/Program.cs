using System;

namespace Encapsulation
{
    public class Program
    {
        static void Main()
        {
            Student student_one = new Student();
            // student_one.name = "Omar"  gives an error 
            student_one.Name = "Omar"; // no errors
            student_one.ID = 67890; // no errors
            student_one.Index = 1;
        }
    }

    public class Student
    {
        // fields - private
        int index;
        int id;
        string name;

        public int ID //property
        {
            get {return id;}
            set {id = value; Console.WriteLine("ID Set!");}
        }

        public string Name //property
        {
            get {return name;}
            set {name = value; Console.WriteLine("Name Set!");}
        }

        public int Index
        {
            get {return index;}
            set 
            {
                if(index > 50) {
                    index = 0;
                    Console.WriteLine("Could not set index: more than 50!");
                } else {
                    index = value;
                    Console.WriteLine("Index Set!");
                }
            }
        }

        public Student(int index = 0, int id = 0, string name = null) //constructor
        {
            this.index = index; 
            this.id    = id;
            this.name  = name;
            Console.WriteLine("Student Initialized");
        }
    }
}