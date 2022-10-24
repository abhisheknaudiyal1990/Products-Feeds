using Newtonsoft.Json.Linq;
using System;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace GartnerAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a file option from the following list:");
            Console.WriteLine("\tc - Capterra.yaml");
            Console.WriteLine("\ts - Softwareadvice.json");
            Console.Write("Your Option? ");
            
            switch(Console.ReadLine())
            {
                case "c":
                    if (!FileParser.ParseFile("Capterra.yaml"))
                    Console.Write("Capterra.yaml file parsing not successfull");
                    break;

                case "s":
                    if (!FileParser.ParseFile("Softwareadvice.json"))
                        Console.Write("Softwareadvice.json file parsing not successfull");
                    break;
            }
            Console.Write("Press any key to close the console app...");
            Console.ReadKey();
        }
    }
}
