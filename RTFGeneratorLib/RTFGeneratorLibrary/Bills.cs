using System.Runtime.CompilerServices;

namespace RTFGeneratorLibrary
{
    public class Bills
    {
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Frequency { get; set; } = 1;
        public Double Amount { get; set; }


        public string Show
        {
            get { return $"{IssueDate.ToShortDateString()} {Amount}"; }
        }


    }

}