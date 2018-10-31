using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Newtonsoft.Json.Linq;

namespace AnimalWorldC.Components
{
    public static class Serilizer
    {

        public static void SerilizeToPath(string path, List<Element> elements)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Element element in elements)
            {
                sb.Append(
                    (JsonConvert.SerializeObject(
                        element
                        )
                    ) + '\n'
                );
            }
            string temp = sb.ToString();

            StreamWriter sw = new StreamWriter(path);

            sw.Write(sb);
            sw.Close();
        }

        public static List<Element> DeSerilze(string path)
        {
            List<Element> elements = new List<Element>();

            StreamReader sr = new StreamReader(path);

            string theDots = sr.ReadToEnd();

            sr.Close();

            string[] theLines = theDots.Split('\n');

            foreach (string line in theLines)
            {
                if (line != "")
                {
                    Element element;

                    if (line.Contains("Scissors"))
                    {
                        element = JsonConvert.DeserializeObject<Scissors>(line);
                    }
                    else if (line.Contains("Rock")){
                        element = JsonConvert.DeserializeObject<Rock>(line);

                    }else {
                        element = JsonConvert.DeserializeObject<Paper>(line);
                    }

                    
                    elements.Add(element);
                }
            }

            return elements;
        }

        

        
    }
}
