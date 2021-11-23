using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorCompras;

namespace CapaVistaCompras
{
    public partial class FacturaEncabezado : Form
    {
        public FacturaEncabezado()
        {
            InitializeComponent();
        }
        clscontrolador log = new clscontrolador();
        private void FacturaEncabezado_Load(object sender, EventArgs e)
        {
            lenarVentas();
            llenarcombocliente();
        }

        public void lenarVentas()
        {
            cboVentas.Items.Clear();
            OdbcDataReader datareader = log.llenarventas();
            while (datareader.Read())
            {
                cboVentas.Items.Add(datareader[0].ToString());
                comboBox1.Items.Add(datareader[0].ToString());
            }
        }

        private void cboVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtidVenta.Text = cboVentas.SelectedItem.ToString();
          
        }

        

        public void llenarcombocliente()
        {
            cboVentas.Items.Clear();
            OdbcDataReader datareader = log.llenarcliente();
            while (datareader.Read())
            {
                cliente.Items.Add(datareader[0].ToString());
                cbmCliente.Items.Add(datareader[1].ToString());
            }
        }

        private void cbmCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            cliente.SelectedIndex = cbmCliente.SelectedIndex;
            txtCliente.Text = cliente.SelectedItem.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] valores = { txtIDFactura.Text, txtidVenta.Text, txtCliente.Text, txtFecha.Text, txtTotal.Text };
            if (log.insertar_facturaE(valores) == null)
            {
                MessageBox.Show("Error al ingresar");
            }
            else
            {
                MessageBox.Show("Datos Agregados a la base de datos", "Insercion de datos");
                txtidVenta.Text = "";
                txtIDFactura.Text = "";
                cboVentas.Text = "";
             
                txtFecha.Text = "";
                txtTotal.Text = "";
            
                txtCliente.Text = "";
             
                cbmCliente.Text = "";
               
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtidVenta.Text = comboBox1.SelectedItem.ToString();
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            actualizardatagrid1();
        }
        public void actualizardatagrid1()
        {
            DataTable dt = log.actualizar3();
            dgvV.DataSource = dt;
        }
    }
}
