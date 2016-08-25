using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Project
{
    class Manga : Book
    {
        private string NameOfIlustrator { get; set; }
        private string Synopsis { get; set; }
        private int Volume { get; set; }
        private string Series { get; set; }

        public override void AddDetails()
        {

        }
    }
}
