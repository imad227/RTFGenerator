using RTFGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RTFGeneratorWinForms.Models
{
    internal class CreateRTF
    {
        public static string ClientData(Person person)
        {
            StringBuilder sb = new();
            if(person.Gender == gender.Male)
            {
                sb.Append("Του ");
            }
            else if (person.Gender == gender.Female)
            {
                sb.Append("Της ");
            }
            else
            {
                // Company.
                sb.Append("Τηςςς ");
            }

            sb.Append(person.FirstName + " " + person.LastName + " του " + person.FatherName + ", με ΑΦΜ " + person.TaxNumber);
            sb.Append(" ,και Διευθνση " + person.FirstAddress.Street + " Αριθ. " + person.FirstAddress.StrNumber.ToString() + " ");
            sb.Append("," + person.FirstAddress.City + " ,ΤΚ " + person.FirstAddress.PostalCode + ".");

            return sb.ToString();
        }


        public static void MaleSingelContract(Person person)
        {
            
            RichTextBox richTextBox1 = new();
            richTextBox1 = RTFGen.ReadTemplateFiel();

            string str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΦΟΥ"), RTFGen.RtfToString("ΚΡΗΤΗΣ"));
            richTextBox1.Rtf = str1;


            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΜΠΑΡ"), RTFGen.RtfToString("κρήτης"));
            richTextBox1.Rtf = str1;


            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΣΤΟΙΧΕΙΑΟΦΗΛΕΤΗΣ"), RTFGen.RtfToString(ClientData(person)));
            richTextBox1.Rtf = str1;


            //string fielname = $"{person.FirstName} {person.LastName}";
            RTFGen.SaveTemplateFile(richTextBox1);
        }

        public static void Test(Person person)
        {
            
            RichTextBox richTextBox1 = new();
            richTextBox1 = RTFGen.ReadTemplateFiel();
            
            //string str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΣΤΟΙΧΕΙΑΟΦΗΛΕΤΗΣ"), RTFGen.RtfToString(ClientData(person)));
            string str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΣΤΟΙΧΕΙΑΟΦΗΛΕΤΗΣ"), "");
            richTextBox1.Rtf = str1;
            
            RTFGen.SaveTemplateFile(richTextBox1);

        }
    }
}
