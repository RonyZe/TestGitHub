using System;
using System.IO;

namespace FileSystemExample
{
    class FileExample
    {
        public static void Main()
        {
            var path = @"C:\Users\ronyr\OneDrive\Documents\visual studio 2015\Projects\CFun.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("FileName: " + Path.GetFileName(path));
            Console.WriteLine("Directory: "+Path.GetDirectoryName(path));
            Console.ReadLine();

        }
    }
}