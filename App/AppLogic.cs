using JsonReader.FileWork;
using JsonReader.SaveError;
using System.Text.Json;


namespace JsonReader.App
{
    public class AppLogic
    {
        public WorkWithFiles _workWithFiles;
        public Logger _logger; 

        public AppLogic(WorkWithFiles workWithFiles, Logger logger)
        {
            workWithFiles = _workWithFiles;
            logger = _logger;
        }

        public void Run()
        {
            while(true)
            {
                Console.WriteLine("Enter the name of the file you want to read? ");
                var userInput = Console.ReadLine();

                if(userInput == "games.json" || userInput == "gamesInvalidFormat.json")
                {
                    try
                    {
                        _workWithFiles.ReadFile(userInput);
                        Console.WriteLine("File does not contain any error. Press any key to exit the program");
                        Console.ReadLine();
                        
                    }
                    catch(JsonException err)
                    {
                        _logger.LogError(err);
                        Console.WriteLine("File contains an error: " + err.Message);
                        Console.WriteLine("Please take a look into Log.txt file to review the Stack trace");
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