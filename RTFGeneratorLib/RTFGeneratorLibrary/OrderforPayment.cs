using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTFGeneratorLibrary
{
    public class OrderforPayment
    {
        public Court CourtName { get; set; }
        public Lawyer LawyerName { get; set; }
        public string City { get; set; } = string.Empty;
        public string CompanyType { get; set; } = string.Empty;
        public double Debt { get; set; }
        public List<Contract> contracts {get; set;}
        public List<Bills> bills { get; set;}

        public OrderforPayment()
        {
            contracts = new List<Contract>();
            bills = new List<Bills>();
            CourtName = new Court();
            LawyerName = new Lawyer();
        }


    }
}
