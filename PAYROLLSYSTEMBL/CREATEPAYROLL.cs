using System;
using System.Collections.Generic;
using System.Text;
using PAYROLLSYSTEMDL;
using System.Linq;

namespace PAYROLLSYSTEMBL
{
    public class CREATEPAYROLL
    {

        public void CreatePayroll()
        {
            EMPLOYEE employee = new EMPLOYEE
            {
                Name1 = "Mary Paingas",
                Name2 = "Clarence Martin",
                Name3 = "Dolores Lobrigo"
            };

            employee.AddEmployeeName(employee.Name1);
            employee.AddEmployeeName(employee.Name2);
            employee.AddEmployeeName(employee.Name3);

            GROSSINCOME grossIncome = new GROSSINCOME();


            Console.Clear();
            Console.WriteLine("\n------------------------------------------------------------------------------------------");
            Console.WriteLine("                              C R E A T E   P A Y R O L L");
            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\tPLEASE CHOOSE AN EMPLOYEE NAME FROM THE FOLLOWING TO PROCESS PAYROLL.");
            Console.WriteLine("\tREMINDER: Please enter employee name as shown.\n");
            employee.ViewEMployeeName();
            Console.WriteLine("\n------------------------------------------------------------------------------------------");
            Console.Write("\t\tName: ");
            var nameInput = Console.ReadLine();

            if (employee.EmployeeNames.Exists(s => s.Equals(nameInput, StringComparison.OrdinalIgnoreCase)))
            {
                //Console.Write("enter: ");
                //CALCULATE.number = Convert.ToInt32(Console.ReadLine());
                //Console.Write("enter2: ");
                //CALCULATE.numbers = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine($"Answer: {GROSSINCOME.answer}");
                Console.WriteLine("\n------------------------------------------------------------------------------------------");
                Console.Write("\n\tENTER EMPLOYEE'S PAYROLL DETAILS.\n");
                Console.Write("\n\t\tTotal Days Present: ");
                var daysPresent = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\t\tTotal Hours Worked: ");
                GROSSINCOME.HoursWorked = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\t\tTotal Over Time Worked: ");
                grossIncome.OTWorked = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\t\tBonus: ");
                grossIncome.Bonus = Convert.ToInt32(Console.ReadLine());
                Console.Write($"\n\t\tGross Income: {NETINCOME.GetNetIncome}");

                Console.Write("\n\t\tTax: ");
                CALCULATE.Tax = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\t\tSSS: ");
                CALCULATE.SSS = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\t\tPhilHealth: ");
                CALCULATE.PhilHealth = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\t\tPag Ibig: ");
                CALCULATE.PagIbig = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\t\tCash Advance: ");
                CALCULATE.CashAdvance = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\t\tSalary Loan: ");
                CALCULATE.SalaryLoan = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\t\tPag Ibig Loan: ");
                CALCULATE.PagIbigLoan = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n\t\tOthers: ");
                CALCULATE.Others = Convert.ToInt32(Console.ReadLine());
                Console.Write($"\n\t\tNet Income: {NETINCOME.GetNetIncome}");

                //Console.WriteLine("hi");
            }

            else
            {
                Console.WriteLine("pls try again.");
                Console.WriteLine("press any key to go back");
                Console.ReadKey();
                CreatePayroll();
            }

        }

    }
}
