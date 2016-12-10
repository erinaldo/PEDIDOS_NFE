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
    public partial class formCpagar : Form
    {
        bool novo;
        public formCpagar()
        {
            InitializeComponent();
        }
        utils u = new utils();
       
        private void formCpagar_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FrmCpagar = null;           
        }
        
        private void formCpagar_Load(object sender, EventArgs e)
        {
            u.limparTextBoxes(this);
            u.limparMTextBoxes(this);
            cdSituacao.Text = "PENDENTE";
            btnCancela.Enabled = false;
            btnBForn.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSair.Enabled = true;
            btnSalvar.Enabled = false;
            txtCCadastro.Enabled = false;
            txtControle.Enabled = false;
            txtNcadastro.Enabled = false;
            txtObs.Enabled = false;
            txtValor.Enabled = false;
            txtVlPago.Enabled = false;            
            cdSituacao.Enabled = false;           
            txtVlPago.Text = "0,00";
            txtJuros.Text = "0,00";
            panelCpagar.Visible = false;
            panelpFORNECEDOR.Visible = false;
            txtCCadastro.Focus();
            
            this.MaximizeBox = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            double valorInicial;
            double valorPago;
            double valJuros;
            valorInicial = Convert.ToDouble(txtValor.Text);
            valorPago = Convert.ToDouble(txtVlPago.Text);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja realmente excluir esse registro", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (escolha == DialogResult.Cancel)
            {
                u.limparTextBoxes(this);
                u.limparMTextBoxes(this);
                btnCancela.Enabled = false;
                btnBForn.Enabled = false;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnSair.Enabled = true;
                btnSalvar.Enabled = false;
                txtCCadastro.Enabled = false;
                txtControle.Enabled = false;
                txtNcadastro.Enabled = false;
                txtObs.Enabled = false;
                txtValor.Enabled = false;               
                txtVlPago.Enabled = false;
                mskDtVenc.Enabled = false;
                maskedTextBox1.Enabled = false;
                cdSituacao.Enabled = false;                           
                this.MaximizeBox = false;

            }
            else
            {
                string excluir = "delete from cpagar where pag_codigo = " + txtControle.Text;
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
                        u.messageboxSucesso();
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
            u.limparTextBoxes(this);
            u.limparMTextBoxes(this);
            btnCancela.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;
            btnBForn.Enabled = false;
            btnPesquisar.Enabled = true;
            btnSair.Enabled = true;
            btnSalvar.Enabled = false;
            txtCCadastro.Enabled = false;
            txtControle.Enabled = false;
            txtNcadastro.Enabled = false;
            txtObs.Enabled = false;
            txtValor.Enabled = false;            
            txtVlPago.Enabled = false;
            mskDtVenc.Enabled = false;
            maskedTextBox1.Enabled = false;
            cdSituacao.Enabled = false;            
            this.MaximizeBox = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            u.limparTextBoxes(this);
            u.limparMTextBoxes(this);
            btnCancela.Enabled = true;
            btnBForn.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSair.Enabled = false;
            btnSalvar.Enabled = false;
            txtCCadastro.Enabled = true;           
            txtNcadastro.Enabled = true;
            txtObs.Enabled = true;
            txtValor.Enabled = true;           
            txtVlPago.Enabled = true;
            mskDtVenc.Enabled = true;
            maskedTextBox1.Enabled = true;
            cdSituacao.Enabled = true;           
            novo = true;
            txtVlPago.Text = "0,00";
            txtJuros.Text = "0,00";
            txtNcadastro.Focus();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            u.limparTextBoxes(this);
            u.limparMTextBoxes(this);
            btnCancela.Enabled = false;
            btnBForn.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSair.Enabled = true;
            btnSalvar.Enabled = false;
            txtCCadastro.Enabled = false;
            txtControle.Enabled = false;
            txtNcadastro.Enabled = false;
            txtObs.Enabled = false;
            txtValor.Enabled = false;            
            txtVlPago.Enabled = false;
            mskDtVenc.Enabled = false;
            maskedTextBox1.Enabled = false;
            cdSituacao.Enabled = false;
            
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (txtCCadastro.Text == string.Empty || txtValor.Text == string.Empty || mskDtVenc.Text == string.Empty)
            {
                txtCCadastro.BackColor = Color.Gold;
                txtValor.BackColor = Color.Gold;
                mskDtVenc.BackColor = Color.Gold;
                u.messageboxCamposObrigatorio();
            }

            else
            {
                string Ncadastro = txtNcadastro.Text.Trim();
                int codCadastro = Convert.ToInt32(txtCCadastro.Text.Trim());
                string dtvencto = mskDtVenc.Text.Trim();
                decimal valor = Convert.ToDecimal(txtValor.Text.Trim());
                string situacao = cdSituacao.Text.Trim();
                string dtBaixa = maskedTextBox1.Text.Trim();
                decimal vlpago = Convert.ToDecimal(txtVlPago.Text.Trim());
                decimal vlVlAdiconal = Convert.ToDecimal(txtJuros.Text.Trim());
                string observacao = txtObs.Text.Trim();
                if (novo)
                {

                    string inserir = "insert into cpagar(cod_cliente, pag_valor, pag_recebido, pag_dtvenc, pag_dtbaixa, pag_situacao, pag_obs, pag_juros) values(@cod_cliente, @pag_valor, @pag_recebido, @pag_dtvenc, @pag_dtbaixa, @pag_situacao, @pag_obs, @pag_juros)";

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(inserir, con);
                    cmd.Parameters.Add("@cod_cliente", SqlDbType.Int).Value = codCadastro;
                    cmd.Parameters.Add("@pag_valor", SqlDbType.Decimal).Value = valor;
                    cmd.Parameters.Add("@pag_recebido", SqlDbType.Decimal).Value = vlpago;
                    cmd.Parameters.Add("@pag_dtvenc", SqlDbType.NVarChar).Value = dtvencto;
                    cmd.Parameters.Add("@pag_dtbaixa", SqlDbType.NVarChar).Value = dtBaixa;
                    cmd.Parameters.Add("@pag_situacao", SqlDbType.NChar).Value = situacao;
                    cmd.Parameters.Add("@pag_obs", SqlDbType.NVarChar).Value = observacao;
                    cmd.Parameters.Add("@pag_juros", SqlDbType.Decimal).Value = vlVlAdiconal;
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
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }
                }

                else
                {

                    string altera = "update cpagar set cod_cliente = @cod_cliente, pag_valor = @pag_valor, pag_recebido = @pag_recebido, pag_dtvenc = @pag_dtvenc, pag_dtbaixa = @pag_dtbaixa, pag_situacao = @pag_situacao, pag_obs = @pag_obs, pag_juros = @pag_juros where pag_codigo = " + txtControle.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(altera, con);
                    cmd.Parameters.Add("@cod_cliente", SqlDbType.Int).Value = codCadastro;
                    cmd.Parameters.Add("@pag_valor", SqlDbType.Decimal).Value = valor;
                    cmd.Parameters.Add("@pag_recebido", SqlDbType.Decimal).Value = vlpago;
                    cmd.Parameters.Add("@pag_dtvenc", SqlDbType.NVarChar).Value = dtvencto;
                    cmd.Parameters.Add("@pag_dtbaixa", SqlDbType.NVarChar).Value = dtBaixa;
                    cmd.Parameters.Add("@pag_situacao", SqlDbType.NChar).Value = situacao;
                    cmd.Parameters.Add("@pag_obs", SqlDbType.NVarChar).Value = observacao;
                    cmd.Parameters.Add("@pag_juros", SqlDbType.Decimal).Value = vlVlAdiconal;
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
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            
                u.limparTextBoxes(this);
                u.limparMTextBoxes(this);
                btnCancela.Enabled = false;
                btnBForn.Enabled = false;
                btnExcluir.Enabled = false;
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnSair.Enabled = true;
                btnSalvar.Enabled = false;
                txtCCadastro.Enabled = false;
                txtControle.Enabled = false;
                txtNcadastro.Enabled = false;
                txtObs.Enabled = false;
                txtValor.Enabled = false;
                txtVlPago.Enabled = false;
                mskDtVenc.Enabled = false;
                maskedTextBox1.Enabled = false;
                cdSituacao.Enabled = false;
                txtVlPago.Text = "0,00";
                txtJuros.Text = "0,00";
                txtValor.BackColor = SystemColors.Window;
                txtCCadastro.BackColor = SystemColors.Window;
                mskDtVenc.BackColor = SystemColors.Window;
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
            else if (txtVlPago.Text == string.Empty)
            {
                return false;
            }
            else if (txtValor.Text == string.Empty)
            {
                return false;
            }
            
            return true;
        }

        private void mskDtVenc_Leave(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            panelpFORNECEDOR.Visible = true;
        }

        private void btnSaiPforn_Click(object sender, EventArgs e)
        {
            panelpFORNECEDOR.Visible = false;
        }

        private void fornecedoresDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelpFORNECEDOR.Visible = false;
            DataGridViewRow row = this.fornecedoresDataGridView.Rows[e.RowIndex];
            txtCCadastro.Text = row.Cells[0].Value.ToString();
            txtNcadastro.Text = row.Cells[1].Value.ToString();
            txtpesqConPag.Text = row.Cells[0].Value.ToString();
            txtNpesquicon.Text = row.Cells[1].Value.ToString();
        }

        private void btnfilForn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand("select * from fornecedores", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            if (rbCodForn.Checked)
            {
                dv.RowFilter = "cod_fornecedor =" + txtpForn.Text;
            }
            if (radioButtonFantasia.Checked)
            {
                dv.RowFilter = "fantasia like'%" + txtpForn.Text + "%'";
            }
            if (radioButtonrRazao.Checked)
            {
                dv.RowFilter = "razão like '%" + txtpForn.Text + "%'";
            }
            fornecedoresDataGridView.DataSource = dv;
            con.Close();
        }

        private void txtCCadastro_TextChanged(object sender, EventArgs e)
        {
            if (txtCCadastro.Text == null)
            {
                txtNcadastro.Focus();

            }
            else
            {
                string buscaFornecedor = "Select fantasia From fornecedores where cod_fornecedor = '" + txtCCadastro.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand sqlCommand = new SqlCommand(buscaFornecedor, con);

                con.Open();
                SqlDataReader dR = sqlCommand.ExecuteReader();

                if (dR.Read())
                {
                    txtNcadastro.Text = dR[0].ToString();
                }

                con.Close();
            }
        }

        private void btnFilCpagar_Click(object sender, EventArgs e)
        {
            if (txtpesqConPag.Text == string.Empty)
            {

                string buscacpagar = "select a.pag_codigo as Controle, a.cod_cliente as Código, b.fantasia as Nome, a.pag_valor as Valor, a.pag_dtvenc as Vencimento, a.pag_recebido as Pago, a.pag_dtbaixa as Baixa, a.pag_situacao as Situação, a.pag_obs as Observações, a.pag_juros as Acréscimos from CPAGAR a join fornecedores b on a.cod_cliente = b.cod_fornecedor order by a.pag_dtvenc";


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
                string buscacpagar = "select a.pag_codigo as Controle, a.cod_cliente as Código, b.fantasia as Nome, a.pag_valor as Valor, a.pag_dtvenc as Vencimento, a.pag_recebido as Pago, a.pag_dtbaixa as Baixa, a.pag_situacao as Situação, a.pag_obs as Observações, a.pag_juros as Acréscimos from CPAGAR a join fornecedores b on a.cod_cliente = b.cod_fornecedor where a.cod_cliente = " + txtpesqConPag.Text;


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

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelpFORNECEDOR.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtpesqConPag.Text == null)
            {
                txtNpesquicon.Focus();
            }
            else
            {
                string buscaFornecedor = "Select fantasia From fornecedores where cod_fornecedor = '" + txtpesqConPag.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand sqlCommand = new SqlCommand(buscaFornecedor, con);

                con.Open();
                SqlDataReader dR = sqlCommand.ExecuteReader();

                if (dR.Read())
                {
                    txtNpesquicon.Text = dR[0].ToString();
                }

                con.Close();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            panelCpagar.Visible = true;
        }

        private void dataGridViewCpagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
           if (e.RowIndex >= 0)
             {
                panelCpagar.Visible = false;
                DataGridViewRow row = this.dataGridViewCpagar.Rows[e.RowIndex];
                txtControle.Text = row.Cells[0].Value.ToString();
                txtCCadastro.Text = row.Cells[1].Value.ToString();
                txtNcadastro.Text = row.Cells[2].Value.ToString();
                txtValor.Text = row.Cells[3].Value.ToString();
                mskDtVenc.Text = row.Cells[4].Value.ToString();
                txtVlPago.Text = row.Cells[5].Value.ToString();
                maskedTextBox1.Text = row.Cells[6].Value.ToString();
                cdSituacao.Text = row.Cells[7].Value.ToString();
                txtObs.Text = row.Cells[8].Value.ToString();
                txtJuros.Text = row.Cells[9].Value.ToString();
                btnCancela.Enabled = true;
                btnBForn.Enabled = true;
                btnExcluir.Enabled = true;
                btnNovo.Enabled = false;
                btnPesquisar.Enabled = false;
                btnSair.Enabled = false;
                btnSalvar.Enabled = false;
                txtCCadastro.Enabled = true;
                txtNcadastro.Enabled = true;
                txtObs.Enabled = true;
                txtValor.Enabled = true;             
                txtVlPago.Enabled = true;
                mskDtVenc.Enabled = true;
                maskedTextBox1.Enabled = true;
                cdSituacao.Enabled = true;
                txtJuros.Text = "0,00";
                txtVlPago.Text = "0,00";               
                txtNcadastro.Focus();
            }
         
        }

        private void btnsaircPagar_Click(object sender, EventArgs e)
        {
            panelCpagar.Visible = false;
        }

        private void mskDtVenc_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                u.messageboxDataInv();
            }
        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                u.messageboxDataInv();
            }
        }

        private void txtCCadastro_KeyPress(object sender, KeyPressEventArgs e)
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
}
