using System.Text.Json;

namespace JsonReader.SaveError
{
    public class Logger
    {
        private string Path {get; } = @"C:\Users\amankeldi.kurban\Desktop\C#\JsonReader\Log.txt";

        public void LogError(JsonException err )
        {
            string text = "" + $"{DateTime.Now}\n" + err.StackTrace +"\n"; 
            string createText = $"{text}" + Environment.NewLine;

            File.AppendAllText(Path, createText);
        }
    }
}