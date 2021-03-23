﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CDatos
{
    public class DProceso_Fabricacion
    {

        public DataTable Cmb_tarea()
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("cmb_tarea", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                Con.Open();
                Dr = cmd.ExecuteReader();
                Dt.Load(Dr);
                return Dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }

        public DataTable Cmb_Asociacion()
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("cmb_asociacion", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                Con.Open();
                Dr = cmd.ExecuteReader();
                Dt.Load(Dr);

              
                return Dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }

        public DataTable Cmb_Control_uno()
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("cmb_usuario_uno", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                Con.Open();
                Dr = cmd.ExecuteReader();
                Dt.Load(Dr);
                return Dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }

        public DataTable Cmb_Control_dos()
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("cmb_usuario_dos", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                Con.Open();
                Dr = cmd.ExecuteReader();
                Dt.Load(Dr);
                return Dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }
        public string Insertar_Proceso()
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("NUEVO_PROCESO", Con);
                cmd.CommandType = CommandType.StoredProcedure;
             

                Con.Open();
                 rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
            return rpta;

        }

        public string Actualizadatosproceso(EProceso_Fabricacion obj)
        {
            
            string rpta3 = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("ot_proceso_actualiza", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@realiza", SqlDbType.Int).Value = obj.Realiza;
                cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = obj.Fecha;
                cmd.Parameters.Add("@NRO_FABRICACION", SqlDbType.Int).Value = obj.Nro_Fabricacion;

                Con.Open();
                rpta3 = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";


            }
            catch (Exception ex)
            {
                rpta3 = ex.Message;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
            return rpta3;

        }

        public DataTable ListarProceso(int id)
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("proceso_fabricacion_asociado", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                Con.Open();
                Dr = cmd.ExecuteReader();
                Dt.Load(Dr);
                return Dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }

    }
}

