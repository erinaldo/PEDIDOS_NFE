using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ducaun.dal;
using System.Data.SqlClient;


namespace WindowsFormsApplication3
{
    public partial class FormCadProcedimento : Form
    {
        bool novo;
        public FormCadProcedimento()
        {
            InitializeComponent();
        }
        utils u = new utils();

        private void FormCadProcedimento_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            panel1.Visible = false;
            txtCodProcedimento.Enabled = false;
            textBoxNomeProcedimento.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            textBoxNomeProcedimento.Enabled = false;
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void buttonLocaliza_Click(object sender, EventArgs e)
        {

            textBoxNomeProcedimento.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            u.limparTextBoxes(this);
            textBoxNomeProcedimento.Focus();

        }

        private void FormCadProcedimento_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FrmCadProcedimento = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult escolha = MessageBox.Show("Você deseja realmente excluir esse item?", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (escolha == DialogResult.Cancel)
            {
                textBoxNomeProcedimento.Enabled = false;
                btnNovo.Enabled = true;
                btnCancelar.Enabled = false;
                u.limparTextBoxes(this);
                textBoxNomeProcedimento.Focus();
            }


            else
            {
                string excrui = "delete from procedimentos where cod_procedimento = " + txtCodProcedimento.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(excrui, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        u.messageboxSucesso();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Gravar no Banco de dados" + ex.ToString(), "Mensagem de Erro do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    con.Close();
                }


            }
            txtCodProcedimento.Enabled = false;
            textBoxNomeProcedimento.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            u.limparTextBoxes(this);
            textBoxNomeProcedimento.Enabled = false;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            textBoxNomeProcedimento.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = false;
            textBoxNomeProcedimento.Focus();
            novo = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxNomeProcedimento.Text == string.Empty)
            {
                textBoxNomeProcedimento.BackColor = Color.Gold;
                u.messageboxCamposObrigatorio();
            }
            else
            {
                if (novo)
                {
                    string inclui = "insert into procedimentos(des_procedimento)" +
                        "values('" + textBoxNomeProcedimento.Text + "')";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(inclui, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            u.messageboxSucesso();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString(), "Mensagem de Erro do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    string altera = "update procedimentos set des_procedimento = '"
                        + textBoxNomeProcedimento.Text + "' where cod_procedimento = '"
                        + txtCodProcedimento.Text + "'";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(altera, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            u.messageboxSucesso();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString(), "Mensagem de Erro do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }


                }
                txtCodProcedimento.Enabled = false;
                textBoxNomeProcedimento.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;
                textBoxNomeProcedimento.Enabled = false;
                u.limparTextBoxes(this);
                btnNovo.Focus();
                textBoxNomeProcedimento.BackColor = SystemColors.Window;
            }
        }

        public DialogResult escolha { get; set; }



        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand("select * from procedimentos ", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            if (radioButtonCodigo.Checked)
            {
                dv.RowFilter = "cod_procedimento =" + Convert.ToInt32(textBox1.Text);
            }
            if (radioButtonDescricao.Checked)
            {
                dv.RowFilter = "des_procedimento like'%" + textBox1.Text + "%'";
            }
            procedimentosDataGridView.DataSource = dv;
            con.Close();
            textBoxNomeProcedimento.Enabled = true;
            procedimentosDataGridView.Enabled = true;
            btnCancelar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            textBoxNomeProcedimento.Focus();
        }

        private void radioButtonCodigo_Enter(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void radioButtonDescricao_Enter(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            novo = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void procedimentosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                panel1.Visible = false;
                DataGridViewRow row = this.procedimentosDataGridView.Rows[e.RowIndex];
                txtCodProcedimento.Text = row.Cells[0].Value.ToString();
                textBoxNomeProcedimento.Text = row.Cells[1].Value.ToString();
                textBoxNomeProcedimento.Enabled = true;
                btnCancelar.Enabled = true;
                btnSalvar.Enabled = true;
                btnExcluir.Enabled = true;
                textBoxNomeProcedimento.Focus();
                btnNovo.Enabled = false;


            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonCodigo.Checked)
            {
                if (char.IsLetter(e.KeyChar) || //Letras

               char.IsSymbol(e.KeyChar) || //Símbolos

               char.IsWhiteSpace(e.KeyChar)) //Espaço


                    e.Handled = true; //Não permitir
                if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
