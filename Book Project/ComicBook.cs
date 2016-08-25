using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Project
{
    class ComicBook : Book
    {
        private string Illustrator { get; set; }
        private int IssueNumber { get; set; }
        private string Synopsis { get; set; }
        private string PublisherComp { get; set; }

        public override void AddDetails()
        {
            Console.WriteLine("Who is the illustrator?");
            this.Illustrator = Console.ReadLine();
            Console.WriteLine("What issue number is this?");
            this.IssueNumber = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Whats the Synopsis?");
            this.Synopsis = Console.ReadLine();
            Console.WriteLine("Who is the Publishing Company?");
            this.PublisherComp = Console.ReadLine();
            Console.WriteLine("What is the Title of the Book?");
            base.AddDetails();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(Illustrator);
            Console.WriteLine(IssueNumber);
            Console.WriteLine(Synopsis);
            Console.WriteLine(PublisherComp);
        }
    }
}
