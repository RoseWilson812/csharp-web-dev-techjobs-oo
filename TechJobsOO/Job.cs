using System;
namespace TechJobsOO
{
    public class Job 
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()    
        {
            Id = nextId;
            nextId++;
        }
        public Job( string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;

        
        }
        public override bool Equals(object obj)  // makes sure the object is == current object
        {
            return obj is Job &&
                   Id == this.Id;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            
            string prtName = "";
            if (string.IsNullOrEmpty(this.Name))
            {
                this.Name = "Data not available";
                prtName = "Data not available";
            }

            string prtEmployerName = "";
            if (this.EmployerName is null)
            {
                prtEmployerName = "Data not available";
            }
            else if (string.IsNullOrEmpty(this.EmployerName.Value))
            {
                this.EmployerName.Value = "Data not available";
            }
            

            string prtLocation = "";
            if (this.EmployerLocation is null)
            {
                prtLocation = "Data not available";
            }
            else if (string.IsNullOrEmpty(this.EmployerLocation.Value))
            {
                this.EmployerLocation.Value = "Data not available";
            }
           

            string prtJobType = "";
            if (this.JobType is null)
            {
                prtJobType = "Data not available";
            }
            else if (string.IsNullOrEmpty(this.JobType.Value))
            {
                this.JobType.Value = "Data not available";
            }
           

            string prtCoreCompetency = "";
            if (this.JobCoreCompetency is null)
            {
                prtCoreCompetency = "Data not available";
            }
            else if (string.IsNullOrEmpty(this.JobCoreCompetency.Value))
            {
                this.JobCoreCompetency.Value = "Data not available";
            }
                
            if (prtName == "Data not available" &&
                 prtEmployerName == "Data not available" &&
                 prtLocation == "Data not available" &&
                 prtJobType == "Data not available" &&
                 prtCoreCompetency == "Data not available")
            {
                return "OOPS! This job does not seem to exist.";
            }
            else
            {
                //return "\nID: " + this.Id + "\nName: " + prtName + "\nEmployer: " + prtEmployerName + "\nLocation: " + prtLocation + "\nPosition Type: " + prtJobType + "\nCore Competency: " + prtCoreCompetency + "\n";
                return "\nID: " + this.Id + "\nName: " + this.Name + "\nEmployer: " + this.EmployerName + "\nLocation: " + this.EmployerLocation + "\nPosition Type: " + this.JobType + "\nCore Competency: " + this.JobCoreCompetency + "\n";
            }
        }

    }
}
