using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages

public class MultipleCompanyWage
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    //public const int EMP_RATE_PER_HOUR = 20;
    //public const int NUM_OF_WORKING_DAYS = 20;
    //public const int MAX_HRS_IN_MONTH = 100;

    public static void MultipleCompanyWages(string company, int EMP_WAGE_PER_HOUR, int NUM_OF_WORKING_DAYS, int MAX_HRS_IN_MONTH)
    {
        //Variable
        int empHrs = 0, totalWorkingDays = 0, empWage = 0;
              
        //Computation
        
        while (totalWorkingDays <= NUM_OF_WORKING_DAYS && empHrs < MAX_HRS_IN_MONTH)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    empWage = 80;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    empWage = 160;
                    break;
                default:
                    empHrs = 0;
                    empWage = 0;
                    break;
            }
            //totalempHrs += empHrs;
            C//onsole.WriteLine("Day " + totalWorkingDays + " Employee Wage : " + empWage);
        }
        empWage = empHrs * EMP_WAGE_PER_HOUR;
        Console.WriteLine("Employee wage is : " + empWage + " for company. " + company);
        Console.ReadLine();



    }

}
