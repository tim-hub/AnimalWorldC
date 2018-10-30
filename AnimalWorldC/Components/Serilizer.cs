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
                        element,
                        Formatting.Indented
                        )
                    ) + "#"
                );
            }
            string temp = sb.ToString();

            StreamWriter sw = new StreamWriter(path);

            sw.Write(sb);
            sw.Close();
        }

        

        
    }
}
