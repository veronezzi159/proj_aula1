using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using proj_aula1B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_aula1B
{
    public class ReadFile
    {
        public static List<PenalidadesAplicadas> GetData(string path, string file)
        {
            

            StreamReader reader = new StreamReader(path + file);
            string jsonString = reader.ReadToEnd();
            var lst = JsonConvert.DeserializeObject<MotoristaHabilitado>(jsonString, new IsoDateTimeConverter {DateTimeFormat = "dd/MM/yyyy" });

            if (lst != null) return lst.PenalidadesAplicadas;
            return null;    
            
        }       
    }
}
