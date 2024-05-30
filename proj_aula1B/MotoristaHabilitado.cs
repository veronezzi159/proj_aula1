using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace proj_aula1B
{
    public class MotoristaHabilitado
    {
        [JsonProperty("penalidades_aplicadas")]
        public List<PenalidadesAplicadas> PenalidadesAplicadas { get; set; }
    }
}
