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

            foreach (string file in fileEntries)
            {
                fileName = Path.GetFileName(file);
                fileExtension = Path.GetExtension(file);
                foreach (string y in destFolders)
                {
                    if (fileExtension.TrimStart('.') == Path.GetFileName(y))
                    {
                        Console.WriteLine("File Moved!");
                        File.Move(file, Path.Combine(y, fileName));
                    }
                }

            };
        }
    }
}
