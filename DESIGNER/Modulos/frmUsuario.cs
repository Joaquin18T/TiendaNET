using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CryptSharp;       //Encriptar
using BOL;              //Logica
using ENTITIES;         //Estructura
using DESIGNER.Tools;   //Herramientas

namespace DESIGNER.Modulos
{
    public partial class frmUsuario : Form
    {
        //Objeto "usuario" contiene las funciones/logica => Registrar, Listar, Eliminar, etc.
        Usuario usuario = new Usuario();

        //Objeto "entUsuario" contiene los datos => apellidos, nombres, email, clave, etc.
        EUsuario entUsuario = new EUsuario();
        string nivelAcceso = "INV";

        //Reservado un espacio de memoria para el objeto(Vista de Datos)  - BUSCAR REGISTROS
        DataView dv;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Aviso.Preguntar("¿Estas seguro de guardar?") == DialogResult.Yes)
            {
                string claveEncriptada = Crypter.Blowfish.Crypt(txtClave.Text.Trim());
                entUsuario.apellidos = txtApellidos.Text;
                entUsuario.nombres = txtNombres.Text;
                entUsuario.email = txtEmail.Text;
                entUsuario.claveacceso = claveEncriptada;
                entUsuario.nivelAcceso = nivelAcceso;
                
                if (usuario.Registrar(entUsuario)>0)
                {
                    ReiniciarInterfaz();
                    actualizarDatos(); //Actualiza el DATAGRIDVIEW
                    Aviso.Imformar("Nuevo usuario registrado");
                }
                else
                {
                    Aviso.Imformar("No hemos podido terminar el registro");
                }
                
                
            }
        }

        private void actualizarDatos()
        {
            dv = new DataView (usuario.Listar());
            gridUsuarios.DataSource = dv;
            gridUsuarios.Refresh();

            gridUsuarios.Columns[0].Visible = false; //ID
            gridUsuarios.Columns[4].Visible = false; //Clave

            gridUsuarios.Columns[1].Width = 200; //Apellidos
            gridUsuarios.Columns[2].Width = 200; //Nombres
            gridUsuarios.Columns[3].Width = 200; //Email
            gridUsuarios.Columns[5].Width = 200; //Nivelacceso
            //gridUsuarios.Enabled = false;

            //Filas cebreadas (cambiar el color)
            gridUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
        private void ReiniciarInterfaz()
        {
            txtApellidos.Clear();
            txtNombres.Clear();
            txtEmail.Clear();
            txtClave.Clear();
            optInvitado.Checked = true;
            nivelAcceso = "INV";
            txtApellidos.Focus();
        }
        private void optAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            nivelAcceso = "ADM";
        }

        private void optInvitado_CheckedChanged(object sender, EventArgs e)
        {
            nivelAcceso = "INV";
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        private void gridUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridUsuarios.ClearSelection();
        }

        //BUSCAR REGISTROS
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            dv.RowFilter = "apellidos LIKE '%" + txtBuscar.Text + "%' OR nombres LIKE '%" + txtBuscar.Text+ "%'";
        }
    }
}
