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
using validacao;

namespace WindowsFormsApplication3
{
    public partial class FormFornecedores : Form
    {
        bool novo;
        public FormFornecedores()
        {
            InitializeComponent();
        }
        utils u = new utils();

        private Boolean EnableSalvar()
        {
            if (textBoxRazao.Text == string.Empty)
            {
                return false;
            }

            return true;
        }

        private void FormFornecedores_Load(object sender, EventArgs e)
        {
            u.limparMTextBoxes(this);
            u.limparTextBoxes(this);
            panelCid.Visible = false;
            rbNomeC.Checked = true;
            panel1.Visible = false;
            this.MaximizeBox = false;
            textBoxCodFornecedor.Enabled = false;
            textBoxBairro.Enabled = false;
            textBoxCidade.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxEndereco.Enabled = false;
            textBoxFantasia.Enabled = false;
            textBoxNumero.Enabled = false;
            textBoxRazao.Enabled = false;
            maskedTextBoxCelular.Enabled = false;
            maskedTextBoxCep.Enabled = false;
            maskedTextBoxCnpj.Enabled = false;
            maskedTextBoxTelefone.Enabled = false;
            buttoncancel.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnPcidade.Enabled = false;
            txtNcidade.Enabled = false;
            btnExcluir.Focus();
            radioButtonrRazao.Checked = true;                        
        }

