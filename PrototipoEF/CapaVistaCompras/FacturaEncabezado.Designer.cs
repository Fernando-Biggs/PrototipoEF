
namespace CapaVistaCompras
{
    partial class FacturaEncabezado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbmCliente = new System.Windows.Forms.ComboBox();
            this.cliente = new System.Windows.Forms.ComboBox();
            this.btnMostra = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvV = new System.Windows.Forms.DataGridView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtidVenta = new System.Windows.Forms.TextBox();
            this.cboVentas = new System.Windows.Forms.ComboBox();
            this.txtIDFactura = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmCliente
            // 
            this.cbmCliente.FormattingEnabled = true;
            this.cbmCliente.Location = new System.Drawing.Point(343, 111);
            this.cbmCliente.Name = "cbmCliente";
            this.cbmCliente.Size = new System.Drawing.Size(100, 21);
            this.cbmCliente.TabIndex = 59;
            this.cbmCliente.SelectedIndexChanged += new System.EventHandler(this.cbmCliente_SelectedIndexChanged);
            // 
            // cliente
            // 
            this.cliente.FormattingEnabled = true;
            this.cliente.Location = new System.Drawing.Point(500, 112);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(27, 21);
            this.cliente.TabIndex = 55;
            this.cliente.Visible = false;
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(410, 534);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(75, 23);
            this.btnMostra.TabIndex = 50;
            this.btnMostra.Text = "Mostrar";
            this.btnMostra.UseVisualStyleBackColor = true;
            this.btnMostra.Click += new System.EventHandler(this.btnMostra_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(601, 106);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 48;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvV
            // 
            this.dgvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvV.Location = new System.Drawing.Point(12, 232);
            this.dgvV.Name = "dgvV";
            this.dgvV.Size = new System.Drawing.Size(885, 296);
            this.dgvV.TabIndex = 47;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(449, 112);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(27, 20);
            this.txtCliente.TabIndex = 46;
            this.txtCliente.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(343, 166);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 43;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(343, 138);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Id Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Facturas Encabezado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 60;
            this.label10.Text = "Id Factura Encabezadoi";
            // 
            // txtidVenta
            // 
            this.txtidVenta.Location = new System.Drawing.Point(476, 85);
            this.txtidVenta.Name = "txtidVenta";
            this.txtidVenta.Size = new System.Drawing.Size(24, 20);
            this.txtidVenta.TabIndex = 39;
            this.txtidVenta.Visible = false;
            // 
            // cboVentas
            // 
            this.cboVentas.FormattingEnabled = true;
            this.cboVentas.Location = new System.Drawing.Point(731, 59);
            this.cboVentas.Name = "cboVentas";
            this.cboVentas.Size = new System.Drawing.Size(100, 21);
            this.cboVentas.TabIndex = 62;
            this.cboVentas.Visible = false;
            this.cboVentas.SelectedIndexChanged += new System.EventHandler(this.cboVentas_SelectedIndexChanged);
            // 
            // txtIDFactura
            // 
            this.txtIDFactura.Location = new System.Drawing.Point(342, 59);
            this.txtIDFactura.Name = "txtIDFactura";
            this.txtIDFactura.Size = new System.Drawing.Size(98, 20);
            this.txtIDFactura.TabIndex = 63;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(342, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 64;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 65;
            this.button1.Text = "Reportes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FacturaEncabezado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtIDFactura);
            this.Controls.Add(this.cboVentas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbmCliente);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.btnMostra);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvV);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtidVenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FacturaEncabezado";
            this.Text = "FacturaEncabezado";
            this.Load += new System.EventHandler(this.FacturaEncabezado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmCliente;
        private System.Windows.Forms.ComboBox cliente;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvV;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtidVenta;
        private System.Windows.Forms.ComboBox cboVentas;
        private System.Windows.Forms.TextBox txtIDFactura;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}