using RTFGeneratorLibrary;
using System;
using System.Collections.Generic;
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
        /// <summary>
        /// Temporary funciton to read the temlate file.
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static RichTextBox ReadTemplateFiel()
        {
            RichTextBox richTextBox1 = new();
            richTextBox1.LoadFile(@"C:\Demos\DATA\template.rtf");
            return richTextBox1;
        }

        /// <summary>
        /// temporary function to save RTF file.
        /// </summary>
        /// <param name="richTextBox1"></param>
        public static void SaveTemplateFile(RichTextBox richTextBox1)
        {
            richTextBox1.SaveFile(@"C:\Demos\DATA\output.rtf");
        }

        public static List<Lawyer> LoadLawyers()
        {
            string filePath = @"C:\Demos\DATA\LawyersDatabase.txt";

            List<Lawyer> lawyers = new();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Lawyer newLawyer = new Lawyer();

                newLawyer.AMDSA = int.Parse(entries[0]);
                newLawyer.FirstName = entries[1];
                newLawyer.Prfix = entries[2];
                newLawyer.LastName = entries[3];
                if (entries[4] == "F")
                    newLawyer.Gender = gender.Female;
                else if (entries[4] == "M")
                    newLawyer.Gender = gender.Male;

                    lawyers.Add(newLawyer);
            }

            return lawyers;
        }

        public static List<string> LoadContractsDuration()
        {
            string filepath = @"C:\Demos\DATA\ContractDuration.txt";

            List<string> lines = File.ReadAllLines(filepath).ToList();
            return lines;
        }

        public static List<string> LoadCompaniesTypes()
        {
            string filepath = @"C:\Demos\DATA\TypesOfCompanies.txt";

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
                    // continue form this line





                    default:
                        MessageBox.Show("Unable to convert the character: " + c.ToString(), "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        str2 += "\\'23";
                        break;

                }

            }
            return str2;
        }


    }
}
