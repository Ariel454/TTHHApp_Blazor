﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTHHApp_Blazor.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);




    public class Usuario
    {
        public string NOMBREUSUARIO { get; set; }
        public string PERFIL { get; set; }
        public string OBSERVACION { get; set; }
        public int CODIGOPERFIL { get; set; }
        public string ESTADO { get; set; }
        public int COMPANIA { get; set; }
        public int Emisor { get; set; }
        public int Cargo { get; set; }
        public string NOMBREEMISOR { get; set; }
        public string NOMBRECOMPANIA { get; set; }
        public string USUARIOCLIENTE { get; set; }
        public string RucUsuario { get; set; }
    }

    public class Root
    {
        public List<Usuario> MyArray { get; set; }
    }

}
