using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using JsonReader.FileWork;

namespace JsonReader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter the name of the file you want to read? ");
                var userInput = Console.ReadLine();

                if(userInput == "games.json" || userInput == "gamesInvalidFormat.json")
                {
                    WorkWithFiles test = new WorkWithFiles(userInput);
                    try
                    {
                        test.ReadFile(); 
                        Console.WriteLine("File does not contain any error. Press any key to exit the program");
                        Console.ReadLine();
                        
                    }
                    catch(Exception err)
                    {
                        test.LogError(err);
                        //test.ConvertJsonToTxt(userInput);
                        Console.WriteLine("File contains an error: " + err.Message);
                        Console.WriteLine("Please take a look into Log.txt file to review the Stack trace")
                        Console.WriteLine("Press any key to exit the program");
                        Console.ReadLine();
                    }
                    break;
                } 
                else if(userInput == "" || userInput == " ")
                {
                    Console.WriteLine("File name cannot be empty");
                } 
                else if(userInput == null)
                {
                    Console.WriteLine("File name cannot be null");
                }
                else {
                    Console.WriteLine("File cannot be found");
                }
            }
        }
    }
}