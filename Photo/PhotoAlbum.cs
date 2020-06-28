using System;
using System.Collections.Generic;
using System.Text;

namespace Photo
{
    class PhotoAlbum
    {
        protected int numberOfPages;
        public PhotoAlbum()
        {
            numberOfPages = 16;
        }


        public PhotoAlbum(int n)
        {
            numberOfPages = n;
        }


        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
}
