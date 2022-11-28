using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EncodingFiles
{
    public class FileOperations
    {
        private static string? Filepath;

        public static void savingFile(string savingName, string saveContent) => 
            File.WriteAllText(Path.GetDirectoryName(FileOperations.Filepath) + @$"\{savingName}.txt", saveContent);
        
        public static string loadFile()
        {
            Console.WriteLine("Drop a .txt file and press Enter");
            string loadedFilePath = Console.ReadLine().Replace('"', ' ').Trim();
            string loadedFile = File.ReadAllText(loadedFilePath);
            Filepath = loadedFilePath;
            return loadedFile;
        }

    }
}
