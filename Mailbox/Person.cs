using System;

namespace Mailbox
{
    public struct Person : IEquatable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Equals(Person other)
        {
            return FirstName == other.FirstName && 
                   LastName == other.LastName;
        }

        public override bool Equals(object obj)
        {
            return obj is Person other && Equals(other);
        }

        public override int GetHashCode()
        {
            return (FirstName, LastName).GetHashCode();
        }

        public static bool operator ==(Person a, Person b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Person a, Person b)
        {
            return !(a == b);
        }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}