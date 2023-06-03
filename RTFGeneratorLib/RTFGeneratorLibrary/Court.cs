using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTFGeneratorLibrary
{
    public class Court
    {
        public string CapitalName { get; set; } = string.Empty;
        public string SmallName { get; set; } = string.Empty;
        public string CityName { get; set; } = string.Empty;
        public string InCity { get; set; } = string.Empty;
        public gender Gender { get; set; }
        public CourtRegion Region { get; set; }

        // Advanced options
        public bool WriteAMDSAinApplication { get; set; }  = false;
        public bool WriteAMDSAinOrder { get; set; } = false;
        public bool BillingAnalysis { get; set; } = false;


        public string Show
        {
            get
            {
                if (Gender == gender.Female)
                    return $"ΕΙΡΗΝΟΔΙΚΕΙΟ {CapitalName}";
                else if (Gender == gender.Male)
                    return $"ΕΙΡΗΝΟΔΙΚΕΙΟ {CapitalName}";
                else if (Gender == gender.Neutral)
                    return $"ΕΙΡΗΝΟΔΙΚΕΙΟ { CapitalName}";
                else
                    return "";
            }
        }
    }


    public enum CourtRegion
    {
        ATTICA = 0,
        OTHERREGION = 1
    };
}
