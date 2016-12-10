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
    public partial class FrmRelCreceber : Form
    {
        public FrmRelCreceber()
        {
            InitializeComponent();
        }

        private void FrmRelCreceber_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmRelCreceber_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.formRlcreceber = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                this.CRECEBERTableAdapter.Fill(this.relDataSet.CRECEBER);

                this.reportViewer1.RefreshReport();
            }
            else if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                if (radioButton1.Checked)
                {
                    this.CRECEBERTableAdapter.FillBycRECEBERbAIXADObUSCAnOME(this.relDataSet.CRECEBER, textBox1.Text);
                    this.reportViewer1.RefreshReport();
                }
                else if (radioButton2.Checked)
                {
                    this.CRECEBERTableAdapter.FillByBaixadosComdatabaixa(this.relDataSet.CRECEBER, textBox1.Text);
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    this.CRECEBERTableAdapter.FillByCRECEBERtODASBAIXADOS(this.relDataSet.CRECEBER);
                    this.reportViewer1.RefreshReport();
                }

            }
            else if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                if (radioButton1.Checked)
                {
                    this.CRECEBERTableAdapter.FillByCreceberPendenteBuscaNome(this.relDataSet.CRECEBER, textBox1.Text);
                    this.reportViewer1.RefreshReport();
                }
                else if (radioButton2.Checked)
                {
                    this.CRECEBERTableAdapter.FillBycreberDatapendente(this.relDataSet.CRECEBER, textBox1.Text);
                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    this.CRECEBERTableAdapter.FillBycRECEBERtODASPENDENTE(this.relDataSet.CRECEBER);
                    this.reportViewer1.RefreshReport();
                }
            }
            else 
            {
                this.CRECEBERTableAdapter.Fill(this.relDataSet.CRECEBER);

                this.reportViewer1.RefreshReport();
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
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
