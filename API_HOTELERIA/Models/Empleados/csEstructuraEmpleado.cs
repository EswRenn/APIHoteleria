using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_HOTELERIA.Models.Empleados
{
    public class csEstructuraEmpleado
    {
        public class requestEmpleado
        {
            public int Id_empleado { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public int No_identificacion { get; set; }
            public string Domicilio { get; set; }
            public int Telefono { get; set; }
            public string Puesto { get; set; }
            public DateTime Fecha_ingreso { get; set; }
            public string Email { get; set; }
            public int Id_hotel { get; set; }

        }
        public class responseEmpleado
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }


        public class requestEliminarEmpleados
        {
            public int Id_empleado { get; set; }
        }


    }
}