using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proyecto_BlindScanner
{
    public partial class Añadirhotel : Form
    {
        OleDbConnection conexion = new OleDbConnection();

        DataSet ds = new DataSet();
        public Añadirhotel()
        {
            InitializeComponent();
        }

        private void Añadirhotel_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Provider=MIcrosoft.ACE.OLEDB.12.0;Data Source=.\db_users.accdb;";
            conexion.Open();
            OleDbCommand comando = new OleDbCommand("SELECT provincias from Provincias", conexion);
            conexion.Open();
            OleDbDataReader provincia = comando.ExecuteReader();
            while (provincia.Read())
            {
                comboboxprovincia.Items.Add(provincia["provincias"].ToString());
            }
            
            
            
        }

        private void btnvolver2_Click(object sender, EventArgs e)
        {
            this.Close();
            MENU menu = new MENU();
            menu.Show();
        }

        private void txtnombrehotel_TextChanged(object sender, EventArgs e)
        {

        }
    }
 
}
