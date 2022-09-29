using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Address
    {
        //Properties
        public string address { get; init; } = String.Empty;
        public string City { get; init; } = String.Empty;
        public string State { get; init; } = String.Empty;
        public string PostalCode { get; init; } = String.Empty;

        //Constructor
        public Address(string addressone, string cityone, string stateone, string postalcodeone)
        {
            address = addressone;
            City = cityone;
            State = stateone;
            PostalCode = postalcodeone;
        }

        //ToString
        public override string ToString()
        {
            return ($"{address}|{City}|{State}|{PostalCode}");
        }
    }
}