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
    public partial class FrmRelVendas : Form
    {
        public FrmRelVendas()
        {
            InitializeComponent();
        }

        private void FrmRelVendas_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmRelVendas_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.formRelVendas = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                this.PEDIDOTableAdapter.Fill(this.relDataSet.PEDIDO);

                this.reportViewer1.RefreshReport();
            }
            else if (radioButton1.Checked)
            {
                this.PEDIDOTableAdapter.FillByVendasNomeClie(this.relDataSet.PEDIDO, textBox1.Text);

                this.reportViewer1.RefreshReport();
            }
            else if (radioButton2.Checked)
            {
                this.PEDIDOTableAdapter.FillByVendasData(this.relDataSet.PEDIDO, maskedTextBox1.Text);

                this.reportViewer1.RefreshReport();
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
