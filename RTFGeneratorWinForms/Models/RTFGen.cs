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


        /// <summary>
        /// Convert String to RTF compatible Format.
        /// if unable to convert return '#' char instade
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
                    case ' ':
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
                        str2 += "\\'d5";
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
                    case '-':
                        str2 += "\\'00";
                        break;
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
