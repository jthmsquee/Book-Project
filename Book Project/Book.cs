using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Project
{
    abstract class Book
    {
        protected string Title { get; set; }
        protected int TotalNumberOfPages { get; set; }
        protected string Genre { get; set; }
        protected int Isbn { get; set; }
        protected float Cost { get; set; }
        protected string Author { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Total number of pages: " + TotalNumberOfPages);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("ISBN: " + Isbn);
            Console.WriteLine("Cost: " + Cost);
        }

        public virtual void AddDetails()
        {
            Console.WriteLine("What is the Title of the Book?");
            this.Title = Console.ReadLine();
            Console.WriteLine("What is the total number of pages?");
            this.TotalNumberOfPages = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What genre is this Book?");
            this.Genre = Console.ReadLine();
            Console.WriteLine("What is this books ISBN?");
            this.Isbn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the cost of this Book?");
            this.Cost = (float)Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Who is the Author?");
            this.Author = Console.ReadLine();
        }
    }
}
