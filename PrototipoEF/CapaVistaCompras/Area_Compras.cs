using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;
using CapaVista;
using CapaVistaReporte;

namespace CapaVistaCompras
{
    public partial class MDI_Prototipo_EF : Form
    {        

        public MDI_Prototipo_EF()
        {
            InitializeComponent();
        }

        private void Area_Compras_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtusuario.Text = form.usuario();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtusuario.Text = form.usuario();
                this.Show();
            }
            else
            { this.Close();
                txtusuario.Text = "";
                this.Close();
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultasInteligentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuconsultas formulario = new menuconsultas();
            formulario.Show();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteadorAdmin formulario = new ReporteadorAdmin();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void moduloDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMIDSeguridad formulario = new frmMIDSeguridad();
            formulario.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVentas frm = new frmVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventasEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaEncabezado frm = new FacturaEncabezado();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventasDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facturaDetalle frm = new facturaDetalle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aYUDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AYUDAS form = new AYUDAS();
            form.MdiParent = this;
            form.Show();
        }
    }
}
