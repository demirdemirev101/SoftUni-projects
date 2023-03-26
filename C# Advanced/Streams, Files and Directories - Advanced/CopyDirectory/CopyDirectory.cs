namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            // string inputPath =  @$"{Console.ReadLine()}";
            string inputPath = @$"D:\Papka 1";
            //string outputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"D:\Papka 2";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath);
            }
            Directory.CreateDirectory(outputPath);
            string[] files = Directory.GetDirectories(inputPath);
            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file);

                string destination = Path.Combine(outputPath, fileName);
                File.Copy(file, destination);
            }
        }
    }
}

