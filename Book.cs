using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookCategory { get; set; }

        public Book(int id, string name, string category)
        {
            BookID = id;
            BookName = name;
            BookCategory = category;
        }
    }
}
