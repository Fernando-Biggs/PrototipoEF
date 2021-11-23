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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        clscontrolador log = new clscontrolador();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] valores = { txtidVenta.Text, txtProducto.Text, txtCantidad.Text, txtFecha.Text, txtTotal.Text, txtTipoPago.Text, txtBodega.Text, txtCliente.Text };
            if (log.insertar_venta(valores) == null)
            {
                MessageBox.Show("Error al ingresar");
            }
            else
            {
                MessageBox.Show("Datos Agregados a la base de datos", "Insercion de datos");
                txtidVenta.Text = "";
                txtProducto.Text = "";
                txtCantidad.Text = "";
                txtFecha.Text = "";
                txtTotal.Text = "";
                txtTipoPago.Text = "";
                txtBodega.Text = "";
                txtCliente.Text = "";
                cbmBodega.Text = "";
                cbmCliente.Text = "";
                cbmTipoPago.Text = "";
                cboProducto.Text = "";
            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            llenarcomboProducto();
            llenarcomboProducto2();
            llenarcomboProducto3();
            llenarcomboProducto4();
        }

        public void llenarcomboProducto()
        {
            cboProducto.Items.Clear();
            OdbcDataReader datareader = log.llenarProducto();
            while (datareader.Read())
            {
                cboPro.Items.Add(datareader[0].ToString());
                cboProducto.Items.Add(datareader[1].ToString());
            }
        }

        public void llenarcomboProducto2()
        {
            cbmTipoPago.Items.Clear();
            OdbcDataReader datareader = log.llenartp();
            while (datareader.Read())
            {
                cbmTP.Items.Add(datareader[0].ToString());
                cbmTipoPago.Items.Add(datareader[1].ToString());
            }
        }

        public void llenarcomboProducto3()
        {
            cbmBodega.Items.Clear();
            OdbcDataReader datareader = log.llenarbodega();
            while (datareader.Read())
            {
                bodega.Items.Add(datareader[0].ToString());
                cbmBodega.Items.Add(datareader[1].ToString());
            }
        }

        public void llenarcomboProducto4()
        {
            cbmCliente.Items.Clear();
            OdbcDataReader datareader = log.llenarcliente();
            while (datareader.Read())
            {
                cliente.Items.Add(datareader[0].ToString());
                cbmCliente.Items.Add(datareader[1].ToString());
            }
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPro.SelectedIndex = cboProducto.SelectedIndex;
            txtProducto.Text = cboPro.SelectedItem.ToString();
        }

        public void actualizardatagrid1()
        {
            DataTable dt = log.actualizar2();
            dgvV.DataSource = dt;
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            actualizardatagrid1();
        }

        private void cbmTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmTP.SelectedIndex = cbmTipoPago.SelectedIndex;
            txtTipoPago.Text = cbmTP.SelectedItem.ToString();
        }

        private void cbmBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            bodega.SelectedIndex = cbmBodega.SelectedIndex;
            txtBodega.Text = bodega.SelectedItem.ToString();
        }

        private void cbmCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliente.SelectedIndex = cbmCliente.SelectedIndex;
            txtCliente.Text = cliente.SelectedItem.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cboPro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportesVentas form = new reportesVentas();
            form.Show();
        }
    }
}
