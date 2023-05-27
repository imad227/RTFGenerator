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
        public bool ChallengeRequest { get; set; } = false;
        public bool AthensJurisdiction { get; set; } = false;
        public bool AddressChange { get; set; } = false;
        public ChangeOfAddress ChangeOfAddressApplication { get; set; }
        public List<Contract> contracts {get; set;}
        public List<Bills> bills { get; set;}

        public string DSA { get; set; } = string.Empty;
        public string TAXDIK { get; set; } = string.Empty; 

        public OrderforPayment()
        {
            contracts = new List<Contract>();
            bills = new List<Bills>();
            CourtName = new Court();
            LawyerName = new Lawyer();
            ChangeOfAddressApplication = new ChangeOfAddress();
        }

        public string PrintDebt
        {
            get
            {
                string str = String.Format("{0:0.00}", Debt);
                return str.ToString().Replace('.', ',');
            }
        }


    }
}
