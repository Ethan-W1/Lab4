using Lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Person : IComparable<Person>
    {
        //Properties
        public string Firstname { get; init; } = String.Empty;
        public string Lastname { get; init; } = String.Empty;
        public Address Address { get; init; }

        //Constructor
        public Person(string firstn, string lastn, Address addressone)
        {
            Firstname = firstn;
            Lastname = lastn;
            Address = addressone;
        }
        //ToString
        public override string ToString()
        {
            return ($"{Firstname}|{Lastname}|{Address}");
        }

        //CompareTo
        public int CompareTo(Person? other)
        {
            return string.Compare(this.Lastname, other.Lastname);
        }
    }
}