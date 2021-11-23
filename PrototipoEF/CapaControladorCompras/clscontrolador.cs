using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModeloCompras;

namespace CapaControladorCompras
{
    public class clscontrolador
    {
        //Instanciamos la clase sentencias

        clssentencias sn = new clssentencias();
                public OdbcDataReader insertar_bodegas(string[] dato)
                {
                    return sn.insertar_bodegas(dato);
                }
                public OdbcDataReader insertar_linea(string[] dato)
                {
                    return sn.insertar_linea(dato);
                }
                public OdbcDataReader insertar_marca(string[] dato)
                {
                    return sn.insertar_marca(dato);
                }

        public OdbcDataReader llenarProducto()
        {
            return sn.llenarPr();
        }

        public DataTable actualizar2()
        {
            OdbcDataAdapter dt = sn.llenardvgFD();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable actualizar3()
        {
            OdbcDataAdapter dt = sn.llenarfacturaE();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable actualizar4()
        {
            OdbcDataAdapter dt = sn.llenarfacturaD();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public OdbcDataReader llenartp()
        {
            return sn.llenarTPP();
        }
        public OdbcDataReader llenarbodega()
        {
            return sn.llenarbod();
        }
        public OdbcDataReader llenarcliente()
        {
            return sn.llenarcli();
        }

        public OdbcDataReader insertar_venta(string[] dato)
        {
            return sn.insertar_v(dato);
        
        }

        public OdbcDataReader insertar_facturaE(string[] dato)
        {
            return sn.insertar_facE(dato);
        }

        public OdbcDataReader llenarventas()
        {
            return sn.llenarV();
        }

        public OdbcDataReader llenarFactuasE()
        {
            return sn.llenarF();
        }

        public OdbcDataReader insertar_facturaD(string[] dato)
        {
            return sn.insertar_facD(dato);
        }
    }
}
