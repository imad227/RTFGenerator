using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTFGeneratorLibrary
{
    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;
        public Address FirstAddress { get; set; } 
        public OrderforPayment orderforPayment {get; set;}

        public gender Gender { get; set; }

        public Person() 
        {
            FirstAddress = new Address();
            orderforPayment = new OrderforPayment();
        }

    }


    public enum gender
    {
        Male = 0,
        Female = 1,
        Company = 2
    };
}
