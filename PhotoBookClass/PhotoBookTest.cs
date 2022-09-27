using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookClass
{
    public static class PhotoBookTest
    {
        public static void ShowBooks()
        {
            PhotoBook photoBook1 = new PhotoBook();
            PhotoBook photoBook24 = new PhotoBook(24);
            BigPhotoBook bigPhotoBook = new BigPhotoBook();

            Console.WriteLine(photoBook1.GetNumberOfPages());
            Console.WriteLine(photoBook24.GetNumberOfPages());
            Console.WriteLine(bigPhotoBook.GetNumberOfPages());

        }
      
    }
}
