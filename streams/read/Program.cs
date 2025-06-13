using System;
using System.IO;

namespace Read
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
      const char Delim = ',';

      FileStream file_in  = new FileStream("employees.csv", FileMode.Open, FileAccess.Read);
      StreamReader reader = new StreamReader(file_in);
              
      Employee employee = new Employee();
      string record_in = reader.ReadLine();
      string sought_name = "";
      if(record_in != null) {
        Console.Write("Enter employee name: ");
        sought_name = Console.ReadLine();
      }

      while(sought_name != "exit") {
       string[] fields = record_in.Split(Delim);
       employee.EmpNum    = Convert.ToInt32(fields[0]);
       employee.EmpName   = fields[1];
       employee.EmpSalary = Convert.ToDouble(fields[2]);
       
       if(employee.EmpName == sought_name) {
         Console.WriteLine($"Number\tName\tSalary");
         Console.WriteLine($"{employee.EmpNum}\t{employee.EmpName}\t{employee.EmpSalary}");
         file_in.Seek(0, SeekOrigin.Begin);
         Console.Write("Enter employee name: ");
         sought_name = Console.ReadLine();
       }

       record_in = reader.ReadLine();

       if(record_in == null) {
         Console.WriteLine("Employee not found!");
         file_in.Seek(0, SeekOrigin.Begin);
         Console.Write("Enter employee name: ");
         sought_name = Console.ReadLine();
         record_in = reader.ReadLine();
       }       
      }
      
      reader.Close();
      file_in.Close();
    }
  }
}
