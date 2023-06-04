using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTFGeneratorLibrary
{
    public class Person
    {
        public string Title { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;
        public Address FirstAddress { get; set; }
        public OrderforPayment orderforPayment { get; set; }

        public gender Gender { get; set; }

        public Person()
        {
            FirstAddress = new Address();
            orderforPayment = new OrderforPayment();
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            string str = string.Empty;
            if (Gender == gender.Male)
            {
                str = "O";
            }
            else
            {
                str = "H";
            }
            sb.AppendLine($"ΔΙΑΤΑΓΗ ΠΛΗΡΩΜΗΣ: {str} {FirstName} {LastName} του {FatherName}");
            sb.AppendLine($"ΑΦΜ: {TaxNumber}");
            sb.AppendLine($"ΔΙΕΥΘΥΝΣΗ: {FirstAddress.Street} {FirstAddress.StrNumber}, {FirstAddress.City} {FirstAddress.PostalCode}");
            sb.AppendLine("---------------------------------");
            sb.AppendLine("");
            sb.AppendLine($"ΑΡΜΟΔΙΟ ΕΙΡΗΝΟΔΙΚΕΙΟ: {orderforPayment.CourtName.CapitalName}");
            if (orderforPayment.LawyerName.Gender == gender.Male)
            {
                str = "O";
            }
            else
            {
                str = "H";
            }

            sb.AppendLine($"ΔΙΚΗΓΟΡΟΣ: {str} {orderforPayment.LawyerName.Print}");
            sb.AppendLine($"ΠΟΣΟ ΟΦΗΛΗΣ: {orderforPayment.Debt.ToString()}");
            sb.AppendLine("------ ΣΥΜΒΑΣΕΙΣ ------");
            foreach (var m in orderforPayment.contracts)
            {
                sb.AppendLine(m.Show);
            }

            sb.AppendLine("");
            sb.AppendLine("----- ΤΙΜΟΛΟΓΙΑ ------");
            foreach (var m in orderforPayment.bills)
            {
                sb.AppendLine(m.Show);
            }
            return sb.ToString();
        }
    }


    public enum gender
    {
        Male = 0,
        Female = 1,
        Company = 2,
        Neutral = 3
    };
}
