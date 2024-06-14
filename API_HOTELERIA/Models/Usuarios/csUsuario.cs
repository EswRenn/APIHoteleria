using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http.Description;
using static API_HOTELERIA.Models.Habitacion.csEstructuraHabitacion;
using static API_HOTELERIA.Models.Usuarios.csEstructuraUsuario;

namespace API_HOTELERIA.Models.Usuarios
{
    public class csUsuario
    {
        public responseUsuario insertarUsuario(int Id_usuario, string Email, string Password, DateTime Fecha_alta, DateTime Ultimo_acceso, int Id_empleado)
        {
            responseUsuario result = new responseUsuario();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "insert into Usuario(Id_usuario,Email,Password,Fecha_alta,Ultimo_acceso,Id_empleado) values " +
                    "(" + Id_usuario + ", '" + Email + "', '" + Password + "', '" + Fecha_alta + "', '" + Ultimo_acceso + "'," + Id_empleado + "  ) ";

                SqlCommand cmd = new SqlCommand(cadena, con);
                result.respuesta = cmd.ExecuteNonQuery();
                result.descripcion_respuesta = "Operacion realizada exitosamente";

            }catch (Exception ex) {
                result.respuesta = 0;
                result.descripcion_respuesta = "Ocurrio un error al realizar la transaccion, descripcion de error : "+ ex.Message.ToString();   


            }


            con.Close();

            return result;
        }

        public responseUsuario actualizarUsuario(int Id_usuario, string Email, string Password, DateTime Fecha_alta,DateTime Ultimo_acceso, int Id_empleado)
        {
            responseUsuario result = new responseUsuario();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "update Usuario set Id_usuario=" + Id_usuario + ",Email='" + Email + "',Password= '" + Password + "',Fecha_alta='"+Fecha_alta+"',Ultimo_acceso='"+Ultimo_acceso+"',Id_empleado="+Id_empleado+" where Id_usuario=" + Id_usuario + "";

                SqlCommand cmd = new SqlCommand(cadena, con);
                result.respuesta = cmd.ExecuteNonQuery();
                result.descripcion_respuesta = "Operacion realizada exitosamente";

            }
            catch (Exception ex)
            {
                result.respuesta = 0;
                result.descripcion_respuesta = "Ocurrio un error al realizar la transaccion, descripcion de error : " + ex.Message.ToString();


            }


            con.Close();

            return result;
        }
        public responseUsuario eliminarUsuario(int Id_usuario)
        {
            responseUsuario result = new responseUsuario();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "delete from Usuario where Id_usuario =" + Id_usuario + "";

                SqlCommand cmd = new SqlCommand(cadena, con);
                result.respuesta = cmd.ExecuteNonQuery();
                result.descripcion_respuesta = "Operacion realizada exitosamente";

            }
            catch (Exception ex)
            {
                result.respuesta = 0;
                result.descripcion_respuesta = "Ocurrio un error al realizar la transaccion, descripcion de error : " + ex.Message.ToString();


            }


            con.Close();

            return result;
        }

        public DataSet listarUsuario()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "select * from Usuario";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "lista";
                return dsi;
            }
            catch (Exception ex)
            {
                return null;
            }


        }
        public DataSet listarUsuarioXid(int Id_usuario)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "select * from Usuario where Id_usuario = " + Id_usuario + "";
                SqlCommand cmd = new SqlCommand(cadena, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsi);
                dsi.Tables[0].TableName = "lista";
                return dsi;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}