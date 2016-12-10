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
    public partial class FormCreceber : Form
    {
        bool novo;
        public FormCreceber()
        {
            InitializeComponent();
        }
        utils u = new utils();



        private void btnBuscaCadSecundario_Click(object sender, EventArgs e)
        {
            panelPesquisaClientes.Visible = true;

        }
        public void limparTextBoxes(Control controles)
        {

            foreach (Control ctrl in controles.Controls)
            {

                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = String.Empty;

                }
                else if (ctrl.Controls.Count > 0)
                {
                    limparTextBoxes(ctrl);
                }
            }
        }

        private void btnBClientePrincipal_Click(object sender, EventArgs e)
        {
            panelPesquisaClientes.Visible = true;
        }

        private void btnSaiPesquisa_Click(object sender, EventArgs e)
        {
            panelPesquisaClientes.Visible = false;
        }

        private void clientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelPesquisaClientes.Visible = false;
            DataGridViewRow row = this.clientesDataGridView.Rows[e.RowIndex];
            txtCCadastro.Text = row.Cells[0].Value.ToString();
            txtNcadastroPrincipal.Text = row.Cells[1].Value.ToString();
            txtpesqConRec.Text = row.Cells[0].Value.ToString();
            txtNpesquicon.Text = row.Cells[1].Value.ToString();
        }

        private void btnsaircPagar_Click(object sender, EventArgs e)
        {
            panelCreceber.Visible = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            panelCreceber.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCreceber_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FrmCreceber = null;
        }

        private void txtCCadastro_TextChanged(object sender, EventArgs e)
        {
            if (txtCCadastro.Text == null)
            {
                txtNcadastroPrincipal.Focus();

            }
            else
            {
                string buscaCliente = "Select n_cliente From clientes where cod_cliente = '" + txtCCadastro.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand sqlCommand = new SqlCommand(buscaCliente, con);

                con.Open();
                SqlDataReader dR = sqlCommand.ExecuteReader();

                if (dR.Read())
                {
                    txtNcadastroPrincipal.Text = dR[0].ToString();
                }

                con.Close();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVlRecebido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtJuros_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVlRecebido_Leave(object sender, EventArgs e)
        {
            double valorInicial;
            double valorPago;
            double valJuros;
            valorInicial = Convert.ToDouble(txtValor.Text);
            valorPago = Convert.ToDouble(txtVlRecebido.Text);
            valJuros = valorPago - valorInicial;
            if (valJuros > 0)
            {
                txtJuros.Text = Convert.ToString(valJuros);
            }
            else
            {
                txtJuros.Text = "0,00";
            }
            if (validaCalculo())
            {
                btnSalvar.Enabled = true;
            }

        }
        private Boolean validaCalculo()
        {

            if (txtCCadastro.Text == string.Empty)
            {
                return false;
            }
            else if (txtValor.Text == string.Empty)
            {
                return false;
            }
            else if (txtVlRecebido.Text == string.Empty)
            {
                return false;
            }
            else if (txtValor.Text == string.Empty)
            {
                return false;
            }

            return true;
        }

        private void txtCCadastro_Leave(object sender, EventArgs e)
        {
            if (validaCalculo())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void txtNcadastroPrincipal_Leave(object sender, EventArgs e)
        {
            if (validaCalculo())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (validaCalculo())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void mskDtVenc_Leave(object sender, EventArgs e)
        {
            if (validaCalculo())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void cdSituacao_Leave(object sender, EventArgs e)
        {
            if (validaCalculo())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void txtObs_Leave(object sender, EventArgs e)
        {
            if (validaCalculo())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (validaCalculo())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void FormCreceber_Load(object sender, EventArgs e)
        {
            cdSituacao.Text = "PENDENTE";
            u.limparTextBoxes(this);
            u.limparMTextBoxes(this);
            btnCancela.Enabled = false;
            btnBClientePrincipal.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSair.Enabled = true;
            btnSalvar.Enabled = false;
            txtCCadastro.Enabled = false;
            txtControle.Enabled = false;
            txtNcadastroPrincipal.Enabled = false;
            txtObs.Enabled = false;
            txtValor.Enabled = false;
            txtVlRecebido.Enabled = false;
            mskDtVenc.Enabled = false;
            maskedTextBox1.Enabled = false;
            cdSituacao.Enabled = false;            
            txtVlRecebido.Text = "0,00";
            txtJuros.Text = "0,00";
            panelCreceber.Visible = false;
            panelPesquisaClientes.Visible = false;
            txtCCadastro.Focus();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            cdSituacao.Text = "PENDENTE";
            u.limparTextBoxes(this);
            u.limparMTextBoxes(this);
            btnCancela.Enabled = false;
            btnBClientePrincipal.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSair.Enabled = true;
            btnSalvar.Enabled = false;
            txtCCadastro.Enabled = false;
            txtControle.Enabled = false;
            txtNcadastroPrincipal.Enabled = false;
            txtObs.Enabled = false;
            txtValor.Enabled = false;
            txtVlRecebido.Enabled = false;
            mskDtVenc.Enabled = false;
            maskedTextBox1.Enabled = false;
            cdSituacao.Enabled = false;           
            txtVlRecebido.Text = "0,00";
            txtJuros.Text = "0,00";
            panelCreceber.Visible = false;
            panelPesquisaClientes.Visible = false;
            txtCCadastro.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancela.Enabled = true;
            btnBClientePrincipal.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSair.Enabled = false;
            btnSalvar.Enabled = false;
            txtCCadastro.Enabled = true;
            txtNcadastroPrincipal.Enabled = true;
            txtObs.Enabled = true;
            txtValor.Enabled = true;
            limparTextBoxes(this);
            txtVlRecebido.Enabled = true;
            mskDtVenc.Enabled = true;
            maskedTextBox1.Enabled = true;
            cdSituacao.Enabled = true;
            novo = true;            
            txtVlRecebido.Text = "0,00";
            txtJuros.Text = "0,00";
            txtNcadastroPrincipal.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja realmente excluir esse registro", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (escolha == DialogResult.Cancel)
            {
                cdSituacao.Text = "PENDENTE";
                u.limparTextBoxes(this);
                u.limparMTextBoxes(this);
                btnCancela.Enabled = false;
                btnBClientePrincipal.Enabled = false;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnSair.Enabled = true;
                btnSalvar.Enabled = false;
                txtCCadastro.Enabled = false;
                txtControle.Enabled = false;
                txtNcadastroPrincipal.Enabled = false;
                txtObs.Enabled = false;
                txtValor.Enabled = false;
                txtVlRecebido.Enabled = false;
                mskDtVenc.Enabled = false;
                maskedTextBox1.Enabled = false;
                cdSituacao.Enabled = false;                
                txtVlRecebido.Text = "0,00";
                txtJuros.Text = "0,00";
                panelCreceber.Visible = false;
                panelPesquisaClientes.Visible = false;
                txtCCadastro.Focus();
            }
            else
            {
                string excluir = "delete from creceber where rec_codigo = " + txtControle.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(excluir, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if
                        (i > 0)
                        MessageBox.Show("Registro excluído com sucesso !", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao Gravar no banco de dados" + ex.ToString(), "Mensagem de Erro do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

            }
            cdSituacao.Text = "PENDENTE";
            u.limparTextBoxes(this);
            u.limparMTextBoxes(this);
            btnCancela.Enabled = false;
            btnBClientePrincipal.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSair.Enabled = true;
            btnSalvar.Enabled = false;
            txtCCadastro.Enabled = false;
            txtControle.Enabled = false;
            txtNcadastroPrincipal.Enabled = false;
            txtObs.Enabled = false;
            txtValor.Enabled = false;
            txtVlRecebido.Enabled = false;
            mskDtVenc.Enabled = false;
            maskedTextBox1.Enabled = false;
            cdSituacao.Enabled = false;
            
            txtVlRecebido.Text = "0,00";
            txtJuros.Text = "0,00";
            panelCreceber.Visible = false;
            panelPesquisaClientes.Visible = false;
            txtCCadastro.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCCadastro.Text == string.Empty || txtValor.Text == string.Empty || mskDtVenc.Text == string.Empty)
            {
                txtCCadastro.BackColor = Color.Gold;
                txtValor.BackColor = Color.Gold;
                mskDtVenc.BackColor = Color.Gold;
                MessageBox.Show("Os campos marcado em amarelo são obrigatórios !", "Mensagem o Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string Ncadastro = txtNcadastroPrincipal.Text.Trim();
                int codCadastro = Convert.ToInt32(txtCCadastro.Text.Trim());
                string dtvencto = mskDtVenc.Text.Trim();
                decimal valor = Convert.ToDecimal(txtValor.Text.Trim());
                string situacao = cdSituacao.Text.Trim();
                string dtBaixa = maskedTextBox1.Text.Trim();
                decimal vlpago = Convert.ToDecimal(txtVlRecebido.Text.Trim());
                decimal vlVlAdiconal = Convert.ToDecimal(txtJuros.Text.Trim());
                string observacao = txtObs.Text.Trim();

                if (novo)
                {
                    string inserir = "insert into creceber(cod_cliente, rec_valor, rec_valorrec, rec_dtvenc, rec_dtbaixa, rec_situacao, rec_obs, rec_vlacrescimo) values(@cod_cliente, @rec_valor, @rec_valorrec, @rec_dtvenc, @rec_dtbaixa, @rec_situacao, @rec_obs, @rec_vlacrescimo)";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(inserir, con);
                    cmd.Parameters.Add("@cod_cliente", SqlDbType.Int).Value = codCadastro;
                    cmd.Parameters.Add("@rec_valor", SqlDbType.Decimal).Value = valor;
                    cmd.Parameters.Add("@rec_valorrec", SqlDbType.Decimal).Value = vlpago;
                    cmd.Parameters.Add("@rec_dtvenc", SqlDbType.NVarChar).Value = dtvencto;
                    cmd.Parameters.Add("@rec_dtbaixa", SqlDbType.NVarChar).Value = dtBaixa;
                    cmd.Parameters.Add("@rec_situacao", SqlDbType.NVarChar).Value = situacao;
                    cmd.Parameters.Add("@rec_obs", SqlDbType.NVarChar).Value = observacao;
                    cmd.Parameters.Add("@rec_vlacrescimo", SqlDbType.Decimal).Value = vlVlAdiconal;
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Operação efetuada com sucesso !", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }



                }
                else
                {
                    string alterar = " update creceber set cod_cliente = @cod_cliente, rec_valor = @rec_valor, rec_valorrec = @rec_valorrec, rec_dtvenc = @rec_dtvenc, rec_dtbaixa = @rec_dtbaixa, rec_situacao =  @rec_situacao, rec_obs = @rec_obs, rec_vlacrescimo = @rec_vlacrescimo where rec_codigo = " + txtControle.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(alterar, con);
                    cmd.Parameters.Add("@cod_cliente", SqlDbType.Int).Value = codCadastro;
                    cmd.Parameters.Add("@rec_valor", SqlDbType.Decimal).Value = valor;
                    cmd.Parameters.Add("@rec_valorrec", SqlDbType.Decimal).Value = vlpago;
                    cmd.Parameters.Add("@rec_dtvenc", SqlDbType.NVarChar).Value = dtvencto;
                    cmd.Parameters.Add("@rec_dtbaixa", SqlDbType.NVarChar).Value = dtBaixa;
                    cmd.Parameters.Add("@rec_situacao", SqlDbType.NVarChar).Value = situacao;
                    cmd.Parameters.Add("@rec_obs", SqlDbType.NVarChar).Value = observacao;
                    cmd.Parameters.Add("@rec_vlacrescimo", SqlDbType.Decimal).Value = vlVlAdiconal;
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Operação efetuada com sucesso !", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                cdSituacao.Text = "PENDENTE";
                u.limparTextBoxes(this);
                u.limparMTextBoxes(this);
                btnCancela.Enabled = false;
                btnBClientePrincipal.Enabled = false;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnSair.Enabled = true;
                btnSalvar.Enabled = false;
                txtCCadastro.Enabled = false;
                txtControle.Enabled = false;
                txtNcadastroPrincipal.Enabled = false;
                txtObs.Enabled = false;
                txtValor.Enabled = false;
                txtVlRecebido.Enabled = false;
                mskDtVenc.Enabled = false;
                maskedTextBox1.Enabled = false;
                cdSituacao.Enabled = false;
                txtVlRecebido.Text = "0,00";
                txtJuros.Text = "0,00";
                panelCreceber.Visible = false;
                panelPesquisaClientes.Visible = false;
                txtCCadastro.Focus();
                txtCCadastro.BackColor = SystemColors.Window;
                txtValor.BackColor = SystemColors.Window;
                mskDtVenc.BackColor = SystemColors.Window;
            }
        }

        private void dataGridViewCpagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                panelCreceber.Visible = false;
                DataGridViewRow row = this.dataGridViewCpagar.Rows[e.RowIndex];
                txtControle.Text = row.Cells[0].Value.ToString();
                txtCCadastro.Text = row.Cells[1].Value.ToString();
                txtNcadastroPrincipal.Text = row.Cells[2].Value.ToString();
                txtValor.Text = row.Cells[3].Value.ToString();
                mskDtVenc.Text = row.Cells[4].Value.ToString();
                txtVlRecebido.Text = row.Cells[5].Value.ToString();
                maskedTextBox1.Text = row.Cells[6].Value.ToString();
                cdSituacao.Text = row.Cells[7].Value.ToString();
                txtObs.Text = row.Cells[8].Value.ToString();
                txtJuros.Text = row.Cells[9].Value.ToString();
                btnCancela.Enabled = true;
                btnBClientePrincipal.Enabled = true;
                btnExcluir.Enabled = true;
                btnNovo.Enabled = false;
                btnPesquisar.Enabled = false;
                btnSair.Enabled = false;
                btnSalvar.Enabled = false;
                txtCCadastro.Enabled = true;
                txtNcadastroPrincipal.Enabled = true;
                txtObs.Enabled = true;
                txtValor.Enabled = true;
                txtVlRecebido.Enabled = true;
                mskDtVenc.Enabled = true;
                maskedTextBox1.Enabled = true;
                cdSituacao.Enabled = true;
                
            }
        }

        private void btnFilCpagar_Click(object sender, EventArgs e)
        {
            if (txtpesqConRec.Text == string.Empty)
            {
                string buscacpagar = "select a.rec_codigo as Controle, a.cod_cliente as Código, b.n_cliente as Nome, a.rec_valor as Valor, a.rec_dtvenc as Vencimento, a.rec_valorrec as Recebido, a.rec_dtbaixa as Baixa, a.rec_situacao as Situação, a.rec_obs as Observações, a.rec_vlacrescimo as Acréscimos from Creceber a join clientes b on a.cod_cliente = b.cod_cliente order by a.rec_dtvenc";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(buscacpagar, con);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataView dv = new DataView(dt);
                dataGridViewCpagar.DataSource = dv;
                con.Close();
            }
            else
            {
                string buscacpagar = "select a.rec_codigo as Controle, a.cod_cliente as Código, b.n_cliente as Nome, a.rec_valor as Valor, a.rec_dtvenc as Vencimento, a.rec_valorrec as Recebido, a.rec_dtbaixa as Baixa, a.rec_situacao as Situação, a.rec_obs as Observações, a.rec_vlacrescimo as Acréscimos from Creceber a join clientes b on a.cod_cliente = b.cod_cliente where a.cod_cliente = " + txtpesqConRec.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(buscacpagar, con);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataView dv = new DataView(dt);
                dataGridViewCpagar.DataSource = dv;
                con.Close();
            }
        }

        private void btnPesquisaCliSecundario_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand("select * from clientes", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            if (radioButtonCodigo.Checked)
            {
                dv.RowFilter = "cod_cliente =" + txtpcli.Text;
            }
            if (radioButtonDescricao.Checked)
            {
                dv.RowFilter = "n_cliente like'%" + txtpcli.Text + "%'";
            }
            clientesDataGridView.DataSource = dv;

            con.Close();
        }

        private void txtpesqConRec_TextChanged(object sender, EventArgs e)
        {
            if (txtpesqConRec.Text == null)
            {
                btnPesquisaCliSecundario.Focus();

            }
            else
            {
                string buscaCliente = "Select n_cliente From clientes where cod_cliente = '" + txtpesqConRec.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand sqlCommand = new SqlCommand(buscaCliente, con);

                con.Open();
                SqlDataReader dR = sqlCommand.ExecuteReader();

                if (dR.Read())
                {
                    txtNpesquicon.Text = dR[0].ToString();
                }

                con.Close();
            }
        }

        private void mskDtVenc_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

