using System;
using JsonReader.App;
using JsonReader.WorkWithFile;
using JsonReader.SaveError;

namespace JsonReader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                ReadJsonFile readJsonFile = new ReadJsonFile();
                Logger logger = new Logger();
                AppLogic app = new AppLogic(readJsonFile, logger);
                app.Run();

            }
            catch(Exception err)
            {
                Console.WriteLine($"Unexpected error occured: {err.Message}");
                Console.WriteLine("Please type anything to exit from the app");
                Console.ReadLine();
            }
        }
    }
}