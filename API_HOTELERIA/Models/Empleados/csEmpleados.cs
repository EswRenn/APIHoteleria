using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using static API_HOTELERIA.Models.Empleados.csEstructuraEmpleado;
using static API_HOTELERIA.Models.Tipo_habitacion.csEstructuraTipo_habitacion;

namespace API_HOTELERIA.Models.Empleados
{
    public class csEmpleados
    {
        public responseEmpleado insertarEmpleado(int Id_empleado, string Nombre, string Apellidos, int No_identificacion, string Domicilio, int Telefono, string Puesto, DateTime Fecha_ingreso, string Email, int Id_hotel)
        {
            responseEmpleado result = new responseEmpleado();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "insert into Empleado(Id_empleado,Nombre,Apellidos,No_identificacion,Domicilio,Telefono,Puesto,Fecha_ingreso,Email,Id_hotel) values " +
                    "(" + Id_empleado + ", '" + Nombre + "', '" + Apellidos + "', " + No_identificacion + ", '" + Domicilio + "'," + Telefono + ", '" + Puesto + "', '" + Fecha_ingreso + "', '" + Email + "', " + Id_hotel + "  ) ";

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


        public responseEmpleado actualizarEmpleados(int Id_empleado, string Nombre, string Apellidos, int No_identificacion, string Domicilio,int Telefono, string Puesto, DateTime Fecha_ingreso, string Email, int Id_hotel)
        {
            responseEmpleado result = new responseEmpleado();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "update Empleado set Id_empleado=" + Id_empleado + ",Nombre='" + Nombre + "',Apellidos= '" + Apellidos + "',No_identificacion="+ No_identificacion +", Domicilio ='"+Domicilio+"',Telefono ="+Telefono+",Puesto='"+Puesto+"',Fecha_ingreso='"+Fecha_ingreso+"',Email='"+Email+"',Id_hotel="+Id_hotel+" where Id_empleado=" + Id_empleado + "";

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
        public responseEmpleado eliminarEmpleados(int Id_empleado)
        {
            responseEmpleado result = new responseEmpleado();
            string conexion = "";
            SqlConnection con = null;

            try
            {
                conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
                con = new SqlConnection(conexion);
                con.Open();


                string cadena = "delete from Empleado where Id_Empleado =" + Id_empleado + "";

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

        public DataSet ListarEmpleados()
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "select * from Empleado";
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
        public DataSet ListarEmpleadosXid(int Id_empleado)
        {
            DataSet dsi = new DataSet();
            string conexion = ConfigurationManager.ConnectionStrings["cnConection"].ConnectionString;
            SqlConnection con = new SqlConnection(conexion);
            con.Open();

            try
            {
                string cadena = "select * from Empleado where Id_empleado = " + Id_empleado + "";
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