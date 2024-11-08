using Newtonsoft.Json;
using Aspose.Cells; 

namespace JsonReader.FileWork
{
    public class WorkWithFiles
    {
        public string Path{get; } = @"C:\Users\amankeldi.kurban\Desktop\C#\JsonReader\Log.txt";
        public bool ReadFile(string filename)
        {
            using (StreamReader r = new StreamReader(filename))
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
    }
}