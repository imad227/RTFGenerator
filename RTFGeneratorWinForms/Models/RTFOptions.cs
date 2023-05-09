//using DocumentFormat.OpenXml.Bibliography;
using RTFGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTFGeneratorWinForms.Models
{
    public class RTFOptions
    {
        public TypeOFOrderForPayment Type;


        public void SetRTFOptions (Person person)
        {
            // Temp section 
            // This is not correct.
            if(person.Gender == gender.Male)
            {
                this.Type = TypeOFOrderForPayment.FemaleMultipleContracts;
            }
        }
    }

    


    public enum TypeOFOrderForPayment
    {
        MaleSingelContractSingelPhone = 0,
        MaleSingelContractMultiplePhones = 1,
        MaleMultipleContracts = 2,
        FemaleSingelContractSingelPhone = 3,
        FemaleSingelContractMultiplePhones = 4,
        FemaleMultipleContracts = 5
    };
}
