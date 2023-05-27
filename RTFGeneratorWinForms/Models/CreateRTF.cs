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

        public static void MaleSingelContract(Person person)
        {
            
            RichTextBox richTextBox1 = new();
            richTextBox1 = RTFGen.ReadTemplateFiel();

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

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΠΕΖΑΟΝΟΜΑΠΟΛΗ"), RTFGen.RtfToString(person.orderforPayment.CourtName.CityName.Trim()));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΤΟΠΟΣΕΚΔΟΣΗΔΙΑΤΑΓΗΣΠΟΛΗ"), RTFGen.RtfToString(PlaceOfIssuingTheOrder(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΣΧΕΤΙΚΑΤΗΣΔΙΑΤΑΓΗΣ"), RTFGen.RtfToString(AddAppendices(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΣΗΜΕΡΑΗΜΕΡΟΜΗΝΙΑΕΓΓΡΑΦΗΣ"), RTFGen.RtfToString(AddTodayDate(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΠΡΟΣΘΗΚΗΥΠΟΓΡΑΦΗΔΙΚΗΓΟΡΟΥ"), RTFGen.RtfToString(AddLawyerSignatureAtApplicationSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΟΤΙΤΛΟΣΤΟΥΑΙΤΩΝΔΙΚΓΟΡΟΣ"), RTFGen.RtfToString(AddLawyerTitelAtApplicationSection(person)));
            richTextBox1.Rtf = str1;


            // ΚΕΙΜΕΝΟ ΑΙΤΗΣΗΣ --------------------------------------------------------------------------------------------------------------------------------------------------------
            
            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΝΟΜΙΜΑΕΚΠΡΟΣΩΠΟΥΜΕΝΗ"), RTFGen.RtfToString(AddLawyerInfoApplicationSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΠΡΩΤΟΜΕΡΟΣΤΗΣΑΙΤΗΣΗΣ"), RTFGen.RtfToString(AddAplicationSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΣΤΟΙΧΕΙΑΤΙΜΟΛΟΓΙΩΝ"), RTFGen.RtfToString(AddBillsInformationSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΠΡΩΤΟΜΟΣΡΟΣΤΜΗΜΑΠΟΣΟΥ"), RTFGen.RtfToString(AddDebtSectionPart1(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΔΕΥΤΕΡΟΜΕΡΟΡΣΤΗΜΗΑΠΟΣΟΥ"), RTFGen.RtfToString(AddDebtSectionPart2(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΤΡΙΤΟΜΕΡΟΣΤΜΗΜΑΠΟΣΟΥ"), RTFGen.RtfToString(AddDebtSectionPart3(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΤΜΗΜΑΕΚΔΟΣΗΛΟΓΑΡΙΑΖΜΩΝΚΑΙΠΡΟΘΕΣΜΙΩΝ"), RTFGen.RtfToString(AddBillIssueAndPaymentAgreementSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΤΜΗΜΑΓΙΑΛΗΞΕΠΡΟΘΕΣΜΩΝΟΦΗΛΩΝ"), RTFGen.RtfToString(AddPrivouseUnpaidDeptSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΤΜΗΜΑΔΕΣΜΕΥΣΗΣΠΑΡΟΥΧΗΣΥΠΕΡΗΣΙΩΝ"), RTFGen.RtfToString(AddServiceProvidedasPerContractSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΤΜΗΜΑΜΗΝΚΑΤΑΘΕΣΗΑΜΦΗΖΒΗΤΗΣΠΕΡΕΙΛΟΓΑΡΙΑΖΜΩΝ"), RTFGen.RtfToString(AddUnserdidntAppealedToBillsSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΤΜΗΜΑΤΡΟΠΟΠΟΙΗΣΗΚΑΤΑΣΤΑΤΙΚΟΥ"), RTFGen.RtfToString(AddCompanyConditionChangedSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΑΡΜΟΔΙΟΤΗΤΗΑΔΙΚΑΣΤΗΡΙΟΥΚΑΤΑΤΟΠΟΛΟΓΑΡΙΑΖΜΩΝ"), RTFGen.RtfToString(AddCorrespondingCourtBasedOnBillingAddressSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΥΠΟΧΡΕΩΣΗΟΦΗΛΕΤΗΓΙΑΠΛΗΡΩΜΗΠΟΣΟΥ"), RTFGen.RtfToString(AddPaymentRequestFromClientSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΠΟΣΟΥΠΟΧΡΕΩΠΛΗΡΩΜΗΣ"), RTFGen.RtfToString(AddAmountOfPaymentRequestedSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΑΙΤΗΜΑΝΑΚΑΤΑΔΙΚΑΣΤΗΟΟΦΕΙΛΕΤΗΣΚΑΙΑΜΟΙΩΝ"), RTFGen.RtfToString(AddRequestAmountAndExpencesFromCourt(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΟΗΚΑΤΑΘΕΣΑΣ"), RTFGen.RtfToString(AppliedLawyer(person)));
            richTextBox1.Rtf = str1;

            // ΚΕΙΜΕΝΟ ΔΙΑΤΑΓΗΣ --------------------------------------------------------------------------------------------------------------------------------------------------------
            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΕΚΠΡΟΣΩΠΟΣΔΙΚΓΗΓΟΡΟΣΕΔΩ"), RTFGen.RtfToString(AddLawyerInfoOrderSection(person)));
            richTextBox1.Rtf = str1;
            // last addtion
            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΕΙΣΑΓΟΓΙΚΟΜΕΡΟΣΣΥΜΒΑΣΕΩΝΣΤΗΝΔΙΑΤΑΓΗ"), RTFGen.RtfToString(AddIntroToNumbersAndContractsOrderSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΠΡΩΤΟΜΟΕΡΟΣΔΙΑΤΑΗΣ"), RTFGen.RtfToString(AddOrderSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΔΕΥΤΕΡΟΜΕΡΟΣΔΙΑΤΑΓΗΣ"), RTFGen.RtfToString(AddSeconPartOfOrderSectionPart1(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΤΟΠΟΣΟΣΕΕΥΡΩΑΡΙΘΜΟΝΟ"), RTFGen.RtfToString(AddSecondPartOfOrderSectionPart2Amount(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΤΡΙΤΟΜΕΡΟΣΔΙΑΤΑΓΗΣ"), RTFGen.RtfToString(AddThirdPartOfOrderFirstPart(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΤΕΤΕΑΡΤΟΜΕΡΟΣΔΙΑΤΑΓΗΣ"), RTFGen.RtfToString(AddForthPartOfOrderFirstPart(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΔΙΚΑΣΤΙΚΟΕΝΣΥΜΟΚΑΙΓΡΑΜΜΑΤΕΙΟ"), RTFGen.RtfToString(AddCourtStamps(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΤΟΔΙΚΑΣΤΗΡΙΟΔΙΑΤΑΖΕΙ"), RTFGen.RtfToString(AddTheCourtOrderThatSection(person)));
            richTextBox1.Rtf = str1;
            
            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΔΙΚΑΙΟΜΑΑΣΚΗΣΗΔΙΑΚΟΠΗΣ"), RTFGen.RtfToString(AddAppealDeadLineSection(person)));
            richTextBox1.Rtf = str1;

            str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΚΑΙΟΛΑΤΑΔΟΙΚΗΤΙΚΑΚΑΙΔΗΜΟΣΙΑΟΡΓΑΝΑ"), RTFGen.RtfToString(AddAndAllThePublicInstrumntsSection(person)));
            richTextBox1.Rtf = str1;


            //string fielname = $"{person.FirstName} {person.LastName}";
            RTFGen.SaveTemplateFile(richTextBox1,person);
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
                sb.Append(person.FirstAddress.City.Trim() + ", " + person.FirstAddress.PostalCode.Trim() + ".");
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
            sb.Append(", " + person.FirstAddress.City.Trim() + ", ΤΚ " + person.FirstAddress.PostalCode.Trim() + ".");

            return sb.ToString();
        }



        // Η ΑΙΤΗΣΗ ΞΕΗΕΙΝΑ ΕΔΩ. ............................................................................................................................................................................


        public static string AddLawyerInfoApplicationSection(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // we need to check the lawyer also. ΑΝ ΥΠΑΡΧΕΙ ΑΙΤΗΜΑ ΑΜΦΗΖΒΗΤΗΣΗ
            if(person.orderforPayment.CourtName.Region == CourtRegion.ATTICA)
            {
                if (person.orderforPayment.LawyerName.Gender == gender.Male)
                {
                    sb.Append("νόμιμα  εκπροσωπούμενης");
                }
                else if (person.orderforPayment.LawyerName.Gender == gender.Female)
                {
                    sb.Append("νόμιμα  εκπροσωπούμενης");
                }
            }
            else if(person.orderforPayment.CourtName.Region == CourtRegion.OTHERREGION)
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
                sb.Append("\tΜεταξύ εμού και του καθού συνήφθη η κάτωθι σύμβαση σύνδεσης στο δίκτυο της COSMOTE: ");
            }
            else if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones)
            {
                sb.Append("\tΜεταξύ εμού και της καθής συνήφθη η κάτωθι σύμβαση σύνδεσης στο δίκτυο της COSMOTE: ");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts)
            {
                sb.Append("\tΜεταξύ εμού και του καθού συνήφθησαν οι κάτωθι συμβάσεις σύνδεσης στο δίκτυο της COSMOTE: ");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts)
            {
                sb.Append("\tΜεταξύ εμού και της καθής συνήφθησαν οι κάτωθι συμβάσεις σύνδεσης στο δίκτυο της COSMOTE: ");
            }
            return sb.ToString();
        }

        public static string AddTodayDate(Person person)
        {
            StringBuilder sb = new();
            sb.Append(DateTime.Now.ToShortDateString());
            return sb.ToString();
        }

        public static string AddLawyerSignatureAtApplicationSection(Person person)
        {
            StringBuilder sb = new();
            if(person.orderforPayment.LawyerName.Gender == gender.Female)
            {
                sb.Append($"παρόντος δικογράφου από την\rδικηγόρο {person.orderforPayment.LawyerName.Print}\r");
            }
            else if(person.orderforPayment.LawyerName.Gender == gender.Male)
            {
                sb.Append($"παρόντος δικογράφου από τον\r\nδικηγόρο {person.orderforPayment.LawyerName.Print}\r");
            }
            return sb.ToString();
        }

        public static string AddLawyerTitelAtApplicationSection(Person preson)
        {
            StringBuilder sb = new();
            if(preson.orderforPayment.LawyerName.Gender == gender.Female)
            {
                sb.Append("Η πληρεξούσια δικηγόρος");
            }
            else if(preson.orderforPayment.LawyerName.Gender == gender.Male)
            {
                sb.Append("Ο πληρεξούσιος δικηγόρος");
            }
            return sb.ToString();
        }

        public static string AddAplicationSection(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // need improvment.
            // we need to check the lawyer also. ΑΝ ΥΠΑΡΧΕΙ ΑΙΤΗΜΑ ΑΜΦΗΖΒΗΤΗΣΗ
            if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractSinglePhone && true) 
            {
                sb.Append("\tΜε την σύμβαση αυτή εγώ μεν η αιτούσα ανέλαβα την υποχρέωση να παρέχω στον καθού τηλεπικοινωνιακές υπηρεσίες, αυτός δε ανέλαβε την υποχρέωση να εξοφλεί εμένα,  βάσει των όρων της μεταξύ μας σύμβασης και ειδικότερα μέσα σε 30 ημέρες από την έκδοση των μηνιαίων λογαριασμών που θα του απέστελνα.\r");
                sb.Append("\tΗ παραπάνω αναφερόμενη σύμβαση συμφωνήσαμε να διέπεται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», τους οποίους ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε ο καθού κατά την υπογραφή της, καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους επίσης ο καθού ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε.\r");
                sb.Append("\tΜε την ίδια σύμβαση ρητά συμφωνήσαμε ότι πλήρη απόδειξη της οφειλής του καθού προς εμένα θα αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνται στα νόμιμα εμπορικά βιβλία μου. Ειδικά, επίσης, συμφωνήσαμε ότι θα δικαιούμαι να προβώ σε έγγραφη καταγγελία της σύμβασης αυτής σε περίπτωση παράβασης από τον καθού οποιασδήποτε από τις συμβατικές του υποχρεώσεις, μία εκ των οποίων ήταν και η εντός 30 ημερών από την έκδοσή τους, εμπρόθεσμη εξόφληση των λογαριασμών, που θα του απέστελνα. Σε περίπτωση μη εξόφλησής τους μέσα στην προθεσμία αυτή, ρητά συμφωνήσαμε ότι οι λογαριασμοί αυτοί θα καθίστανται ληξιπρόθεσμοι και άμεσα απαιτητοί, ο δε καθου θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας χωρίς άλλη όχληση. ");
                // AITHMA AMFHSVITHSH.
                sb.Append(" Ειδικά, τέλος, συμφωνήσαμε ότι η μη έγγραφη αμφισβήτηση από τον καθού των λογαριασμών αυτών εντός 45 ημερών από την έκδοσή τους, θα σήμαινε την πλήρη και ανεπιφύλακτη αποδοχή τους.");
                // ΠΡΟΣΘΕΣΕ ΛΟΓΑΡΙΣΜΟΥΣ ΕΔΩ.
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractMultiplePhones && true)
            {
                sb.Append("\tΜε την σύμβαση αυτή εγώ μεν η αιτούσα ανέλαβα την υποχρέωση να παρέχω στον καθού τηλεπικοινωνιακές υπηρεσίες, αυτός δε ανέλαβε την υποχρέωση να εξοφλεί εμένα,  βάσει των όρων της μεταξύ μας σύμβασης και ειδικότερα μέσα σε 30 ημέρες από την έκδοση των μηνιαίων λογαριασμών που θα του απέστελνα.\r");
                sb.Append("\tΗ παραπάνω αναφερόμενη σύμβαση συμφωνήσαμε να διέπεται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», τους οποίους ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε ο καθού κατά την υπογραφή της, καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους επίσης ο καθού ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε.\r");
                sb.Append("\tΜε την ίδια σύμβαση ρητά συμφωνήσαμε ότι πλήρη απόδειξη της οφειλής του καθού προς εμένα θα αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνται στα νόμιμα εμπορικά βιβλία μου. Ειδικά, επίσης, συμφωνήσαμε ότι θα δικαιούμαι να προβώ σε έγγραφη καταγγελία της σύμβασης αυτής σε περίπτωση παράβασης από τον καθού οποιασδήποτε από τις συμβατικές του υποχρεώσεις, μία εκ των οποίων ήταν και η εντός 30 ημερών από την έκδοσή τους, εμπρόθεσμη εξόφληση των λογαριασμών, που θα του απέστελνα. Σε περίπτωση μη εξόφλησής τους μέσα στην προθεσμία αυτή, ρητά συμφωνήσαμε ότι οι λογαριασμοί αυτοί θα καθίστανται ληξιπρόθεσμοι και άμεσα απαιτητοί, ο δε καθου θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας χωρίς άλλη όχληση. ");
                // AITHMA AMFHSVITHSH.
                sb.Append("Ειδικά, τέλος, συμφωνήσαμε ότι η μη έγγραφη αμφισβήτηση από τον καθού των λογαριασμών αυτών εντός 45 ημερών από την έκδοσή τους, θα σήμαινε την πλήρη και ανεπιφύλακτη αποδοχή τους.");

            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone && true)
            {
                sb.Append("\tΜε την σύμβαση αυτή εγώ μεν η αιτούσα ανέλαβα την υποχρέωση να παρέχω στην καθής τηλεπικοινωνιακές υπηρεσίες, αυτή δε ανέλαβε την υποχρέωση να εξοφλεί εμένα,  βάσει των όρων της μεταξύ μας σύμβασης και ειδικότερα μέσα σε 30 ημέρες από την έκδοση των μηνιαίων λογαριασμών που θα της απέστελνα.\r");
                sb.Append("\tΗ παραπάνω αναφερόμενη σύμβαση συμφωνήσαμε να διέπεται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», τους οποίους ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε η καθής κατά την υπογραφή της, καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους επίσης η καθής ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε.\r");
                sb.Append("\tΜε την ίδια σύμβαση ρητά συμφωνήσαμε ότι πλήρη απόδειξη της οφειλής της καθής προς εμένα θα αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνται στα νόμιμα εμπορικά βιβλία μου. Ειδικά, επίσης, συμφωνήσαμε ότι θα δικαιούμαι να προβώ σε έγγραφη καταγγελία της σύμβασης αυτής σε περίπτωση παράβασης από την καθής οποιασδήποτε από τις συμβατικές της υποχρεώσεις, μία εκ των οποίων ήταν και η εντός 30 ημερών από την έκδοσή τους, εμπρόθεσμη εξόφληση των λογαριασμών, που θα της απέστελνα. Σε περίπτωση μη εξόφλησής τους μέσα στην προθεσμία αυτή, ρητά συμφωνήσαμε ότι οι λογαριασμοί αυτοί θα καθίστανται ληξιπρόθεσμοι και άμεσα απαιτητοί, η δε καθής θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας χωρίς άλλη όχληση. ");
                // AITHMA AMFHSVITHSH.
                sb.Append("Ειδικά, τέλος, συμφωνήσαμε ότι η μη έγγραφη αμφισβήτηση από την καθής των λογαριασμών αυτών εντός 45 ημερών από την έκδοσή τους, θα σήμαινε την πλήρη και ανεπιφύλακτη αποδοχή τους.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones && true)
            {
                sb.Append("\tΜε την σύμβαση αυτή εγώ μεν η αιτούσα ανέλαβα την υποχρέωση να παρέχω στην καθής τηλεπικοινωνιακές υπηρεσίες, αυτή δε ανέλαβε την υποχρέωση να εξοφλεί εμένα,  βάσει των όρων της μεταξύ μας σύμβασης και ειδικότερα μέσα σε 30 ημέρες από την έκδοση των μηνιαίων λογαριασμών που θα της απέστελνα.\r");
                sb.Append("\tΗ παραπάνω αναφερόμενη σύμβαση συμφωνήσαμε να διέπεται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», τους οποίους ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε η καθής κατά την υπογραφή της, καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους επίσης η καθής ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε. \r");
                sb.Append("\tΜε την ίδια σύμβαση ρητά συμφωνήσαμε ότι πλήρη απόδειξη της οφειλής της καθής προς εμένα θα αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνται στα νόμιμα εμπορικά βιβλία μου. Ειδικά, επίσης, συμφωνήσαμε ότι θα δικαιούμαι να προβώ σε έγγραφη καταγγελία της σύμβασης αυτής σε περίπτωση παράβασης από την καθής οποιασδήποτε από τις συμβατικές της υποχρεώσεις, μία εκ των οποίων ήταν και η εντός 30 ημερών από την έκδοσή τους, εμπρόθεσμη εξόφληση των λογαριασμών, που θα της απέστελνα. Σε περίπτωση μη εξόφλησής τους μέσα στην προθεσμία αυτή, ρητά συμφωνήσαμε ότι οι λογαριασμοί αυτοί θα καθίστανται ληξιπρόθεσμοι και άμεσα απαιτητοί, η δε καθής θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας χωρίς άλλη όχληση. ");
                // AITHMA AMFHSVITHSH.
                sb.Append("Ειδικά, τέλος, συμφωνήσαμε ότι η μη έγγραφη αμφισβήτηση από την καθής των λογαριασμών αυτών εντός 45 ημερών από την έκδοσή τους, θα σήμαινε την πλήρη και ανεπιφύλακτη αποδοχή τους.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts && true)
            {
                sb.Append("\tΜε τις συμβάσεις αυτές εγώ μεν η αιτούσα ανέλαβα την υποχρέωση να παρέχω στον καθού τηλεπικοινωνιακές υπηρεσίες, αυτός δε ανέλαβε την υποχρέωση να εξοφλεί εμένα,  βάσει των όρων των μεταξύ μας συμβάσεων και ειδικότερα μέσα σε 30 ημέρες από την έκδοση των μηνιαίων λογαριασμών που θα του απέστελνα.\r");
                sb.Append("\tΟι παραπάνω αναφερόμενες συμβάσεις συμφωνήσαμε να διέπονται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», τους οποίους ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε ο καθού κατά την υπογραφή της, καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους επίσης ο καθού ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε. \r");
                // ΑΝ ΜΕ ΠΑΡΕΚΤΑΣΗ ΒΑΛΕ ΤΟ ΠΑΡΚΑΤΩ: and move the \r from the above to below:
                //sb.Append("Ειδικά συμφωνήσαμε ότι αρμόδια για την επίλυση κάθε τυχόν μεταξύ μας διαφοράς από τις συμβάσεις αυτές, θα ήταν τα δικαστήρια της Αθήνας.");
                sb.Append("\tΜε τις ίδιες συμβάσεις ρητά συμφωνήσαμε ότι πλήρη απόδειξη της οφειλής του καθού προς εμένα θα αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνται στα νόμιμα εμπορικά βιβλία μου. Ειδικά, επίσης, συμφωνήσαμε ότι θα δικαιούμαι να προβώ σε έγγραφη καταγγελία των συμβάσεων αυτών σε περίπτωση παράβασης από τον καθού οποιασδήποτε από τις συμβατικές του υποχρεώσεις, μία εκ των οποίων ήταν και η εντός 30 ημερών από την έκδοσή τους, εμπρόθεσμη εξόφληση των λογαριασμών, που θα του απέστελνα. Σε περίπτωση μη εξόφλησής τους μέσα στην προθεσμία αυτή, ρητά συμφωνήσαμε ότι οι λογαριασμοί αυτοί θα καθίστανται ληξιπρόθεσμοι και άμεσα απαιτητοί, ο δε καθου θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας χωρίς άλλη όχληση. ");
                // AITHMA AMFHSVITHSH.
                sb.Append("Ειδικά, τέλος, συμφωνήσαμε ότι η μη έγγραφη αμφισβήτηση από τον καθού των λογαριασμών αυτών εντός 45 ημερών από την έκδοσή τους, θα σήμαινε την πλήρη και ανεπιφύλακτη αποδοχή τους.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts && true)
            {
                sb.Append("\tΜε τις συμβάσεις αυτές εγώ μεν η αιτούσα ανέλαβα την υποχρέωση να παρέχω στην καθής τηλεπικοινωνιακές υπηρεσίες, αυτή δε ανέλαβε την υποχρέωση να εξοφλεί εμένα,  βάσει των όρων των μεταξύ μας συμβάσεων και ειδικότερα μέσα σε 30 ημέρες από την έκδοση των μηνιαίων λογαριασμών που θα της απέστελνα.\r");
                sb.Append("\tΟι παραπάνω αναφερόμενες συμβάσεις συμφωνήσαμε να διέπονται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», τους οποίους ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε η καθής κατά την υπογραφή της, καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους επίσης η καθής ενυπόγραφα και ανεπιφύλακτα αποδέχθηκε. \r");

                sb.Append("\tΜε τις ίδιες συμβάσεις ρητά συμφωνήσαμε ότι πλήρη απόδειξη της οφειλής της καθής προς εμένα θα αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνται στα νόμιμα εμπορικά βιβλία μου. Ειδικά, επίσης, συμφωνήσαμε ότι θα δικαιούμαι να προβώ σε έγγραφη καταγγελία των συμβάσεων αυτών σε περίπτωση παράβασης από την καθής οποιασδήποτε από τις συμβατικές της υποχρεώσεις, μία εκ των οποίων ήταν και η εντός 30 ημερών από την έκδοσή τους, εμπρόθεσμη εξόφληση των λογαριασμών, που θα της απέστελνα. Σε περίπτωση μη εξόφλησής τους μέσα στην προθεσμία αυτή, ρητά συμφωνήσαμε ότι οι λογαριασμοί αυτοί θα καθίστανται ληξιπρόθεσμοι και άμεσα απαιτητοί, η δε καθής θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας χωρίς άλλη όχληση. ");
                // AITHMA AMFHSVITHSH.
                sb.Append("Ειδικά, τέλος, συμφωνήσαμε ότι η μη έγγραφη αμφισβήτηση από την καθής των λογαριασμών αυτών εντός 45 ημερών από την έκδοσή τους, θα σήμαινε την πλήρη και ανεπιφύλακτη αποδοχή τους.");
            }

            return sb.ToString();
        }

        public static string AddBillsInformationSection(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // need improvment.
            // we need to check the lawyer also. and add the bills dates.
            if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractSinglePhone && true)
            {
                sb.Append($"ο καθού έκανε χρήση της ως άνω σύνδεσης και επειδή για την παροχή των υπηρεσιών μου αυτών εξέδωσα και του απέστειλα, στην από αυτόν δηλωθείσα στην ανωτέρω σύμβαση διεύθυνση, τους από {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} μέχρι {RTFGen.LastBill(person).IssueDate.ToShortDateString()} μηνιαίους λογαριασμούς - τιμολόγια, με ανάλυση των μηνιαίων πάγιων τελών και των παρασχεθεισών από εμένα υπηρεσιών.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractMultiplePhones && true)
            {
                sb.Append($"ο καθού έκανε χρήση των ως άνω συνδέσεων και επειδή για την παροχή των υπηρεσιών μου αυτών εξέδωσα και του απέστειλα, στην από αυτόν δηλωθείσα στην ανωτέρω σύμβαση διεύθυνση, τους από {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} μέχρι {RTFGen.LastBill(person).IssueDate.ToShortDateString()} μηνιαίους λογαριασμούς - τιμολόγια, με ανάλυση των μηνιαίων πάγιων τελών και των παρασχεθεισών από εμένα υπηρεσιών.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone  && true)
            {
                sb.Append($"η καθής έκανε χρήση της ως άνω σύνδεσης και επειδή για την παροχή των υπηρεσιών μου αυτών εξέδωσα και της απέστειλα, στην από αυτήν δηλωθείσα στην ανωτέρω σύμβαση διεύθυνση, τους από {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} μέχρι {RTFGen.LastBill(person).IssueDate.ToShortDateString()} μηνιαίους λογαριασμούς - τιμολόγια, με ανάλυση των μηνιαίων πάγιων τελών και των παρασχεθεισών από εμένα υπηρεσιών.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones && true)
            {
                sb.Append($"η καθής έκανε χρήση των ως άνω συνδέσεων και επειδή για την παροχή των υπηρεσιών μου αυτών εξέδωσα και της απέστειλα, στην από αυτήν δηλωθείσα στην ανωτέρω σύμβαση διεύθυνση, τους από {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} μέχρι {RTFGen.LastBill(person).IssueDate.ToShortDateString()} μηνιαίους λογαριασμούς - τιμολόγια, με ανάλυση των μηνιαίων πάγιων τελών και των παρασχεθεισών από εμένα υπηρεσιών.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts && true)
            {
                sb.Append($"ο καθού έκανε χρήση των ως άνω συνδέσεων και επειδή για την παροχή των υπηρεσιών μου αυτών εξέδωσα και του απέστειλα, στην από αυτόν δηλωθείσα στις ανωτέρω συμβάσεις διεύθυνση, τους από {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} μέχρι {RTFGen.LastBill(person).IssueDate.ToShortDateString()} μηνιαίους λογαριασμούς - τιμολόγια, με ανάλυση των μηνιαίων πάγιων τελών και των παρασχεθεισών από εμένα υπηρεσιών.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts ||  RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts && true)
            {
                sb.Append($"η καθής έκανε χρήση των ως άνω συνδέσεων και επειδή για την παροχή των υπηρεσιών μου αυτών εξέδωσα και της απέστειλα, στην από αυτήν δηλωθείσα στις ανωτέρω συμβάσεις διεύθυνση, τους από {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} μέχρι {RTFGen.LastBill(person).IssueDate.ToShortDateString()} μηνιαίους λογαριασμούς - τιμολόγια, με ανάλυση των μηνιαίων πάγιων τελών και των παρασχεθεισών από εμένα υπηρεσιών.");
            }


            return sb.ToString();
        }

        public static string AddDebtSectionPart1(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // need improvment.
            // we need to check the lawyer also. and add the bills dates.
            if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractSinglePhone)
            {
                sb.Append($"από τους ως άνω μηνιαίους λογαριασμούς – τιμολόγια που εκδόθηκαν στα πλαίσια της πιο πάνω σύμβασης και έχουν εξαχθεί από τα νόμιμα εμπορικά βιβλία μου, προκύπτει ότι ο καθού δεν μου έχει καταβάλει και μου οφείλει από τις {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} έως και τις {RTFGen.LastBill(person).IssueDate.ToShortDateString()} το συνολικό ");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractMultiplePhones)
            {
                sb.Append($"από τους ως άνω μηνιαίους λογαριασμούς – τιμολόγια που εκδόθηκαν στα πλαίσια της πιο πάνω σύμβασης και έχουν εξαχθεί από τα νόμιμα εμπορικά βιβλία μου, προκύπτει ότι ο καθού δεν μου έχει καταβάλει και μου οφείλει από τις {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} έως και τις {RTFGen.LastBill(person).IssueDate.ToShortDateString()} το συνολικό ");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone)
            {
                sb.Append($"από τους ως άνω μηνιαίους λογαριασμούς – τιμολόγια που εκδόθηκαν στα πλαίσια της πιο πάνω σύμβασης και έχουν εξαχθεί από τα νόμιμα εμπορικά βιβλία μου, προκύπτει ότι η καθής δεν μου έχει καταβάλει και μου οφείλει από τις {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} έως και τις {RTFGen.LastBill(person).IssueDate.ToShortDateString()} το συνολικό ");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones)
            {
                sb.Append($"από τους ως άνω μηνιαίους λογαριασμούς – τιμολόγια που εκδόθηκαν στα πλαίσια της πιο πάνω σύμβασης και έχουν εξαχθεί από τα νόμιμα εμπορικά βιβλία μου, προκύπτει ότι η καθής δεν μου έχει καταβάλει και μου οφείλει από τις {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} έως και τις {RTFGen.LastBill(person).IssueDate.ToShortDateString()} το συνολικό ");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts)
            {
                sb.Append($"από τους ως άνω μηνιαίους λογαριασμούς – τιμολόγια που εκδόθηκαν στα πλαίσια των πιο πάνω συμβάσεων και έχουν εξαχθεί από τα νόμιμα εμπορικά βιβλία μου, προκύπτει ότι ο καθού δεν μου έχει καταβάλει και μου οφείλει από τις {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} έως και τις {RTFGen.LastBill(person).IssueDate.ToShortDateString()} το συνολικό ");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts)
            {
                sb.Append($"από τους ως άνω μηνιαίους λογαριασμούς – τιμολόγια που εκδόθηκαν στα πλαίσια των πιο πάνω συμβάσεων και έχουν εξαχθεί από τα νόμιμα εμπορικά βιβλία μου, προκύπτει ότι η καθής δεν μου έχει καταβάλει και μου οφείλει από τις {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} έως και τις {RTFGen.LastBill(person).IssueDate.ToShortDateString()} το συνολικό ");
            }

            return sb.ToString();
        }

        public static string AddDebtSectionPart2(Person person)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"ποσό των ευρώ {person.orderforPayment.PrintDebt} € ({RTFGen.NumberToText(person.orderforPayment.Debt)})");
            return sb.ToString();
        }

        public static string AddDebtSectionPart3(Person person)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(", το οποίο έχει καταστεί ληξιπρόθεσμο και απαιτητό, δεδομένου ότι έχουν παρέλθει, και μάλιστα κατά πολύ, οι 30 ημέρες από την έκδοση των αντίστοιχων λογαριασμών.");
         
            return sb.ToString();
        }

        public static string AddBillIssueAndPaymentAgreementSection(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // need improvment.
            // we need to check the lawyer also. ΑΝ ΥΠΑΡΧΕΙ ΑΙΤΗΜΑ ΑΜΦΗΖΒΗΤΗΣΗ
            if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractSinglePhone && true)
            {
                sb.Append("μεταξύ εμού και του καθού έχει συμφωνηθεί δήλη ημέρα πληρωμής των λογαριασμών που εκδίδω, δεδομένου ότι, σύμφωνα με το άρθρο 8.3 των «Γενικών Όρων Παροχής Υπηρεσιών της COSMOTE», οι λογαριασμοί εκδίδονται κάθε μήνα και πρέπει να εξοφλούνται μέσα σε προθεσμία τριάντα (30) ημερών από την έκδοσή τους, σε περίπτωση δε που ο συνδρομητής δεν τους εξοφλήσει μέσα στη προθεσμία αυτή, θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας, χωρίς άλλη όχληση.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractMultiplePhones && true)
            {
                sb.Append("μεταξύ εμού και του καθού έχει συμφωνηθεί δήλη ημέρα πληρωμής των λογαριασμών που εκδίδω, δεδομένου ότι, σύμφωνα με το άρθρο 8.3 των «Γενικών Όρων Παροχής Υπηρεσιών της COSMOTE», οι λογαριασμοί εκδίδονται κάθε μήνα και πρέπει να εξοφλούνται μέσα σε προθεσμία τριάντα (30) ημερών από την έκδοσή τους, σε περίπτωση δε που ο συνδρομητής δεν τους εξοφλήσει μέσα στη προθεσμία αυτή, θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας, χωρίς άλλη όχληση.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone && true)
            {
                sb.Append("μεταξύ εμού και της καθής έχει συμφωνηθεί δήλη ημέρα πληρωμής των λογαριασμών που εκδίδω, δεδομένου ότι, σύμφωνα με το άρθρο 8.3 των «Γενικών Όρων Παροχής Υπηρεσιών της COSMOTE», οι λογαριασμοί εκδίδονται κάθε μήνα και πρέπει να εξοφλούνται μέσα σε προθεσμία τριάντα (30) ημερών από την έκδοσή τους, σε περίπτωση δε που ο συνδρομητής δεν τους εξοφλήσει μέσα στη προθεσμία αυτή, θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας, χωρίς άλλη όχληση.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones && true)
            {
                sb.Append("μεταξύ εμού και της καθής έχει συμφωνηθεί δήλη ημέρα πληρωμής των λογαριασμών που εκδίδω, δεδομένου ότι, σύμφωνα με το άρθρο 8.3 των «Γενικών Όρων Παροχής Υπηρεσιών της COSMOTE», οι λογαριασμοί εκδίδονται κάθε μήνα και πρέπει να εξοφλούνται μέσα σε προθεσμία τριάντα (30) ημερών από την έκδοσή τους, σε περίπτωση δε που ο συνδρομητής δεν τους εξοφλήσει μέσα στη προθεσμία αυτή, θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας, χωρίς άλλη όχληση.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts && true)
            {
                sb.Append("μεταξύ εμού και του καθού έχει συμφωνηθεί δήλη ημέρα πληρωμής των λογαριασμών που εκδίδω, δεδομένου ότι, σύμφωνα με το άρθρο 8.3 των «Γενικών Όρων Παροχής Υπηρεσιών της COSMOTE», οι λογαριασμοί εκδίδονται κάθε μήνα και πρέπει να εξοφλούνται μέσα σε προθεσμία τριάντα (30) ημερών από την έκδοσή τους, σε περίπτωση δε που ο συνδρομητής δεν τους εξοφλήσει μέσα στη προθεσμία αυτή, θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας, χωρίς άλλη όχληση.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts && true)
            {
                sb.Append("μεταξύ εμού και της καθής έχει συμφωνηθεί δήλη ημέρα πληρωμής των λογαριασμών που εκδίδω, δεδομένου ότι, σύμφωνα με το άρθρο 8.3 των «Γενικών Όρων Παροχής Υπηρεσιών της COSMOTE», οι λογαριασμοί εκδίδονται κάθε μήνα και πρέπει να εξοφλούνται μέσα σε προθεσμία τριάντα (30) ημερών από την έκδοσή τους, σε περίπτωση δε που ο συνδρομητής δεν τους εξοφλήσει μέσα στη προθεσμία αυτή, θα επιβαρύνεται με το νόμιμο τόκο υπερημερίας, χωρίς άλλη όχληση.");
            }

            return sb.ToString();
        }

        public static string AddPrivouseUnpaidDeptSection(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // need improvment.
            // we need to check the lawyer also. ΑΝ ΥΠΑΡΧΕΙ ΑΙΤΗΜΑ ΑΜΦΗΖΒΗΤΗΣΗ
            if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractSinglePhone && true)
            {
                sb.Append("με τους λογαριασμούς που απέστελνα στον καθού τους προηγούμενους μήνες, τον είχα και εγγράφως ειδοποιήσει για το προαναφερόμενο ανεξόφλητο υπόλοιπό του, το οποίο είχε καταστεί ληξιπρόθεσμο και απαιτητό και επειδή κατόπιν τούτου αναγκάσθηκα να καταγγείλω την ανωτέρω σύμβαση και να προβώ σε διακοπή της άνω αναφερόμενης σύνδεσης για το λόγο ότι αυτός ηρνείτο να συμμορφωθεί στις συμβατικές υποχρεώσεις του και δεν μου κατέβαλλε τα οφειλόμενα.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractMultiplePhones && true)
            {
                sb.Append("με τους λογαριασμούς που απέστελνα στον καθού τους προηγούμενους μήνες, τον είχα και εγγράφως ειδοποιήσει για το προαναφερόμενο ανεξόφλητο υπόλοιπό του, το οποίο είχε καταστεί ληξιπρόθεσμο και απαιτητό και επειδή κατόπιν τούτου αναγκάσθηκα να καταγγείλω την ανωτέρω σύμβαση και να προβώ σε διακοπή των άνω αναφερόμενων συνδέσεων για το λόγο ότι αυτός ηρνείτο να συμμορφωθεί στις συμβατικές υποχρεώσεις του και δεν μου κατέβαλλε τα οφειλόμενα.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone && true)
            {
                sb.Append("με τους λογαριασμούς που απέστελνα στην καθής τους προηγούμενους μήνες, την είχα και εγγράφως ειδοποιήσει για το προαναφερόμενο ανεξόφλητο υπόλοιπό της, το οποίο είχε καταστεί ληξιπρόθεσμο και απαιτητό και επειδή κατόπιν τούτου αναγκάσθηκα να καταγγείλω την ανωτέρω σύμβαση και να προβώ σε διακοπή της άνω αναφερόμενης σύνδεσης για το λόγο ότι αυτή ηρνείτο να συμμορφωθεί στις συμβατικές υποχρεώσεις της και δεν μου κατέβαλλε τα οφειλόμενα.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones && true)
            {
                sb.Append("με τους λογαριασμούς που απέστελνα στην καθής τους προηγούμενους μήνες, την είχα και εγγράφως ειδοποιήσει για το προαναφερόμενο ανεξόφλητο υπόλοιπό της, το οποίο είχε καταστεί ληξιπρόθεσμο και απαιτητό και επειδή κατόπιν τούτου αναγκάσθηκα να καταγγείλω την ανωτέρω σύμβαση και να προβώ σε διακοπή των άνω αναφερόμενων συνδέσεων για το λόγο ότι αυτή ηρνείτο να συμμορφωθεί στις συμβατικές υποχρεώσεις της και δεν μου κατέβαλλε τα οφειλόμενα.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts && true)
            {
                sb.Append("με τους λογαριασμούς που απέστελνα στον καθού τους προηγούμενους μήνες, τον είχα και εγγράφως ειδοποιήσει για το προαναφερόμενο ανεξόφλητο υπόλοιπό του, το οποίο είχε καταστεί ληξιπρόθεσμο και απαιτητό και επειδή κατόπιν τούτου αναγκάσθηκα να καταγγείλω τις ανωτέρω συμβάσεις και να προβώ σε διακοπή των άνω αναφερόμενων συνδέσεων για το λόγο ότι αυτός ηρνείτο να συμμορφωθεί στις συμβατικές υποχρεώσεις του και δεν μου κατέβαλλε τα οφειλόμενα.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts && true)
            {
                sb.Append("με τους λογαριασμούς που απέστελνα στην καθής τους προηγούμενους μήνες, την είχα και εγγράφως ειδοποιήσει για το προαναφερόμενο ανεξόφλητο υπόλοιπό της, το οποίο είχε καταστεί ληξιπρόθεσμο και απαιτητό και επειδή κατόπιν τούτου αναγκάσθηκα να καταγγείλω τις ανωτέρω συμβάσεις και να προβώ σε διακοπή των άνω αναφερόμενων συνδέσεων για το λόγο ότι αυτή ηρνείτο να συμμορφωθεί στις συμβατικές υποχρεώσεις της και δεν μου κατέβαλλε τα οφειλόμενα.");
            }

            return sb.ToString();
        }

        public static string AddServiceProvidedasPerContractSection(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // need improvment.
            // we need to check the lawyer also. ΑΝ ΥΠΑΡΧΕΙ ΑΙΤΗΜΑ ΑΜΦΗΖΒΗΤΗΣΗ
            if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractSinglePhone && true)
            {
                sb.Append("εγώ η αιτούσα, από την υπογραφή της άνω σύμβασης και την ενεργοποίηση της σχετικής σύνδεσης, παρείχα προς τον καθού ακώλυτη χρήση τηλεπικοινωνιακών υπηρεσιών, τηρώντας τους όρους της μεταξύ μας σύμβασης, αλλά και τις υποχρεώσεις μου, που πηγάζουν από τις σχετικές άδειες παροχής τηλεπικοινωνιακών υπηρεσιών.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractMultiplePhones && true)
            {
                sb.Append("εγώ η αιτούσα, από την υπογραφή της άνω σύμβασης και την ενεργοποίηση των σχετικών συνδέσεων, παρείχα προς τον καθού ακώλυτη χρήση τηλεπικοινωνιακών υπηρεσιών, τηρώντας τους όρους της μεταξύ μας σύμβασης, αλλά και τις υποχρεώσεις μου, που πηγάζουν από τις σχετικές άδειες παροχής τηλεπικοινωνιακών υπηρεσιών.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone && true)
            {
                sb.Append("εγώ η αιτούσα, από την υπογραφή της άνω σύμβασης και την ενεργοποίηση της σχετικής σύνδεσης, παρείχα προς την καθής ακώλυτη χρήση τηλεπικοινωνιακών υπηρεσιών, τηρώντας τους όρους της μεταξύ μας σύμβασης, αλλά και τις υποχρεώσεις μου, που πηγάζουν από τις σχετικές άδειες παροχής τηλεπικοινωνιακών υπηρεσιών.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones && true)
            {
                sb.Append("εγώ η αιτούσα, από την υπογραφή της άνω σύμβασης και την ενεργοποίηση των σχετικών συνδέσεων, παρείχα προς την καθής ακώλυτη χρήση τηλεπικοινωνιακών υπηρεσιών, τηρώντας τους όρους της μεταξύ μας σύμβασης, αλλά και τις υποχρεώσεις μου, που πηγάζουν από τις σχετικές άδειες παροχής τηλεπικοινωνιακών υπηρεσιών.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts && true)
            {
                sb.Append("εγώ η αιτούσα, από την υπογραφή των άνω συμβάσεων και την ενεργοποίηση των σχετικών συνδέσεων, παρείχα προς τον καθού ακώλυτη χρήση τηλεπικοινωνιακών υπηρεσιών, τηρώντας τους όρους των μεταξύ μας συμβάσεων, αλλά και τις υποχρεώσεις μου, που πηγάζουν από τις σχετικές άδειες παροχής τηλεπικοινωνιακών υπηρεσιών.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts && true)
            {
                sb.Append("εγώ η αιτούσα, από την υπογραφή των άνω συμβάσεων και την ενεργοποίηση των σχετικών συνδέσεων, παρείχα προς την καθής ακώλυτη χρήση τηλεπικοινωνιακών υπηρεσιών, τηρώντας τους όρους των μεταξύ μας συμβάσεων, αλλά και τις υποχρεώσεις μου, που πηγάζουν από τις σχετικές άδειες παροχής τηλεπικοινωνιακών υπηρεσιών.");
            }


            return sb.ToString();
        }

        public static string AddUnserdidntAppealedToBillsSection(Person person)
        {
            StringBuilder sb = new StringBuilder();

            // we need to check the lawyer also. ΑΝ ΥΠΑΡΧΕΙ ΑΙΤΗΜΑ ΑΜΦΗΖΒΗΤΗΣΗ
            if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractSinglePhone && true)
            {
                sb.Append("ο καθού αποδέχθηκε ανεπιφύλακτα τους παραπάνω λογαριασμούς – τιμολόγια, δεδομένου ότι δεν τους αμφισβήτησε εγγράφως εντός της ταχθείσας, σύμφωνα με το άρθρο 8.3 της μεταξύ μας σύμβασης, αποκλειστικής προθεσμίας 45 ημερών από την έκδοσή τους.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractMultiplePhones && true)
            {
                sb.Append("ο καθού αποδέχθηκε ανεπιφύλακτα τους παραπάνω λογαριασμούς – τιμολόγια, δεδομένου ότι δεν τους αμφισβήτησε εγγράφως εντός της ταχθείσας, σύμφωνα με το άρθρο 8.3 της μεταξύ μας σύμβασης, αποκλειστικής προθεσμίας 45 ημερών από την έκδοσή τους.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone && true)
            {
                sb.Append("η καθής αποδέχθηκε ανεπιφύλακτα τους παραπάνω λογαριασμούς – τιμολόγια, δεδομένου ότι δεν τους αμφισβήτησε εγγράφως εντός της ταχθείσας, σύμφωνα με το άρθρο 8.3 της μεταξύ μας σύμβασης, αποκλειστικής προθεσμίας 45 ημερών από την έκδοσή τους.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones && true)
            {
                sb.Append("η καθής αποδέχθηκε ανεπιφύλακτα τους παραπάνω λογαριασμούς – τιμολόγια, δεδομένου ότι δεν τους αμφισβήτησε εγγράφως εντός της ταχθείσας, σύμφωνα με το άρθρο 8.3 της μεταξύ μας σύμβασης, αποκλειστικής προθεσμίας 45 ημερών από την έκδοσή τους.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts && true)
            {
                sb.Append("ο καθού αποδέχθηκε ανεπιφύλακτα τους παραπάνω λογαριασμούς – τιμολόγια, δεδομένου ότι δεν τους αμφισβήτησε εγγράφως εντός της ταχθείσας, σύμφωνα με το άρθρο 8.3 των μεταξύ μας συμβάσεων, αποκλειστικής προθεσμίας 45 ημερών από την έκδοσή τους.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts && true)
            {
                sb.Append("η καθής αποδέχθηκε ανεπιφύλακτα τους παραπάνω λογαριασμούς – τιμολόγια, δεδομένου ότι δεν τους αμφισβήτησε εγγράφως εντός της ταχθείσας, σύμφωνα με το άρθρο 8.3 των μεταξύ μας συμβάσεων, αποκλειστικής προθεσμίας 45 ημερών από την έκδοσή τους.");
            }

            return sb.ToString();
        }

        public static string AddCompanyConditionChangedSection(Person person)
        {
            // we can move this to the template.
            StringBuilder sb = new StringBuilder();

            sb.Append("μετά από τροποποίηση του καταστατικού μου, η οποία νομίμως καταχωρίσθηκε στις 30-06-2021, με κωδικό αριθμό καταχώρισης 2573048, στο Γενικό Εμπορικό Μητρώο (Γ.Ε.ΜΗ.) του Εμπορικού και Βιομηχανικού Επιμελητηρίου Αθηνών, έχω καταστεί μονοπρόσωπη ανώνυμη εταιρεία και έχω μετονομασθεί από ");

            return sb.ToString();
        }

        public static string AddCorrespondingCourtBasedOnBillingAddressSection(Person person)
        {
            // we can move this back to the template.
            StringBuilder sb = new StringBuilder();

            sb.Append("το δικαστήριό Σας είναι καθ’ ύλην και κατά τόπον αρμόδιο για την έκδοση της διαταγής πληρωμής, με την οποία πρέπει να μου επιδικασθούν οι παραπάνω αναφερόμενοι λογαριασμοί, που έχουν καταστεί ληξιπρόθεσμοι και απαιτητοί.");

            return sb.ToString();
        }

        //   ΕΔΩ ΕΙΝΑΙ ΤΑ ΣΧΕΤΙΚΑ.
        public static string AddAppendices(Person person)
        {
            // fix this.
            StringBuilder sb = new();
            

            if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone)
            {
                sb.Append("\t1) Την ένδικη σύμβασή μου με την καθής, περί παροχής σε αυτήν της ένδικης σύνδεσης κινητής τηλεφωνίας στο δίκτυο της COSMOTE, καθώς και τους συνημμένους σε αυτήν «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE» και τους «Ειδικούς Όρους Εταιρικών Πελατών» (ΣΧΕΤΙΚΟ 1).\r");
                sb.Append("\t2) Όλα τα αντίγραφα των παραπάνω αναφερόμενων ένδικων λογαριασμών-τιμολογίων τελών κινητής τηλεφωνίας του ένδικου λογαριασμού της καθής, εξηγμένα από τα νόμιμα εμπορικά μου βιβλία, νομίμως επικυρωμένα (ΣΧΕΤΙΚΟ 2).\r");

            }
            else if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractSinglePhone)
            {
                sb.Append("\t1) Την ένδικη σύμβασή μου με τον καθού, περί παροχής σε αυτόν της ένδικης σύνδεσης κινητής τηλεφωνίας στο δίκτυο της COSMOTE, καθώς και τους συνημμένους σε αυτήν «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE» και τους «Ειδικούς Όρους Εταιρικών Πελατών» (ΣΧΕΤΙΚΟ 1).\r");
                sb.Append("\t2) Όλα τα αντίγραφα των παραπάνω αναφερόμενων ένδικων λογαριασμών-τιμολογίων τελών κινητής τηλεφωνίας του ένδικου λογαριασμού του καθού, εξηγμένα από τα νόμιμα εμπορικά μου βιβλία, νομίμως επικυρωμένα (ΣΧΕΤΙΚΟ 2).\r");
            }
            else if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractMultiplePhones)
            {
                sb.Append("\t1) Την ένδικη σύμβασή μου με τον καθού, περί παροχής σε αυτόν των ένδικων συνδέσεων κινητής τηλεφωνίας στο δίκτυο της COSMOTE, καθώς και τους συνημμένους σε αυτήν «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE» και τους «Ειδικούς Όρους Εταιρικών Πελατών» (ΣΧΕΤΙΚΟ 1).\r");
                sb.Append("\t2) Όλα τα αντίγραφα των παραπάνω αναφερόμενων ένδικων λογαριασμών-τιμολογίων τελών κινητής τηλεφωνίας του ένδικου λογαριασμού του καθού, εξηγμένα από τα νόμιμα εμπορικά μου βιβλία, νομίμως επικυρωμένα (ΣΧΕΤΙΚΟ 2).\r");
            }
            else if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones)
            {
                sb.Append("\t1) Την ένδικη σύμβασή μου με την καθής, περί παροχής σε αυτήν των ένδικων συνδέσεων κινητής τηλεφωνίας στο δίκτυο της COSMOTE, καθώς και τους συνημμένους σε αυτήν «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE» και τους «Ειδικούς Όρους Εταιρικών Πελατών» (ΣΧΕΤΙΚΟ 1).\r");
                sb.Append("\t2) Όλα τα αντίγραφα των παραπάνω αναφερόμενων ένδικων λογαριασμών-τιμολογίων τελών κινητής τηλεφωνίας του ένδικου λογαριασμού της καθής, εξηγμένα από τα νόμιμα εμπορικά μου βιβλία, νομίμως επικυρωμένα (ΣΧΕΤΙΚΟ 2).\r");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts)
            {
                sb.Append("\t1) Τις ένδικες συμβάσεις μου με τον καθού, περί παροχής σε αυτόν των ένδικων συνδέσεων κινητής τηλεφωνίας στο δίκτυο της COSMOTE, καθώς και τους συνημμένους σε αυτές «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE» και τους «Ειδικούς Όρους Εταιρικών Πελατών» (ΣΧΕΤΙΚΟ 1).\r");
                sb.Append("\t2) Όλα τα αντίγραφα των παραπάνω αναφερόμενων ένδικων λογαριασμών-τιμολογίων τελών κινητής τηλεφωνίας του ένδικου λογαριασμού του καθού, εξηγμένα από τα νόμιμα εμπορικά μου βιβλία, νομίμως επικυρωμένα (ΣΧΕΤΙΚΟ 2).\r");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts)
            {
                sb.Append("\t1) Τις ένδικες συμβάσεις μου με την καθής, περί παροχής σε αυτήν των ένδικων συνδέσεων κινητής τηλεφωνίας στο δίκτυο της COSMOTE, καθώς και τους συνημμένους σε αυτές «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE» και τους «Ειδικούς Όρους Εταιρικών Πελατών» (ΣΧΕΤΙΚΟ 1).\r");
                sb.Append("\t2) Όλα τα αντίγραφα των παραπάνω αναφερόμενων ένδικων λογαριασμών-τιμολογίων τελών κινητής τηλεφωνίας του ένδικου λογαριασμού της καθής, εξηγμένα από τα νόμιμα εμπορικά μου βιβλία, νομίμως επικυρωμένα (ΣΧΕΤΙΚΟ 2).\r");
            }
            // Add endline if there is appenidix 4 
            sb.Append("\t3) Το τελευταίο κωδικοποιημένο καταστατικό μου, το οποίο νομίμως καταχωρίσθηκε, στις 30-06-2021, με αριθμό καταχώρισης 2573048 στο Γενικό Εμπορικό Μητρώο (Γ.Ε.ΜΗ.) του Εμπορικού και Βιομηχανικού Επιμελητηρίου Αθηνών, όπως προκύπτει από την υπ’ αριθμ. πρωτ. 2396295/30-06-2021 ανακοίνωση (ΣΧΕΤΙΚΟ 3).");
            
            // If the Address has been changed.
            if (person.orderforPayment.AddressChange)
            {
                sb.Append($"\r\t4) Την υπ’ αριθμόν {person.orderforPayment.ChangeOfAddressApplication.ApplicationNumber.Trim()} και με ημερομηνία {person.orderforPayment.ChangeOfAddressApplication.ApplicationDate.ToShortDateString().Trim()} αίτηση αλλαγής διεύθυνσης του καθού (ΣΧΕΤΙΚΟ 4).");
            }

            // If the Court is in a region other than ATTICA.
            if(person.orderforPayment.CourtName.Region == CourtRegion.OTHERREGION)
            {
                sb.Append($"\r\tΕπειδή η αίτηση μου είναι νόμιμη (άρθρα. 623 επ. ΚΠολΔ), αποδεικνύεται με έγγραφα και επειδή έχει καταβληθεί και το ανάλογο τέλος δικαστικού ενσήμου με τα ποσοστά υπέρ ΤΝ, ΤΠΔΑ, ΤΑΧΔΙΚ ({person.orderforPayment.TAXDIK.Trim()}) και γραμμάτιο προείσπραξης Δ.Σ.Α. ({person.orderforPayment.DSA.Trim()}).");
            }

            return sb.ToString();

        }

        public static string AddPaymentRequestFromClientSection(Person person)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("\tΝα υποχρεωθεί ");
            
            if(person.Gender == gender.Male)
            {
                sb.Append("ο καθού, ");
            }
            else if(person.Gender == gender.Female || person.Gender == gender.Company)
            {
                sb.Append("η καθής, ");
            }

            sb.Append("με διαταγή προς πληρωμή που θα εκδώσετε εις βάρος ");

            if (person.Gender == gender.Male)
            {
                sb.Append("του, ");
            }
            else if (person.Gender == gender.Female || person.Gender == gender.Company)
            {
                sb.Append("της, ");
            }

            sb.Append("να μου καταβάλει το ποσό των ");

            return sb.ToString();

        }

        public static string AddAmountOfPaymentRequestedSection(Person person)
        {
            StringBuilder sb = new StringBuilder();

            // we need to check the lawyer also. ΑΝ ΥΠΑΡΧΕΙ ΑΙΤΗΜΑ ΑΜΦΗΖΒΗΤΗΣΗ
            sb.Append($"ευρώ {person.orderforPayment.PrintDebt} € ({RTFGen.NumberToText(person.orderforPayment.Debt)}),");

            return sb.ToString();
        }

        public static string AddRequestAmountAndExpencesFromCourt(Person person)
        {
            StringBuilder sb = new StringBuilder();

            if(person.Gender == gender.Male)
            {
                sb.Append("\tΝα καταδικασθεί ο καθού στη δικαστική μου δαπάνη, ");
            }
            else if(person.Gender == gender.Female || person.Gender == gender.Company)
            {
                sb.Append("\tΝα καταδικασθεί η καθής στη δικαστική μου δαπάνη, ");
            }

            if(person.orderforPayment.LawyerName.Gender == gender.Male)
            {
                sb.Append("καθώς και στην αμοιβή του πληρεξούσιου μου δικηγόρου.");
            }
            else if(person.orderforPayment.LawyerName.Gender == gender.Female)
            {
                sb.Append("καθώς και στην αμοιβή της πληρεξούσιας μου δικηγόρου.");
            }

            return sb.ToString();
        }

        public static string AppliedLawyer(Person person)
        {
            StringBuilder sb = new StringBuilder();

            if (person.orderforPayment.LawyerName.Gender == gender.Female)
            {
                sb.Append("Η καταθέσασα");
            }
            else if(person.orderforPayment.LawyerName.Gender == gender.Male)
            {
                sb.Append("Ο καταθέσας");
            }

            return sb.ToString();
        }
        // Η ΑΙΤΗΣΗ ΤΕΛΕΙΩΝΕΙ ΕΔΩ.....................................................................................................................................................................


        // Η ΔΙΑΤΑΓΗ ΞΕΚΕΙΝΑΕΙ ΕΔΩ.....................................................................................................................................................................
        public static string AddLawyerInfoOrderSection(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // we need to check the lawyer also. ΑΝ ΥΠΑΡΧΕΙ ΑΙΤΗΜΑ ΑΜΦΗΖΒΗΤΗΣΗ
            if(person.orderforPayment.LawyerName.Gender == gender.Male)
            {
                sb.Append($"νόμιμα  εκπροσωπούμενης, και η οποία υπογράφεται από τον πληρεξούσιο δικηγόρο της {person.orderforPayment.LawyerName.Print} (ΑΜ ΔΣΑ {person.orderforPayment.LawyerName.AMDSA.ToString().Trim()}).");
            }
            else if(person.orderforPayment.LawyerName.Gender == gender.Female)
            {
                sb.Append($"νόμιμα  εκπροσωπούμενης, και η οποία υπογράφεται από την πληρεξούσια δικηγόρο της {person.orderforPayment.LawyerName.Print} (ΑΜ ΔΣΑ {person.orderforPayment.LawyerName.AMDSA.ToString().Trim()}).");
            }

            return sb.ToString();
        }

        public static string AddIntroToNumbersAndContractsOrderSection(Person person)
        {
            StringBuilder sb = new StringBuilder();
            if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones)
            {
                sb.Append("Α) Την κάτωθι περιγραφόμενη σύμβαση");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts)
            {
                sb.Append("Α) Τις κάτωθι περιγραφόμενες συμβάσεις");
            }

            return sb.ToString();
        }

        public static string AddOrderSection(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // we need to check the lawyer also. ΑΝ ΥΠΑΡΧΕΙ ΑΙΤΗΜΑ ΑΜΦΗΖΒΗΤΗΣΗ
            // Change articles numbers based on order type.
            // and add the section if the court is in Athens.
            // this: "για κάθε διαφορά αρμόδια είχαν ορισθεί τα δικαστήρια των Αθηνών, ότι"
            if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractSinglePhone && true)
            {
                sb.Append("η οποία καταρτίσθηκε ανάμεσα στην αιτούσα και στον καθού από την οποία προκύπτει ότι η πρώτη παρείχε στον δεύτερο τηλεπικοινωνιακές υπηρεσίες, αυτός δε είχε αναλάβει να εξοφλεί την αιτούσα βάσει των όρων της μεταξύ τους σύμβασης. Από την ίδια σύμβαση προκύπτει ότι η παραπάνω αναφερόμενη σύμβαση είχε συμφωνηθεί να διέπεται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους ο καθού ενυπόγραφα και ανεπιφύλακτα είχε αποδεχθεί. Από την ίδια σύμβαση προκύπτει ότι πλήρη απόδειξη της οφειλής του καθού προς την αιτούσα είχε συμφωνηθεί να αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνταν στα νόμιμα εμπορικά βιβλία της αιτούσας, ότι είχε συμφωνηθεί, κατ’ άρθρο 8.3 της σύμβασης, ότι κάθε λογαριασμός – τιμολόγιο έπρεπε να εξοφλείται μέσα σε προθεσμία τριάντα (30) ημερών από την έκδοσή του, ήτοι κατ’ άρθρο 341 ΑΚ, σε δήλη ημέρα, καταστάντος τοιουτοτρόπως του καθού υπερήμερου με μόνη τη παρέλευση της προθεσμίας αυτής, καθώς και ότι η αιτούσα είχε συμφωνηθεί να δικαιούται να προβεί σε έγγραφη καταγγελία της σύμβασης αυτής σε περίπτωση παράβασης από τον καθού οποιασδήποτε από τις συμβατικές του υποχρεώσεις, κατ’ άρθρο 13.1α των «Γενικών Όρων Παροχής Υπηρεσιών της COSMOTE», μία εκ των οποίων ήταν και κατ’ άρθρο 8.3, εντός 30 ημερών από την έκδοσή τους εμπρόθεσμη εξόφληση των λογαριασμών, που αυτή θα του απέστελνε. ");
                // AITHMA AMFHSVITHSH.
                sb.Append("Τέλος, από τη σύμβαση προκύπτει ότι ο καθού είχε αποδεχθεί ανεπιφύλακτα τους παραπάνω λογαριασμούς – τιμολόγια, δεδομένου ότι δεν τους είχε αμφισβητήσει εγγράφως εντός της ταχθείσας, σύμφωνα με το άρθρο 8.3 της σύμβασης, αποκλειστικής προθεσμίας 45 ημερών από την έκδοσή τους.");
            }
            if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractMultiplePhones && true)
            {
                sb.Append("η οποία καταρτίσθηκε ανάμεσα στην αιτούσα και στον καθού από την οποία προκύπτει ότι η πρώτη παρείχε στον δεύτερο τηλεπικοινωνιακές υπηρεσίες, αυτός δε είχε αναλάβει να εξοφλεί την αιτούσα βάσει των όρων της μεταξύ τους σύμβασης. Από την ίδια σύμβαση προκύπτει ότι η παραπάνω αναφερόμενη σύμβαση είχε συμφωνηθεί να διέπεται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους ο καθού ενυπόγραφα και ανεπιφύλακτα είχε αποδεχθεί. Από την ίδια σύμβαση προκύπτει ότι πλήρη απόδειξη της οφειλής του καθού προς την αιτούσα είχε συμφωνηθεί να αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνταν στα νόμιμα εμπορικά βιβλία της αιτούσας, ότι είχε συμφωνηθεί, κατ’ άρθρο 8.3 της σύμβασης, ότι κάθε λογαριασμός – τιμολόγιο έπρεπε να εξοφλείται μέσα σε προθεσμία τριάντα (30) ημερών από την έκδοσή του, ήτοι κατ’ άρθρο 341 ΑΚ, σε δήλη ημέρα, καταστάντος τοιουτοτρόπως του καθού υπερήμερου με μόνη τη παρέλευση της προθεσμίας αυτής, καθώς και ότι η αιτούσα είχε συμφωνηθεί να δικαιούται να προβεί σε έγγραφη καταγγελία της σύμβασης αυτής σε περίπτωση παράβασης από τον καθού οποιασδήποτε από τις συμβατικές του υποχρεώσεις, κατ’ άρθρο 13.1α των «Γενικών Όρων Παροχής Υπηρεσιών της COSMOTE», μία εκ των οποίων ήταν και κατ’ άρθρο 8.3, εντός 30 ημερών από την έκδοσή τους εμπρόθεσμη εξόφληση των λογαριασμών, που αυτή θα του απέστελνε. ");
                // AITHMA AMFHSVITHSH
                sb.Append("Τέλος, από τη σύμβαση προκύπτει ότι ο καθού είχε αποδεχθεί ανεπιφύλακτα τους παραπάνω λογαριασμούς – τιμολόγια, δεδομένου ότι δεν τους είχε αμφισβητήσει εγγράφως εντός της ταχθείσας, σύμφωνα με το άρθρο 8.3 της σύμβασης, αποκλειστικής προθεσμίας 45 ημερών από την έκδοσή τους.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone && true)
            {
                sb.Append("η οποία καταρτίσθηκε ανάμεσα στην αιτούσα και στην καθής από την οποία προκύπτει ότι η πρώτη παρείχε στην δεύτερη τηλεπικοινωνιακές υπηρεσίες, αυτή δε είχε αναλάβει να εξοφλεί την αιτούσα βάσει των όρων της μεταξύ τους σύμβασης. Από την ίδια σύμβαση προκύπτει ότι η παραπάνω αναφερόμενη σύμβαση είχε συμφωνηθεί να διέπεται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους η καθής ενυπόγραφα και ανεπιφύλακτα είχε αποδεχθεί. Από την ίδια σύμβαση προκύπτει ότι πλήρη απόδειξη της οφειλής της καθής προς την αιτούσα είχε συμφωνηθεί να αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνταν στα νόμιμα εμπορικά βιβλία της αιτούσας, ότι είχε συμφωνηθεί, κατ’ άρθρο 8.3 της σύμβασης, ότι κάθε λογαριασμός – τιμολόγιο έπρεπε να εξοφλείται μέσα σε προθεσμία τριάντα (30) ημερών από την έκδοσή του, ήτοι κατ’ άρθρο 341 ΑΚ, σε δήλη ημέρα, καταστάντος τοιουτοτρόπως της καθής υπερήμερης με μόνη τη παρέλευση της προθεσμίας αυτής, καθώς και ότι η αιτούσα είχε συμφωνηθεί να δικαιούται να προβεί σε έγγραφη καταγγελία της σύμβασης αυτής σε περίπτωση παράβασης από την καθής οποιασδήποτε από τις συμβατικές της υποχρεώσεις, κατ’ άρθρο 13.1α των «Γενικών Όρων Παροχής Υπηρεσιών της COSMOTE», μία εκ των οποίων ήταν και κατ’ άρθρο 8.3, εντός 30 ημερών από την έκδοσή τους εμπρόθεσμη εξόφληση των λογαριασμών, που αυτή θα της απέστελνε. ");
                // AITHMA AMFHSVITHSH
                sb.Append("Τέλος, από τη σύμβαση προκύπτει ότι η καθής είχε αποδεχθεί ανεπιφύλακτα τους παραπάνω λογαριασμούς – τιμολόγια, δεδομένου ότι δεν τους είχε αμφισβητήσει εγγράφως εντός της ταχθείσας, σύμφωνα με το άρθρο 8.3 της σύμβασης, αποκλειστικής προθεσμίας 45 ημερών από την έκδοσή τους.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones && true)
            {
                sb.Append("η οποία καταρτίσθηκε ανάμεσα στην αιτούσα και στην καθής από την οποία προκύπτει ότι η πρώτη παρείχε στην δεύτερη τηλεπικοινωνιακές υπηρεσίες, αυτή δε είχε αναλάβει να εξοφλεί την αιτούσα βάσει των όρων της μεταξύ τους σύμβασης. Από την ίδια σύμβαση προκύπτει ότι η παραπάνω αναφερόμενη σύμβαση είχε συμφωνηθεί να διέπεται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους η καθής ενυπόγραφα και ανεπιφύλακτα είχε αποδεχθεί. Από την ίδια σύμβαση προκύπτει ότι πλήρη απόδειξη της οφειλής της καθής προς την αιτούσα είχε συμφωνηθεί να αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνταν στα νόμιμα εμπορικά βιβλία της αιτούσας, ότι είχε συμφωνηθεί, κατ’ άρθρο 8.3 της σύμβασης, ότι κάθε λογαριασμός – τιμολόγιο έπρεπε να εξοφλείται μέσα σε προθεσμία τριάντα (30) ημερών από την έκδοσή του, ήτοι κατ’ άρθρο 341 ΑΚ, σε δήλη ημέρα, καταστάντος τοιουτοτρόπως της καθής υπερήμερης με μόνη τη παρέλευση της προθεσμίας αυτής, καθώς και ότι η αιτούσα είχε συμφωνηθεί να δικαιούται να προβεί σε έγγραφη καταγγελία της σύμβασης αυτής σε περίπτωση παράβασης από την καθής οποιασδήποτε από τις συμβατικές της υποχρεώσεις, κατ’ άρθρο 13.1α των «Γενικών Όρων Παροχής Υπηρεσιών της COSMOTE», μία εκ των οποίων ήταν και κατ’ άρθρο 8.3, εντός 30 ημερών από την έκδοσή τους εμπρόθεσμη εξόφληση των λογαριασμών, που αυτή θα της απέστελνε. ");
                // AITHMA AMFHSVITHSH
                sb.Append("Τέλος, από τη σύμβαση προκύπτει ότι η καθής είχε αποδεχθεί ανεπιφύλακτα τους παραπάνω λογαριασμούς – τιμολόγια, δεδομένου ότι δεν τους είχε αμφισβητήσει εγγράφως εντός της ταχθείσας, σύμφωνα με το άρθρο 8.3 της σύμβασης, αποκλειστικής προθεσμίας 45 ημερών από την έκδοσή τους.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts && true)
            {
                sb.Append("οι οποίες καταρτίσθηκαν ανάμεσα στην αιτούσα και στον καθού από τις οποίες προκύπτει ότι η πρώτη παρείχε στον δεύτερο τηλεπικοινωνιακές υπηρεσίες, αυτός δε είχε αναλάβει να εξοφλεί την αιτούσα βάσει των όρων των μεταξύ τους συμβάσεων. Από τις ίδιες συμβάσεις προκύπτει ότι οι παραπάνω αναφερόμενες συμβάσεις είχε συμφωνηθεί να διέπονται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους ο καθού ενυπόγραφα και ανεπιφύλακτα είχε αποδεχθεί. Από τις ίδιες συμβάσεις προκύπτει ότι πλήρη απόδειξη της οφειλής του καθού προς την αιτούσα είχε συμφωνηθεί να αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνταν στα νόμιμα εμπορικά βιβλία της αιτούσας, ότι είχε συμφωνηθεί, κατ’ άρθρο 8.3 της σύμβασης, ότι κάθε λογαριασμός – τιμολόγιο έπρεπε να εξοφλείται μέσα σε προθεσμία τριάντα (30) ημερών από την έκδοσή του, ήτοι κατ’ άρθρο 341 ΑΚ, σε δήλη ημέρα, καταστάντος τοιουτοτρόπως του καθού υπερήμερου με μόνη τη παρέλευση της προθεσμίας αυτής, καθώς και ότι η αιτούσα είχε συμφωνηθεί να δικαιούται να προβεί σε έγγραφη καταγγελία των συμβάσεων αυτών σε περίπτωση παράβασης από τον καθού οποιασδήποτε από τις συμβατικές του υποχρεώσεις, κατ’ άρθρο 12.1 των «Γενικών Όρων Παροχής Υπηρεσιών της COSMOTE», μία εκ των οποίων ήταν και κατ’ άρθρο 7.4, εντός 30 ημερών από την έκδοσή τους εμπρόθεσμη εξόφληση των λογαριασμών, που αυτή θα του απέστελνε. ");
                // AITHMA AMFHSVITHSH
                sb.Append("Τέλος, από τη σύμβαση προκύπτει ότι ο καθού είχε αποδεχθεί ανεπιφύλακτα τους παραπάνω λογαριασμούς – τιμολόγια, δεδομένου ότι δεν τους είχε αμφισβητήσει εγγράφως εντός της ταχθείσας, σύμφωνα με το άρθρο 8.3 της σύμβασης, αποκλειστικής προθεσμίας 45 ημερών από την έκδοσή τους.");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts && true)
            {
                sb.Append("οι οποίες καταρτίσθηκαν ανάμεσα στην αιτούσα και στην καθής από τις οποίες προκύπτει ότι η πρώτη παρείχε στην δεύτερη τηλεπικοινωνιακές υπηρεσίες, αυτή δε είχε αναλάβει να εξοφλεί την αιτούσα βάσει των όρων των μεταξύ τους συμβάσεων. Από τις ίδιες συμβάσεις προκύπτει ότι οι παραπάνω αναφερόμενες συμβάσεις είχε συμφωνηθεί να διέπονται από τους ισχύοντες «Γενικούς Όρους Παροχής Υπηρεσιών COSMOTE», καθώς και από τους «Ειδικούς Όρους Εταιρικών Πελατών», τους οποίους η καθής ενυπόγραφα και ανεπιφύλακτα είχε αποδεχθεί. Από τις ίδιες συμβάσεις προκύπτει ότι πλήρη απόδειξη της οφειλής της καθής προς την αιτούσα είχε συμφωνηθεί να αποτελούν τα αποσπάσματα του ένδικου λογαριασμού, που τηρούνταν στα νόμιμα εμπορικά βιβλία της αιτούσας, ότι είχε συμφωνηθεί, κατ’ άρθρο 8.3 της σύμβασης, ότι κάθε λογαριασμός – τιμολόγιο έπρεπε να εξοφλείται μέσα σε προθεσμία τριάντα (30) ημερών από την έκδοσή του, ήτοι κατ’ άρθρο 341 ΑΚ, σε δήλη ημέρα, καταστάντος τοιουτοτρόπως της καθής υπερήμερης με μόνη τη παρέλευση της προθεσμίας αυτής, καθώς και ότι η αιτούσα είχε συμφωνηθεί να δικαιούται να προβεί σε έγγραφη καταγγελία των συμβάσεων αυτών σε περίπτωση παράβασης από την καθής οποιασδήποτε από τις συμβατικές της υποχρεώσεις, κατ’ άρθρο 13.1α των «Γενικών Όρων Παροχής Υπηρεσιών της COSMOTE», μία εκ των οποίων ήταν και κατ’ άρθρο 8.3, εντός 30 ημερών από την έκδοσή τους εμπρόθεσμη εξόφληση των λογαριασμών, που αυτή θα της απέστελνε. ");
                // AITHMA AMFHSVITHSH
                sb.Append("Τέλος, από τη σύμβαση προκύπτει ότι η καθής είχε αποδεχθεί ανεπιφύλακτα τους παραπάνω λογαριασμούς – τιμολόγια, δεδομένου ότι δεν τους είχε αμφισβητήσει εγγράφως εντός της ταχθείσας, σύμφωνα με το άρθρο 8.3 της σύμβασης, αποκλειστικής προθεσμίας 45 ημερών από την έκδοσή τους.");
            }

            return sb.ToString();
        }

        public static string AddSeconPartOfOrderSectionPart1(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // we need to check the lawyer also. ΑΝ ΥΠΑΡΧΕΙ ΑΙΤΗΜΑ ΑΜΦΗΖΒΗΤΗΣΗ
            // CHANGE THIS TO ADD BILS ALSO.
            if (RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractSinglePhone && true)
            {
                sb.Append($"Β) Τους ένδικους λογαριασμούς - τιμολόγια τελών κινητής τηλεφωνίας της ένδικης σύνδεσης του καθού, που τηρήθηκαν στα πλαίσια της πιο πάνω σύμβασης εξηγμένα από τα νόμιμα εμπορικά βιβλία της αιτούσας, νομίμως επικυρωμένα, από τα οποία προκύπτει αφενός μεν ότι το υφιστάμενο στις {RTFGen.LastBill(person).IssueDate.ToShortDateString()} κατάλοιπο του λογαριασμού σε βάρος του καθού, για το χρονικό διάστημα από {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} μέχρι {RTFGen.LastBill(person).IssueDate.ToShortDateString()}, ανερχόταν στο ");
            }
            if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleSingleContractMultiplePhones && true)
            {
                sb.Append($"Β) Τους ένδικους λογαριασμούς - τιμολόγια τελών κινητής τηλεφωνίας των ένδικων συνδέσεων του καθού, που τηρήθηκαν στα πλαίσια της πιο πάνω σύμβασης εξηγμένα από τα νόμιμα εμπορικά βιβλία της αιτούσας, νομίμως επικυρωμένα, από τα οποία προκύπτει αφενός μεν ότι το υφιστάμενο στις {RTFGen.LastBill(person).IssueDate.ToShortDateString()} κατάλοιπο του λογαριασμού σε βάρος του καθού, για το χρονικό διάστημα από {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} μέχρι {RTFGen.LastBill(person).IssueDate.ToShortDateString()}, ανερχόταν στο ");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractSinglePhone || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractSinglePhone && true)
            {
                sb.Append($"Β) Τους ένδικους λογαριασμούς - τιμολόγια τελών κινητής τηλεφωνίας της ένδικης σύνδεσης της καθής, που τηρήθηκαν στα πλαίσια της πιο πάνω σύμβασης εξηγμένα από τα νόμιμα εμπορικά βιβλία της αιτούσας, νομίμως επικυρωμένα, από τα οποία προκύπτει αφενός μεν ότι το υφιστάμενο στις {RTFGen.LastBill(person).IssueDate.ToShortDateString()} κατάλοιπο του λογαριασμού σε βάρος της καθής, για το χρονικό διάστημα από {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} μέχρι {RTFGen.LastBill(person).IssueDate.ToShortDateString()}, ανερχόταν στο ");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleSingleContractMultiplePhones || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanySingleContractMultiplePhones && true)
            {
                sb.Append($"Β) Τους ένδικους λογαριασμούς - τιμολόγια τελών κινητής τηλεφωνίας των ένδικων συνδέσεων της καθής, που τηρήθηκαν στα πλαίσια της πιο πάνω σύμβασης εξηγμένα από τα νόμιμα εμπορικά βιβλία της αιτούσας, νομίμως επικυρωμένα, από τα οποία προκύπτει αφενός μεν ότι το υφιστάμενο στις {RTFGen.LastBill(person).IssueDate.ToShortDateString()} κατάλοιπο του λογαριασμού σε βάρος της καθής, για το χρονικό διάστημα από {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} μέχρι {RTFGen.LastBill(person).IssueDate.ToShortDateString()}, ανερχόταν στο ");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.MaleMultipleContracts && true)
            {
                sb.Append($"Β) Τους ένδικους λογαριασμούς - τιμολόγια τελών κινητής τηλεφωνίας των ένδικων συνδέσεων του καθού, που τηρήθηκαν στα πλαίσια των πιο πάνω συμβάσεων εξηγμένα από τα νόμιμα εμπορικά βιβλία της αιτούσας, νομίμως επικυρωμένα, από τα οποία προκύπτει αφενός μεν ότι το υφιστάμενο στις {RTFGen.LastBill(person).IssueDate.ToShortDateString()} κατάλοιπο του λογαριασμού σε βάρος του καθού, για το χρονικό διάστημα από {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} μέχρι {RTFGen.LastBill(person).IssueDate.ToShortDateString()}, ανερχόταν στο");
            }
            else if(RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.FemaleMultipleContracts || RTFOptions.SetRTFOptions(person) == TypeOFOrderForPayment.CompanyMultipleContracts && true)
            {
                sb.Append($"Β) Τους ένδικους λογαριασμούς - τιμολόγια τελών κινητής τηλεφωνίας των ένδικων συνδέσεων της καθής, που τηρήθηκαν στα πλαίσια των πιο πάνω συμβάσεων εξηγμένα από τα νόμιμα εμπορικά βιβλία της αιτούσας, νομίμως επικυρωμένα, από τα οποία προκύπτει αφενός μεν ότι το υφιστάμενο στις {RTFGen.LastBill(person).IssueDate.ToShortDateString()} κατάλοιπο του λογαριασμού σε βάρος της καθής, για το χρονικό διάστημα από {RTFGen.FirstBill(person).IssueDate.ToShortDateString()} μέχρι {RTFGen.LastBill(person).IssueDate.ToShortDateString()}, ανερχόταν στο ");
            }


            return sb.ToString();
        }

        public static string AddSecondPartOfOrderSectionPart2Amount(Person person)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"ποσό των ευρώ {person.orderforPayment.PrintDebt}");
            return sb.ToString();
        }

        public static string AddThirdPartOfOrderFirstPart(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // we can move this to the template.

            sb.Append("Γ) Το τελευταίο κωδικοποιημένο καταστατικό της αιτούσας, το οποίο νομίμως καταχωρίσθηκε, στις 30-06-2021, με αριθμό καταχώρισης 2573048 στο Γενικό Εμπορικό Μητρώο (Γ.Ε.ΜΗ.) του Εμπορικού και Βιομηχανικού Επιμελητηρίου Αθηνών, όπως προκύπτει από την υπ’ αριθμ. πρωτ. 2396295/30-06-2021 ανακοίνωση, από το οποίο προκύπτει ότι η αιτούσα έχει καταστεί μονοπρόσωπη ανώνυμη εταιρεία και έχει μετονομασθεί από");

            return sb.ToString();

        }

        public static string AddForthPartOfOrderFirstPart(Person person)
        {
            StringBuilder sb = new StringBuilder();
            // we can move this to the template.

            if (person.orderforPayment.AddressChange)
            {
                sb.Append($"Δ) Την υπ’ αριθμόν {person.orderforPayment.ChangeOfAddressApplication.ApplicationNumber.Trim()} και με ημερομηνία {person.orderforPayment.ChangeOfAddressApplication.ApplicationDate.ToShortDateString().Trim()} αίτηση αλλαγής διεύθυνσης του καθού (ΣΧΕΤΙΚΟ 4).\r");
                sb.Append("\tΕπειδή όλα τα παραπάνω αναφερόμενα ποσά έχουν καταστεί ληξιπρόθεσμα και απαιτητά, δεδομένου ότι δεν έχουν εξοφληθεί αν και έχουν παρέλθει 30 ημέρες από την έκδοση των ένδικων λογαριασμών. ");
            }
            else
            {
                sb.Append("\tΕπειδή όλα τα παραπάνω αναφερόμενα ποσά έχουν καταστεί ληξιπρόθεσμα και απαιτητά, δεδομένου ότι δεν έχουν εξοφληθεί αν και έχουν παρέλθει 30 ημέρες από την έκδοση των ένδικων λογαριασμών. ");
            }

            return sb.ToString();

        }

        public static string AddCourtStamps(Person person)
        {
            // Add ΓΡΑΜΜΑΤΕΙΑ ΚΑΙ ΕΝΣΥΜΑ ΕΔΩ.
            StringBuilder sb = new StringBuilder();
            sb.Append($"\tΕπειδή η αίτηση είναι νόμιμη (άρθρα. 623 επ. ΚΠολΔ), αποδεικνύεται με έγγραφα και εισάγεται στο καθ’ ύλην και κατά τόπο αρμόδιο δικαστήριο και επειδή πρέπει, συνεπώς, να γίνει δεκτή και κατ’ ουσίαν, όπως ορίζεται στο διατακτικό, δεδομένου ότι έχει καταβληθεί και το ανάλογο τέλος δικαστικού ενσήμου με τα ποσοστά υπέρ ΤΝ, ΤΠΔΑ, ΤΑΧΔΙΚ ({person.orderforPayment.TAXDIK.Trim()}) και γραμμάτιο προείσπραξης Δ.Σ.Α. ({person.orderforPayment.DSA.Trim()}).");
            return sb.ToString();
        }

        public static string AddTheCourtOrderThatSection(Person person)
        {
            StringBuilder sb = new StringBuilder();

            if(person.Gender == gender.Male)
            {
                sb.Append("\tΔιατάσσει τον καθού η αίτηση να καταβάλει στην αιτούσα το ");
            }
            else if(person.Gender == gender.Female || person.Gender == gender.Company)
            {
                sb.Append("\tΔιατάσσει την καθής η αίτηση να καταβάλει στην αιτούσα το ");
            }

            return sb.ToString();

        }

        public static string AddAppealDeadLineSection(Person person)
        {
            StringBuilder sb = new StringBuilder();

            if (person.Gender == gender.Male)
            {
                sb.Append("\tΣημειώνεται ότι ο καθού η αίτηση έχει δικαίωμα να ασκήσει ανακοπή κατά της διαταγής αυτής μέσα σε προθεσμία (15) δέκα πέντε εργασίμων ημερών από την επίδοσή της σε αυτόν.");
            }
            else if (person.Gender == gender.Female || person.Gender == gender.Company)
            {
                sb.Append("\tΣημειώνεται ότι η καθής η αίτηση έχει δικαίωμα να ασκήσει ανακοπή κατά της διαταγής αυτής μέσα σε προθεσμία (15) δέκα πέντε εργασίμων ημερών από την επίδοσή της σε αυτήν.");
            }

            return sb.ToString();

        }

        public static string AddAndAllThePublicInstrumntsSection(Person person)
        {
            StringBuilder sb = new StringBuilder();
            if(person.orderforPayment.CourtName.Region == CourtRegion.ATTICA)
            {
                sb.Append("\tΔίνεται εντολή προς κάθε δικαστικό επιμελητή να εκτελέσει την παραπάνω απόφαση όταν του ζητηθεί και προς τους εισαγγελείς να ενεργήσουν ό,τι εμπίπτει στην αρμοδιότητά τους και προς όλους τους διοικητές και τους άλλους αξιωματικούς της δημόσιας δύναμης να βοηθήσουν στην εκτέλεση της διαταγής, όταν αυτό τους ζητηθεί νόμιμα.");
            }
            else if(person.orderforPayment.CourtName.Region == CourtRegion.OTHERREGION)
            {
                sb.Append("\tΔίνεται εντολή προς κάθε δικαστικό επιμελητή να εκτελέσει την παραπάνω απόφαση όταν του ζητηθεί και προς τους εισαγγελείς να ενεργήσουν ό,τι εμπίπτει στην αρμοδιότητά τους και προς όλους τους διοικητές και τους άλλους αξιωματικούς της δημόσιας δύναμης και όλα τα διοικητικά και δημόσια όργανα να βοηθήσουν στην εκτέλεση της διαταγής, όταν αυτό τους ζητηθεί νόμιμα.");
            }

            return sb.ToString();
        }

        // Η ΔΙΑΤΑΓΗ ΤΕΛΕΙΩΝΕΙ ΕΔΩ.....................................................................................................................................................................

        public static string ClientContractsandConnectoin(Person person)
        {
            StringBuilder sb = new();

            foreach (var v in person.orderforPayment.contracts)
            {
                sb.Append("\tτην ");
                sb.Append(v.Date.ToShortDateString().Trim());
                sb.Append(" η υπ' αριθμόν ");
                sb.Append(v.Number.Trim());
                // Change this if sim number and add type of contract.
                sb.Append(", για τη σύνδεση με αριθμό ");
                sb.Append(v.PhoneNumber.Trim());
                // removed Elaxistis if the durration is more than 24 months.
                if(v.Durration == "αορίστου χρόνου")
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
                    sb.Append(".");
                }
                else
                {
                    sb.Append(",\r");
                }

            }
            return sb.ToString();
        }

        public static string PlaceOfIssuingTheOrder(Person person)
        {
            StringBuilder sb = new();
            sb.Append("\tΕκδόθηκε και δημοσιεύθηκε ");
            if (person.orderforPayment.CourtName.Gender == gender.Male)
            {
                sb.Append("στον ");
            }
            else if (person.orderforPayment.CourtName.Gender == gender.Female)
            {
                sb.Append("στην ");
            }
            else if (person.orderforPayment.CourtName.Gender == gender.Neutral)
            {
                sb.Append("στο ");
            }
            // CHANGE THIS TO ONOMA STHN GENIKI.
            sb.Append(person.orderforPayment.CourtName.InCity.Trim());
            sb.Append(" στις ...........................\r");
            return sb.ToString();
        }

        public static void Test(Person person)
        {
            
            RichTextBox richTextBox1 = new();
            richTextBox1 = RTFGen.ReadTemplateFiel();
            
            //string str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΣΤΟΙΧΕΙΑΟΦΗΛΕΤΗΣ"), RTFGen.RtfToString(ClientData(person)));
            string str1 = richTextBox1.Rtf.Replace(RTFGen.RtfToString("ΔΟΚΙΜΗΓΙΑΔΙΑΓΡΑΦΗ"), RTFGen.RtfToString(""));
            richTextBox1.Rtf = str1;
            
            RTFGen.SaveTemplateFile(richTextBox1, person);

        }
    }
}
