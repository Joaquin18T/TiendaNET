
namespace DESIGNER.Modulos
{
    partial class frmUsuario
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
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optInvitado = new System.Windows.Forms.RadioButton();
            this.optAdministrador = new System.Windows.Forms.RadioButton();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.AllowUserToAddRows = false;
            this.gridUsuarios.AllowUserToDeleteRows = false;
            this.gridUsuarios.AllowUserToResizeColumns = false;
            this.gridUsuarios.AllowUserToResizeRows = false;
            this.gridUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Location = new System.Drawing.Point(21, 117);
            this.gridUsuarios.MultiSelect = false;
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.ReadOnly = true;
            this.gridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsuarios.Size = new System.Drawing.Size(1017, 305);
            this.gridUsuarios.TabIndex = 2;
            this.gridUsuarios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridUsuarios_DataBindingComplete);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optInvitado);
            this.groupBox1.Controls.Add(this.optAdministrador);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // optInvitado
            // 
            this.optInvitado.AutoSize = true;
            this.optInvitado.Checked = true;
            this.optInvitado.Location = new System.Drawing.Point(667, 70);
            this.optInvitado.Name = "optInvitado";
            this.optInvitado.Size = new System.Drawing.Size(80, 21);
            this.optInvitado.TabIndex = 9;
            this.optInvitado.TabStop = true;
            this.optInvitado.Text = "Invitado";
            this.optInvitado.UseVisualStyleBackColor = true;
            this.optInvitado.CheckedChanged += new System.EventHandler(this.optInvitado_CheckedChanged);
            // 
            // optAdministrador
            // 
            this.optAdministrador.AutoSize = true;
            this.optAdministrador.Location = new System.Drawing.Point(667, 39);
            this.optAdministrador.Name = "optAdministrador";
            this.optAdministrador.Size = new System.Drawing.Size(116, 21);
            this.optAdministrador.TabIndex = 8;
            this.optAdministrador.Text = "Administrador";
            this.optAdministrador.UseVisualStyleBackColor = true;
            this.optAdministrador.CheckedChanged += new System.EventHandler(this.optAdministrador_CheckedChanged);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(386, 71);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(249, 23);
            this.txtClave.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(386, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Clave:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(92, 71);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(185, 23);
            this.txtNombres.TabIndex = 3;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(92, 28);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(185, 23);
            this.txtApellidos.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 54);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(1026, 23);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba el nombre del usuario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(870, 483);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(870, 541);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(108, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(870, 512);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 593);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridUsuarios);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optInvitado;
        private System.Windows.Forms.RadioButton optAdministrador;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}