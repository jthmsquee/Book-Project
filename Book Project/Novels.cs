using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Project
{
    class Novels : Book
    {
        private int Chapters { get; set; }
        private string Synopsis { get; set; }

        public override void AddDetails()
        {
            Console.WriteLine("How many chapters is there?");
            Chapters = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("What is the Synposis?");
            Synopsis = Console.ReadLine();
            base.AddDetails();
        }

        public Novels()
        {

        }
    }
}
