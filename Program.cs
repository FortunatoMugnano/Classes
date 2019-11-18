using System;
using System.Collections.Generic;

namespace ListIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a new List variable
            List<int> cohorts = new List<int>();

            //Add method
            cohorts.Add(34);
            cohorts.Add(35);
            cohorts.Add(36);
            cohorts.Add(37);

            //Another way we can initialize this list
            List<string> classes = new List<string>()
            {
                "Cohort 34",
                "Cohort 35",
                "Cohort 36",
                "Cohort 37",
            };

            //Remove method
            classes.Remove("Cohort 34");
            classes.Add("Cohort 38");

            //Looping with ForEach
            foreach (string nssClass in classes)
            {
                Console.WriteLine(nssClass);
            }

            foreach (int nssClass in cohorts)
            {
                Console.WriteLine(nssClass);
            }

            //Conditional looping
            foreach (int nssClass in cohorts)
            {
                if (nssClass == 35)
                {
                    Console.WriteLine($"The Best Cohort: {nssClass}");
                }
                else
                {
                    Console.WriteLine($"A Perfectly fine Cohort: {nssClass}");
                }
            }

        }
    }
}