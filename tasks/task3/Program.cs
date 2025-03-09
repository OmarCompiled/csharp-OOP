using System;

namespace Task_3
{
    public class Program
    {	
        static void Main()
        {
						
            Project project_one = new Project();
            project_one.Name = null;
						project_one.ID = 12345;
						project_one.Name = "SCP";
						project_one.Phone = 12345;
						project_one.Phone = 1234567;
        }
    }
		
		public class Project
    {
        int id;
        string name;
        int phone;

        public int ID
        {
            get {return id;}
            set 
						{
							id = value;
							Console.WriteLine($"Project ID successfully set!\n{id}\n");
						}
        }

        public string Name
        {
            get {return name;}
            set 
            {
                if(value != null)
                {
                    name = value;
										Console.WriteLine($"Project name successfully set!\n{name}\n");
                } 
                else
                {
										name = "Untitled";
					        	Console.WriteLine($"Cannot set project name to null! \nProject name set to {name}\n");
                }
            }
        }

				public int Phone
				{
					get {return phone;}
					set
					{
						if(Convert.ToString(value).Length < 6)
						{
							Console.WriteLine("Phone number has to be at least 6 digits! \nPlease try again.\n");
						} 
						else
						{
							phone = value;
							Console.WriteLine($"Phone number successfully set!\n{phone}\n");
						}
					}
				}
    }
}
