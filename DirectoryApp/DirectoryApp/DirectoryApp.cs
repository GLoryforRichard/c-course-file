using System;
using System.IO;  // Added for File access
namespace DirectoryApp
{
    class DirectoryApp
    {
        static void Main(string[] args)
        {
            string result;
            DirectoryInfo Info = new DirectoryInfo(".");

            result = Info.FullName + "\n\n" +
                    "File Names".PadRight(40) + "Size".PadLeft(20) + "\n";
            foreach (FileInfo fil in Info.GetFiles("*.*"))
            {
                result += fil.Name.PadRight(40) +
                    fil.Length.ToString("N0").PadLeft(20) + "\n";
            }
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
