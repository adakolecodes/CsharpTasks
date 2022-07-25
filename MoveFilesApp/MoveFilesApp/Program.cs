using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MoveFilesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\danie\Downloads";
            
            string[] files = Directory.GetFiles(path, "*.jpg");
            var newPath = @"C:\Users\danie\Downloads\Images\";
            bool directoryExists = Directory.Exists(newPath);


            if (files.Length == 0)
            {
                Console.WriteLine("No image file located");
            }
            else
            {
                foreach (var file in files)
                {
                    if (directoryExists)
                    {
                        try
                        {
                            File.Move(file, $"{newPath}{Path.GetFileName(file)}");
                            Console.WriteLine($"{Path.GetFileName(file)} file moved successfully");
                        }
                        catch (IOException)
                        {
                            Console.WriteLine($"{Path.GetFileName(file)} file you want to move already exist in the destination folder");
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(newPath);
                        File.Move(file, $"{newPath}{Path.GetFileName(file)}");
                        Console.WriteLine($"{Path.GetFileName(file)} file moved successfully with folder created");
                    }
                }
            }


            Console.ReadLine();
        }
    }
}
