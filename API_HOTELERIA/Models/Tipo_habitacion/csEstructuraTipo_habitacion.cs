using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_HOTELERIA.Models.Tipo_habitacion
{
    public class csEstructuraTipo_habitacion
    {
        public class requestTipo_habitacion
        {
            public int Id_tipo_habitacion { get; set; }
            public string Descripcion { get; set; }
            public int Capacidad_personas { get; set; }
            public int Precio { get; set; }
        }
        public class responseTipo_habitacion
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }

        public class requestEliminarTipo_habitacion
        {
            public int Id_tipo_habitacion { get; set; }
        }
    }
}