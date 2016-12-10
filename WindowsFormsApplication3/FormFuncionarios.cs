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
    public partial class FormFuncionarios : Form
    {
        bool novo;
        public FormFuncionarios()
        {
            InitializeComponent();
        }
        utils u = new utils();

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {

            this.MaximizeBox = false;
            panelCid.Visible = false;
            rbNomeC.Checked = true;
            panel1.Visible = false;
            u.limparMTextBoxes(this);
            u.limparTextBoxes(this);
            textBoxCodFuncionario.Enabled = false;
            textBoxBairroFuncionario.Enabled = false;
            textBoxCidadeFuncionario.Enabled = false;
            textBoxEndereco.Enabled = false;
            textBoxNomeFuncionario.Enabled = false;
            textBoxNumero.Enabled = false;
            maskedTextBoxCelular.Enabled = false;
            maskedTextBoxCepFuncionario.Enabled = false;
            maskedTextBoxCpf.Enabled = false;
            maskedTextBoxCtps.Enabled = false;
            maskedTextBoxDatacon.Enabled = false;
            maskedTextBoxTelefoneFuncionario.Enabled = false;
            btnPcidade.Enabled = false;            
            txtNcid.Enabled = false;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            buttonCancelareg.Enabled = false;          
            btnNovo.Focus();
        }

        private void buttonSaiAtendimento_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        private void buttonLocalizaCadCliente_Click(object sender, EventArgs e)
        {
            u.limparMTextBoxes(this);
            u.limparTextBoxes(this);
            textBoxCodFuncionario.Enabled = false;
            textBoxBairroFuncionario.Enabled = false;
            textBoxCidadeFuncionario.Enabled = false;
            textBoxEndereco.Enabled = false;
            textBoxNomeFuncionario.Enabled = false;
            textBoxNumero.Enabled = false;
            maskedTextBoxCelular.Enabled = false;
            maskedTextBoxCepFuncionario.Enabled = false;
            maskedTextBoxCpf.Enabled = false;
            maskedTextBoxCtps.Enabled = false;
            maskedTextBoxDatacon.Enabled = false;
            maskedTextBoxTelefoneFuncionario.Enabled = false;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            buttonCancelareg.Enabled = false;
            btnPcidade.Enabled = false;
            
        }
        private void FormFuncionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FrmFuncionarios = null;
        }

        private void btnLocaliza_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            u.limparMTextBoxes(this);
            u.limparTextBoxes(this);
            textBoxBairroFuncionario.Enabled = true;
            textBoxCidadeFuncionario.Enabled = true;
            textBoxEndereco.Enabled = true;
            textBoxNomeFuncionario.Enabled = true;
            textBoxNumero.Enabled = true;
            maskedTextBoxCelular.Enabled = true;
            maskedTextBoxCepFuncionario.Enabled = true;
            maskedTextBoxCpf.Enabled = true;
            maskedTextBoxCtps.Enabled = true;
            maskedTextBoxDatacon.Enabled = true;
            maskedTextBoxTelefoneFuncionario.Enabled = true;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            buttonCancelareg.Enabled = true;
            btnPcidade.Enabled = true;
            txtNcid.Enabled = true;
            novo = true;
            textBoxNomeFuncionario.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja realmente excluir esse registro? ", "Mensagem do sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (escolha == DialogResult.Cancel)
            {
                u.limparMTextBoxes(this);
                u.limparTextBoxes(this);
                textBoxCodFuncionario.Enabled = false;
                textBoxBairroFuncionario.Enabled = false;
                textBoxCidadeFuncionario.Enabled = false;
                textBoxEndereco.Enabled = false;
                textBoxNomeFuncionario.Enabled = false;
                textBoxNumero.Enabled = false;
                maskedTextBoxCelular.Enabled = false;
                maskedTextBoxCepFuncionario.Enabled = false;
                maskedTextBoxCpf.Enabled = false;
                maskedTextBoxCtps.Enabled = false;
                maskedTextBoxDatacon.Enabled = false;
                maskedTextBoxTelefoneFuncionario.Enabled = false;
                btnNovo.Enabled = true;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                buttonCancelareg.Enabled = false;
                btnPcidade.Enabled = false;               

            }
            else
            {

                string excrui = "delete from funcionarios where cod_funcionario =  " + textBoxCodFuncionario.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(excrui, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if
                        (i > 0)
                        u.messageboxSucesso();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao Gravar no banco de dados" + ex.ToString(), "Mensagem de Erro do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    funcionariosDataGridView.Refresh();
                    con.Close();
                }
                u.limparMTextBoxes(this);
                u.limparTextBoxes(this);
                textBoxBairroFuncionario.Enabled = false;
                textBoxCidadeFuncionario.Enabled = false;
                textBoxEndereco.Enabled = false;
                textBoxNomeFuncionario.Enabled = false;
                textBoxNumero.Enabled = false;
                maskedTextBoxCelular.Enabled = false;
                maskedTextBoxCepFuncionario.Enabled = false;
                maskedTextBoxCpf.Enabled = false;
                maskedTextBoxCtps.Enabled = false;
                maskedTextBoxDatacon.Enabled = false;
                maskedTextBoxTelefoneFuncionario.Enabled = false;
                btnNovo.Enabled = true;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                buttonCancelareg.Enabled = false;
                btnLocaliza.Enabled = true;
                btnPcidade.Enabled = false;
                txtNcid.Enabled = false;
               
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxNomeFuncionario.Text == string.Empty)
            {
                textBoxNomeFuncionario.BackColor = Color.Gold;
                u.messageboxCamposObrigatorio();
            }
            else
            {
                if (novo)
                {
                    string insere = "insert into funcionarios(n_funcionario, endereco, bairro, cidade, telefone, celular, cep, data_contratacao, obs, ctps, cpf, email) " +
                        "values ('" + textBoxNomeFuncionario.Text + "','"
                            + textBoxEndereco.Text + "','"
                            + textBoxBairroFuncionario.Text + "','"
                            + textBoxCidadeFuncionario.Text + "','"
                            + maskedTextBoxTelefoneFuncionario.Text + "','"
                            + maskedTextBoxCelular.Text + "','"
                            + maskedTextBoxCepFuncionario.Text + "','"
                            + maskedTextBoxDatacon.Text + "','"
                            + textBoxObs.Text + "','"
                            + maskedTextBoxCtps.Text + "','"
                            + maskedTextBoxCpf.Text + "','"
                            + textBoxNumero.Text + "')";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(insere, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            u.messageboxSucesso();
                        funcionariosDataGridView.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString());
                    }
                    finally
                    {
                        funcionariosDataGridView.Refresh();
                        con.Close();
                    }
                }
                else
                {
                    string altera = "update funcionarios set n_funcionario = '" + textBoxNomeFuncionario.Text +
                        "', endereco = '" + textBoxEndereco.Text +
                        "',bairro = '" + textBoxBairroFuncionario.Text +
                        "',cidade = '" + textBoxCidadeFuncionario.Text +
                        "',telefone = '" + maskedTextBoxTelefoneFuncionario.Text +
                        "', celular = '" + maskedTextBoxCelular.Text +
                        "',cep = '" + maskedTextBoxCepFuncionario.Text +
                        "', data_contratacao = '" + maskedTextBoxDatacon.Text +
                        "', obs = '" + textBoxObs.Text +
                        "', ctps = '" + maskedTextBoxCtps.Text +
                        "', cpf =  '" + maskedTextBoxCpf.Text +
                        "', email = '" + textBoxNumero.Text + "' where cod_funcionario = '" + textBoxCodFuncionario.Text + "'";
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
                        funcionariosDataGridView.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString());
                    }
                    finally
                    {
                        funcionariosDataGridView.Refresh();
                        con.Close();
                    }

                }
                u.limparMTextBoxes(this);
                u.limparTextBoxes(this);
                textBoxCodFuncionario.Enabled = false;
                textBoxBairroFuncionario.Enabled = false;
                textBoxCidadeFuncionario.Enabled = false;
                textBoxEndereco.Enabled = false;
                textBoxNomeFuncionario.Enabled = false;
                textBoxNumero.Enabled = false;
                maskedTextBoxCelular.Enabled = false;
                maskedTextBoxCepFuncionario.Enabled = false;
                maskedTextBoxCpf.Enabled = false;
                maskedTextBoxCtps.Enabled = false;
                maskedTextBoxDatacon.Enabled = false;
                maskedTextBoxTelefoneFuncionario.Enabled = false;
                btnPcidade.Enabled = false;
                txtNcid.Enabled = false;
                btnNovo.Enabled = true;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = false;
                buttonCancelareg.Enabled = false;
                textBoxNomeFuncionario.BackColor = SystemColors.Window;
                btnNovo.Focus();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand("select * from funcionarios", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            if (radioButtonCodigo.Checked)
            {
                dv.RowFilter = "cod_funcionario = " + textBox2.Text;
            }
            if (radioButtonDescricao.Checked)
            {
                dv.RowFilter = "n_funcionario like '%" + textBox2.Text + "%'";
            }
            funcionariosDataGridView.DataSource = dv;
            con.Close();
        }

        private void radioButtonDescricao_Enter(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void radioButtonCodigo_Enter(object sender, EventArgs e)
        {
            textBox2.Focus();
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

        private void funcionariosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                panel1.Visible = false;
                DataGridViewRow row = this.funcionariosDataGridView.Rows[e.RowIndex];
                textBoxCodFuncionario.Text = row.Cells[0].Value.ToString();
                textBoxNomeFuncionario.Text = row.Cells[1].Value.ToString();
                textBoxEndereco.Text = row.Cells[2].Value.ToString();
                textBoxBairroFuncionario.Text = row.Cells[3].Value.ToString();
                textBoxCidadeFuncionario.Text = row.Cells[4].Value.ToString();
                maskedTextBoxTelefoneFuncionario.Text = row.Cells[5].Value.ToString();
                maskedTextBoxCelular.Text = row.Cells[6].Value.ToString();
                maskedTextBoxCepFuncionario.Text = row.Cells[7].Value.ToString();
                maskedTextBoxDatacon.Text = row.Cells[8].Value.ToString();
                textBoxObs.Text = row.Cells[9].Value.ToString();
                maskedTextBoxCtps.Text = row.Cells[10].Value.ToString();
                maskedTextBoxCpf.Text = row.Cells[12].Value.ToString();
                textBoxNumero.Text = row.Cells[13].Value.ToString();
                textBoxBairroFuncionario.Enabled = true;
                textBoxCidadeFuncionario.Enabled = true;
                textBoxEndereco.Enabled = true;
                textBoxNomeFuncionario.Enabled = true;
                textBoxNumero.Enabled = true;
                maskedTextBoxCelular.Enabled = true;
                maskedTextBoxCepFuncionario.Enabled = true;
                maskedTextBoxCpf.Enabled = true;
                maskedTextBoxCtps.Enabled = true;
                maskedTextBoxDatacon.Enabled = true;
                maskedTextBoxTelefoneFuncionario.Enabled = true;
                btnNovo.Enabled = false;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = true;
                buttonCancelareg.Enabled = true;
                textBoxNomeFuncionario.Focus();
                btnPcidade.Enabled = true;
                txtNcid.Enabled = true;
                
            }
        }

        private void maskedTextBoxCpf_Leave(object sender, EventArgs e)
        {
            try
            {
                string valor = maskedTextBoxCpf.Text;
                if (ValidaCPF.ValidaCPF.Valida(valor))
                {
                    textBoxBairroFuncionario.Focus();

                }
            }
            catch
            {
                MessageBox.Show("O CPF digitado é inválido", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                textBoxBairroFuncionario.Focus();
            }
        }

        private void btnPcidade_Click(object sender, EventArgs e)
        {
            panelCid.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            panelCid.Visible = false;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                panelCid.Visible = false;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxCidadeFuncionario.Text = row.Cells[0].Value.ToString();
                txtNcid.Text = row.Cells[1].Value.ToString();
            }
        }

        private void textBoxCidadeFuncionario_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCidadeFuncionario.Text == null)
            {
                txtNcid.Focus();

            }
            else
            {
                string buscaCidade = "Select cid_nome From cidades where cid_codigo = '" + textBoxCidadeFuncionario.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand sqlCommand = new SqlCommand(buscaCidade, con);

                con.Open();
                SqlDataReader dR = sqlCommand.ExecuteReader();

                if (dR.Read())
                {
                    txtNcid.Text = dR[0].ToString();
                }
                con.Close();
            }
        }

        private void textBoxCidadeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBoxDatacon_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                u.messageboxDataInv();
            }
        }
    }
}
