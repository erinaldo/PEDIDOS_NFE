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
    public partial class FrmRelCpagar : Form
    {
        public FrmRelCpagar()
        {
            InitializeComponent();
        }

        private void FrmRelCpagar_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Enabled = false;
         
        }

        private void FrmRelCpagar_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.formRelCpagar = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;

                if (radioButton1.Checked)
                {
                    this.CPAGARTableAdapter.cPAGARFantasiaPendente(this.relDataSet.CPAGAR, textBox1.Text);
                    this.reportViewer1.RefreshReport();
                }
                else if (radioButton2.Checked)
                {
                    this.CPAGARTableAdapter.FillByREldataVencPend(this.relDataSet.CPAGAR, maskedTextBox1.Text);
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    this.CPAGARTableAdapter.FillByCpagarPendenteRel(this.relDataSet.CPAGAR);
                    this.reportViewer1.RefreshReport();
                }
            }
            //////////////////////////////////////////////////
            else if (checkBox1.Checked)// 
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;

                if (radioButton1.Checked)
                {
                    this.CPAGARTableAdapter.CpagarFantasiaBaixado(this.relDataSet.CPAGAR, textBox1.Text);
                    this.reportViewer1.RefreshReport();
                }
                else if (radioButton2.Checked)
                {
                    this.CPAGARTableAdapter.FillByrELdATAbAIXADO(this.relDataSet.CPAGAR, maskedTextBox1.Text);
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    this.CPAGARTableAdapter.FillByRelCpagarBaixado(this.relDataSet.CPAGAR);
                    this.reportViewer1.RefreshReport();
                }
            }
            ///////////////////////////////////////////
            else if (checkBox3.Checked)// todas todas
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;

                this.CPAGARTableAdapter.Fill(this.relDataSet.CPAGAR);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.CPAGARTableAdapter.Fill(this.relDataSet.CPAGAR);
                this.reportViewer1.RefreshReport();
            }
            /////////////////////////////////////////
            radioButton1.Checked = false;
            radioButton2.Checked = false;



        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Enabled = true;
        }

        private void radioButton2_Leave(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                maskedTextBox1.Enabled = true;

            }
            else
            {
                maskedTextBox1.Enabled = false;
            }
        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
        }
    }
}
