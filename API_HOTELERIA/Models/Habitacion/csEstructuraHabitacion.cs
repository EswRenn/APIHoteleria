using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_HOTELERIA.Models.Habitacion
{
    public class csEstructuraHabitacion
    {
        public class requestHabitacion
        {
            public int Id_tipo_habitacion { get; set; }
            public int Numero_habitacion { get; set; }
            public int Id_hotel { get; set; }
            public string Estado { get; set; }
        }
        public class responseHabitacion
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }

        public class requesteliminarHabitacion
        {
            public int Id_tipo_habitacion { get; set; }
        }
    }
}