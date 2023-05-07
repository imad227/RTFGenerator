using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTFGeneratorLibrary
{
    public class ConstValues
    {
        public static List<string> Duration { get; set; }
        public static List<string> CompanyTypes { get; set; }

        public ConstValues()
        {
            Duration = new List<string>();
            Duration.Add ("12");
            Duration.Add ("18");
            Duration.Add ("24");
            Duration.Add ("--");

            CompanyTypes = new List<string>();
            CompanyTypes.Add("FISIKO PROSOPO");
            CompanyTypes.Add("ATOMIKI");
            CompanyTypes.Add("IDIOTIKI");
            CompanyTypes.Add("KEFALEOYXA");
        }
    }
}
