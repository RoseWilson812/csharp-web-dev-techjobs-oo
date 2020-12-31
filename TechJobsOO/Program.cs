using System;
using System.Collections.Generic;
using System.Linq;

namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //  rw             my tests
            Job job1 = new Job();
            Console.WriteLine(job1.ToString());
            
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            //Console.WriteLine(job2.Id + " " + job2.EmployerName);
            Console.WriteLine(job2.ToString());
            Job job3 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
   
            Console.WriteLine(job3.ToString());
           
            //
            string result = job3.ToString();
            List<string> resultList = result.Split("\n").ToList();

            string id = resultList[1].Substring(0, 3);
            string name = resultList[2].Substring(0, 5);
            string employer = resultList[3].Substring(0, 9);
            string location = resultList[4].Substring(0, 9);
            string position = resultList[5].Substring(0, 9);
            string coreCompetency = resultList[6].Substring(0, 16);
            
            Console.WriteLine("");
            //

            /*
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);

            foreach (Job job in jobs)
            {
                Console.WriteLine(job);
            }
           */
        }
    }
}
