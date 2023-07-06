using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTHHApp_Blazor.Models
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class CentroCostos
    {
        public int Codigo { get; set; }
        public string NombreCentroCostos { get; set; }
        public object Mensaje { get; set; }
    }


}
