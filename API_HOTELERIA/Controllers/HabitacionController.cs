
using API_HOTELERIA.Models.Cliente;
using API_HOTELERIA.Models.Habitacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using static API_HOTELERIA.Models.Cliente.csEstructuraCliente;
using static API_HOTELERIA.Models.Habitacion.csEstructuraHabitacion;

namespace API_HOTELERIA.Controllers
{
    public class HabitacionController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarHabitacion")]

        public IHttpActionResult insertarHabitacion(requestHabitacion models)
        {
            return Ok(new csHabitacion().insertarHabitacion(models.Id_tipo_habitacion, models.Numero_habitacion, models.Id_hotel, models.Estado));
        }

        [HttpPost]
        [Route("rest/api/actualizarHabitacion")]
        public IHttpActionResult actualizarHabitacion(requestHabitacion models)
        {
            return Ok(new csHabitacion().actualizarHabitacion(models.Id_tipo_habitacion, models.Numero_habitacion, models.Id_hotel, models.Estado));
        }

        [HttpPost]
        [Route("rest/api/eliminarHabitacion")]
        public IHttpActionResult eliminarHabitacion(requestHabitacion models)
        {
            return Ok(new csHabitacion().eliminarHabitacion(models.Id_tipo_habitacion));
        }

        [HttpGet]
        [Route("rest/api/listarHabitacion")]
        public IHttpActionResult ListarHabitacion()
        {
            return Ok(new csHabitacion().ListarHabitacion());
        }

        [HttpGet]
        [Route("rest/api/listarHabitacionXid")]
        public IHttpActionResult ListarHabitacionXid(int Id_tipo_habitacion)
        {
            return Ok(new csHabitacion().ListarHabitacionXid(Id_tipo_habitacion));
        }

    }
}