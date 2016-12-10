using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class FrmRelCadCli : Form
    {
        public FrmRelCadCli()
        {
            InitializeComponent();
        }

        private void FrmRelCadCli_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmRelCadCli_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FormRelCadCli = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.clientesTableAdapter.FillByCodClienteRel(this.jarbasDataSet.clientes, Convert.ToInt32(textBox1.Text));

                this.reportViewer1.RefreshReport();
            }
            else if (radioButton2.Checked)
            {
                this.clientesTableAdapter.FillByNomeCliRel(this.jarbasDataSet.clientes, textBox1.Text);

                this.reportViewer1.RefreshReport();
            }
            else if (textBox1.Text == string.Empty)
            {
                this.clientesTableAdapter.FillByTudoRelCli(this.jarbasDataSet.clientes);

                this.reportViewer1.RefreshReport();
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
