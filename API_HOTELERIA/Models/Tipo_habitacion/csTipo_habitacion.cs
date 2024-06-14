using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static API_HOTELERIA.Models.Habitacion.csEstructuraHabitacion;
using static API_HOTELERIA.Models.Tipo_habitacion.csEstructuraTipo_habitacion;

namespace API_HOTELERIA.Models.Tipo_habitacion
{
    public class csTipo_habitacion
    {
        public responseTipo_habitacion insertarTipo_habitacion(int Id_tipo_habitacion, string Descripcion, int Capacidad_personas, int Precio)
        {
            responseTipo_habitacion result = new responseTipo_habitacion();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "insert into Tipo_habitacion(Id_tipo_habitacion,Descripcion,Capacidad_personas,Precio) values " +
                    "(" + Id_tipo_habitacion + ", '" + Descripcion + "', " + Capacidad_personas + ", " + Precio + ") ";

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
        public responseTipo_habitacion actualizarTipo_habitacion(int Id_tipo_habitacion, string Descripcion, int Capacidad_personas, int Precio)
        {
            responseTipo_habitacion result = new responseTipo_habitacion();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "update Tipo_habitacion set Id_tipo_habitacion=" + Id_tipo_habitacion + ",Descripcion='" + Descripcion + "',Capacidad_personas= " + Capacidad_personas + ",Precio=" + Precio + " where Id_tipo_habitacion=" + Id_tipo_habitacion + "";

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
        public responseTipo_habitacion eliminarTipo_habitacion(int Id_tipo_habitacion)
        {
            responseTipo_habitacion result = new responseTipo_habitacion();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "delete from Tipo_habitacion where Id_tipo_habitacion =" + Id_tipo_habitacion + "";

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

        public DataSet ListarTipo_habitacion()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "select * from Tipo_habitacion";
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
        public DataSet ListarTipo_habitacionXid(int Id_tipo_habitacion)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "select * from Tipo_habitacion where Id_tipo_habitacion = " + Id_tipo_habitacion + "";
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