using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication3
{
    public partial class Conexaun : Form
    {
        public Conexaun()
        {
            InitializeComponent();
        }
        
        private void button1_click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = WindowsFormsApplication3.conex.CarregaClientes();
            
           

        }

       
    }
}
