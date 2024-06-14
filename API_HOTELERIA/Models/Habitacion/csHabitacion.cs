using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using static API_HOTELERIA.Models.Habitacion.csEstructuraHabitacion;

namespace API_HOTELERIA.Models.Habitacion
{
    public class csHabitacion
    {
        public responseHabitacion insertarHabitacion(int Id_tipo_habitacion, int Numero_habitacion,int Id_hotel, string Estado)
        {
            responseHabitacion result = new responseHabitacion();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "insert into Habitacion(Id_tipo_habitacion,Numero_habitacion,Id_hotel,Estado) values " +
                    "(" + Id_tipo_habitacion + ", " + Numero_habitacion + ", " + Id_hotel + ", '" + Estado + "') ";

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
        public responseHabitacion actualizarHabitacion(int Id_tipo_habitacion, int Numero_habitacion, int Id_hotel, string Estado)
        {
            responseHabitacion result = new responseHabitacion();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "update Habitacion set Id_tipo_habitacion=" + Id_tipo_habitacion + ",Numero_habitacion=" + Numero_habitacion + ",Id_hotel= " + Id_hotel + ",Estado= '" + Estado + "' where Id_tipo_habitacion=" + Id_tipo_habitacion + "";

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
        public responseHabitacion eliminarHabitacion(int Id_tipo_habitacion)
        {
            responseHabitacion result = new responseHabitacion();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "delete from Habitacion where Id_tipo_habitacion =" + Id_tipo_habitacion + "";

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

        public DataSet ListarHabitacion()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "select * from Habitacion";
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
        public DataSet ListarHabitacionXid(int Id_tipo_habitacion)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "select * from Habitacion where Id_tipo_habitacion = " + Id_tipo_habitacion + "";
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