using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTHHApp_Blazor.Models
{
    public class DecimosProxy
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }


        public string ObtenerCalculoDecimo()
        {
            if (Codigo == "0")
            {
                return "Mensual";
            }
            else if (Codigo == "1")
            {
                return "Acumulada";
            }
            else
            {
                return "Valor inválido";
            }
        }

    }


}
