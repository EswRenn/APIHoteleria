using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_HOTELERIA.Models.Usuarios
{
    public class csEstructuraUsuario
    {
        public class requestUsuario
        {
            public int Id_usuario { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public DateTime Fecha_alta { get; set; }
            public DateTime Ultimo_acceso { get; set; }
            public int Id_empleado { get; set; }



        }

        public class responseUsuario
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }

        }
        public class requesteliminarUsuario
        {
            public int Id_usuario { get; set; }
        }
    }
}