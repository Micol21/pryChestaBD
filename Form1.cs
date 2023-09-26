using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace pryChestaBD
{
    public partial class Form1 : Form
    {

        OleDbConnection conexion;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conexion = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\Alumnos\\source\repos\\pryChestaBD\\BASE");
            conexion.Open();
            lblResultado.Text = "Conectado a la base";
            lblResultado.BackColor = Color.Green;
        }

    }
}