        private void buttonLocalizaatendimento_Click(object sender, EventArgs e)
        {
            u.limparMTextBoxes(this);
            u.limparTextBoxes(this);
            textBoxBairro.Enabled = false;
            textBoxCidade.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxEndereco.Enabled = false;
            textBoxFantasia.Enabled = false;
            textBoxNumero.Enabled = false;
            textBoxRazao.Enabled = false;
            maskedTextBoxCelular.Enabled = false;
            maskedTextBoxCep.Enabled = false;
            maskedTextBoxCnpj.Enabled = false;
            maskedTextBoxTelefone.Enabled = false;
            buttoncancel.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnPcidade.Enabled = false;
            btnNovo.Enabled = true;      
            btnNovo.Focus();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            btnSalvar.Focus();
        }
        private void FormFornecedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FrmFornecedores = null;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {

            textBoxBairro.Enabled = true;
            textBoxCidade.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxEndereco.Enabled = true;
            textBoxFantasia.Enabled = true;
            textBoxNumero.Enabled = true;
            textBoxRazao.Enabled = true;
            maskedTextBoxCelular.Enabled = true;
            maskedTextBoxCep.Enabled = true;
            maskedTextBoxCnpj.Enabled = true;
            maskedTextBoxTelefone.Enabled = true;
            buttoncancel.Enabled = true;
            btnExcluir.Enabled = false;            
            btnNovo.Enabled = false;
            textBoxRazao.Focus();
            btnPcidade.Enabled = true;
            txtNcidade.Enabled = true;
            novo = true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxRazao.Text == string.Empty)
            {
                
                textBoxRazao.BackColor = Color.Gold;
                u.messageboxCamposObrigatorio();
            }
            else
            {
                if(txtcid.Text == string.Empty)
                {
                    textBoxCidade.Text = "0";
                }


                string vRazao = textBoxRazao.Text;
                string fantasia = textBoxFantasia.Text;
                string endereco = textBoxBairro.Text;
                string bairro = textBoxBairro.Text;
                int cidade = Convert.ToInt32(textBoxCidade.Text);
                string telefone = maskedTextBoxTelefone.Text;
                string celular = maskedTextBoxCelular.Text;
                string cep = maskedTextBoxCep.Text;
                string obs = textBoxObs.Text;
                string cnpj = maskedTextBoxCnpj.Text;
                string numero = textBoxNumero.Text;
                string email = textBoxEmail.Text;



                if (novo)
                {
                    string sql = "insert into fornecedores(razão, fantasia, endereco, bairro,cidade, telefone, celular, cep, obs, cnpj, numero, email) values(@razão, @fantasia, @endereco, @bairro, @cidade, @telefone, @celular, @cep, @obs, @cnpj, @numero, @email )";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@razão", SqlDbType.VarChar).Value = vRazao;
                    cmd.Parameters.Add("@fantasia", SqlDbType.VarChar).Value = fantasia;
                    cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = endereco;
                    cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
                    cmd.Parameters.Add("@cidade", SqlDbType.Int).Value = cidade;
                    cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
                    cmd.Parameters.Add("@celular", SqlDbType.VarChar).Value = celular;
                    cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = cep;
                    cmd.Parameters.Add("@obs", SqlDbType.VarChar).Value = obs;
                    cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = cnpj;
                    cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    con.Open();
                    fornecedoresDataGridView.Refresh();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            u.messageboxSucesso();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString());
                    }
                    finally
                    {
                        fornecedoresDataGridView.Refresh();
                        con.Close();
                    }
                }
                else
                {
                    string sql = "update fornecedores set razão = @razão, fantasia = @fantasia, endereco = @endereco, bairro = @bairro, cidade = @cidade, telefone = @telefone, celular = @celular, cep = @cep, obs = @obs, cnpj = @cnpj,  numero = @numero, email = @email where cod_fornecedor = " + textBoxCodFornecedor.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@razão", SqlDbType.VarChar).Value = vRazao;
                    cmd.Parameters.Add("@fantasia", SqlDbType.VarChar).Value = fantasia;
                    cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = endereco;
                    cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
                    cmd.Parameters.Add("@cidade", SqlDbType.Int).Value = cidade;
                    cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
                    cmd.Parameters.Add("@celular", SqlDbType.VarChar).Value = celular;
                    cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = cep;
                    cmd.Parameters.Add("@obs", SqlDbType.VarChar).Value = obs;
                    cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = cnpj;
                    cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    con.Open();
                    fornecedoresDataGridView.Refresh();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            u.messageboxSucesso();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString());
                    }
                    finally
                    {
                        fornecedoresDataGridView.Refresh();
                        con.Close();
                    }
                }
                u.limparMTextBoxes(this);
                u.limparTextBoxes(this);
                btnNovo.Enabled = true;
                textBoxCodFornecedor.Enabled = false;
                textBoxBairro.Enabled = false;
                textBoxCidade.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxEndereco.Enabled = false;
                textBoxFantasia.Enabled = false;
                textBoxNumero.Enabled = false;
                textBoxRazao.Enabled = false;
                maskedTextBoxCelular.Enabled = false;
                maskedTextBoxCep.Enabled = false;
                maskedTextBoxCnpj.Enabled = false;
                maskedTextBoxTelefone.Enabled = false;
                buttoncancel.Enabled = false;
                btnExcluir.Enabled = false;
                txtNcidade.Enabled = false;
                btnSalvar.Enabled = false;
                txtcid.BackColor = SystemColors.Window;
                textBoxRazao.BackColor = SystemColors.Window;
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Você deseja realmente excluir esse resgitro ?", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (escolha == DialogResult.Cancel)
            {
                u.limparMTextBoxes(this);
                u.limparTextBoxes(this);
                textBoxBairro.Enabled = false;
                textBoxCidade.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxEndereco.Enabled = false;
                textBoxFantasia.Enabled = false;
                textBoxNumero.Enabled = false;
                textBoxRazao.Enabled = false;
                maskedTextBoxCelular.Enabled = false;
                maskedTextBoxCep.Enabled = false;
                maskedTextBoxCnpj.Enabled = false;
                maskedTextBoxTelefone.Enabled = false;
                buttoncancel.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                btnNovo.Enabled = true;            
                btnNovo.Focus();
            }
            else
            {
                string sql = " delete from fornecedores where cod_fornecedor = " + textBoxCodFornecedor.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                fornecedoresDataGridView.Refresh();             
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        u.messageboxSucesso();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: Erro ao gravar no banco de dados " + ex.ToString());
                }
                finally
                {
                    fornecedoresDataGridView.Refresh();
                    con.Close();
                }

            }
            u.limparMTextBoxes(this);
            u.limparTextBoxes(this);
            textBoxBairro.Enabled = false;
            textBoxCidade.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxEndereco.Enabled = false;
            textBoxFantasia.Enabled = false;
            textBoxNumero.Enabled = false;
            textBoxRazao.Enabled = false;
            maskedTextBoxCelular.Enabled = false;
            maskedTextBoxCep.Enabled = false;
            maskedTextBoxCnpj.Enabled = false;
            maskedTextBoxTelefone.Enabled = false;
            buttoncancel.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;         
            btnNovo.Focus();
        }
        private void buttonSaiAtendimento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand("select * from fornecedores", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            if (radioButtonCodigo.Checked)
            {
                dv.RowFilter = "cod_fornecedor =" + textBox2.Text;
            }
            if (radioButtonFantasia.Checked)
            {
                dv.RowFilter = "fantasia like'%" + textBox2.Text + "%'";
            }
            if (radioButtonrRazao.Checked)
            {
                dv.RowFilter = "razão like '%" + textBox2.Text + "%'";
            }
            fornecedoresDataGridView.DataSource = dv;
            con.Close();
        }

        private void textBoxFantasia_Enter(object sender, EventArgs e)
        {
            string razaun;
            string fantasia;

            razaun = textBoxRazao.Text;
            fantasia = razaun;
            textBoxFantasia.Text = razaun;
        }

        private void btnLocaliza_Click(object sender, EventArgs e)
        {
            novo = false;
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }       

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand("select * from fornecedores", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            if (radioButtonCodigo.Checked)
            {
                dv.RowFilter = "cod_fornecedor =" + textBox2.Text;
            }
            if (radioButtonFantasia.Checked)
            {
                dv.RowFilter = "fantasia like'%" + textBox2.Text + "%'";
            }
            if (radioButtonrRazao.Checked)
            {
                dv.RowFilter = "razão like '%" + textBox2.Text + "%'";
            }
            fornecedoresDataGridView.DataSource = dv;
            con.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonCodigo.Checked)
            {
                if (char.IsLetter(e.KeyChar) ||

               char.IsSymbol(e.KeyChar) ||

               char.IsWhiteSpace(e.KeyChar))


                    e.Handled = true;
                if (e.KeyChar == ','
                && (sender as TextBox).Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void maskedTextBoxCnpj_Leave(object sender, EventArgs e)
        {
            try
            {
                string valor = maskedTextBoxCnpj.Text;
                if (validacao.ValidaCnpj.IsCnpj(valor))
                {
                    textBoxNumero.Focus();
                }
            }
            catch
            {
                MessageBox.Show("O CNPJ informado não é valido", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                textBoxNumero.Focus();
            }
        }

        private void textBoxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCidade_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCidade.Text == null)
            {
                txtNcidade.Focus();
            }
            else
            {
                string buscaCidade = "Select cid_nome From cidades where cid_codigo = '" + textBoxCidade.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand sqlCommand = new SqlCommand(buscaCidade, con);

                con.Open();
                SqlDataReader dR = sqlCommand.ExecuteReader();

                if (dR.Read())
                {
                    txtNcidade.Text = dR[0].ToString();
                }

                con.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            panelCid.Visible = false;
        }

        private void btnPcidade_Click(object sender, EventArgs e)
        {
            panelCid.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                panelCid.Visible = false;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxCidade.Text = row.Cells[0].Value.ToString();
                txtNcidade.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand("select * from cidades", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            if (rbCcid.Checked)
            {
                dv.RowFilter = "cid_codigo = " + txtcid.Text;
            }
            if (rbNomeC.Checked)
            {
                dv.RowFilter = "cid_nome like '%" + txtcid.Text + "%'";
            }
            dataGridView1.DataSource = dv;
            con.Close();
        }

        private void fornecedoresDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                panel1.Visible = false;
                DataGridViewRow row = this.fornecedoresDataGridView.Rows[e.RowIndex];
                textBoxCodFornecedor.Text = row.Cells[0].Value.ToString();
                textBoxRazao.Text = row.Cells[1].Value.ToString();
                textBoxFantasia.Text = row.Cells[2].Value.ToString();
                textBoxEndereco.Text = row.Cells[3].Value.ToString();
                textBoxBairro.Text = row.Cells[4].Value.ToString();
                textBoxCidade.Text = row.Cells[5].Value.ToString();
                maskedTextBoxTelefone.Text = row.Cells[6].Value.ToString();
                maskedTextBoxCelular.Text = row.Cells[7].Value.ToString();
                maskedTextBoxCep.Text = row.Cells[8].Value.ToString();
                textBoxObs.Text = row.Cells[9].Value.ToString();
                maskedTextBoxCnpj.Text = row.Cells[10].Value.ToString();
                //textBoxNumero.Text = row.Cells[11].Value.ToString();
                textBoxEmail.Text = row.Cells[12].Value.ToString();
                textBoxBairro.Enabled = true;
                textBoxCidade.Enabled = true;
                textBoxEmail.Enabled = true;
                textBoxEndereco.Enabled = true;
                textBoxFantasia.Enabled = true;
                textBoxNumero.Enabled = true;
                textBoxRazao.Enabled = true;
                maskedTextBoxCelular.Enabled = true;
                maskedTextBoxCep.Enabled = true;
                maskedTextBoxCnpj.Enabled = true;
                maskedTextBoxTelefone.Enabled = true;
                buttoncancel.Enabled = true;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                btnNovo.Enabled = false;
                textBoxRazao.Focus();
                txtNcidade.Enabled = true;
                btnPcidade.Enabled = true;
                btnExcluir.Enabled = true;

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void textBoxRazao_Leave(object sender, EventArgs e)
        {
            string razaun;
            string fantasia;

            razaun = textBoxRazao.Text;
            fantasia = razaun;
            textBoxFantasia.Text = razaun;
            if (EnableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void textBoxCodFornecedor_Leave(object sender, EventArgs e)
        {
            if (EnableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void textBoxCidade_Leave(object sender, EventArgs e)
        {
            if (EnableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }
    }
}
