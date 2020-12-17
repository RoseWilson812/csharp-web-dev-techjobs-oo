using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            Assert.AreEqual(1, job1.Id);
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
        
    }
}
