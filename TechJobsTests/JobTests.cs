using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();          
            Job job2 = new Job();          
            double result = job2.Id - job1.Id; 
            Assert.AreEqual(1, result, .001);
            
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            
            Assert.AreEqual("Product tester", job1.Name);
            Assert.AreEqual("ACME", actual: job1.EmployerName.Value);
            Assert.AreEqual("Desert", job1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job1.JobType.Value);
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.Value);
        }
        [TestMethod]
        public void TestJobForEquality()
        {

            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            
            bool result = Equals(job1);
            Assert.IsFalse(result); 
            
        }
        //
        [TestMethod]
        public void TestBlankLinesBeforeAndAfterJobInfo()
        {

            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string result = job3.ToString();
            string pos1 = result.Substring(0, 1);
            string lastpos = result.Substring(result.Length - 1, 1);

            Assert.AreEqual("\n", pos1);
            Assert.AreEqual("\n", lastpos);

        }
        [TestMethod]
        public void TestEachFieldOnSeparteLine()
        {

            Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string result = job3.ToString();
            List<string> resultList = result.Split('\n').ToList();
            
            string id = resultList[1].Substring(0, 3);
            string name = resultList[2].Substring(0, 5);
            string employer = resultList[3].Substring(0, 9);
            string location = resultList[4].Substring(0, 9);
            string position = resultList[5].Substring(0, 14);
            string coreCompetency = resultList[6].Substring(0, 16);

            Assert.AreEqual("ID:", id);
            Assert.AreEqual("Name:", name);
            Assert.AreEqual("Employer:", employer);
            Assert.AreEqual("Location:", location);
            Assert.AreEqual("Position Type:", position);
            Assert.AreEqual("Core Competency:", coreCompetency);

        }
        //
        [TestMethod]
        public void TestAllFieldsEmptyExceptId()
        {

            Job job1 = new Job("", new Employer(""), new Location(), new PositionType(), new CoreCompetency());
            job1.ToString();
            Assert.AreNotEqual(0, job1.Id);
            Assert.AreEqual("Data not available", job1.Name);
            Assert.AreEqual("Data not available", job1.EmployerName.Value);
            Assert.AreEqual("Data not available", job1.EmployerLocation.Value);
            Assert.AreEqual("Data not available", job1.JobType.Value);
            Assert.AreEqual("Data not available", job1.JobCoreCompetency.Value);


        }
        [TestMethod]
        public void TestJobIdOnlyFieldPresent()
        {

            Job job1 = new Job();
            string result = job1.ToString();
            
            Assert.AreEqual("OOPS! This job does not seem to exist.", result);
           


        }
       

    }
}
