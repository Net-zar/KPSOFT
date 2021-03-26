using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using System.Data;
using CEntidades;
namespace CNegocios
{
   public class NProceso_Fabricacion
    {

        public static string Insertar_Proceso()
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();

            return Datos.Insertar_Proceso();

        }

        public static DataTable Cmb_tarea()
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            return Datos.Cmb_tarea();
        }

        public static DataTable Cmb_asociacion()
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            return Datos.Cmb_Asociacion();
        }

        public static DataTable Cmb_usuario_uno()
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            return Datos.Cmb_Control_uno();
        }

        public static DataTable Cmb_usuario_dos()
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            return Datos.Cmb_Control_dos();
        }


        public static string Actualizadatosproceso(int realiza, DateTime fecha, int nro_fabricacion)
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            EProceso_Fabricacion obj = new EProceso_Fabricacion();
            obj.Realiza = realiza;
            obj.Fecha = fecha;
            obj.Nro_Fabricacion = nro_fabricacion;
            return Datos.Actualizadatosproceso(obj);
        }

        public static DataTable ListarProceso(int id)
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            return Datos.ListarProceso(id);
        }

        public static string ActualizaControlUno(int idfabricacion, int idTarea,int controlUno ,DateTime fecha, string notas)
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            EProceso_Fabricacion obj = new EProceso_Fabricacion();
            obj.Nro_Fabricacion = idfabricacion;
            obj.Tarea_Id = idTarea;
            obj.ControlUno = controlUno;
            obj.Fecha = fecha;
            obj.Notas = notas;

            return Datos.ActualizaControlUno(obj);
        }
        public static string ActualizaControlDos(int idfabricacion, int idTarea, int controlDos, DateTime fecha, string notas)
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            EProceso_Fabricacion obj = new EProceso_Fabricacion();
            obj.Nro_Fabricacion = idfabricacion;
            obj.Tarea_Id = idTarea;
            obj.ControlDos = controlDos;
            obj.Fecha = fecha;
            obj.Notas = notas;

            return Datos.ActualizaControlDos(obj);
        }
    }
}
