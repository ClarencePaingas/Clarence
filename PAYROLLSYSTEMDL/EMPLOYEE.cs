using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLLSYSTEMDL
{
    public class EMPLOYEE
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }

        public List<string> EmployeeNames = new List<string>();

        public  void AddEmployeeName(string name)
        {
            EmployeeNames.Add(name);
        }

        public void ViewEMployeeName()
        {
            foreach (var name in EmployeeNames)
            {
                Console.WriteLine($"\t\t\t\t{name}");
            }
        }

       
        //public static string Input { get; set; }
        //public List<string> GetEmployeeNames()
        //{
        //    return _employeeNames;
        //}

    }
}
