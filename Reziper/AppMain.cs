using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReZipper
{
    public class AppMain
    {
        internal static void Main(string[] args)
        {
            checkArgs(args);

            foreach (var dir in Directory.GetDirectories(args[0]))
            {
                string dirName = Path.GetFileName(dir);
                string zipName = dirName + ".zip";
                string zipPath = Path.Combine(args[1], zipName);

                Console.WriteLine("[" + dirName + "]");
                using (var zip = ZipFile.Open(zipPath, ZipArchiveMode.Create, Encoding.UTF8))
                {
                    foreach (var filePath in Directory.GetFiles(dir))
                    {
                        zip.CreateEntryFromFile(filePath, Path.GetFileName(filePath), CompressionLevel.NoCompression);
                        Console.WriteLine("  /File : " + Path.GetFileName(filePath));
                    }
                }
            }

            Console.WriteLine("Completed.");
            //Console.ReadLine();
        }

        private static bool checkArgs(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Invalied args.");
                return false;
            }

            if (!Directory.Exists(args[0]))
            {
                Console.WriteLine("Source dir is not found.");
                return false;
            }

            if (!Directory.Exists(args[1]))
            {
                Console.WriteLine("Destination dir is not found.");
                return false;
            }

            return true;
        }
    }
}
