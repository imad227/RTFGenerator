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

        /// <summary>
        /// Find the Type of the Payment Order, by the provided data.
        /// </summary>
        /// <param name="person"></param>
        /// TODO - Return TypeOFOrderForPayment.
        /// 

        public RTFOptions()
        {
            Type = new TypeOFOrderForPayment();
        }

        public static TypeOFOrderForPayment SetRTFOptions(Person person)
        {
            // Temp section 
            // This is not correct.

            bool foundMultipleContracts = false;
            bool foundMultiplePhoneNumbers = false;
            Contract FirstContract = new();

            if(person.orderforPayment.contracts.Count != 0)
            {
                FirstContract = person.orderforPayment.contracts[0];
            }

            //if (person.Gender == gender.Male)
            //{
            //    this.Type = TypeOFOrderForPayment.FemaleMultipleContracts;
            //}

            // TODO: MOVE THIS TO RTFGen.
            // Test the number of Contracts.
            if (person.orderforPayment.contracts.Count == 0)
            {
                //MessageBox.Show("You Need to prvide a contract.");
                return TypeOFOrderForPayment.NoneValid;
            }
            else if (person.orderforPayment.contracts.Count == 1)
            {
                foundMultiplePhoneNumbers = false;
                //MessageBox.Show("One Contract only");
            }
            else
            {
                //MessageBox.Show("Not implemented yet.");
                //bool foundMultipleContracts = false;
                //Contracts cont = person.orderforPayment.contracts[0];
                foundMultiplePhoneNumbers = true;

                foreach (var m in person.orderforPayment.contracts)
                {
                    if (FirstContract.Number != m.Number) { foundMultipleContracts = true; break; }
                }
                //if (foundMultipleContracts)
                //{
                //    MessageBox.Show("Multi Numbers Multi Contracts");
                //}
                //else
                //{
                //    MessageBox.Show("Multi Numbers One Contract");
                //}
            }
            if (person.Gender == gender.Male)
            {
                if (foundMultipleContracts)
                {
                    //MessageBox.Show("Male, Multiple Contracts");
                    return TypeOFOrderForPayment.MaleMultipleContracts;
                }
                else if (!foundMultipleContracts && foundMultiplePhoneNumbers)
                {
                    //MessageBox.Show("Male, Singele Contract, Multiple Phone number.");
                    return TypeOFOrderForPayment.MaleSingleContractMultiplePhones;
                }
                else
                {
                    //MessageBox.Show("Male, Single Contract, Single Phone number");
                    return TypeOFOrderForPayment.MaleSingleContractSinglePhone;
                }
            }
            else if(person.Gender == gender.Female)
            {
                if (foundMultipleContracts)
                {
                    //MessageBox.Show("Female, Multiple Contracts");
                    return TypeOFOrderForPayment.FemaleMultipleContracts;
                }
                else if (!foundMultipleContracts && foundMultiplePhoneNumbers)
                {
                    //MessageBox.Show("Female, Singele Contract, Multiple Phone number.");
                    return TypeOFOrderForPayment.FemaleSingleContractMultiplePhones;
                }
                else
                {
                    //MessageBox.Show("Female, Single Contract, Single Phone number");
                    return TypeOFOrderForPayment.FemaleSingleContractSinglePhone;
                }
            }
            else if (person.Gender == gender.Company)
            {
                if (foundMultipleContracts)
                {
                    //MessageBox.Show("Company, Multiple Contracts");
                    return TypeOFOrderForPayment.CompanyMultipleContracts;
                }
                else if (!foundMultipleContracts && foundMultiplePhoneNumbers)
                {
                    //MessageBox.Show("Company, Singele Contract, Multiple Phone number.");
                    return TypeOFOrderForPayment.CompanySingleContractMultiplePhones;
                }
                else
                {
                    //MessageBox.Show("Company, Single Contract, Single Phone number");
                    return TypeOFOrderForPayment.CompanySingleContractSinglePhone;
                }
            }
            else
            {
                //MessageBox.Show("None Valide Court Type Option!");
                return TypeOFOrderForPayment.NoneValid;
            }
        }



    }

    


    public enum TypeOFOrderForPayment
    {
        MaleSingleContractSinglePhone = 0,
        MaleSingleContractMultiplePhones = 1,
        MaleMultipleContracts = 2,
        FemaleSingleContractSinglePhone = 3,
        FemaleSingleContractMultiplePhones = 4,
        FemaleMultipleContracts = 5,
        CompanySingleContractSinglePhone = 6,
        CompanySingleContractMultiplePhones = 7,
        CompanyMultipleContracts = 8,

        NoneValid = 100
    };

    public enum AdvancedTypeOFP
    {
        MeParektasi,
        XorisParektasi,
        Sxetiko4,
        AnalisiTimologion,
    }
}
