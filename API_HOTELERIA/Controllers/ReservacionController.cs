using API_HOTELERIA.Models.Tipo_habitacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static API_HOTELERIA.Models.Tipo_habitacion.csEstructuraTipo_habitacion;
using System.Web.Http;
using static API_HOTELERIA.Models.Reservaciones.csEstructuraReservacion;
using API_HOTELERIA.Models.Reservaciones;
using API_HOTELERIA.Models.Habitacion;
using static API_HOTELERIA.Models.Habitacion.csEstructuraHabitacion;

namespace API_HOTELERIA.Controllers
{
    public class ReservacionController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarReservacion")]

        public IHttpActionResult insertarReservacion(requestReservacion models)
        {
            return Ok(new csReservacion().insertarReservacion(models.Id_reservacion, models.Fecha_inicio, models.Fecha_fin, models.Costo_total, models.Estado_reservacion, models.Numero_habitacion, models.Id_Cliente, models.Id_Usuario, models.id_hotel));
        }



        [HttpPost]
        [Route("rest/api/actualizarReservacion")]
        public IHttpActionResult actualizarReservacion(requestReservacion models)
        {
            return Ok(new csReservacion().actualizarReservacion(models.Id_reservacion, models.Fecha_inicio, models.Fecha_fin, models.Costo_total, models.Estado_reservacion,models.Numero_habitacion,models.Id_Cliente, models.Id_Usuario, models.id_hotel));
        }

        [HttpPost]
        [Route("rest/api/eliminarReservacion")]
        public IHttpActionResult eliminarReservacion(requestReservacion models)
        {
            return Ok(new csReservacion().eliminarReservacion(models.Id_reservacion));
        }

        [HttpGet]
        [Route("rest/api/listarReservacion")]
        public IHttpActionResult ListarReservacion()
        {
            return Ok(new csReservacion().ListarReservacion());
        }

        [HttpGet]
        [Route("rest/api/listarReservacionXid")]
        public IHttpActionResult ListarReservacionXid(int Id_reservacion)
        {
            return Ok(new csReservacion().listarReservacionXid(Id_reservacion));
        }


    }
}