/* Programmer: Austin Parker
   Date: March 29th, 2020
   Purpose: This program allows user to see breakdown of employees pay
 */

using System;
using static System.Console;


namespace CIST2341_Final_Project_Austin_Parker
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double annualSalary;
            double monthlySales;

            Employee[] emp = new Employee[20];
            int i = 0;
            do
            {
                //Welcome screen
                Write("Thanks for using the Employee Gross Pay Calculator!\n" +
                    "\nEnter Employee's name OR \"Q\" to end program : ");
                name = ReadLine();
                WriteLine();

                //Requires employee name or "Q" to continue program
                while (string.IsNullOrEmpty(name))
                {
                    WriteLine("Please enter employee's name or \"Q\" to end program");
                    name = ReadLine();
                }

                //Closes program if "Q" is entered rather than employee name
                if (name == "q" || name == "Q")
                {
                    WriteLine("Have a nice day, Goodbye!");
                    Read();
                    break;

                }

                do
                {
                    Write("Enter Annual Salary (Enter \"0\" for commission only employees ):\n");
                    annualSalary = double.Parse(ReadLine());
                    if (annualSalary == 0)
                        break;
                    //Continues to ask for annual salary if invalid input is entered. Will not let user continue
                    while (annualSalary > 120000 || annualSalary < 12000)
                    {
                        WriteLine("\nIncorrect salary value, please input salary less than $120000.\n");
                        WriteLine("Re-enter Salary: ");
                        annualSalary = double.Parse(ReadLine());

                    }
                } while (annualSalary > 120000 || annualSalary < 12000);
                WriteLine();

                do
                {
                    Write("Enter Monthly Sales:");
                    monthlySales = double.Parse(ReadLine());
                    Clear();
                    //Continues to ask for monthly sales if invalid input is entered. Will not let user continue
                    while (monthlySales < 0)
                    {
                        WriteLine("\nIncorrect value, please input monthly sales of \"0\" or more.\n");
                        WriteLine("Re-enter Sales");
                        monthlySales = double.Parse(ReadLine());

                    }
                } while (monthlySales < 0);
                emp[i] = new Employee(name, annualSalary, monthlySales);
                emp[i].PrintEmployee();
                i++;
            } while (name != "q" || name != "Q");



        }
    }
}
