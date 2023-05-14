using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTFGeneratorLibrary
{
    public class Contract
    {
        public string PhoneNumber { get; set; } = string.Empty;
        public string SimNumber { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string ContractType { get; set; } = string.Empty;
        public string Durration { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        public string Show
        {
            get
            {
                return ($"{PhoneNumber} - {Number} - {Date.ToShortDateString()} - {Durration}.");
            }
        }

    }
}
