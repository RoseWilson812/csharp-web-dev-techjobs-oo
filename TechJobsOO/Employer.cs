using System;
namespace TechJobsOO
{
    public class Employer
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public Employer()
        {
            Id = nextId;  // will use 1 for the first Id
            nextId++;     // then add 1, so nextId will use 2
        }

        public Employer(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)  // makes sure the object is == current object
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
