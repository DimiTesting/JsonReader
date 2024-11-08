namespace JsonReader.SaveError
{
    public class Logger
    {
        private JsonException _jsonexception;
        private string Path {get; } = @"C:\Users\amankeldi.kurban\Desktop\C#\JsonReader\Log.txt";

        public Logger(JsonException JsonError)
        {
            _jsonexception = JsonError;
        }
        public void LogError()
        {
            string text = "" + $"{DateTime.Now}\n" + JsonError.StackTrace +"\n"; 
            string createText = $"{text}" + Environment.NewLine;

            File.AppendAllText(Path, createText);
        }
    }
}