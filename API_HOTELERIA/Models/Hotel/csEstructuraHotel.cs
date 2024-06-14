using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_HOTELERIA.Models.Hotel
{
    public class csEstructuraHotel
    {
        public class requestHotel
        {
            public int Id_hotel { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public string Categoria { get; set; }
            public string Direccion { get; set; }
            public int Cod_postal { get; set; }
            public int Telefono { get; set; }
            public int Numero_habitacion { get; set; }
            public int Id_empleados { get; set; }

            public class responseHotel
            {
                public int respuesta { get; set; }
                public string descripcion_respuesta { get; set; }

            }


        }

        public class requesteliminarHotel
        {
            public int Id_hotel { get; set; }
        }
    }
}