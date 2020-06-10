using System;
using System.IO;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        private static void FileD()
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temo\myfile.jpg", true);
            File.Delete(path);
            File.Exists(path);
            File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {

            }
        }

        private static void Dir()
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.sln", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file); 
            }

            var dir = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*.*",SearchOption.AllDirectories);

            var dirr = new DirectoryInfo("...");
            dirr.GetFiles();
            dirr.GetDirectories();
        }

        private static void path()
        {

        }
    }
}
