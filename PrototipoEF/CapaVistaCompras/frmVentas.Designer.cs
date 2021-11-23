
namespace CapaVistaCompras
{
    partial class frmVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtidVenta = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTipoPago = new System.Windows.Forms.TextBox();
            this.txtBodega = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvV = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostra = new System.Windows.Forms.Button();
            this.cboPro = new System.Windows.Forms.ComboBox();
            this.cbmTP = new System.Windows.Forms.ComboBox();
            this.bodega = new System.Windows.Forms.ComboBox();
            this.cliente = new System.Windows.Forms.ComboBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.cbmTipoPago = new System.Windows.Forms.ComboBox();
            this.cbmBodega = new System.Windows.Forms.ComboBox();
            this.cbmCliente = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Pago";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bodega";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cliente";
            // 
            // txtidVenta
            // 
            this.txtidVenta.Location = new System.Drawing.Point(118, 85);
            this.txtidVenta.Name = "txtidVenta";
            this.txtidVenta.Size = new System.Drawing.Size(100, 20);
            this.txtidVenta.TabIndex = 9;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(231, 113);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(28, 20);
            this.txtProducto.TabIndex = 10;
            this.txtProducto.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(118, 142);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(118, 172);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 12;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(118, 200);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 13;
            // 
            // txtTipoPago
            // 
            this.txtTipoPago.Location = new System.Drawing.Point(231, 226);
            this.txtTipoPago.Name = "txtTipoPago";
            this.txtTipoPago.Size = new System.Drawing.Size(28, 20);
            this.txtTipoPago.TabIndex = 14;
            this.txtTipoPago.Visible = false;
            // 
            // txtBodega
            // 
            this.txtBodega.Location = new System.Drawing.Point(233, 257);
            this.txtBodega.Name = "txtBodega";
            this.txtBodega.Size = new System.Drawing.Size(26, 20);
            this.txtBodega.TabIndex = 15;
            this.txtBodega.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(232, 295);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(27, 20);
            this.txtCliente.TabIndex = 16;
            this.txtCliente.Visible = false;
            // 
            // dgvV
            // 
            this.dgvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvV.Location = new System.Drawing.Point(314, 63);
            this.dgvV.Name = "dgvV";
            this.dgvV.Size = new System.Drawing.Size(474, 296);
            this.dgvV.TabIndex = 17;
            this.dgvV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvV_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(39, 381);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(540, 12);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(75, 23);
            this.btnMostra.TabIndex = 20;
            this.btnMostra.Text = "Mostrar";
            this.btnMostra.UseVisualStyleBackColor = true;
            this.btnMostra.Click += new System.EventHandler(this.btnMostra_Click);
            // 
            // cboPro
            // 
            this.cboPro.FormattingEnabled = true;
            this.cboPro.Location = new System.Drawing.Point(275, 113);
            this.cboPro.Name = "cboPro";
            this.cboPro.Size = new System.Drawing.Size(30, 21);
            this.cboPro.TabIndex = 22;
            this.cboPro.Visible = false;
            this.cboPro.SelectedIndexChanged += new System.EventHandler(this.cboPro_SelectedIndexChanged);
            // 
            // cbmTP
            // 
            this.cbmTP.FormattingEnabled = true;
            this.cbmTP.Location = new System.Drawing.Point(278, 225);
            this.cbmTP.Name = "cbmTP";
            this.cbmTP.Size = new System.Drawing.Size(30, 21);
            this.cbmTP.TabIndex = 23;
            this.cbmTP.Visible = false;
            // 
            // bodega
            // 
            this.bodega.FormattingEnabled = true;
            this.bodega.Location = new System.Drawing.Point(275, 255);
            this.bodega.Name = "bodega";
            this.bodega.Size = new System.Drawing.Size(30, 21);
            this.bodega.TabIndex = 24;
            this.bodega.Visible = false;
            // 
            // cliente
            // 
            this.cliente.FormattingEnabled = true;
            this.cliente.Location = new System.Drawing.Point(278, 295);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(27, 21);
            this.cliente.TabIndex = 25;
            this.cliente.Visible = false;
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(118, 115);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(100, 21);
            this.cboProducto.TabIndex = 26;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // cbmTipoPago
            // 
            this.cbmTipoPago.FormattingEnabled = true;
            this.cbmTipoPago.Location = new System.Drawing.Point(118, 228);
            this.cbmTipoPago.Name = "cbmTipoPago";
            this.cbmTipoPago.Size = new System.Drawing.Size(100, 21);
            this.cbmTipoPago.TabIndex = 27;
            this.cbmTipoPago.SelectedIndexChanged += new System.EventHandler(this.cbmTipoPago_SelectedIndexChanged);
            // 
            // cbmBodega
            // 
            this.cbmBodega.FormattingEnabled = true;
            this.cbmBodega.Location = new System.Drawing.Point(118, 256);
            this.cbmBodega.Name = "cbmBodega";
            this.cbmBodega.Size = new System.Drawing.Size(100, 21);
            this.cbmBodega.TabIndex = 28;
            this.cbmBodega.SelectedIndexChanged += new System.EventHandler(this.cbmBodega_SelectedIndexChanged);
            // 
            // cbmCliente
            // 
            this.cbmCliente.FormattingEnabled = true;
            this.cbmCliente.Location = new System.Drawing.Point(118, 294);
            this.cbmCliente.Name = "cbmCliente";
            this.cbmCliente.Size = new System.Drawing.Size(100, 21);
            this.cbmCliente.TabIndex = 29;
            this.cbmCliente.SelectedIndexChanged += new System.EventHandler(this.cbmCliente_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Reportes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbmCliente);
            this.Controls.Add(this.cbmBodega);
            this.Controls.Add(this.cbmTipoPago);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.bodega);
            this.Controls.Add(this.cbmTP);
            this.Controls.Add(this.cboPro);
            this.Controls.Add(this.btnMostra);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvV);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtBodega);
            this.Controls.Add(this.txtTipoPago);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtidVenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtidVenta;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTipoPago;
        private System.Windows.Forms.TextBox txtBodega;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvV;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.ComboBox cboPro;
        private System.Windows.Forms.ComboBox cbmTP;
        private System.Windows.Forms.ComboBox bodega;
        private System.Windows.Forms.ComboBox cliente;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.ComboBox cbmTipoPago;
        private System.Windows.Forms.ComboBox cbmBodega;
        private System.Windows.Forms.ComboBox cbmCliente;
        private System.Windows.Forms.Button button1;
    }
}