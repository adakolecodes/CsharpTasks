using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassGroupWorkWorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\danie\source\repos\Documents\";
            string[] dirs = Directory.GetFiles(path);
            string destinationPath = @"C:\Users\danie\source\";

            foreach(string d in dirs)
            {
                File.Copy(d, $"{destinationPath}{Path.GetFileName(d)}", true);
            }
        }
    }
}
