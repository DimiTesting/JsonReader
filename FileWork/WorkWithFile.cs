using Newtonsoft.Json;
using Aspose.Cells; 

namespace JsonReader.FileWork
{
    public class WorkWithFiles
    {
        public string FileName{get; }
        public string Path{get; } = @"C:\Users\amankeldi.kurban\Desktop\C#\JsonReader\Log.txt";

        public WorkWithFiles(string fileName)
        {
            FileName = fileName;
        }

        public bool ReadFile()
        {
            using (StreamReader r = new StreamReader(FileName))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach(var item in array)
                {
                    Console.WriteLine("{0}, {1}, {2}", item.Title, item.ReleaseYear, item.Rating);
                }
            }
            return false;
        }

        public void LogError(Exception error)
        {
            string text = "" + $"{DateTime.Now}\n" + error.StackTrace +"\n"; 
            string createText = $"{text}" + Environment.NewLine;

            File.AppendAllText(Path, createText);
        }

        /*public void ConvertJsonToTxt(string invalidFileInput)
        {
            var workbook = new Workbook(invalidFileInput);
            workbook.Save("Output.txt");
        }*/
    }
}