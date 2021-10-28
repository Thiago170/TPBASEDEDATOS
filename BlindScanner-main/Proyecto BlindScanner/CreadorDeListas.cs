using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BlindScanner
{
    public partial class CreadorDeListas : Form
    {
        public CreadorDeListas()
        {
            InitializeComponent();
        }

        private void CreadorDeListas_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadirProducto_Click(object sender, EventArgs e)
        {
            if (numUDCant.Value == 1)
            {
                listBxProductos.Items.Add(txtAñadirProducto.Text);
            }
            else
            {
                listBxProductos.Items.Add(txtAñadirProducto.Text + " (" + numUDCant.Value + ")");
            }
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (listBxProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto de la lista para remover");
                
            }
            else
            {
                listBxProductos.Items.Remove(listBxProductos.SelectedItem);
            }
        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            new Listas_activas().Show();

        }
    }
}
