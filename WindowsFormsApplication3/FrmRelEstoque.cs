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
    public partial class FrmRelEstoque : Form
    {
        public FrmRelEstoque()
        {
            InitializeComponent();
        }

        private void FrmRelEstoque_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmRelEstoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.formRelEstproduto = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.produtosTableAdapter.Fill(this.relDataSet.produtos, Convert.ToInt32(textBox1.Text));

                this.reportViewer1.RefreshReport();
            }
            else if (radioButton2.Checked)
            {
                this.produtosTableAdapter.FillByDescricao(this.relDataSet.produtos,textBox1.Text);

                this.reportViewer1.RefreshReport();
            }
            else if(textBox1.Text == string.Empty)
            {
                this.produtosTableAdapter.FillBySemParametro(this.relDataSet.produtos);

                this.reportViewer1.RefreshReport();
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
