using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_HOTELERIA.Models.Reservaciones
{
    public class csEstructuraReservacion
    {
        public class requestReservacion
        {
            public int Id_reservacion { get; set; }
            public DateTime Fecha_inicio { get; set; }
            public DateTime Fecha_fin { get; set; }
            public int Costo_total { get; set; }
            public string Estado_reservacion { get; set; }
            public int Numero_habitacion { get; set; }  
            public int Id_Cliente { get; set; } 
            public int Id_Usuario { get; set; }
            public int id_hotel { get; set; }


        }
        public class responseReservacion
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }
        public class requesteliminarReservacion
        {
            public int Id_reservacion { get; set; }
        }
    }
}