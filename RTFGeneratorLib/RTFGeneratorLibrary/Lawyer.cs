using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RTFGeneratorLibrary
{
    public class Lawyer
    {
        public int AMDSA { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string Prfix { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public gender Gender { get; set; }




        public string Print
        {
            get 
            {
                if (Gender == gender.Female)
                    return $"{FirstName} {Prfix} {LastName}";
                else if (Gender == gender.Male)
                    return $"{FirstName} {Prfix} {LastName}";
                else
                    return "";
            }
        }

        public string Show
        {
            get
            {
                if (Gender == gender.Female)
                    return $"H {FirstName} {Prfix} {LastName} ({AMDSA})";
                else if (Gender == gender.Male)
                    return $"O {FirstName} {Prfix} {LastName} ({AMDSA})";
                else
                    return "";
            }
        }

    }
}
