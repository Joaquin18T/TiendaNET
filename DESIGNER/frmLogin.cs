using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CryptSharp;   //Claves encriptadas
using BOL;
using DESIGNER.Tools; //Traemos las herramientas

namespace DESIGNER
{
    public partial class frmLogin : Form
    {
        //Instancia de la clase
        Usuario usuario = new Usuario();
        DataTable dtRpta = new DataTable();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login()
        {
            //txtClaveAcceso.Text = Crypter.Blowfish.Crypt("SENATI123");//AQUI ESTA EL PASS ENCRIPTADO
            //return;//ignora las lineas siguentes
            if (txtEmail.Text.Trim() == String.Empty)//trim quita los espacios en blanco
            {
                errorLogin.SetError(txtEmail, "Por favor, ingrese su email");//error login es una herramienta
                txtEmail.Focus(); //te direcciona a los errores que puedes tener
            }
            else
            {
                errorLogin.Clear();//limpia los errores anteriores
                if (txtClaveAcceso.Text.Trim() == String.Empty)
                {
                    errorLogin.SetError(txtClaveAcceso, "Escriba su contraseña");
                    txtClaveAcceso.Focus();
                }
                else
                {
                    errorLogin.Clear();
                    dtRpta = usuario.iniciarSesion(txtEmail.Text);

                    if (dtRpta.Rows.Count > 0)//verifica el correo del usuario ingresado con el correo que esta en el DB
                    {
                        string claveEncriptada = dtRpta.Rows[0][4].ToString();//la segundo cero es la celda
                        string apellidos = dtRpta.Rows[0][1].ToString();
                        string nombres = dtRpta.Rows[0][2].ToString(); //MessageBox.Show(claveEncriptada);
                        if (Crypter.CheckPassword(txtClaveAcceso.Text, claveEncriptada))
                        {
                            Aviso.Imformar($"Bienvenido {apellidos} {nombres}");
                            frmMain formMain = new frmMain();
                            formMain.Show();//abre el formulario principal(frmMain)
                            this.Hide(); //login se oculta(frmLogin)
                        }
                        else
                        {
                            Aviso.Advertir("Error en la contraseña");
                        }

                    }
                    else
                    {
                        Aviso.Advertir("El usuario no existe");
                    }
                }
            }
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {

            Login();
            
        }

        private void txtClaveAcceso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Login();
            }
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {

        }











        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtClaveAcceso_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola que hace");
        }
    }
}
