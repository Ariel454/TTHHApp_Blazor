using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTHHApp_Blazor.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Compania
    {
        public int Codigo { get; set; }
        public string NombreEmisor { get; set; }
        public string Ruc { get; set; }
    }


}
