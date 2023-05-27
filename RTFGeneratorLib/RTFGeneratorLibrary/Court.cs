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


        public string Show
        {
            get
            {
                if (Gender == gender.Female)
                    return $"ΕΙΡΗΝΟΚΙΚΕΙΟ {CapitalName}";
                else if (Gender == gender.Male)
                    return $"ΕΙΡΗΝΟΚΙΚΕΙΟ {CapitalName}";
                else if (Gender == gender.Neutral)
                    return $"ΕΙΡΗΝΟΚΙΚΕΙΟ { CapitalName}";
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
