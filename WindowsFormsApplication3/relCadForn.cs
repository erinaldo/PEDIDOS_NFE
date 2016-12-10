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
    public partial class relCadForn : Form
    {
        public relCadForn()
        {
            InitializeComponent();
        }

        private void relCadForn_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                this.fornecedoresTableAdapter.NovoFill(this.relDataSet.fornecedores);

                this.reportViewer1.RefreshReport();
            }
            else if (radioButton1.Checked)
            {
                this.fornecedoresTableAdapter.PCodFornecedor(this.relDataSet.fornecedores, Convert.ToInt32(textBox1.Text));
                this.reportViewer1.RefreshReport();
            }
            else if (radioButton2.Checked)
            {
                this.fornecedoresTableAdapter.PFantasiaFornecedor(this.relDataSet.fornecedores, textBox1.Text);
                this.reportViewer1.RefreshReport();

            }
            else if (checkBox1.Checked)
            {
                this.fornecedoresTableAdapter.TesteVariosParametros(this.relDataSet.fornecedores, textBox1.Text, textBox2.Text);
                this.reportViewer1.RefreshReport();

            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
