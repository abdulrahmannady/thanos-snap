using System;
using System.IO;

namespace ThanosSnap
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dir = new DirectoryInfo(FileManager.GetDirectory());

                var files = dir.GetFiles();

                foreach (var file in files)
                {
                    if (file.BelongsTo())
                    {
                        file.SendToRecycleBin();
                        Console.WriteLine("Deleted File: {0}", file.FullName);
                    }
                }

                Console.WriteLine("Press any key to exit ...");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                using (StreamWriter w = File.AppendText("Error Log.txt"))
                {
                    w.WriteLine(e.ToString());
                }
            }
        }
    }
}