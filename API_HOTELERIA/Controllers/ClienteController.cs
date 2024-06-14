using API_HOTELERIA.Models.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using API_HOTELERIA.Models.Cliente;
using static API_HOTELERIA.Models.Cliente.csEstructuraCliente;
using static API_HOTELERIA.Models.Empleados.csEstructuraEmpleado;

namespace API_HOTELERIA.Controllers
{
    public class ClienteController : ApiController
    {
            [HttpPost]
            [Route("rest/api/insertarCliente")]
            public IHttpActionResult insertarCliente(requestCliente models)
            {
                return Ok(new csCliente().insertarCliente(models.Id_cliente, models.Nombre, models.Apellidos, models.Cod_postal,models.Telefono));

            }

        [HttpPost]
        [Route("rest/api/actualizarCliente")]
        public IHttpActionResult actualizarCliente(requestCliente models)
        {
            return Ok(new csCliente().actualizarCliente(models.Id_cliente, models.Nombre, models.Apellidos, models.Cod_postal,models.Telefono));
        }

        [HttpPost]
        [Route("rest/api/eliminarCliente")]
        public IHttpActionResult eliminarCliente(requestCliente models)
        {
            return Ok(new csCliente().eliminarCliente(models.Id_cliente));
        }

        [HttpGet]
        [Route("rest/api/listarCliente")]
        public IHttpActionResult ListarCliente()
        {
            return Ok(new csCliente().ListarCliente());
        }

        [HttpGet]
        [Route("rest/api/listarClienteXid")]
        public IHttpActionResult ListarClienteXid(int Id_Cliente)
        {
            return Ok(new csCliente().ListarClienteXid(Id_Cliente));
        }

    }
    
}