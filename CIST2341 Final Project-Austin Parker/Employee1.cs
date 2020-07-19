/* Programmer: Austin Parker
   Date: March 29th, 2020
   Purpose: This program allows user to see breakdown of employees pay
 */

using System;
using static System.Console;

namespace CIST2341_Final_Project_Austin_Parker
{
    class Employee
    {
        string name;
        double basePay;
        double sales;

        //Constructor
        public Employee(string empName, double empBasePay, double empSales)
        {
            Name = empName;
            BasePay = empBasePay;
            Sales = empSales;
        }

        //Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double BasePay
        {
            get
            {
                return basePay;
            }
            set
            {
                basePay = value;
            }
        }
        public double Sales
        {
            get
            {
                return sales;
            }
            set
            {
                sales = value;
            }
        }

        //Methods for calculating values
        public double CalculateCommission()
        {
            double baseSalary, netSales;
            double commission;
            double remainSales;
            baseSalary = basePay / 12;
            netSales = sales - (10 * baseSalary);
            if (netSales <= 0)
                commission = 0;
            else
            {
                if (netSales < 10000)
                {
                    commission = 0.05 * netSales;
                }
                else
                {
                    commission = 500;
                    remainSales = netSales - 10000;
                    if (remainSales < 15000)
                    {
                        commission += 0.1 * remainSales;
                    }
                    else
                    {
                        commission += 1500;
                        remainSales -= 15000;
                        if (remainSales < 25000)
                        {
                            commission += 0.15 * remainSales;
                        }
                        else
                        {
                            commission += 3750;
                            remainSales -= 25000;
                            commission += 0.2 * remainSales;
                        }
                    }
                }
            }
            return commission;
        }

        //Calculates total pay
        public double CalculateGross(double commission)
        {
            double grossPay;
            grossPay = (basePay / 12) + commission;
            return grossPay;
        }

        //Displays final information
        public void PrintEmployee()
        {

            Write("Below is " + name + "'s" + " breakdown of pay: ");
            double baseSalary = basePay / 12;
            Write("\n\nBase Salary = $" + string.Format("{0:n}", baseSalary) + " ");
            Write("Sales = $" + string.Format("{0:n}", sales) + " ");
            double com = CalculateCommission();
            Write("Conmmission = $" + string.Format("{0:n}", CalculateCommission()) + " ");
            WriteLine("Gross Pay = $" + string.Format("{0:n}", CalculateGross(com)) + " ");
            WriteLine();

        }
    }


}

