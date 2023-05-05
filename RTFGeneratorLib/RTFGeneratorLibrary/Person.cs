using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTFGeneratorLibrary
{
    internal class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FatherName { get; set; }
        public Address? FirstAddress { get; set; }
        public OrderforPayment? orderforPayment {get; set;}

    }
}
