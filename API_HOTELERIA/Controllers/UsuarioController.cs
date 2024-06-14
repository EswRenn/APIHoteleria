using API_HOTELERIA.Models.Habitacion;
using API_HOTELERIA.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using static API_HOTELERIA.Models.Habitacion.csEstructuraHabitacion;
using static API_HOTELERIA.Models.Usuarios.csEstructuraUsuario;

namespace API_HOTELERIA.Controllers
{
    public class UsuarioController : ApiController
    {

        [HttpPost]
        [Route("rest/api/insertarUsuario")]
        public IHttpActionResult insertarUsuario(requestUsuario models)
        {
            return Ok(new csUsuario().insertarUsuario(models.Id_usuario,models.Email,models.Password,models.Fecha_alta, models.Ultimo_acceso,models.Id_empleado));
            
        }

        [HttpPost]
        [Route("rest/api/actualizarUsuario")]
        public IHttpActionResult actualizarUsuario(requestUsuario models)
        {
            return Ok(new csUsuario().actualizarUsuario(models.Id_usuario, models.Email, models.Password, models.Fecha_alta,models.Ultimo_acceso,models.Id_empleado));
        }

        [HttpPost]
        [Route("rest/api/eliminarUsuario")]
        public IHttpActionResult eliminarUsuario(requestUsuario models)
        {
            return Ok(new csUsuario().eliminarUsuario(models.Id_usuario));
        }

        [HttpGet]
        [Route("rest/api/listarUsuario")]
        public IHttpActionResult listarUsuario()
        {
            return Ok(new csUsuario().listarUsuario());
        }

        [HttpGet]
        [Route("rest/api/listarUsuarioXid")]
        public IHttpActionResult ListarUsuarioXid(int Id_usuario)
        {
            return Ok(new csUsuario().listarUsuarioXid(Id_usuario));
        }

    }
}