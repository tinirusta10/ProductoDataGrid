using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using static Entidad.Productoss;

namespace Producto
{

    public partial class FormProductos : Form
    {


        bool nuevo = true;
        int fila;
        Productos ProdExistente;
        Productos NuevoProd;
        public FormProductos()
        {
            InitializeComponent();
            CrearDg();
        }

        void CrearDg()

        {

            dg.Columns.Add("0", "Código");
            dg.Columns.Add("1", "Descripción");
            dg.Columns.Add("2", "Stock");
            dg.Columns[0].Width = 100;
            dg.Columns[1].Width = 300;
            dg.Columns[2].Width = 60;
        }

        private void btncargar_Click(object sender, EventArgs e)
        {

            NuevoProd = new Productos(int.Parse(txtcodigo.Text), txtdesc.Text);


            lbl_codmovimietno.Text = NuevoProd.p_codigo.ToString();



            lbl_descmovimiento.Text = NuevoProd.p_descripcion;
            lbl_stock.Text = "Hay " + NuevoProd.p_stock.ToString() + " unidades";
            tab.SelectedTab = tabcantidad;
            txtcantidad.Clear();
            txtcantidad.Focus();

            nuevo = true;

            dg.Rows.Add(NuevoProd.p_codigo.ToString(), NuevoProd.p_descripcion,
            NuevoProd.p_stock.ToString());
            fila = (dg.Rows.Count - 1);

        }

        void LlevarProdAldgv(Productos Prod, int lugar)
        {


            {
                dg[0, lugar].Value = Prod.p_codigo.ToString();
                dg[1, lugar].Value = Prod.p_descripcion;
                dg[2, lugar].Value = Prod.p_stock.ToString();
            }
        }

        private void lbl_descmovimiento_Click(object sender, EventArgs e)
        {

        }




        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                if (rbingreso.Checked == true)
                {
                    NuevoProd.Ingreso(int.Parse(txtcantidad.Text));
                }
                if (rbegreso.Checked == true)
                {
                    NuevoProd.Salida(int.Parse(txtcantidad.Text));
                }
                LlevarProdAldgv(NuevoProd, fila);
            }
            else
            {
                if (rbingreso.Checked == true)
                {
                    ProdExistente.Ingreso(int.Parse(txtcantidad.Text));
                }
                if (rbegreso.Checked == true)
                {
                    ProdExistente.Salida(int.Parse(txtcantidad.Text));
                }
                LlevarProdAldgv(ProdExistente, fila);
            }
        }
    

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                ProdExistente = new
                Productos(Convert.ToInt32(dg.CurrentRow.Cells[0].Value),
                 dg.CurrentRow.Cells[1].Value.ToString(),
                Convert.ToInt32(dg.CurrentRow.Cells[2].Value));
                lbl_codmovimietno.Text = ProdExistente.p_codigo.ToString();
                lbl_descmovimiento.Text = ProdExistente.p_descripcion;
                lbl_stock.Text = "Hay " + ProdExistente.p_stock.ToString() + "unidades";



                txtcantidad.Clear();
                fila = e.RowIndex;
                nuevo = false;
            }
        }

    }
    }

