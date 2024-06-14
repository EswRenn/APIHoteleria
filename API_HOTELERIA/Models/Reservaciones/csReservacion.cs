using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static API_HOTELERIA.Models.Habitacion.csEstructuraHabitacion;
using static API_HOTELERIA.Models.Reservaciones.csEstructuraReservacion;

namespace API_HOTELERIA.Models.Reservaciones
{
    public class csReservacion
    {
        public responseReservacion insertarReservacion(int Id_reservacion, DateTime Fecha_inicio, DateTime Fecha_fin, int Costo_total,string Estado_reservacion, int Numero_habitacion, int Id_cliente, int Id_usuario, int id_hotel)
        {
            responseReservacion result = new responseReservacion();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "insert into Reservacion(Id_reservacion,Fecha_inicio,Fecha_fin,Costo_total,Estado_reservacion,Numero_habitacion,Id_cliente,Id_usuario,id_hotel) values " +
                    "(" + Id_reservacion + ", '" + Fecha_inicio + "', '" + Fecha_fin + "', " + Costo_total + ", '" + Estado_reservacion + "', " + Numero_habitacion + ", " + Id_cliente + ", " + Id_usuario + ", "+id_hotel+") ";

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

        public responseReservacion actualizarReservacion(int Id_reservacion, DateTime Fecha_inicio, DateTime Fecha_fin, int Costo_total,string Estado_reservacion,int Numero_habitacion,int Id_cliente,int Id_usuario,int id_hotel)
        {
            responseReservacion result = new responseReservacion();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "update Reservacion set Id_reservacion=" + Id_reservacion + ",Fecha_inicio= '" + Fecha_inicio + "',Fecha_fin= '" + Fecha_fin + "',Costo_total= " + Costo_total + ",Estado_reservacion='"+Estado_reservacion+"',Numero_habitacion="+Numero_habitacion+",Id_cliente="+Id_cliente+",Id_usuario="+Id_usuario+", id_hotel="+id_hotel+" where Id_reservacion=" + Id_reservacion + "";

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
        public responseReservacion eliminarReservacion(int Id_reservacion)
        {
            responseReservacion result = new responseReservacion();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "delete from Reservacion where Id_reservacion =" + Id_reservacion + "";

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

        public DataSet ListarReservacion()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "select * from Reservacion";
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
        public DataSet listarReservacionXid(int Id_reservacion)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "select * from Reservacion where Id_reservacion = " + Id_reservacion + "";
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