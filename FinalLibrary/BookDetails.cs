using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLibrary
{
    internal class BookDetails
    {
        public string Name { get; set; }
        public int ISBNo { get; set; }
        public string AuthorName { get; set; }
        public int NumberOfCopies { get; set; }
        public string PublisherName { get; set; }

        public BookDetails(string name, int iSBNo, string authorName, int numberOfCopies, string publisherName)
        {
            Name = name;
            ISBNo = iSBNo;
            AuthorName = authorName;
            NumberOfCopies = numberOfCopies;
            PublisherName = publisherName;
        }
    }
}
