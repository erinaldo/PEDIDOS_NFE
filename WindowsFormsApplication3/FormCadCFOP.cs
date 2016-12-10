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
    public partial class FormCadCFOP : Form
    {
        bool novo;
        public FormCadCFOP()
        {
            InitializeComponent();
        }
        utils u = new utils();
        private void limpa()
        {
            u.limparMTextBoxes(this);
            u.limparTextBoxes(this);
            btnCancela.Enabled = false;
            buttonExclui.Enabled = false;
            buttonNovo.Enabled = true;
            buttonSair.Enabled = true;
            buttonSalva.Enabled = false;
            txtCodCopf.Focus();
        }
        private void alterar()
        {
            btnCancela.Enabled = true;
            buttonExclui.Enabled = true;
            buttonNovo.Enabled = false;
            buttonSair.Enabled = true;
            buttonSalva.Enabled = true;
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        private void FormCadCFOP_Load(object sender, EventArgs e)
        {           
            u.DisableTxt(this);
            limpa();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            limpa();
            buttonSalva.Enabled = true;
            u.EnableTxt(this);
            txtCodCopf.Enabled = true;
            novo = true;
            txtCodCopf.Focus();

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadCFOP_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FrmCadCfop = null;
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            buttonSalva.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelPesquisa.Visible = true;
            textBox1.Focus();
            novo = false;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            limpa();
        }

        private void buttonExclui_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja realmente excluir esse registro ?", "Mensagem do Sitema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (escolha == DialogResult.Cancel)
            {

            }
            else
            {
                string excluir = "delete from CFOP where cfo_codigo = " + txtCodCopf.Text.Trim();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(excluir, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        u.messageboxSucesso();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: Erro ao gravar no banco de dados " + ex.ToString());
                    throw;
                }
                finally
                {
                    con.Close();
                }
                limpa();


            }
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            if (txtCodCopf.Text == string.Empty || txtDescricao.Text == string.Empty)
            {
                txtCodCopf.BackColor = Color.Gold;
                txtDescricao.BackColor = Color.Gold;
                u.messageboxCamposObrigatorio();
            }
            else
            {
                int cfoCodigo = Convert.ToInt32(txtCodCopf.Text.Trim());
                string descricao = txtDescricao.Text;
                if (novo)
                {
                    string inserir = "insert into cfop(cfo_codigo, cfo_descricao) values(@cfo_codigo, @cfo_descricao)";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(inserir, con);
                    cmd.Parameters.Add("@cfo_codigo", SqlDbType.Int).Value = cfoCodigo;
                    cmd.Parameters.Add("@cfo_descricao", SqlDbType.NVarChar).Value = descricao;
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            u.messageboxSucesso();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString());
                        throw;
                    }
                    finally
                    {
                        con.Close();
                    }


                }
                else
                {
                    string altera = "update cfop set cfo_descricao = @cfo_descricao where cfo_codigo =" + txtCodCopf.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(altera, con);
                    cmd.Parameters.Add("@cfo_descricao", SqlDbType.NVarChar).Value = descricao;
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            u.messageboxSucesso();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString());
                        throw;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                txtCodCopf.BackColor = SystemColors.Window;
                txtDescricao.BackColor = SystemColors.Window;
                limpa();
                u.DisableTxt(this);
            }
        }

        private void cIDADESDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelPesquisa.Visible = false;
            alterar();
            DataGridViewRow row = this.cfopDataGridView.Rows[e.RowIndex];
            txtCodCopf.Text = row.Cells[0].Value.ToString();
            txtDescricao.Text = row.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand("select * from cfop", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            if (radioButtonCodigo.Checked)
            {
                dv.RowFilter = "cfo_codigo =" + textBox1.Text;
            }
            if (radioButtonDescricao.Checked)
            {
                dv.RowFilter = "cfo_descricao like'%" + textBox1.Text + "%'";
            }

            cfopDataGridView.DataSource = dv;
            con.Close();

        }

        private void txtCodCopf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelPesquisa.Visible = false;
        }

        private void txtCodCopf_TextChanged(object sender, EventArgs e)
        {
            if (txtCodCopf.Text == null)
            {
                txtDescricao.Focus();

            }
            else
            {
                string buscaCfop = "Select cfo_descricao From cfop where cfo_codigo = '" + txtCodCopf.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand sqlCommand = new SqlCommand(buscaCfop, con);

                con.Open();
                SqlDataReader dR = sqlCommand.ExecuteReader();

                if (dR.Read())
                {
                    novo = false;

                    txtDescricao.Text = dR[0].ToString();
                }
                else
                {
                    txtDescricao.Clear();
                }

                con.Close();
            }
        }
    }
}
