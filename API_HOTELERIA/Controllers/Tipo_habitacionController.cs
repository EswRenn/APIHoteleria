using API_HOTELERIA.Models.Habitacion;
using API_HOTELERIA.Models.Tipo_habitacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using static API_HOTELERIA.Models.Habitacion.csEstructuraHabitacion;
using static API_HOTELERIA.Models.Tipo_habitacion.csEstructuraTipo_habitacion;

namespace API_HOTELERIA.Controllers
{
    public class Tipo_habitacionController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarTipo_habitacion")]

        public IHttpActionResult insertarTipo_habitacion(requestTipo_habitacion models)
        {
            return Ok(new csTipo_habitacion().insertarTipo_habitacion(models.Id_tipo_habitacion,models.Descripcion,models.Capacidad_personas, models.Precio));
        }

        [HttpPost]
        [Route("rest/api/actualizarTipo_habitacion")]
        public IHttpActionResult actualizarTipo_habitacion(requestTipo_habitacion models)
        {
            return Ok(new csTipo_habitacion().actualizarTipo_habitacion(models.Id_tipo_habitacion, models.Descripcion, models.Capacidad_personas, models.Precio));
        }

        [HttpPost]
        [Route("rest/api/eliminarTipo_habitacion")]
        public IHttpActionResult eliminarTipo_habitacion(requestEliminarTipo_habitacion models)
        {
            return Ok(new csTipo_habitacion().eliminarTipo_habitacion(models.Id_tipo_habitacion));
        }

        [HttpGet]
        [Route("rest/api/listarTipo_habitacion")]
        public IHttpActionResult ListarTipo_habitacion()
        {
            return Ok(new csTipo_habitacion().ListarTipo_habitacion());
        }

        [HttpGet]
        [Route("rest/api/listarTipo_habitacionXid")]
        public IHttpActionResult ListarTipo_habitacionXid(int Id_tipo_habitacion)
        {
            return Ok(new csTipo_habitacion().ListarTipo_habitacionXid(Id_tipo_habitacion));
        }
    }
    
}




