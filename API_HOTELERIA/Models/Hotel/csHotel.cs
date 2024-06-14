using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static API_HOTELERIA.Models.Empleados.csEstructuraEmpleado;
using static API_HOTELERIA.Models.Hotel.csEstructuraHotel.requestHotel;


namespace API_HOTELERIA.Models.Hotel
{
    public class csHotel
    {

        public responseHotel insertarHotel(int Id_hotel, string Nombre, string Descripcion,string Categoria, string Direccion, int Cod_postal,int Telefono, int Numero_habitacion, int Id_empleados)
        {
            responseHotel result = new responseHotel();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "insert into Hotel(Id_hotel,Nombre,Descripcion,Categoria,Direccion,Cod_postal,Telefono,Numero_habitacion,Id_empleados) values " +
                    "(" + Id_hotel + ", '" + Nombre + "', '" + Descripcion + "', '" + Categoria + "', '" + Direccion + "'," + Cod_postal + ", " + Telefono + ", " + Numero_habitacion + ", " + Id_empleados + "  ) ";

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

        public responseHotel actualizarHotel(int Id_hotel, string Nombre,string Descripcion,string Categoria,string Direccion, int Cod_postal, int Telefono, int Numero_habitacion, int Id_empleados)
        {
            responseHotel result = new responseHotel();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "update Hotel set Id_hotel=" + Id_hotel + ",Nombre='" + Nombre + "',Descripcion= '" + Descripcion + "',Categoria='" + Categoria + "',Direccion='"+Direccion+"', Cod_postal =" + Cod_postal + ",Telefono =" + Telefono + ",Numero_habitacion=" + Numero_habitacion + ",Id_empleados=" + Id_empleados + " where Id_hotel=" + Id_hotel + "";

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
        public responseHotel eliminarHotel(int Id_hotel)
        {
            responseHotel result = new responseHotel();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "delete from Hotel where Id_hotel =" + Id_hotel + "";

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

        public DataSet ListarHotel()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "select * from Hotel";
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
        public DataSet ListarHotelXid(int Id_hotel)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "select * from Hotel where Id_hotel = " + Id_hotel + "";
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