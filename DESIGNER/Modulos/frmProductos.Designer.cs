
namespace DESIGNER.Modulos
{
    partial class frmProductos
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
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.GbDatos = new System.Windows.Forms.GroupBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnXls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.GbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(12, 65);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(1043, 417);
            this.gridProductos.TabIndex = 0;
            this.gridProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellContentClick);
            this.gridProductos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridProductos_DataBindingComplete);
            // 
            // GbDatos
            // 
            this.GbDatos.Controls.Add(this.txtStock);
            this.GbDatos.Controls.Add(this.txtPrecio);
            this.GbDatos.Controls.Add(this.txtGarantia);
            this.GbDatos.Controls.Add(this.txtDescripcion);
            this.GbDatos.Controls.Add(this.label7);
            this.GbDatos.Controls.Add(this.cbSubCategoria);
            this.GbDatos.Controls.Add(this.cbCategoria);
            this.GbDatos.Controls.Add(this.cbMarca);
            this.GbDatos.Controls.Add(this.label4);
            this.GbDatos.Controls.Add(this.label3);
            this.GbDatos.Controls.Add(this.label2);
            this.GbDatos.Controls.Add(this.label6);
            this.GbDatos.Controls.Add(this.label5);
            this.GbDatos.Controls.Add(this.label1);
            this.GbDatos.Location = new System.Drawing.Point(46, 525);
            this.GbDatos.Name = "GbDatos";
            this.GbDatos.Size = new System.Drawing.Size(749, 193);
            this.GbDatos.TabIndex = 1;
            this.GbDatos.TabStop = false;
            this.GbDatos.Text = "Datos del Producto";
            this.GbDatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(512, 146);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(106, 23);
            this.txtStock.TabIndex = 4;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(512, 104);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(106, 23);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtGarantia
            // 
            this.txtGarantia.Location = new System.Drawing.Point(512, 66);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(106, 23);
            this.txtGarantia.TabIndex = 4;
            this.txtGarantia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGarantia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(157, 29);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(399, 23);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Descripcion:";
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(117, 146);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(212, 25);
            this.cbSubCategoria.TabIndex = 1;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(117, 107);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(212, 25);
            this.cbCategoria.TabIndex = 1;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(117, 66);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(212, 25);
            this.cbMarca.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subcategoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Garantia:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(872, 535);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(872, 567);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(872, 605);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(872, 641);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(112, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(935, 674);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(49, 23);
            this.btnPdf.TabIndex = 2;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnXls
            // 
            this.btnXls.Location = new System.Drawing.Point(872, 674);
            this.btnXls.Name = "btnXls";
            this.btnXls.Size = new System.Drawing.Size(49, 23);
            this.btnXls.TabIndex = 2;
            this.btnXls.Text = "XLS";
            this.btnXls.UseVisualStyleBackColor = true;
            this.btnXls.Click += new System.EventHandler(this.btnXls_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 752);
            this.Controls.Add(this.btnXls);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.GbDatos);
            this.Controls.Add(this.gridProductos);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.GbDatos.ResumeLayout(false);
            this.GbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.GroupBox GbDatos;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnXls;
    }
}