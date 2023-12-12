using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DESIGNER.Tools;
using ENTITIES;
using BOL;
namespace DESIGNER.Modulos
{
    public partial class frmProductos : Form
    {
        Producto producto = new Producto();
        Categoria categoria = new Categoria();
        Subcategoria subcategoria = new Subcategoria();
        Marca marca = new Marca();

        EProducto entproducto = new EProducto();

        //bandera = variable logica que controla estados
        bool categoriaListas = false;
        public frmProductos()
        {
            InitializeComponent();
        }
        #region METODOS PARA LA CARGA DE DATOS
        private void actualizarMarcas()
        {
            cbMarca.DataSource = marca.listar();
            cbMarca.DisplayMember = "marca"; //Mostrar |debe coincidir con la consulta
            cbMarca.ValueMember = "idmarca"; //PK (guarda id de marca) |debe coincidir con la consulta
            cbMarca.Refresh();
            cbMarca.Text = "";
        }
        private void actualizarCategorias()
        {
            cbCategoria.DataSource = categoria.listar();
            cbCategoria.DisplayMember = "categoria";
            cbCategoria.ValueMember = "idcategoria";
            cbCategoria.Refresh();
            cbCategoria.Text = "";
        }
        private void actualizarProductos()
        {
            gridProductos.DataSource = producto.listar();
            gridProductos.Refresh();
        }
        #endregion
        private void frmProductos_Load(object sender, EventArgs e)
        {
            actualizarProductos();
            actualizarMarcas();
            actualizarCategorias();

            gridProductos.Columns[0].Visible = false;
            gridProductos.Columns[1].Width = 130;
            gridProductos.Columns[2].Width = 130;
            gridProductos.Columns[3].Width = 150;
            gridProductos.Columns[4].Width = 240;
            gridProductos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridProductos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridProductos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            categoriaListas = true;
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (categoriaListas)
            {
                //Invocar al metodo que carga las subcategorias
                int idcategoria = Convert.ToInt32(cbCategoria.SelectedValue.ToString());
                cbSubCategoria.DataSource = subcategoria.listar(idcategoria);
                cbSubCategoria.DisplayMember = "subcategoria";
                cbSubCategoria.ValueMember = "idsubcategoria";
                cbSubCategoria.Refresh();
                cbSubCategoria.Text = "";
            }

        }
        private void reiniciarInterfaz()
        {
            cbMarca.Text = "";
            cbCategoria.Text = "";
            cbSubCategoria.Text = "";
            txtDescripcion.Clear();
            txtGarantia.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Aviso.Preguntar("Estas seguro que quieres guardar?")==DialogResult.Yes)
            {
                
                
                entproducto.idmarca = Convert.ToInt32(cbMarca.SelectedValue.ToString());
                entproducto.idsubcategoria =Convert.ToInt32(cbSubCategoria.SelectedValue.ToString());
                entproducto.descripcion = txtDescripcion.Text;
                entproducto.garantia = Convert.ToInt32(txtGarantia.Text);
                entproducto.precio = Convert.ToDouble(txtPrecio.Text);
                entproducto.stock = Convert.ToInt32(txtStock.Text);

                if (producto.registrar(entproducto)>0)
                {
                    reiniciarInterfaz();
                    actualizarProductos();
                    Aviso.Imformar("Nuevo producto registrado");
                }
            }

            
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //1. Instanciar el reporte
            Reportes.rptProductos reporte = new Reportes.rptProductos();

            //2. Asignar los datos al objeto reporte (creado en el paso 1)
            reporte.SetDataSource(producto.listar());
            reporte.Refresh();

            //3. Instanciar el formulario donde se mostraran los reportes
            Reportes.FrmVisorReportes formulario = new Reportes.FrmVisorReportes();

            //4.Pasamos el reporte al visor
            formulario.visor.ReportSource = reporte;
            formulario.visor.Refresh();

            //5. Mostramos el formulario conteniendo el reporte
            formulario.ShowDialog();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridProductos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridProductos.ClearSelection();
        }
        /// <summary>
        /// Genera un archivo fisico del reporte
        /// </summary>
        /// <param name="extension">Utilice: XLS o PDF</param>
        private void ExportarDatos(string extension)
        {
            SaveFileDialog sd = new SaveFileDialog();//como guardar un archivo
            sd.Title = "Reporte de productos";//poner titulo
            sd.Filter = $"Archivos en formato {extension.ToUpper()}|*.{extension.ToLower()}"; //elegir un formato

            if (sd.ShowDialog() == DialogResult.OK)//mostrar ventana de guardar
            {
                //Creamos una version de reporte en formato PDF
                //1. Instancia del objeto reporte (crystal report)
                Reportes.rptProductos reporte = new Reportes.rptProductos();

                //2. Asignar los datos al objeto reporte (creado en el paso 1)
                reporte.SetDataSource(producto.listar());
                reporte.Refresh();

                //3. El reporte creado y en memoria se escribira en el storage(disco duro)
                if (extension.ToUpper() == "PDF")
                {
                    reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, sd.FileName);
                }else if (extension.ToUpper() == "XLSX")
                {
                    reporte.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.ExcelWorkbook, sd.FileName);
                }
                

                //4. Notificar al usuario la creacion del archivo
                Aviso.Imformar("Se ha creado el reporte correctamente");

            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            ExportarDatos("PDF");
        }

        private void btnXls_Click(object sender, EventArgs e)
        {
            ExportarDatos("XLSX");
        }

        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
