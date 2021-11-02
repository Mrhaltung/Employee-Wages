using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages
{
    class Emp_Wages
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem. ");
            
            Emp_Attendence.empCheck();
            Emp_Daily_Wage.DailyEmpWage();
            Part_Time_Emp_Wage.PartTimeEmpWage();
            Case_Statement.CaseStatement();
            Monthly_Emp_Wage.MonthlyEmpWage();
            While_Loop.WhileLoop();
            Method.Methods();
            MultipleCompanyWage.MultipleCompanyWages();

            MultipleCompanyWages("apple",20,20,400);
            MultipleCompanyWages("microsoft", 10, 20, 8);
            MultipleCompanyWages("google", 25, 20, 100);

            Console.ReadLine();
        }
    }
}
