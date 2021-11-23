using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloCompras
{
    public class clssentencias
    {
        clsconexion cn = new clsconexion(); //crear objeto
        OdbcCommand com; //variable para querys

        public OdbcDataReader insertar_bodegas(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO bodegas Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_linea(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO linea Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_marca(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO marca Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader llenarPr()
        {
            try
            {
                string sql = "SELECT pkid,Nombre from producto";
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter llenardvgFD()
        {
            string sql = "SELECT * from ventas";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, cn.conexion());
            return datatable;
        }

        public OdbcDataReader llenarTPP()
        {
            try
            {
                string sql = "SELECT id_tipo_pago, descripcion from tipo_pago";
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public OdbcDataReader llenarbod()
        {
            try
            {
                string sql = "SELECT pkid, nombre from bodega";
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public OdbcDataReader llenarcli()
        {
            try
            {
                string sql = "SELECT Pkid, nombre from cliente";
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_v(string[] datos)
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO ventas Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "','" + datos[7] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader llenarV()
        {
            try
            {
                string sql = "SELECT id_venta from ventas";
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public OdbcDataReader insertar_facE(string[] datos)
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO facturasencabezadoventas Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataAdapter llenarfacturaE()
        {
            string sql = "SELECT * from facturasencabezadoventas";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, cn.conexion());
            return datatable;
        }

        public OdbcDataReader llenarF()
        {
            try
            {
                string sql = "SELECT id_encabezado from facturasencabezadoventas";
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter llenarfacturaD()
        {
            string sql = "SELECT * from facturadetalleventas";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, cn.conexion());
            return datatable;
        }

        public OdbcDataReader insertar_facD(string[] datos)
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO facturadetalleventas Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "');";
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
    }
}
