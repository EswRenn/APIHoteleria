using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_HOTELERIA.Models.Cliente
{
    public class csEstructuraCliente
    {
        public class requestCliente
        {
            public int Id_cliente { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public int Cod_postal { get; set; }
           public int Telefono { get; set; }
           

        }
        public class responseCliente
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }

        public class requestEliminarCliente
        {
            public int Id_cliente { get; set; }
        }


    }
}