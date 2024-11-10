using System;
using Newtonsoft.Json;

namespace JsonReader.WorkWithFile
{
    public class ReadJsonFile
    {
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