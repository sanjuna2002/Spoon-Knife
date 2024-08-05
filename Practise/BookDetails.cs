using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class BookDetails
    {
        public string BookName{ get; set; }
        public int ISBNNo { get; set; }
        public string AuthorName { get; set; }
        public int NoOfCopies { get; set; }
        public string PublisherName { get; set; }


        public BookDetails(string bookName, int iSBNNo, string authorName, int noOfCopies, string publisherName)
        {
            BookName = bookName;
            ISBNNo = iSBNNo;
            AuthorName = authorName;
            NoOfCopies = noOfCopies;
            PublisherName = publisherName;

        }
    }
}
