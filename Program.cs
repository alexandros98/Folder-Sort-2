using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string fileName = null;
            string fileExtension = null;
            string folder = "C:\\Users\\Alexandros\\Desktop\\yeb1";

            string dest = "C:\\Users\\Alexandros\\Desktop\\yeb2";

            //SUBDIRECTORIES DECLARATION
            string subdirPDF = Path.Combine(dest, "PDF");
            string subdirTXT = Path.Combine(dest, "TXT");
            string subdirJPG = Path.Combine(dest, "JPG");
            string subdirBRUH = Path.Combine(dest, "BRUH");

            string[] destFolders = Directory.GetDirectories(dest);
            
            if (destFolders.Length == 0)
            {
                Directory.CreateDirectory(subdirPDF);
                Directory.CreateDirectory(subdirTXT);
                Directory.CreateDirectory(subdirJPG);
                Directory.CreateDirectory(subdirBRUH);
                Console.WriteLine("Destination folder is empty. All subdirectories succesfully created!");
            }
            else
            {
                foreach (string dirs in destFolders)
                {
                    //Console.WriteLine(dirs);
                    if (dirs == subdirPDF)
                    {
                        Console.WriteLine("PDF Subdirectory exists!");
                    }
                    else
                    {
                        Directory.CreateDirectory(subdirPDF);
                        Console.WriteLine("PDF Subdirectory succesfully created!");
                    }
                    if (dirs == subdirTXT)
                    {
                        Console.WriteLine("TXT Subdirectory exists!");
                    }
                    else
                    {
                        Directory.CreateDirectory(subdirTXT);
                        Console.WriteLine("TXT Subdirectory succesfully created!");
                    }
                    if (dirs == subdirJPG)
                    {
                        Console.WriteLine("JPG Subdirectory exists!");
                    }
                    else
                    {
                        Directory.CreateDirectory(subdirJPG);
                        Console.WriteLine("JPG Subdirectory succesfully created!");
                    }
                    if (dirs == subdirBRUH)
                    {
                        Console.WriteLine("BRUH Subdirectory exists!");
                    }
                    else
                    {
                        Directory.CreateDirectory(subdirBRUH);
                        Console.WriteLine("BRUH Subdirectory succesfully created!");
                    }

                }
            }


            string[] fileEntries = Directory.GetFiles(folder);
            foreach (string file in fileEntries)
            {
                fileName = Path.GetFileName(file);
                //File.Move(file, Path.Combine(dest, fileName));
                fileExtension = Path.GetExtension(file);

                if (fileExtension == ".pdf")
                {
                    File.Move(file, Path.Combine(subdirPDF, fileName));
                }
                else if (fileExtension == ".txt")
                {
                    File.Move(file, Path.Combine(subdirTXT, fileName));
                }
                else if (fileExtension == ".jpg")
                {
                    File.Move(file, Path.Combine(subdirJPG, fileName));
                }
                else
                {
                    File.Move(file, Path.Combine(subdirBRUH, fileName));
                }
            };
        }
    }
}
