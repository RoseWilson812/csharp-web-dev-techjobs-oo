using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        
        //private static int nextId = 1;
        

        // TODO: Change the fields to auto-implemented properties.
        //public int Id { get; }
       // public string Value { get; set; }

        public CoreCompetency() : base ()
        {
           
            //Id = nextId;
            //nextId++;
            
        }

        public CoreCompetency(string value) : base(value)
        {
            
            //Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   ///id == competency.id;
                   Id == competency.Id;
        }
        /* rw
        public override int GetHashCode()
        {
            ///return HashCode.Combine(id);
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            ///return value;
            return Value;
        } rw */
    
    }
}
