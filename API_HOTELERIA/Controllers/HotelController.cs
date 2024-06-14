using API_HOTELERIA.Models.Empleados;
using API_HOTELERIA.Models.Hotel;
using API_HOTELERIA.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using static API_HOTELERIA.Models.Empleados.csEstructuraEmpleado;
using static API_HOTELERIA.Models.Hotel.csEstructuraHotel;

namespace API_HOTELERIA.Controllers
{
    public class HotelController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarHotel")]
        public IHttpActionResult insertarHotel(requestHotel models)
        {
            return Ok(new csHotel().insertarHotel(models.Id_hotel, models.Nombre, models.Descripcion, models.Categoria, models.Direccion, models.Cod_postal,models.Telefono, models.Numero_habitacion, models.Id_empleados));

        }

        [HttpPost]
        [Route("rest/api/actualizarHotel")]
        public IHttpActionResult actualizarHotel(requestHotel models)
        {
            return Ok(new csHotel().actualizarHotel(models.Id_hotel, models.Nombre, models.Descripcion,models.Categoria,models.Direccion, models.Cod_postal, models.Telefono, models.Numero_habitacion, models.Id_empleados));
        }

        [HttpPost]
        [Route("rest/api/eliminarHotel")]
        public IHttpActionResult eliminarHotel(requestHotel models)
        {
            return Ok(new csHotel().eliminarHotel(models.Id_hotel));
        }

        [HttpGet]
        [Route("rest/api/listarHotel")]
        public IHttpActionResult ListarHotel()
        {
            return Ok(new csHotel().ListarHotel());
        }

        [HttpGet]
        [Route("rest/api/listarHotelXid")]
        public IHttpActionResult ListarEmpleadosXid(int Id_hotel)
        {
            return Ok(new csHotel().ListarHotelXid(Id_hotel));
        }




    }
}