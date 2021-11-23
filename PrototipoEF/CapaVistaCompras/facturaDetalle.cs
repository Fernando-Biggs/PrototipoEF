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
    public partial class facturaDetalle : Form
    {
        public facturaDetalle()
        {
            InitializeComponent();
        }
        clscontrolador log = new clscontrolador();

        private void button1_Click(object sender, EventArgs e)
        {
            string[] valores = { txtDetalle.Text, txtidencabezado.Text, txtdescrip.Text, txtfecja.Text};
            if (log.insertar_facturaD(valores) == null)
            {
                MessageBox.Show("Error al ingresar");
            }
            else
            {
                MessageBox.Show("Datos Agregados a la base de datos", "Insercion de datos");
             

            }
        }

        private void facturaDetalle_Load(object sender, EventArgs e)
        {
            llenarFE();

        }

        public void llenarFE()
        {
            comboBox1.Items.Clear();
            OdbcDataReader datareader = log.llenarFactuasE();
            while (datareader.Read())
            {
               comboBox1.Items.Add(datareader[0].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         ;
            txtidencabezado.Text=comboBox1.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizardatagrid1();
        }

        public void actualizardatagrid1()
        {
            DataTable dt = log.actualizar4();
            dataGridView1.DataSource = dt;
        }

    }
}
