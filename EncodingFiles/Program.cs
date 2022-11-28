using EncodingFiles;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;

bool loopContinue = true;
while (loopContinue)
{
    Console.WriteLine("(1) -> .txt file encrypt\n(2) -> .txt file decrypt\n(3) -> exit");
    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            {
                string loadedfile = FileOperations.loadFile();
                Console.WriteLine("Enter your encoding key");
                string key = Console.ReadLine();
                if (keyValidation.Validate(key))
                {
                    string encryptedString = EncryptionAndDecryption.EncryptString(key, loadedfile);
                    Console.WriteLine("Save file? Y or N");
                    if (Console.ReadLine().ToLower().Equals("y"))
                    {
                        Console.WriteLine("Name your file");
                        string savingName = Console.ReadLine();
                        FileOperations.savingFile(savingName, encryptedString);
                        Console.WriteLine("Saved");
                    }

                }
                Console.WriteLine("Invalid Key");
                break;
            }
        case "2":
            {
                string loadedfile = FileOperations.loadFile();
                Console.WriteLine("Enter your decoding key");
                string key = Console.ReadLine();
                if (keyValidation.Validate(key))
                {
                    string decryptedString = EncryptionAndDecryption.DecryptString(key, loadedfile);
                    Console.WriteLine("Save file? Y or N");
                    if (Console.ReadLine().ToLower().Equals("y"))
                    {
                        Console.WriteLine("Name your file");
                        string savingName = Console.ReadLine();
                        FileOperations.savingFile(savingName, decryptedString);
                        Console.WriteLine("Saved");
                    }
                }
                Console.WriteLine("Invalid Key");
                break;
            }
        case "3":
            {
                loopContinue = false;
                break;
                
            }

    }
}

Console.ReadKey();
