using RTFGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTFGeneratorWinForms.Models
{
    public class CreateRTFOTE
    {
        public static void Generate(Person person)
        {
            RichTextBox richTextBox1 = new();

            // Test the following:
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

            TemplateType templateType = new TemplateType();
            templateType = TemplateType.CosmoteOFP;
            richTextBox1 = RTFGen.ReadTemplateFiel(templateType);


            string str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΚΕΦΑΛΑΙΟΟΝΟΜΑΕΙΡΗΝΟΔΙΚΕΙΟΥ"), RTFGen.RtfToString(person.orderforPayment.CourtName.CapitalName));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΠΕΖΟΟΝΟΜΟΑΕΙΡΗΝΟΚΙΚΕΟΥ"), RTFGen.RtfToString(person.orderforPayment.CourtName.SmallName));
            richTextBox1.Rtf = str1;

            //DateTime dt1 = DateTime.Now;
            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΕΤΟΣΑΡΙΘΜΟΣ"), RTFGen.RtfToString(DateTime.Now.Year.ToString()));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΣΤΟΙΧΕΙΑΟΦΗΛΕΤΗΣ"), RTFGen.RtfToString(ClientData(person)));
            richTextBox1.Rtf = str1;
        }

        public static string ClientData(Person person)
        {
            StringBuilder sb = new();
            if (person.Gender == gender.Company)
            {
                sb.Append("\tΤης ");
                sb.Append(person.orderforPayment.CompanyType.Trim() + " Εταιρείας με την επωνυμία «" + person.Title.Trim());
                sb.Append("» με ΑΦΜ " + person.TaxNumber.Trim() + ", και με διακριτικό τίτλο «" + person.Title.Trim());
                sb.Append("» νομίμως εκπροσωπουμένης, που εδρεύει ");
                sb.Append(person.FirstAddress.Street.Trim() + " " + person.FirstAddress.StrNumber.ToString().Trim() + ", ");
                sb.Append(person.FirstAddress.City.Trim() + ", " + person.FirstAddress.PostalCode.Trim() + ".\r");
                return sb.ToString();
            }
            else if (person.Gender == gender.Male)
            {
                sb.Append("\tΤου ");
            }
            else if (person.Gender == gender.Female)
            {
                sb.Append("\tΤης ");
            }

            sb.Append(person.FirstName.Trim() + " " + person.LastName.Trim());
            if (person.FatherName != string.Empty)
            {
                sb.Append(" του " + person.FatherName.Trim());
            }
            sb.Append(", με ΑΦΜ " + person.TaxNumber.Trim());
            sb.Append(", που κατοικεί " + person.FirstAddress.Street.Trim() + " " + person.FirstAddress.StrNumber.ToString().Trim());
            sb.Append(", " + person.FirstAddress.City.Trim() + ", ΤΚ " + person.FirstAddress.PostalCode.Trim() + ".\r");

            return sb.ToString();
        }


    }
}
