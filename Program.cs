using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using JsonReader.App;
using JsonReader.FileWork;
using JsonReader.SaveError;

namespace JsonReader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                WorkWithFiles workWithFiles = new WorkWithFiles();
                Logger logger = new Logger();
                AppLogic app = new AppLogic(workWithFiles, logger);
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