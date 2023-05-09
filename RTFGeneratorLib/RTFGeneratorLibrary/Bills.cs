using System.Runtime.CompilerServices;

namespace RTFGeneratorLibrary
{
    public class Bills
    {
        public DateTime IssueDate { get; set; }
        public Double Amount { get; set; }


        public string Show
        {
            get { return $"{IssueDate.ToShortDateString()} {Amount}"; }
        }


    }

}