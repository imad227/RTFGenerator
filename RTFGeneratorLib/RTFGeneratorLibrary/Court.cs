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
        public gender Gender { get; set; }
        public CourtRegion Region { get; set; }


        public string Show
        {
            get
            {
                if (Gender == gender.Female)
                    return $"H {CityName} ,ΕΙΡΗΝΟΚΙΚΕΙΟ {CapitalName}";
                else if (Gender == gender.Male)
                    return $"O {CityName} ,ΕΙΡΗΝΟΚΙΚΕΙΟ {CapitalName}";
                else if (Gender == gender.Neutral)
                    return $"ΤΟ{ CityName} ,ΕΙΡΗΝΟΚΙΚΕΙΟ { CapitalName}";
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
