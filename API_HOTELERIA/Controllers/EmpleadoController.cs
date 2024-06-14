using API_HOTELERIA.Models.Empleados;
using API_HOTELERIA.Models.Hotel;
using API_HOTELERIA.Models.Tipo_habitacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using static API_HOTELERIA.Models.Empleados.csEstructuraEmpleado;
using static API_HOTELERIA.Models.Tipo_habitacion.csEstructuraTipo_habitacion;

namespace API_HOTELERIA.Controllers
{
    public class EmpleadoController : ApiController

    {

        [HttpPost]
        [Route("rest/api/insertarEmpleado")]
        public IHttpActionResult insertarEmpleado(requestEmpleado models)
        {
            return Ok(new csEmpleados().insertarEmpleado(models.Id_empleado,models.Nombre,models.Apellidos, models.No_identificacion, models.Domicilio, models.Telefono, models.Puesto, models.Fecha_ingreso, models.Email,models.Id_hotel));

        }

        [HttpPost]
        [Route("rest/api/actualizarEmpleados")]
        public IHttpActionResult actualizarEmpleados(requestEmpleado models)
        {
            return Ok(new csEmpleados().actualizarEmpleados(models.Id_empleado, models.Nombre, models.Apellidos, models.No_identificacion,models.Domicilio,models.Telefono, models.Puesto,models.Fecha_ingreso,models.Email, models.Id_hotel));
        }

        [HttpPost]
        [Route("rest/api/eliminarEmpleados")]
        public IHttpActionResult eliminarEmpleados(requestEmpleado models)
        {
            return Ok(new csEmpleados().eliminarEmpleados(models.Id_empleado));
        }

        [HttpGet]
        [Route("rest/api/listarEmpleados")]
        public IHttpActionResult ListarEmpleados()
        {
            return Ok(new csEmpleados().ListarEmpleados());
        }

        [HttpGet]
        [Route("rest/api/listarEmpleadosXid")]
        public IHttpActionResult ListarEmpleadosXid(int Id_empleado)
        {
            return Ok(new csEmpleados().ListarEmpleadosXid(Id_empleado));
        }

    }
}