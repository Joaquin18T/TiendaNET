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
    public partial class frmEmpresa : Form
    {
        Empresa empresa = new Empresa();

        EEmpresa entEmpresa = new EEmpresa();

        DataView dv;

        public frmEmpresa()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Aviso.Preguntar("¿Estas seguro de guardar?")==DialogResult.Yes)
            {
                //string claveEncriptada = Crypter.Blowfish.Crypt()
                entEmpresa.razonsocial = txtRazonSocial.Text;
                entEmpresa.ruc = txtRuc.Text;
                entEmpresa.direccion = txtDireccion.Text;
                entEmpresa.telefono = txtTelefono.Text;
                entEmpresa.email = txtEmail.Text;
                entEmpresa.website = txtWebsite.Text;


                if (txtRuc.Text.Length!=11 && txtRuc.Text[0]!=2)
                {
                    Aviso.Advertir("El Ruc esta mal escrito");
                }

                

                if (empresa.Registrar(entEmpresa)>0 && ValidarDatos()==true)
                {
                    ReiniciarInterfaz();
                    actualizarDatos();
                    Aviso.Imformar("Empresa registrada");
                }
                else
                {
                    Aviso.Imformar("No hemos podido terminar el registro");
                }
            }
        }
        private void actualizarDatos()
        {
            dv = new DataView(empresa.Listar());
            dgvEmpresa.DataSource = dv;
            dgvEmpresa.Refresh();

            dgvEmpresa.Columns[0].Visible = false;

            dgvEmpresa.Columns[1].Width = 200;
            dgvEmpresa.Columns[2].Width = 200;
            dgvEmpresa.Columns[3].Width = 200;
            dgvEmpresa.Columns[4].Width = 200;
            dgvEmpresa.Columns[5].Width = 200;
            dgvEmpresa.Columns[6].Width = 200;

            dgvEmpresa.AlternatingRowsDefaultCellStyle.BackColor = Color.DeepSkyBlue;
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            actualizarDatos();
        }

        private void ReiniciarInterfaz()
        {
            txtRazonSocial.Clear();
            txtRuc.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtWebsite.Clear();
        }
        private bool ValidarDatos()
        {
            bool dato = false;
            if (dgvEmpresa.Columns[1].ToString() != txtRazonSocial.Text)
            {
                dato = true;
            }
            return dato;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            dv.RowFilter = "razonsocial LIKE '%" + txtBuscar.Text + "%' OR ruc LIKE '%" + txtBuscar.Text + "%'";
            
            //for ()
            //{

            //}
            if (txtBuscar.Text==txtRazonSocial.Text)
            {

            }
        }

        private void validarNum(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                Aviso.Advertir("Solo acepta numeros");

                e.Handled = true;
            }
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txtTelefono.Text = e.KeyChar.ToString();
            validarNum(e);
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNum(e);
        }
    }
}
