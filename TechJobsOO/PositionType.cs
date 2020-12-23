using System;
namespace TechJobsOO
{
    public class PositionType : Job
    {
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        public PositionType() : base()
        {
            //Id = nextId;
            //nextId++;
        }

        public PositionType(string value) : base(value)
        {
            //Value = value;
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
        public override bool Equals(object obj)  // makes sure the object is == current object
        {
            return obj is PositionType  &&
                   Id == this.Id;
        }
        /* rw
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        } rw*/
    }
}
