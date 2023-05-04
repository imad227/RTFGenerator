using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTFGeneratorLibrary
{
    internal class OrderforPayment
    {
        public string? CourtName { get; set; }
        public string? City { get; set; }
        public double? Debt { get; set; }
        public List<Contracts>? contracts {get; set;}

    }
}
