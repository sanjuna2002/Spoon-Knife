using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionLibrary
{
    internal class BookDetails
    {
        public string BookName { get; set; }
        public int ISBNno { get; set; }
        public string AuthorName { get; set; }
        public int NoOfCopies { get; set; }
        public string PublisherName { get; set; }

        public BookDetails(string bookName, int iSBNno, string authorName, int noOfCopies, string publisherName)
        {
            BookName = bookName;
            ISBNno = iSBNno;
            AuthorName = authorName;
            NoOfCopies = noOfCopies;
            PublisherName = publisherName;
        }
    }
}
