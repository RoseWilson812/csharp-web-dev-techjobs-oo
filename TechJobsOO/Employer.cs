using System;
namespace TechJobsOO
{
    public class Employer : JobField
    {
        //public int Id { get; }            
        //private static int nextId = 1;   
        //public string Value { get; set; }  

        public Employer() : base()
        {
            //Id = nextId;  
            //nextId++;     
        }

        public Employer(string value) : base(value)   
        {
            //Value = value;
        }

        public override bool Equals(object obj)  // makes sure the object is == current object
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }
        /*rw
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        } rw */
    }
}
