using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Books
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(int bookID, string bookName, string authorName)
        {
            BookID = bookID;
            BookName = bookName;
            AuthorName = authorName;
        }
        public override string ToString()
        {
            return $"Book Id: {BookID} \n Book Name : {BookName} \n AuthorName {AuthorName}  ";
        }
    }
}
