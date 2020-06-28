using System;

namespace Photo
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoAlbum pa = new PhotoAlbum();
            Console.WriteLine(pa.GetNumberOfPages());

            pa = new PhotoAlbum(24);
            Console.WriteLine(pa.GetNumberOfPages());

            BigPhotoAlbum bpa = new BigPhotoAlbum();
            Console.WriteLine(bpa.GetNumberOfPages());
        }
    }
}
