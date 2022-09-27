using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookClass
{
    public class PhotoBook
    {
        private int numPages { get; set; }

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int _numPages)
        {
            numPages = _numPages;
        }
        public int GetNumberOfPages()
        {
            return numPages;
        }
    }
}
