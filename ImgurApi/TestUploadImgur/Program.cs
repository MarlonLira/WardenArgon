using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlickrNet;
using UploadImgur;

namespace TestUploadImgur
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
        }

        private static void Test()
        {
            UploadFlickr.UploadFlickr upload = new UploadFlickr.UploadFlickr();
            string path = System.IO.Path.GetDirectoryName("D:\\Project\\Chup Anh Lien Quan Nox\\UploadImages\\bin\\Debug\\Capture\\");
            string[] files = System.IO.Directory.GetFiles(path, "*.png");
            Console.WriteLine(string.Concat("Tim thay ", files.Length, " files anh"));
            foreach (string file in files)
            {
                Console.WriteLine("Dang Upload file " + Path.GetFileName(file));

                if (upload.Upload(file))
                    Console.WriteLine(upload.link);
                else
                    Console.WriteLine(upload.error);
                File.AppendAllText("flickr.txt", string.Concat(Path.GetFileName(file), "|", upload.link, "\r\n"));
            }
            Console.WriteLine("Da thuc hien xong");
            Console.ReadLine();
        }   

        private static void TestImgur()
        {
            Imgur imgur = new Imgur();
            string path = System.IO.Path.GetDirectoryName("D:\\Project\\Chup Anh Lien Quan Nox\\UploadImages\\bin\\Debug\\Capture\\");
            string[] files = System.IO.Directory.GetFiles(path, "*.png");
            Console.WriteLine(string.Concat("Tim thay ", files.Length, " files anh"));
            foreach (string file in files)
            {
                Console.WriteLine("Dang Upload file " + Path.GetFileName(file));

                if (imgur.UploadImages(file))
                    Console.WriteLine(imgur.link);
                else
                    Console.WriteLine(imgur.error);
                File.AppendAllText("anh.txt", string.Concat(Path.GetFileName(file), "|", imgur.link, "\r\n"));
            }
            Console.WriteLine("Da thuc hien xong");
            Console.ReadLine();
        }
    }
}
