using RTFGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RTFGeneratorWinForms.Models
{
    /// <summary>
    /// RTFGen Contain the Core Functions to handel the creation and edit of the RTF file.
    /// </summary>
    internal class RTFGen
    {

        public static Bills FirstBill(Person person)
        {
            Bills bill = new Bills();
            if (person.orderforPayment.bills.Count > 0)
            {
                bill = person.orderforPayment.bills[0];
                foreach (var t in person.orderforPayment.bills)
                {
                    if (DateTime.Compare(t.IssueDate, bill.IssueDate) < 0)
                    {
                        bill = t;
                    }
                }
                return bill;
            }
            else
            {
                bill.IssueDate = DateTime.MinValue;
                return bill;
            }

        }

        public static Bills LastBill(Person person)
        {
            Bills bill = new Bills();
            if (person.orderforPayment.bills.Count > 0)
            {
                bill = person.orderforPayment.bills[0];
                foreach (var t in person.orderforPayment.bills)
                {
                    if (DateTime.Compare(t.IssueDate, bill.IssueDate) > 0)
                    {
                        bill = t;
                    }
                }
                return bill;
            }
            else
            {
                bill.IssueDate = DateTime.MaxValue;
                return bill;
            }
        }

        public static Bills RemunerationFirstBill(Person person)
        {
            Bills bill = new Bills();
            if (person.orderforPayment.RemunerationDate.Count > 0)
            {
                bill = person.orderforPayment.RemunerationDate[0];
                foreach (var t in person.orderforPayment.RemunerationDate)
                {
                    if (DateTime.Compare(t.IssueDate, bill.IssueDate) < 0)
                    {
                        bill = t;
                    }
                }
                return bill;
            }
            else
            {
                bill.IssueDate = DateTime.MinValue;
                return bill;
            }

        }

        public static Bills RemunerationLastBill(Person person)
        {
            Bills bill = new Bills();
            if (person.orderforPayment.RemunerationDate.Count > 0)
            {
                bill = person.orderforPayment.RemunerationDate[0];
                foreach (var t in person.orderforPayment.RemunerationDate)
                {
                    if (DateTime.Compare(t.IssueDate, bill.IssueDate) > 0)
                    {
                        bill = t;
                    }
                }
                return bill;
            }
            else
            {
                bill.IssueDate = DateTime.MaxValue;
                return bill;
            }
        }

        /// <summary>
        /// Takes the total amount and return the amount verbaly in a string.
        /// </summary>
        /// <param name="number"></param>
        /// <returns> string </returns>
        public static string NumberToText(double number)
        {
            int? intPart = null;
            int? fractionalPart = null;

            intPart = (int)Math.Truncate(number);
            fractionalPart = (int)((number - intPart) * 100 + 0.5);

            if (fractionalPart != 0 )
            {
                if (fractionalPart == 1)
                {
                    return $"{SplitNumber(intPart)}ευρώ και {SplitNumber(fractionalPart)}λεπτό";
                }
                else
                {
                    return $"{SplitNumber(intPart)}ευρώ και {SplitNumber(fractionalPart)}λεπτά";
                }
            }
            return $"{SplitNumber(intPart)}ευρώ";
        }

        internal static string SplitNumber(int? num)
        {
            StringBuilder str = new StringBuilder();
            if(num >= 1000)
            {
                int? thousandsNumber = num / 1000;
                str.Append(NumberInVerbal(thousandsNumber,1000));
                num -= thousandsNumber * 1000;
            }
            if(num >= 100)
            {
                int? hundredNumber = num / 100;
                str.Append(NumberInVerbal(hundredNumber,100));
                num -= hundredNumber * 100;
            }
            if(num >= 10)
            {
                if (num < 20 && num >= 11)
                {
                    str.Append(NumberInVerbal(num, 10));
                    return str.ToString();
                }
                else
                {
                    int? tensNumber = num / 10;
                    str.Append(NumberInVerbal(tensNumber, 10));

                    num -= tensNumber * 10;
                    str.Append(NumberInVerbal(num, 1));

                    return str.ToString();
                }

            }
            else
            {
                str.Append(NumberInVerbal(num, 1));

                return str.ToString();
            }

        }


        /// <summary>
        /// Temporary funciton to read the temlate file.
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static RichTextBox ReadTemplateFiel()
        {
            RichTextBox richTextBox1 = new();
            string path = System.Configuration.ConfigurationManager.AppSettings["TemplateFile"].ToString();

            //richTextBox1.LoadFile(@"C:\Demos\DATA\TEMPLATE.rtf");
            richTextBox1.LoadFile(path);

            return richTextBox1;
        }


        /// <summary>
        /// Save File function. 
        /// </summary>
        /// <param name="richTextBox1"> RTF file target</param>
        /// <param name="person"> Person parameter to save the file with the client information as default value.</param>
        public static void SaveTemplateFile(RichTextBox richTextBox1, Person person)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = $"{person.LastName} {person.FirstName} {person.FatherName}.rtf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
            //DialogResult openfile = MessageBox.Show("Would you like to open the file?", "Open saved file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if(openfile == DialogResult.Yes)
            //{
            //    RichTextBox text = new RichTextBox();
            //    text.LoadFile(saveFileDialog1.FileName);
            //    MyNotePad myNotePad = new MyNotePad(text);
            //    myNotePad.Show();
            //}
        }

        public static List<Lawyer> LoadLawyers()
        {
            //string filePath = @"C:\Demos\DATA\LawyersDatabase.txt";
            string filePath = System.Configuration.ConfigurationManager.AppSettings["LawyersDatabase"].ToString();

            List<Lawyer> lawyers = new();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Lawyer newLawyer = new()
                {
                    AMDSA = int.Parse(entries[0]),
                    FirstName = entries[1],
                    Prfix = entries[2],
                    LastName = entries[3]
                };
                if (entries[4].Trim() == "F")
                    newLawyer.Gender = gender.Female;
                else if (entries[4].Trim() == "M")
                    newLawyer.Gender = gender.Male;

                    lawyers.Add(newLawyer);
            }

            return lawyers;
        }


        public static List<Court> LoadCourts()
        {
            //string filePath = @"C:\Demos\DATA\CourtsDatabase.txt";
            string filePath = System.Configuration.ConfigurationManager.AppSettings["CourtsDatabase"].ToString();

            List<Court> courts = new();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Court newLCourt = new()
                {
                    CapitalName = entries[0],
                    SmallName = entries[1],
                    CityName = entries[2],
                    InCity = entries[3],
                };
                if (entries[4] == "F")
                    newLCourt.Gender = gender.Female;
                else if (entries[4] == "M")
                    newLCourt.Gender = gender.Male;
                else if (entries[4] == "N")
                    newLCourt.Gender = gender.Neutral;

                if (entries[5] == "A")
                    newLCourt.Region = CourtRegion.ATTICA;
                else if (entries[5] == "E")
                    newLCourt.Region = CourtRegion.OTHERREGION;
                //advanced options.
                if (entries[6] == "T")
                    newLCourt.WriteAMDSAinApplication = true;
                if (entries[7] == "T")
                    newLCourt.WriteAMDSAinOrder = true;
                if (entries[8] == "T")
                    newLCourt.BillingAnalysis = true;

                courts.Add(newLCourt);
            }

            return courts;
        }

        // TODO: FIX THIS, FIND A BETTER METHOD THAN THE IF ELSE METHOD.
        public static void SaveCourts(List<Court> courts)
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["CourtsDatabase"].ToString();

            List<string> output = new List<string>();
            string strRegion = "#";
            string strGender = "#"; 
            string strApplication = "#";
            string strOrder = "#"; 
            string strBilling = "#";

            foreach (var court in courts)
            {
                if(court.Region == CourtRegion.ATTICA)
                {
                    strRegion = "A";
                }
                else if(court.Region == CourtRegion.OTHERREGION)
                {
                    strRegion = "E";
                }

                if(court.Gender == gender.Male)
                {
                    strGender = "M";
                }
                else if(court.Gender == gender.Female)
                {
                    strGender = "F";
                }
                else if(court.Gender == gender.Neutral)
                {
                    strGender = "N";
                }

                if (court.WriteAMDSAinApplication == true)
                {
                    strApplication = "T";
                }
                else
                {
                    strApplication = "O";
                }

                if (court.WriteAMDSAinOrder == true)
                {
                    strOrder = "T";
                }
                else
                {
                    strOrder = "O";
                }

                if (court.BillingAnalysis == true)
                {
                    strBilling = "T";
                }
                else
                {
                    strBilling = "O";
                }

                //output.Add($"{court.CapitalName},{court.SmallName},{court.CityName},{court.InCity},{court.Gender},{court.Region},{court.WriteAMDSAinApplication},{court.WriteAMDSAinOrder},{court.BillingAnalysis}");

                output.Add($"{court.CapitalName},{court.SmallName},{court.CityName},{court.InCity},{strGender},{strRegion},{strApplication},{strOrder},{strBilling}");
            }

            File.WriteAllLines(filePath, output);

        }

        public static void SaveLawyers(List<Lawyer> lawyers)
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["LawyersDatabase"].ToString();
            List<string> output = new List<string>();

            foreach (Lawyer lawyer in lawyers)
            {
                if(lawyer.Gender == gender.Male)
                {
                    output.Add($"{lawyer.AMDSA},{lawyer.FirstName},{lawyer.Prfix},{lawyer.LastName},M");
                }
                else if( lawyer.Gender == gender.Female)
                {
                    output.Add($"{lawyer.AMDSA},{lawyer.FirstName},{lawyer.Prfix},{lawyer.LastName},F");
                }
            }
            File.WriteAllLines(filePath, output);

        }


        public static List<string> LoadContractsDuration()
        {
            string filepath = System.Configuration.ConfigurationManager.AppSettings["ContractDuration"].ToString();

            List<string> lines = File.ReadAllLines(filepath).ToList();
            return lines;
        }

        public static List<string> LoadCompaniesTypes()
        {
            string filepath = System.Configuration.ConfigurationManager.AppSettings["TypesOfCompanies"].ToString();

            List<string> lines = File.ReadAllLines(filepath).ToList();
            return lines;
        }



        /// <summary>
        /// Convert String to RTF compatible Format.
        /// if unable to convert return '#' char instade
        /// using: https://en.wikipedia.org/wiki/Windows-1253
        /// </summary>
        /// <param name="str"></param>
        /// <returns>RTF Compatible String</returns>
        public static string RtfToString(string str)
        {
            string str2 = "";
            
            for (int i = 0; i < str.Length; i++)
            {

                // Convert char to RTF Greek Format chars
                char c = str[i];
                switch (c)
                {
                    case 'Α':
                        str2 += "\\'c1";
                        break;
                    case 'Β':
                        str2 += "\\'c2";
                        break;
                    case 'Γ':
                        str2 += "\\'c3";
                        break;
                    case 'Δ':
                        str2 += "\\'c4";
                        break;
                    case 'Ε':
                        str2 += "\\'c5";
                        break;
                    case 'Ζ':
                        str2 += "\\'c6";
                        break;
                    case 'Η':
                        str2 += "\\'c7";
                        break;
                    case 'Θ':
                        str2 += "\\'c8";
                        break;
                    case 'Ι':
                        str2 += "\\'c9";
                        break;
                    case 'Κ':
                        str2 += "\\'ca";
                        break;
                    case 'Λ':
                        str2 += "\\'cb";
                        break;
                    case 'Μ':
                        str2 += "\\'cc";
                        break;
                    case 'Ν':
                        str2 += "\\'cd";
                        break;
                    case 'Ξ':
                        str2 += "\\'ce";
                        break;
                    case 'Ο':
                        str2 += "\\'cf";
                        break;
                    case 'Π':
                        str2 += "\\'d0";
                        break;
                    case 'Ρ':
                        str2 += "\\'d1";
                        break;
                    case 'Σ':
                        str2 += "\\'d3";
                        break;
                    case 'Τ':
                        str2 += "\\'d4";
                        break;
                    case 'Υ':
                        str2 += "\\'d5";
                        break;
                    case 'Φ':
                        str2 += "\\'d6";
                        break;
                    case 'Χ':
                        str2 += "\\'d7";
                        break;
                    case 'Ψ':
                        str2 += "\\'d8";
                        break;
                    case 'Ω':
                        str2 += "\\'d9";
                        break;
                    case '⍽':
                        str2 += "\\'a0";
                        break;
                    case 'α':
                        str2 += "\\'e1";
                        break;
                    case 'β':
                        str2 += "\\'e2";
                        break;
                    case 'γ':
                        str2 += "\\'e3";
                        break;
                    case 'δ':
                        str2 += "\\'e4";
                        break;
                    case 'ε':
                        str2 += "\\'e5";
                        break;
                    case 'ζ':
                        str2 += "\\'e6";
                        break;
                    case 'η':
                        str2 += "\\'e7";
                        break;
                    case 'θ':
                        str2 += "\\'e8";
                        break;
                    case 'ι':
                        str2 += "\\'e9";
                        break;
                    case 'κ':
                        str2 += "\\'ea";
                        break;
                    case 'λ':
                        str2 += "\\'eb";
                        break;
                    case 'μ':
                        str2 += "\\'ec";
                        break;
                    case 'ν':
                        str2 += "\\'ed";
                        break;
                    case 'ξ':
                        str2 += "\\'ee";
                        break;
                    case 'ο':
                        str2 += "\\'ef";
                        break;
                    case 'π':
                        str2 += "\\'f0";
                        break;
                    case 'ρ':
                        str2 += "\\'f1";
                        break;
                    case 'ς':
                        str2 += "\\'f2";
                        break;
                    case 'σ':
                        str2 += "\\'f3";
                        break;
                    case 'τ':
                        str2 += "\\'f4";
                        break;
                    case 'υ':
                        str2 += "\\'f5";
                        break;
                    case 'φ':
                        str2 += "\\'f6";
                        break;
                    case 'χ':
                        str2 += "\\'f7";
                        break;
                    case 'ψ':
                        str2 += "\\'f8";
                        break;
                    case 'ω':
                        str2 += "\\'f9";
                        break;
                    case 'Έ':
                        str2 += "\\'b8";
                        break;
                    case 'Ή':
                        str2 += "\\'b9";
                        break;
                    case 'Ί':
                        str2 += "\\'ba";
                        break;
                    case 'Ό':
                        str2 += "\\'bc";
                        break;
                    case 'Ύ':
                        str2 += "\\'be";
                        break;
                    case 'Ώ':
                        str2 += "\\'bf";
                        break;
                    case 'ΐ':
                        str2 += "\\'c0";
                        break;
                    case 'Ϊ':
                        str2 += "\\'da";
                        break;
                    case 'Ϋ':
                        str2 += "\\'db";
                        break;
                    case 'ά':
                        str2 += "\\'dc";
                        break;
                    case 'έ':
                        str2 += "\\'dd";
                        break;
                    case 'ή':
                        str2 += "\\'de";
                        break;
                    case 'ί':
                        str2 += "\\'df";
                        break;
                    case 'ΰ':
                        str2 += "\\'e0";
                        break;
                    case 'ϊ':
                        str2 += "\\'fa";
                        break;
                    case 'ϋ':
                        str2 += "\\'fb";
                        break;
                    case 'ό':
                        str2 += "\\'fc";
                        break;
                    case 'ύ':
                        str2 += "\\'fd";
                        break;
                    case 'ώ':
                        str2 += "\\'fe";
                        break;
                    case '€':
                        str2 += "\\'80";
                        break;
                    case 'Ά':
                        str2 += "\\'a2";
                        break;
                    // Spical characters.
                    case '!':
                        str2 += "\\'21";
                        break;
                    case '"':
                        str2 += "\\'22";
                        break;
                    case '#':
                        str2 += "\\'23";
                        break;
                    case '$':
                        str2 += "\\'24";
                        break;
                    case '%':
                        str2 += "\\'25";
                        break;
                    case '&':
                        str2 += "\\'26";
                        break;
                    case '\'':
                        str2 += "\\'27";
                        break;
                    case '(':
                        str2 += "\\'28";
                        break;
                    case ')':
                        str2 += "\\'29";
                        break;
                    case '*':
                        str2 += "\\'2a";
                        break;
                    case '+':
                        str2 += "\\'2b";
                        break;
                    case ',':
                        str2 += "\\'2c";
                        break;
                    case '-':
                        str2 += "\\'2d";
                        break;
                    case '.':
                        str2 += "\\'2e";
                        break;
                    case '/':
                        str2 += "\\'2f";
                        break;
                    case ' ':
                        str2 += "\\'20";
                        break;
                    case '0':
                        str2 += "\\'30";
                        break;
                    case '1':
                        str2 += "\\'31";
                        break;
                    case '2':
                        str2 += "\\'32";
                        break;
                    case '3':
                        str2 += "\\'33";
                        break;
                    case '4':
                        str2 += "\\'34";
                        break;
                    case '5':
                        str2 += "\\'35";
                        break;
                    case '6':
                        str2 += "\\'36";
                        break;
                    case '7':
                        str2 += "\\'37";
                        break;
                    case '8':
                        str2 += "\\'38";
                        break;
                    case '9':
                        str2 += "\\'39";
                        break;
                    case ':':
                        str2 += "\\'3a";
                        break;
                    case ';':
                        str2 += "\\'3b";
                        break;
                    case '<':
                        str2 += "\\'3c";
                        break;
                    case '=':
                        str2 += "\\'3d";
                        break;
                    case '>':
                        str2 += "\\'3e";
                        break;
                    case '?':
                        str2 += "\\'3f";
                        break;
                    case '@':
                        str2 += "\\'40";
                        break;
                    case 'A':
                        str2 += "\\'41";
                        break;
                    case 'B':
                        str2 += "\\'42";
                        break;
                    case 'C':
                        str2 += "\\'43";
                        break;
                    case 'D':
                        str2 += "\\'44";
                        break;
                    case 'E':
                        str2 += "\\'45";
                        break;
                    case 'F':
                        str2 += "\\'46";
                        break;
                    case 'G':
                        str2 += "\\'47";
                        break;
                    case 'H':
                        str2 += "\\'48";
                        break;
                    case 'I':
                        str2 += "\\'49";
                        break;
                    case 'J':
                        str2 += "\\'4a";
                        break;
                    case 'K':
                        str2 += "\\'4b";
                        break;
                    case 'L':
                        str2 += "\\'4c";
                        break;
                    case 'M':
                        str2 += "\\'4d";
                        break;
                    case 'N':
                        str2 += "\\'4e";
                        break;
                    case 'O':
                        str2 += "\\'4f";
                        break;
                    case 'P':
                        str2 += "\\'50";
                        break;
                    case 'Q':
                        str2 += "\\'51";
                        break;
                    case 'R':
                        str2 += "\\'52";
                        break;
                    case 'S':
                        str2 += "\\'53";
                        break;
                    case 'T':
                        str2 += "\\'54";
                        break;
                    case 'U':
                        str2 += "\\'55";
                        break;
                    case 'V':
                        str2 += "\\'56";
                        break;
                    case 'W':
                        str2 += "\\'57";
                        break;
                    case 'X':
                        str2 += "\\'58";
                        break;
                    case 'Y':
                        str2 += "\\'59";
                        break;
                    case 'Z':
                        str2 += "\\'5a";
                        break;
                    case '[':
                        str2 += "\\'5b";
                        break;
                    case '\\':
                        str2 += "\\'5c";
                        break;
                    case ']':
                        str2 += "\\'5d";
                        break;
                    case '^':
                        str2 += "\\'5e";
                        break;
                    case '_':
                        str2 += "\\'5f";
                        break;
                    case '`':
                        str2 += "\\'60";
                        break;
                    case 'a':
                        str2 += "\\'61";
                        break;
                    case 'b':
                        str2 += "\\'62";
                        break;
                    case 'c':
                        str2 += "\\'63";
                        break;
                    case 'd':
                        str2 += "\\'64";
                        break;
                    case 'e':
                        str2 += "\\'65";
                        break;
                    case 'f':
                        str2 += "\\'66";
                        break;
                    case 'g':
                        str2 += "\\'67";
                        break;
                    case 'h':
                        str2 += "\\'68";
                        break;
                    case 'i':
                        str2 += "\\'69";
                        break;
                    case 'j':
                        str2 += "\\'6a";
                        break;
                    case 'k':
                        str2 += "\\'6b";
                        break;
                    case 'l':
                        str2 += "\\'6c";
                        break;
                    case 'm':
                        str2 += "\\'6d";
                        break;
                    case 'n':
                        str2 += "\\'6e";
                        break;
                    case 'o':
                        str2 += "\\'6f";
                        break;
                    case 'p':
                        str2 += "\\'70";
                        break;
                    case 'q':
                        str2 += "\\'71";
                        break;
                    case 'r':
                        str2 += "\\'72";
                        break;
                    case 's':
                        str2 += "\\'73";
                        break;
                    case 't':
                        str2 += "\\'74";
                        break;
                    case 'u':
                        str2 += "\\'75";
                        break;
                    case 'v':
                        str2 += "\\'76";
                        break;
                    case 'w':
                        str2 += "\\'77";
                        break;
                    case 'x':
                        str2 += "\\'78";
                        break;
                    case 'y':
                        str2 += "\\'79";
                        break;
                    case 'z':
                        str2 += "\\'7a";
                        break;
                    case '{':
                        str2 += "\\'7b";
                        break;
                    case '|':
                        str2 += "\\'7c";
                        break;
                    case '}':
                        str2 += "\\'7d";
                        break;
                    case '~':
                        str2 += "\\'7e";
                        break;
                    case '‚':
                        str2 += "\\'82";
                        break;
                    case 'ƒ':
                        str2 += "\\'83";
                        break;
                    case '„':
                        str2 += "\\'84";
                        break;
                    case '…':
                        str2 += "\\'85";
                        break;
                    case '†':
                        str2 += "\\'86";
                        break;
                    case '‡':
                        str2 += "\\'87";
                        break;
                    case '‰':
                        str2 += "\\'89";
                        break;
                    case '‹':
                        str2 += "\\'8b";
                        break;
                    case '‘':
                        str2 += "\\'91";
                        break;
                    case '’':
                        str2 += "\\'92";
                        break;
                    case '“':
                        str2 += "\\'93";
                        break;
                    case '”':
                        str2 += "\\'94";
                        break;
                    case '•':
                        str2 += "\\'95";
                        break;
                    case '–':
                        str2 += "\\'96";
                        break;
                    case '—':
                        str2 += "\\'97";
                        break;
                    case '™':
                        str2 += "\\'99";
                        break;
                    case '›':
                        str2 += "\\'9b";
                        break;
                    case '΅':
                        str2 += "\\'a1";
                        break;
                    case '£':
                        str2 += "\\'a3";
                        break;
                    case '¤':
                        str2 += "\\'a4";
                        break;
                    case '¥':
                        str2 += "\\'a5";
                        break;
                    case '¦':
                        str2 += "\\'a6";
                        break;
                    case '§':
                        str2 += "\\'a7";
                        break;
                    case '¨':
                        str2 += "\\'a8";
                        break;
                    case '©':
                        str2 += "\\'a9";
                        break;
                    case '«':
                        str2 += "\\'ab";
                        break;
                    case '¬':
                        str2 += "\\'ac";
                        break;
                    case '®':
                        str2 += "\\'ae";
                        break;
                    case '°':
                        str2 += "\\'b0";
                        break;
                    case '±':
                        str2 += "\\'b1";
                        break;
                    case '²':
                        str2 += "\\'b2";
                        break;
                    case '³':
                        str2 += "\\'b3";
                        break;
                    case '΄':
                        str2 += "\\'b4";
                        break;
                    case 'µ':
                        str2 += "\\'b5";
                        break;
                    case '¶':
                        str2 += "\\'b6";
                        break;
                    case '·':
                        str2 += "\\'b7";
                        break;
                    case '»':
                        str2 += "\\'bb";
                        break;
                    // ASCII control characters
                    case '\0':
                        str2 += "\\'00";
                        break;
                    case '\a':
                        str2 += "\\'bb";
                        break;
                    case '\b':
                        str2 += "\\'08";
                        break;
                    // test if this is a page break.
                    case '\f':
                        str2 += "\\'0c";
                        break;
                    case '\n':
                        str2 += "\\'0a";
                        break;
                    case '\r':
                        str2 += "\\'0d";
                        break;
                    case '\t':
                        str2 += "\\'09";
                        break;
                    case '\v':
                        str2 += "\\'0b";
                        break;


                    default:
                        MessageBox.Show("Unable to convert the character: " + c.ToString(), "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        str2 += "\\'23";
                        break;

                }

            }
                return str2;
        }


        internal static string NumberInVerbal(int? number, int controler)
        {
            if (number == null)
            {
                return "";
            }
            else if (number == 19)
            {
                if (controler == 1000)
                {
                    return "δεκαεννέα χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "";
                }
                else if (controler == 10)
                {
                    return "δεκαεννέα ";
                }
                else if(controler == 1)
                {
                    return "δεκαεννέα ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 18)
            {
                if (controler == 1000)
                {
                    return "δεκαοκτώ χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "";
                }
                else if (controler == 10)
                {
                    return "δεκαοκτώ ";
                }
                else if (controler == 1)
                {
                    return "δεκαοκτώ ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 17)
            {
                if (controler == 1000)
                {
                    return "δεκαεπτά χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "";
                }
                else if (controler == 10)
                {
                    return "δεκαεπτά ";
                }
                else if (controler == 1)
                {
                    return "δεκαεπτά ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 16)
            {
                if (controler == 1000)
                {
                    return "δεκαέξι χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "";
                }
                else if (controler == 10)
                {
                    return "δεκαέξι ";
                }
                else if (controler == 1)
                {
                    return "δεκαέξι ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 15)
            {
                if (controler == 1000)
                {
                    return "δεκαπέντε χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "";
                }
                else if (controler == 10)
                {
                    return "δεκαπέντε ";
                }
                else if (controler == 1)
                {
                    return "δεκαπέντε ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 14)
            {
                if (controler == 1000)
                {
                    return "δεκατέσσερα χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "";
                }
                else if (controler == 10)
                {
                    return "δεκατέσσερα ";
                }
                else if (controler == 1)
                {
                    return "δεκατέσσερα ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 13)
            {
                if (controler == 1000)
                {
                    return "δεκατρία χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "";
                }
                else if (controler == 10)
                {
                    return "δεκατρία ";
                }
                else if (controler == 1)
                {
                    return "δεκατρία ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 12)
            {
                if (controler == 1000)
                {
                    return "δώδεκα χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "";
                }
                else if (controler == 10)
                {
                    return "δώδεκα ";
                }
                else if (controler == 1)
                {
                    return "δώδεκα ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 11)
            {
                if (controler == 1000)
                {
                    return "έντεκα χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "";
                }
                else if (controler == 10)
                {
                    return "έντεκα ";
                }
                else if (controler == 1)
                {
                    return "έντεκα ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 10)
            {
                if (controler == 1000)
                {
                    return "δέκα χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "";
                }
                else if (controler == 10)
                {
                    return "δέκα ";
                }
                else if (controler == 1)
                {
                    return "ένα ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 9)
            {
                if (controler == 1000)
                {
                    return "εννέα χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "εννιακόσια ";
                }
                else if (controler == 10)
                {
                    return "ενενήντα ";
                }
                else if (controler == 1)
                {
                    return "εννέα ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 8)
            {
                if (controler == 1000)
                {
                    return "οκτώ χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "οκτακόσια ";
                }
                else if (controler == 10)
                {
                    return "ογδόντα ";
                }
                else if (controler == 1)
                {
                    return "οκτώ ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 7)
            {
                if (controler == 1000)
                {
                    return "επτά χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "επτακόσια ";
                }
                else if (controler == 10)
                {
                    return "εβδομήντα ";
                }
                else if (controler == 1)
                {
                    return "επτά ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 6)
            {
                if (controler == 1000)
                {
                    return "έξι χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "εξακόσια ";
                }
                else if (controler == 10)
                {
                    return "εξήντα ";
                }
                else if (controler == 1)
                {
                    return "έξι ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 5)
            {
                if (controler == 1000)
                {
                    return "πέντε χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "πεντακόσια ";
                }
                else if (controler == 10)
                {
                    return "πενήντα ";
                }
                else if (controler == 1)
                {
                    return "πέντε ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 4)
            {
                if (controler == 1000)
                {
                    return "τέσσερις χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "τετρακόσια ";
                }
                else if (controler == 10)
                {
                    return "σαράντα ";
                }
                else if (controler == 1)
                {
                    return "τέσσερα ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 3)
            {
                if (controler == 1000)
                {
                    return "τρεις χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "τριακόσια ";
                }
                else if (controler == 10)
                {
                    return "τριάντα ";
                }
                else if (controler == 1)
                {
                    return "τρία ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 2)
            {
                if (controler == 1000)
                {
                    return "δύο χιλιάδες ";
                }
                else if (controler == 100)
                {
                    return "διακόσια ";
                }
                else if (controler == 10)
                {
                    return "είκοσι ";
                }
                else if (controler == 1)
                {
                    return "δύο ";
                }
                else
                {
                    return "";
                }
            }
            else if (number == 1)
            {
                if (controler == 1000)
                {
                    return "χίλια ";
                }
                else if (controler == 100)
                {
                    return "εκατό ";
                }
                else if (controler == 10)
                {
                    return "δέκα ";
                }
                else if (controler == 1)
                {
                    return "ένα ";
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

    }
}
