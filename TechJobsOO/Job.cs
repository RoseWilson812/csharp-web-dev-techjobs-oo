﻿using System;
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
        public Job(string name)
        {
            Name = name; 
        
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)  // makes sure the object is == current object
        {
            return obj is Job name &&
                   Id == this.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

       
    }
}
