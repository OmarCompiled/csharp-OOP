using System;
using System.IO;

namespace Files
{
  public class Employee
  {
    public int    EmpNum    {get; set;}
    public string EmpName   {get; set;}
    public double EmpSalary {get; set;}
  }

  class Program
  {
    static void Main()
    {
      const string Delim = ",";
      const int    End   = 999;

      FileStream file_out = new FileStream("employees.csv", FileMode.Create, FileAccess.Write);
      StreamWriter writer = new StreamWriter(file_out);
      
      Employee employee = new Employee();
      Console.Write("Enter employee number or 999 to exit: ");

      employee.EmpNum = Convert.ToInt32(Console.ReadLine());
      while(employee.EmpNum != End) {
        Console.Write("Enter employee Name: ");
        employee.EmpName = Console.ReadLine();

        Console.Write("Enter employee salary: ");
        employee.EmpSalary = Convert.ToDouble(Console.ReadLine());
          
        writer.WriteLine(employee.EmpNum + Delim + employee.EmpName + Delim + employee.EmpSalary);

        Console.Write("Enter employee number or 999 to exit: ");

        employee.EmpNum = Convert.ToInt32(Console.ReadLine());
      }

      writer.Close();
      file_out.Close();
    }
  }
}
