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
            string subdir = Path.Combine(dest, "");

            string[] destFolders = Directory.GetDirectories(dest);
            string[] fileEntries = Directory.GetFiles(folder);

            if (fileEntries.Length == 0)
            {
                Console.WriteLine("No files to copy. The application will now exit.");
                System.Environment.Exit(1);
            }
            if (destFolders.Length == 0)
            {
                foreach (string x in fileEntries)
                {
                    subdir = Path.Combine(dest, Path.GetExtension(x).TrimStart('.'));
                    Directory.CreateDirectory(subdir);
                    //Console.WriteLine(Path.GetExtension(x));

                }
                Console.WriteLine("Destination folder is empty. All subdirectories succesfully created based on the file extensions from the source folder.");
                destFolders = Directory.GetDirectories(dest);
            }
            else
            {
                foreach (string x in fileEntries)
                {
                    foreach (string y in destFolders)
                    {
                        //Console.WriteLine("Comparing " + Path.GetExtension(x).TrimStart('.') + " and " + Path.GetFileName(y));
                        if (Path.GetExtension(x).TrimStart('.') == Path.GetFileName(y))
                        {
                            Console.WriteLine("Directory " + Path.GetExtension(x).TrimStart('.') + " allready exists");
                        }
                        else if (Directory.Exists(Path.Combine(dest, Path.GetExtension(x).TrimStart('.'))) == false)
                        {
                            Directory.CreateDirectory(Path.Combine(dest, Path.GetExtension(x).TrimStart('.')));
                            Console.WriteLine("Subdirectory created!");
                        }
                    }

                }
            }
            Console.WriteLine("HELLO????");
            foreach (string file in fileEntries)
            {
                fileName = Path.GetFileName(file);
                fileExtension = Path.GetExtension(file);
                foreach (string y in destFolders)
                {
                    //Console.WriteLine(file);
                    //Console.WriteLine(Path.Combine(y, fileName));
                    Console.WriteLine("Comparing " + fileExtension.TrimStart('.') + " and " + Path.GetFileName(y));
                    if (fileExtension.TrimStart('.') == Path.GetFileName(y))
                    {
                        Console.WriteLine("File Moved!");
                        File.Move(file, Path.Combine(y, fileName));
                    }
                }

            };



            /*
            
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
            */
        }
    }
}
