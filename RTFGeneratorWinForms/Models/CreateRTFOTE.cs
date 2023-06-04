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

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΕΙΣΑΓΩΓΗΤΩΝΣΥΜΒΑΣΩΝΚΑΙΑΡΙΘΜΩΝ"), RTFGen.RtfToString(IntroClientContractsandConnections(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΣΥΜΒΚΑΙΑΡΙΘΜΟΙ"), RTFGen.RtfToString(ClientContractsandConnectoin(person)));
            richTextBox1.Rtf = str1;


            // ΚΕΙΜΕΝΟ ΑΙΤΗΣΗΣ --------------------------------------------------------------------------------------------------------------------------------------------------------

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΝΟΜΙΜΑΕΚΠΡΟΣΩΠΟΥΜΕΝΗ"), RTFGen.RtfToString(AddLawyerInfoApplicationSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΠΡΩΤΟΜΕΡΟΣΤΗΣΑΙΤΗΣΗΣ"), RTFGen.RtfToString(AddAplicationSection(person)));
            richTextBox1.Rtf = str1;




        }

        #region OFP General Info.
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

        public static string ClientContractsandConnectoin(Person person)
        {
            StringBuilder sb = new();

            foreach (var v in person.orderforPayment.contracts)
            {
                if (v.ContractType == string.Empty)
                {
                    sb.Append("\tτην ");
                    sb.Append(v.Date.ToShortDateString().Trim());
                    sb.Append(" η υπ' αριθμόν ");
                    sb.Append(v.Number.Trim());
                    // Change this if sim number and add type of contract.
                    sb.Append(", για τη σύνδεση με αριθμό ");
                    sb.Append(v.PhoneNumber.Trim());
                    // removed Elaxistis if the durration is more than 24 months.
                    if (v.Durration == "αορίστου χρόνου")
                    {
                        sb.Append(" διάρκειας ");
                    }
                    else
                    {
                        sb.Append(" ελάχιστης διάρκειας ");
                    }

                    sb.Append(v.Durration.Trim());
                    if (person.orderforPayment.contracts.Last() == v)
                    {
                        sb.Append(". ");
                    }
                    else
                    {
                        sb.Append(",\r");
                    }

                }
                else
                {
                    sb.Append("\tτην ");
                    sb.Append(v.Date.ToShortDateString().Trim());
                    sb.Append(" η υπ' αριθμόν ");
                    sb.Append(v.Number.Trim());
                    // Change this if sim number and add type of contract.
                    sb.Append(", για τη σύνδεση με αριθμό SIM ");
                    sb.Append(v.PhoneNumber.Trim());
                    sb.Append(" και Πρόγραμμα ");
                    sb.Append(v.ContractType.Trim());
                    // removed Elaxistis if the durration is more than 24 months.
                    if (v.Durration == "αορίστου χρόνου")
                    {
                        sb.Append(" διάρκειας ");
                    }
                    else
                    {
                        sb.Append(" ελάχιστης διάρκειας ");
                    }

                    sb.Append(v.Durration.Trim());
                    if (person.orderforPayment.contracts.Last() == v)
                    {
                        sb.Append(". ");
                    }
                    else
                    {
                        sb.Append(",\r");
                    }

                }
            }

            return sb.ToString();

        }

        #endregion OFP General Info.

        #region Applictaion.

        public static string AddLawyerInfoApplicationSection(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // we need to check the lawyer also. ΑΝ ΥΠΑΡΧΕΙ ΑΙΤΗΜΑ ΑΜΦΗΖΒΗΤΗΣΗ
            if (person.orderforPayment.CourtName.Region == CourtRegion.ATTICA)
            {
                if (person.orderforPayment.LawyerName.Gender == gender.Male)
                {
                    sb.Append("νόμιμα εκπροσωπούμενης");
                }
                else if (person.orderforPayment.LawyerName.Gender == gender.Female)
                {
                    sb.Append("νόμιμα εκπροσωπούμενης");
                }
            }
            else if (person.orderforPayment.CourtName.Region == CourtRegion.OTHERREGION && !person.orderforPayment.CourtName.WriteAMDSAinApplication)
            {
                if (person.orderforPayment.LawyerName.Gender == gender.Male)
                {
                    sb.Append($"νόμιμα εκπροσωπούμενης, και η οποία υπογράφεται από τον πληρεξούσιο δικηγόρο της {person.orderforPayment.LawyerName.Print}");
                }
                else if (person.orderforPayment.LawyerName.Gender == gender.Female)
                {
                    sb.Append($"νόμιμα εκπροσωπούμενης, και η οποία υπογράφεται από την πληρεξούσια δικηγόρο της {person.orderforPayment.LawyerName.Print}");
                }
            }
            else if (person.orderforPayment.CourtName.Region == CourtRegion.OTHERREGION && person.orderforPayment.CourtName.WriteAMDSAinApplication)
            {
                if (person.orderforPayment.LawyerName.Gender == gender.Male)
                {
                    sb.Append($"νόμιμα  εκπροσωπούμενης, και η οποία υπογράφεται από τον πληρεξούσιο δικηγόρο της {person.orderforPayment.LawyerName.Print} (ΑΜ ΔΣΑ {person.orderforPayment.LawyerName.AMDSA.ToString().Trim()})");
                }
                else if (person.orderforPayment.LawyerName.Gender == gender.Female)
                {
                    sb.Append($"νόμιμα  εκπροσωπούμενης, και η οποία υπογράφεται από την πληρεξούσια δικηγόρο της {person.orderforPayment.LawyerName.Print} (ΑΜ ΔΣΑ {person.orderforPayment.LawyerName.AMDSA.ToString().Trim()})");
                }
            }

            return sb.ToString();
        }

        public static string IntroClientContractsandConnections(Person person)
        {
            StringBuilder sb = new();

            if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractMultiplePhones)
            {
                sb.Append("\tΜεταξύ εμού και του καθού συνήφθη η κάτωθι σύμβαση σύνδεσης στο δίκτυο της ΟΤΕ: ");
            }
            else if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones)
            {
                sb.Append("\tΜεταξύ εμού και της καθής συνήφθη η κάτωθι σύμβαση σύνδεσης στο δίκτυο της ΟΤΕ: ");
            }
            else if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts)
            {
                sb.Append("\tΜεταξύ εμού και του καθού συνήφθησαν οι κάτωθι συμβάσεις σύνδεσης στο δίκτυο της ΟΤΕ: ");
            }
            else if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts)
            {
                sb.Append("\tΜεταξύ εμού και της καθής συνήφθησαν οι κάτωθι συμβάσεις σύνδεσης στο δίκτυο της ΟΤΕ: ");
            }
            return sb.ToString();
        }

        public static string AddAplicationSection(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // need improvment.
            // we need to check the lawyer also. ΑΝ ΥΠΑΡΧΕΙ ΑΙΤΗΜΑ ΑΜΦΗΖΒΗΤΗΣΗ
            if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractSinglePhone && true)
            {
                sb.Append("\tΜε την σύμβαση αυτή εγώ μεν η αιτούσα ανέλαβα την υποχρέωση να παρέχω στον καθού τηλεπικοινωνιακές υπηρεσίες, πλέον του κατάλληλου τηλεπικοινωνιακού τερματικού εξοπλισμού, αυτός δε ανέλαβε την υποχρέωση να εξοφλεί εμένα, βάσει των όρων της μεταξύ μας σύμβασης και ειδικότερα εντός της προθεσμίας που αναγράφεται στους 'μηνιαίους' λογαριασμούς που θα του απέστελνα.\r");
                sb.Append("\tΗ παραπάνω αναφερόμενη σύμβαση συμφωνήσαμε να διέπεται από τους ισχύοντες «Γενικούς Όρους Παροχής Τηλεφωνικής Γραμμής», τους οποίους ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε ο καθού κατά την υπογραφή της, καθώς και από τους «Ειδικούς Όρους», τους οποίους επίσης ο καθού ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε. ");

                // Athens Jurisdiction.
                if (person.orderforPayment.AthensJurisdiction)
                {
                    sb.Append("Ειδικά συμφωνήσαμε ότι αρμόδια για την επίλυση κάθε τυχόν μεταξύ μας διαφοράς από τις συμβάσεις αυτές, θα ήταν τα δικαστήρια της Αθήνας.");
                }

                sb.Append("\r\tΜε την ίδια σύμβαση ρητά συμφωνήσαμε ότι πλήρη απόδειξη της οφειλής του καθού προς εμένα θα αποτελούν τα αποσπάσματα του επίδικου λογαριασμού, που τηρούνται στα νόμιμα εμπορικά βιβλία μου. Ειδικά, επίσης, συμφωνήσαμε ότι θα δικαιούμαι να προβώ σε έγγραφη καταγγελία της σύμβασης αυτής σε περίπτωση παράβασης από τον καθού οποιασδήποτε από τις συμβατικές του υποχρεώσεις, μία εκ των οποίων,  ήταν και η εντός 30 ημερών από την έκδοσή τους, εμπρόθεσμη εξόφληση των λογαριασμών, που θα του απέστελνα. Σε περίπτωση μη εξόφλησής τους μέσα στην προθεσμία αυτή, ρητά συμφωνήσαμε ότι οι λογαριασμοί αυτοί θα καθίστανται ληξιπρόθεσμοι και άμεσα απαιτητοί, ο δε καθού θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας χωρίς άλλη όχληση. ");
                // AITHMA AMFHSVITHSH.
                if (!person.orderforPayment.ChallengeRequest)
                {
                    sb.Append(" Ειδικά, τέλος, συμφωνήσαμε ότι η μη έγγραφη αμφισβήτηση από τον καθού των λογαριασμών αυτών εντός 60 ημερών από την έκδοσή τους θα σήμαινε την πλήρη και ανεπιφύλακτη αποδοχή τους.");
                }
                // ΠΡΟΣΘΕΣΕ ΛΟΓΑΡΙΣΜΟΥΣ ΕΔΩ.
            }
            else if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractMultiplePhones && true)
            {
                //sb.Append("\tΜε την σύμβαση αυτή εγώ μεν η αιτούσα ανέλαβα την υποχρέωση να παρέχω στον καθού τηλεπικοινωνιακές υπηρεσίες, αυτός δε ανέλαβε την υποχρέωση να εξοφλεί εμένα,  βάσει των όρων της μεταξύ μας σύμβασης και ειδικότερα μέσα σε 30 ημέρες από την έκδοση των μηνιαίων λογαριασμών που θα του απέστελνα.\r");
                //sb.Append("\tΗ παραπάνω αναφερόμενη σύμβαση συμφωνήσαμε να διέπεται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», τους οποίους ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε ο καθού κατά την υπογραφή της, καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους επίσης ο καθού ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε. ");

                // Athens Jurisdiction.
                if (person.orderforPayment.AthensJurisdiction)
                {
                    sb.Append("Ειδικά συμφωνήσαμε ότι αρμόδια για την επίλυση κάθε τυχόν μεταξύ μας διαφοράς από τις συμβάσεις αυτές, θα ήταν τα δικαστήρια της Αθήνας.");
                }

                sb.Append("\r\tΜε την ίδια σύμβαση ρητά συμφωνήσαμε ότι πλήρη απόδειξη της οφειλής του καθού προς εμένα θα αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνται στα νόμιμα εμπορικά βιβλία μου. Ειδικά, επίσης, συμφωνήσαμε ότι θα δικαιούμαι να προβώ σε έγγραφη καταγγελία της σύμβασης αυτής σε περίπτωση παράβασης από τον καθού οποιασδήποτε από τις συμβατικές του υποχρεώσεις, μία εκ των οποίων ήταν και η εντός 30 ημερών από την έκδοσή τους, εμπρόθεσμη εξόφληση των λογαριασμών, που θα του απέστελνα. Σε περίπτωση μη εξόφλησής τους μέσα στην προθεσμία αυτή, ρητά συμφωνήσαμε ότι οι λογαριασμοί αυτοί θα καθίστανται ληξιπρόθεσμοι και άμεσα απαιτητοί, ο δε καθου θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας χωρίς άλλη όχληση. ");
                // AITHMA AMFHSVITHSH.
                if (!person.orderforPayment.ChallengeRequest)
                {
                    sb.Append("Ειδικά, τέλος, συμφωνήσαμε ότι η μη έγγραφη αμφισβήτηση από τον καθού των λογαριασμών αυτών εντός 45 ημερών από την έκδοσή τους, θα σήμαινε την πλήρη και ανεπιφύλακτη αποδοχή τους.");
                }
            }
            else if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone && true)
            {
                sb.Append("\tΜε την σύμβαση αυτή εγώ μεν η αιτούσα ανέλαβα την υποχρέωση να παρέχω στην καθής τηλεπικοινωνιακές υπηρεσίες, αυτή δε ανέλαβε την υποχρέωση να εξοφλεί εμένα,  βάσει των όρων της μεταξύ μας σύμβασης και ειδικότερα μέσα σε 30 ημέρες από την έκδοση των μηνιαίων λογαριασμών που θα της απέστελνα.\r");
                sb.Append("\tΗ παραπάνω αναφερόμενη σύμβαση συμφωνήσαμε να διέπεται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», τους οποίους ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε η καθής κατά την υπογραφή της, καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους επίσης η καθής ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε. ");

                // Athens Jurisdiction.
                if (person.orderforPayment.AthensJurisdiction)
                {
                    sb.Append("Ειδικά συμφωνήσαμε ότι αρμόδια για την επίλυση κάθε τυχόν μεταξύ μας διαφοράς από τις συμβάσεις αυτές, θα ήταν τα δικαστήρια της Αθήνας.");
                }

                sb.Append("\r\tΜε την ίδια σύμβαση ρητά συμφωνήσαμε ότι πλήρη απόδειξη της οφειλής της καθής προς εμένα θα αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνται στα νόμιμα εμπορικά βιβλία μου. Ειδικά, επίσης, συμφωνήσαμε ότι θα δικαιούμαι να προβώ σε έγγραφη καταγγελία της σύμβασης αυτής σε περίπτωση παράβασης από την καθής οποιασδήποτε από τις συμβατικές της υποχρεώσεις, μία εκ των οποίων ήταν και η εντός 30 ημερών από την έκδοσή τους, εμπρόθεσμη εξόφληση των λογαριασμών, που θα της απέστελνα. Σε περίπτωση μη εξόφλησής τους μέσα στην προθεσμία αυτή, ρητά συμφωνήσαμε ότι οι λογαριασμοί αυτοί θα καθίστανται ληξιπρόθεσμοι και άμεσα απαιτητοί, η δε καθής θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας χωρίς άλλη όχληση. ");
                // AITHMA AMFHSVITHSH.
                if (!person.orderforPayment.ChallengeRequest)
                {
                    sb.Append("Ειδικά, τέλος, συμφωνήσαμε ότι η μη έγγραφη αμφισβήτηση από την καθής των λογαριασμών αυτών εντός 45 ημερών από την έκδοσή τους, θα σήμαινε την πλήρη και ανεπιφύλακτη αποδοχή τους.");
                }
            }
            else if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones && true)
            {
                sb.Append("\tΜε την σύμβαση αυτή εγώ μεν η αιτούσα ανέλαβα την υποχρέωση να παρέχω στην καθής τηλεπικοινωνιακές υπηρεσίες, αυτή δε ανέλαβε την υποχρέωση να εξοφλεί εμένα,  βάσει των όρων της μεταξύ μας σύμβασης και ειδικότερα μέσα σε 30 ημέρες από την έκδοση των μηνιαίων λογαριασμών που θα της απέστελνα.\r");
                sb.Append("\tΗ παραπάνω αναφερόμενη σύμβαση συμφωνήσαμε να διέπεται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», τους οποίους ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε η καθής κατά την υπογραφή της, καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους επίσης η καθής ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε. ");

                // Athens Jurisdiction.
                if (person.orderforPayment.AthensJurisdiction)
                {
                    sb.Append("Ειδικά συμφωνήσαμε ότι αρμόδια για την επίλυση κάθε τυχόν μεταξύ μας διαφοράς από τις συμβάσεις αυτές, θα ήταν τα δικαστήρια της Αθήνας.");
                }

                sb.Append("\r\tΜε την ίδια σύμβαση ρητά συμφωνήσαμε ότι πλήρη απόδειξη της οφειλής της καθής προς εμένα θα αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνται στα νόμιμα εμπορικά βιβλία μου. Ειδικά, επίσης, συμφωνήσαμε ότι θα δικαιούμαι να προβώ σε έγγραφη καταγγελία της σύμβασης αυτής σε περίπτωση παράβασης από την καθής οποιασδήποτε από τις συμβατικές της υποχρεώσεις, μία εκ των οποίων ήταν και η εντός 30 ημερών από την έκδοσή τους, εμπρόθεσμη εξόφληση των λογαριασμών, που θα της απέστελνα. Σε περίπτωση μη εξόφλησής τους μέσα στην προθεσμία αυτή, ρητά συμφωνήσαμε ότι οι λογαριασμοί αυτοί θα καθίστανται ληξιπρόθεσμοι και άμεσα απαιτητοί, η δε καθής θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας χωρίς άλλη όχληση. ");
                // AITHMA AMFHSVITHSH.
                if (!person.orderforPayment.ChallengeRequest)
                {
                    sb.Append("Ειδικά, τέλος, συμφωνήσαμε ότι η μη έγγραφη αμφισβήτηση από την καθής των λογαριασμών αυτών εντός 45 ημερών από την έκδοσή τους, θα σήμαινε την πλήρη και ανεπιφύλακτη αποδοχή τους.");
                }
            }
            else if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts && true)
            {
                sb.Append("\tΜε τις συμβάσεις αυτές εγώ μεν η αιτούσα ανέλαβα την υποχρέωση να παρέχω στον καθού τηλεπικοινωνιακές υπηρεσίες, αυτός δε ανέλαβε την υποχρέωση να εξοφλεί εμένα,  βάσει των όρων των μεταξύ μας συμβάσεων και ειδικότερα μέσα σε 30 ημέρες από την έκδοση των μηνιαίων λογαριασμών που θα του απέστελνα.\r");
                sb.Append("\tΟι παραπάνω αναφερόμενες συμβάσεις συμφωνήσαμε να διέπονται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», τους οποίους ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε ο καθού κατά την υπογραφή της, καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους επίσης ο καθού ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε. ");

                // Athens Jurisdiction.
                if (person.orderforPayment.AthensJurisdiction)
                {
                    sb.Append("Ειδικά συμφωνήσαμε ότι αρμόδια για την επίλυση κάθε τυχόν μεταξύ μας διαφοράς από τις συμβάσεις αυτές, θα ήταν τα δικαστήρια της Αθήνας.");
                }

                sb.Append("\r\tΜε τις ίδιες συμβάσεις ρητά συμφωνήσαμε ότι πλήρη απόδειξη της οφειλής του καθού προς εμένα θα αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνται στα νόμιμα εμπορικά βιβλία μου. Ειδικά, επίσης, συμφωνήσαμε ότι θα δικαιούμαι να προβώ σε έγγραφη καταγγελία των συμβάσεων αυτών σε περίπτωση παράβασης από τον καθού οποιασδήποτε από τις συμβατικές του υποχρεώσεις, μία εκ των οποίων ήταν και η εντός 30 ημερών από την έκδοσή τους, εμπρόθεσμη εξόφληση των λογαριασμών, που θα του απέστελνα. Σε περίπτωση μη εξόφλησής τους μέσα στην προθεσμία αυτή, ρητά συμφωνήσαμε ότι οι λογαριασμοί αυτοί θα καθίστανται ληξιπρόθεσμοι και άμεσα απαιτητοί, ο δε καθου θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας χωρίς άλλη όχληση. ");
                // AITHMA AMFHSVITHSH.
                if (!person.orderforPayment.ChallengeRequest)
                {
                    sb.Append("Ειδικά, τέλος, συμφωνήσαμε ότι η μη έγγραφη αμφισβήτηση από τον καθού των λογαριασμών αυτών εντός 45 ημερών από την έκδοσή τους, θα σήμαινε την πλήρη και ανεπιφύλακτη αποδοχή τους.");
                }
            }
            else if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts && true)
            {
                sb.Append("\tΜε τις συμβάσεις αυτές εγώ μεν η αιτούσα ανέλαβα την υποχρέωση να παρέχω στην καθής τηλεπικοινωνιακές υπηρεσίες, αυτή δε ανέλαβε την υποχρέωση να εξοφλεί εμένα,  βάσει των όρων των μεταξύ μας συμβάσεων και ειδικότερα μέσα σε 30 ημέρες από την έκδοση των μηνιαίων λογαριασμών που θα της απέστελνα.\r");
                sb.Append("\tΟι παραπάνω αναφερόμενες συμβάσεις συμφωνήσαμε να διέπονται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», τους οποίους ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε η καθής κατά την υπογραφή της, καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους επίσης η καθής ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε. ");

                // Athens Jurisdiction.
                if (person.orderforPayment.AthensJurisdiction)
                {
                    sb.Append("Ειδικά συμφωνήσαμε ότι αρμόδια για την επίλυση κάθε τυχόν μεταξύ μας διαφοράς από τις συμβάσεις αυτές, θα ήταν τα δικαστήρια της Αθήνας.");
                }

                sb.Append("\r\tΜε τις ίδιες συμβάσεις ρητά συμφωνήσαμε ότι πλήρη απόδειξη της οφειλής της καθής προς εμένα θα αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνται στα νόμιμα εμπορικά βιβλία μου. Ειδικά, επίσης, συμφωνήσαμε ότι θα δικαιούμαι να προβώ σε έγγραφη καταγγελία των συμβάσεων αυτών σε περίπτωση παράβασης από την καθής οποιασδήποτε από τις συμβατικές της υποχρεώσεις, μία εκ των οποίων ήταν και η εντός 30 ημερών από την έκδοσή τους, εμπρόθεσμη εξόφληση των λογαριασμών, που θα της απέστελνα. Σε περίπτωση μη εξόφλησής τους μέσα στην προθεσμία αυτή, ρητά συμφωνήσαμε ότι οι λογαριασμοί αυτοί θα καθίστανται ληξιπρόθεσμοι και άμεσα απαιτητοί, η δε καθής θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας χωρίς άλλη όχληση. ");
                // AITHMA AMFHSVITHSH.
                if (!person.orderforPayment.ChallengeRequest)
                {
                    sb.Append("Ειδικά, τέλος, συμφωνήσαμε ότι η μη έγγραφη αμφισβήτηση από την καθής των λογαριασμών αυτών εντός 45 ημερών από την έκδοσή τους, θα σήμαινε την πλήρη και ανεπιφύλακτη αποδοχή τους.");
                }
            }

            return sb.ToString();
        }

        #endregion Application.

    }
}
