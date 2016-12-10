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
    public partial class FormEntProdutos : Form
    {
        bool novo;
        decimal kuantidade;
        decimal valProduto;
        decimal valUnitario;
        decimal desconto;
        int codproduto;
        public FormEntProdutos()
        {
            InitializeComponent();
        }
        utils u = new utils();       

        private void FormEntProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FrmEntProdutos = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand("select * from produtos", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            if (radioButtonBarras.Checked)
            {
                dv.RowFilter = "ean like '%" + textBox1.Text + "%'";
            }
            if (radioButton4.Checked)
            {
                dv.RowFilter = "cod_produto = " + textBox1.Text;
            }
            if (radioButton3.Checked)
            {
                dv.RowFilter = "des_produto like '%" + textBox1.Text + "%'";
            }
            produtosDataGridView.DataSource = dv;
            con.Close();
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
            if (radioButton1.Checked)
            {
                dv.RowFilter = "cod_fornecedor =" + textBox4.Text;
            }
            if (radioButtonFantasia.Checked)
            {
                dv.RowFilter = "fantasia like'%" + textBox4.Text + "%'";
            }
            if (radioButtonrRazao.Checked)
            {
                dv.RowFilter = "razão like '%" + textBox4.Text + "%'";
            }
            fornecedoresDataGridView.DataSource = dv;
            con.Close();
        }

        private void btnPCliente_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnPProduto_Click(object sender, EventArgs e)
        {
            panelPProdutos.Visible = true;
        }

        private void produtosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelPProdutos.Visible = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.produtosDataGridView.Rows[e.RowIndex];
                txtCodProduto.Text = row.Cells[0].Value.ToString();
                txtNomeProduto.Text = row.Cells[1].Value.ToString();
                txtValor.Text = row.Cells[8].Value.ToString();
            }
            txtQuantidade.Focus();
            txtQuantidade.Text = "1,00";
        }
        private Boolean validaCalculo()
        {

            if (txtVTotal.Text == string.Empty)
            {
                return false;
            }
            else if (txtCodProduto.Text == string.Empty)
            {
                return false;
            }
            else if (txtDesconto.Text == string.Empty)
            {
                return false;
            }
            else if (txtValor.Text == string.Empty)
            {
                return false;
            }
            else if (txtQuantidade.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void txtVTotal_Leave(object sender, EventArgs e)
        {
            if (validaCalculo())
            {
                btnInsProduto.Enabled = true;
            }
            if (enableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void txtVTotal_Enter(object sender, EventArgs e)
        {
            if (validaCalculo())
            {
                btnInsProduto.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fornecedoresDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                panel1.Visible = false;
                DataGridViewRow row = this.fornecedoresDataGridView.Rows[e.RowIndex];
                txtcodFornecedor.Text = row.Cells[0].Value.ToString();
                txtNomeFornecedor.Text = row.Cells[1].Value.ToString();
            }
        }

        private void txtcodFornecedor_Leave(object sender, EventArgs e)
        {
            if (txtcodFornecedor == null)
            {
                txtNomeFornecedor.Focus();
            }
            else
            {
                string getFornecedor = "select razão from fornecedores where cod_fornecedor =  '" + txtcodFornecedor.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(getFornecedor, con);
                

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNomeFornecedor.Text = dr[0].ToString();


                }
                con.Close();
            }
            if (enableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            if (txtCodProduto.Text == null)
            {
                txtNomeProduto.Focus();
            }
            else
            {
                string getProduto = "select des_produto from produtos where cod_produto = '" + txtCodProduto.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(getProduto, con);
                
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNomeProduto.Text = dr[0].ToString();
                }
                con.Close();
            }
            if (enableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void btnInsProduto_Click(object sender, EventArgs e)
        {
            
            
                kuantidade = Convert.ToDecimal(txtQuantidade.Text.Trim());
                valProduto = Convert.ToDecimal(txtVTotal.Text.Trim());
                valUnitario = Convert.ToDecimal(txtValor.Text.Trim());
                codproduto = Convert.ToInt32(txtCodProduto.Text.Trim());
                int comcodigo = Convert.ToInt32(txtControle.Text.Trim());

                string insProduto = " insert into compraitem(com_codigo, cod_produto, itp_valor, itp_qtde, itp_total)" +
                    "values(@com_codigo, @cod_produto, @itp_valor, @itp_qtde, @ipt_total)";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(insProduto, con);
                cmd.Parameters.Add("@com_codigo", SqlDbType.Int).Value = comcodigo;
                cmd.Parameters.Add("@cod_produto", SqlDbType.Int).Value = codproduto;
                cmd.Parameters.Add("@itp_valor", SqlDbType.Decimal).Value = valUnitario;
                cmd.Parameters.Add("@itp_qtde", SqlDbType.Decimal).Value = kuantidade;
                cmd.Parameters.Add("@ipt_total", SqlDbType.Decimal).Value = valProduto;

                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    if (dataGridView1.Rows.Cast<DataGridViewRow>().Any(row => row.Cells[0].Value.Equals(txtCodProduto.Text.Trim())))
                    {
                        MessageBox.Show("Erro: Produto já inserido ", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int i = cmd.ExecuteNonQuery();


                        if (i > 0)
                            dataGridView1.Rows.Add(txtCodProduto.Text, txtNomeProduto.Text, txtQuantidade.Text, txtValor.Text, txtDesconto.Text, txtVTotal.Text);
                        txtVTotal.Text = "";
                        txtValor.Text = "";
                        txtQuantidade.Text = "";
                        txtNomeProduto.Text = "";
                        txtCodProduto.Text = "";

                        btnInsProduto.Enabled = false;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: ", ex.ToString());
                }
                finally
                {
                    con.Close();
                }
               
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            string comDtemissao = Convert.ToString(mskDtVenda.Text);
            string nova = "insert into compra(com_data) values(@com_data)";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand(nova, con);
            cmd.Parameters.Add("@com_data", SqlDbType.NChar).Value = comDtemissao;
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    mskDtVenda.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            txtControle.Enabled = false;
            txtcodFornecedor.Enabled = true;
            txtNomeFornecedor.Enabled = true;            
            txtNomeProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;
            txtVTotal.Enabled = true;
            txtDesconto.Enabled = true;
            btnExcluir.Enabled = false;
            btnInsProduto.Enabled = false;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = true;
            btnPCliente.Enabled = true;
            btnPProduto.Enabled = true;
            txtCdesconto.Enabled = true;
            txtsomaTudo.Enabled = true;
            txtObs.Enabled = true;            
            txtSomaDesconto.Enabled = true;
            maskedTextBox1.Enabled = true;
            txtsomaTudo.Text = "0,00";
        }

        private void mskDtVenda_Leave(object sender, EventArgs e)
        {
            string query = "Select com_codigo From compra where com_codigo = (Select MAX(com_codigo) From compra)";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand sqlCommand = new SqlCommand(query, con);

            con.Open();
            SqlDataReader dR = sqlCommand.ExecuteReader();

            if (dR.Read())
            {
                txtControle.Text = dR[0].ToString();
            }
            con.Close();
        }

        private void FormEntProdutos_Load(object sender, EventArgs e)
        {
            u.limparMTextBoxes(this);
            u.limparTextBoxes(this);
            btnInsProduto.Enabled = false;
            panel1.Visible = false;
            panelPProdutos.Visible = false;
            txtObs.Enabled = false;           
            mskDtVenda.Text = DateTime.Now.ToString();
            txtControle.Enabled = false;            
            txtcodFornecedor.Enabled = false;
            txtNomeFornecedor.Enabled = false;
            txtCodProduto.Enabled = false;
            txtCdesconto.Enabled = false;          
            txtNomeProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;
            txtVTotal.Enabled = false;
            txtDesconto.Enabled = false;
            btnExcluir.Enabled = false;
            btnInsProduto.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnPCliente.Enabled = false;
            btnPProduto.Enabled = false;
            btnSalvar.Enabled = false;           
            txtsomaTudo.Enabled = false;
            maskedTextBox1.Enabled = false;
            txtSomaDesconto.Text = "0,00";
            txtDesconto.Text = "0,00";
            txtsomaTudo.Enabled = false;
            txtCdesconto.Enabled = false; 
            txtVTotal.Enabled = false;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            decimal valorTotal = 0;

            foreach (DataGridViewRow col in dataGridView1.Rows)
            {
                valorTotal = valorTotal + Convert.ToDecimal(col.Cells[5].Value);
            }

            txtsomaTudo.Text = Convert.ToString(valorTotal);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCdesconto.Text == string.Empty ||
                txtcodFornecedor.Text == string.Empty ||
                //txtCodProduto.Text == string.Empty ||
                //txtDesconto.Text == string.Empty ||
                txtSomaDesconto.Text == string.Empty ||
                txtsomaTudo.Text == string.Empty ||
                mskDtVenda.Text == string.Empty ||
                maskedTextBox1.Text == string.Empty)
            {
                txtCdesconto.BackColor = Color.Gold;
                txtcodFornecedor.BackColor = Color.Gold;
                //txtCodProduto.BackColor = Color.Gold;
                //txtDesconto.BackColor = Color.Gold;
                txtSomaDesconto.BackColor = Color.Gold;
                txtsomaTudo.BackColor = Color.Gold;
                mskDtVenda.BackColor = Color.Gold;
                maskedTextBox1.BackColor = Color.Gold;
                u.messageboxCamposObrigatorio();
            }
            else
            {
                if (txtSomaDesconto.Text == string.Empty)
                {
                    txtSomaDesconto.Text = "0,00";
                }
                int codcompra = Convert.ToInt32(txtControle.Text.Trim());
                decimal pedtotalliq = Convert.ToDecimal(txtCdesconto.Text.Trim());
                int codfornecedor = Convert.ToInt32(txtcodFornecedor.Text.Trim());
                desconto = Convert.ToDecimal(txtSomaDesconto.Text.Trim());
                string peddtEmissao = mskDtVenda.Text.Trim();
                string dtVenc = maskedTextBox1.Text.Trim();
                string pedobs = txtObs.Text;

                string atualiza = "update compra set com_totalliq = @com_totalliq, com_obs = @com_obs, com_desconto = @com_desconto where com_codigo = " + txtControle.Text;
                string financeiro = "insert into cpagar(pag_valor, pag_dtvenc, cod_cliente, pag_situacao, com_codigo) values(@com_totalliq, @pag_dtvenc, @cod_cliente, 'PENDENTE', @com_codigo)";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(atualiza, con);
                cmd.Parameters.Add("@com_totalliq", SqlDbType.Decimal).Value = pedtotalliq;
                cmd.Parameters.Add("@com_obs", SqlDbType.VarChar).Value = pedobs;
                cmd.Parameters.Add("@com_desconto", SqlDbType.Decimal).Value = desconto;




                //////////////////////////////////////////////////////conta pagar
                SqlCommand cmd1 = new SqlCommand(financeiro, con);
                cmd1.Parameters.Add("@com_totalliq", SqlDbType.Decimal).Value = pedtotalliq;
                cmd1.Parameters.Add("@cod_cliente", SqlDbType.Int).Value = codfornecedor;
                cmd1.Parameters.Add("@pag_dtvenc", SqlDbType.NVarChar).Value = dtVenc;
                cmd1.Parameters.Add("@com_codigo", SqlDbType.Int).Value = codcompra;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    int j = cmd1.ExecuteNonQuery();

                    if ((i > 0) || (j > 0))
                    {
                        u.messageboxSucesso();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString(), "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
                u.limparTextBoxes(this);
                u.limparMTextBoxes(this);
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                txtControle.Enabled = false;
                txtcodFornecedor.Enabled = false;
                txtNomeFornecedor.Enabled = false;
                txtNomeProduto.Enabled = false;
                txtQuantidade.Enabled = false;
                txtValor.Enabled = false;
                txtVTotal.Enabled = false;
                txtSomaDesconto.Enabled = false;
                txtCdesconto.Enabled = false;
                txtObs.Enabled = false;
                maskedTextBox1.Enabled = false;
                txtDesconto.Enabled = false;
                btnExcluir.Enabled = false;
                btnInsProduto.Enabled = false;
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnPCliente.Enabled = false;
                btnPProduto.Enabled = false;
                btnSalvar.Enabled = false;
                mskDtVenda.Enabled = false;
                txtsomaTudo.Enabled = false;
                txtCdesconto.BackColor = SystemColors.Window;
                txtcodFornecedor.BackColor = SystemColors.Window;
                txtCodProduto.BackColor = SystemColors.Window;
                txtDesconto.BackColor = SystemColors.Window;
                txtSomaDesconto.BackColor = SystemColors.Window;
                txtsomaTudo.BackColor = SystemColors.Window;
                mskDtVenda.BackColor = SystemColors.Window;
                maskedTextBox1.BackColor = SystemColors.Window;
            }
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            if (txtValor.Text == string.Empty)
            {
                txtValor.Text = "0,00";
                txtQuantidade.Text = "0,00";
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            kuantidade = Convert.ToDecimal(txtQuantidade.Text.Trim());
            valUnitario = Convert.ToDecimal(txtValor.Text.Trim());


            valProduto = kuantidade * valUnitario;
            txtVTotal.Text = Convert.ToString(valProduto);
        }

        private void txtSomaDesconto_Enter(object sender, EventArgs e)
        {
            if (txtSomaDesconto.Text == string.Empty)
            {
                txtValor.Text = "0,00";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Voce deseja realmente excluir esse registro", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (escolha == DialogResult.Cancel)
            {
                u.limparMTextBoxes(this);
                u.limparTextBoxes(this);
                btnInsProduto.Enabled = false;
                panel1.Visible = false;
                panelPProdutos.Visible = false;
                mskDtVenda.Text = DateTime.Now.ToString();
                txtControle.Enabled = false;
                txtcodFornecedor.Enabled = false;
                txtNomeFornecedor.Enabled = false;
                txtNomeProduto.Enabled = false;
                txtQuantidade.Enabled = false;
                txtValor.Enabled = false;
                txtVTotal.Enabled = false;
                txtDesconto.Enabled = false;
                btnExcluir.Enabled = false;
                btnInsProduto.Enabled = false;
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnPCliente.Enabled = false;
                btnPProduto.Enabled = false;
                btnSalvar.Enabled = false;
                txtsomaTudo.Enabled = false;
                maskedTextBox1.Enabled = false;              
                txtSomaDesconto.Text = "0,00";
                txtDesconto.Text = "0,00";

            }
            else
            {
                string excrui = "delete from compra where com_codigo = '" + txtControle.Text.Trim() + "'";
                string excruiitem = "delete from compraitem where com_codigo = '" + txtControle.Text.Trim() + "'";
                string excruipagamento = "delete from cpagar where com_codigo = '" + txtControle.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(excrui, con);
                cmd.CommandType = CommandType.Text;
                SqlCommand cmd1 = new SqlCommand(excruiitem, con);
                cmd1.CommandType = CommandType.Text;
                SqlCommand cmd2 = new SqlCommand(excruipagamento, con);
                cmd2.CommandType = CommandType.Text;


                con.Open();
                try
                {
                    int k = cmd2.ExecuteNonQuery();
                    int i = cmd.ExecuteNonQuery();
                    int j = cmd1.ExecuteNonQuery();
                    if ((i > 0) || (j > 0) || (k > 0))
                    {
                        u.messageboxSucesso();
                    }
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
        }

        private void buttonCancela_Click(object sender, EventArgs e)
        {
            u.limparTextBoxes(this);
            u.limparMTextBoxes(this);
            dataGridView1.Rows.Clear();
            btnInsProduto.Enabled = false;
            panel1.Visible = false;
            panelPProdutos.Visible = false;
            mskDtVenda.Text = DateTime.Now.ToString();
            txtControle.Enabled = false;
            txtcodFornecedor.Enabled = false;
            txtNomeFornecedor.Enabled = false;
            txtNomeProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;
            txtVTotal.Enabled = false;
            txtDesconto.Enabled = false;
            btnExcluir.Enabled = false;
            btnInsProduto.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnPCliente.Enabled = false;
            btnPProduto.Enabled = false;
            btnSalvar.Enabled = false;
            txtsomaTudo.Enabled = false;
            maskedTextBox1.Enabled = false;


            /////////////////////////////////////////////////////////////////////////////////////////////////
            string excrui = "delete from compra where com_codigo = '" + txtControle.Text.Trim() + "'";
            string excruiitem = "delete from compraitem where com_codigo = '" + txtControle.Text.Trim() + "'";
            

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand(excrui, con);
            cmd.CommandType = CommandType.Text;
            SqlCommand cmd1 = new SqlCommand(excruiitem, con);
            cmd1.CommandType = CommandType.Text;
            

            con.Open();
            try
            {
                
                int i = cmd.ExecuteNonQuery();
                int j = cmd1.ExecuteNonQuery();
                if ((i > 0) || (j > 0))
                {
                    u.messageboxSucesso();
                }
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

        private Boolean enableSalvar()
        {
            if (txtcodFornecedor.Text == string.Empty)
            {
                return false;
            }

            else if (txtSomaDesconto.Text == string.Empty)
            {
                return false;

            }
            else if (txtsomaTudo.Text == string.Empty)
            {
                return false;
            }
            else if (maskedTextBox1.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void txtNomeFornecedor_Leave(object sender, EventArgs e)
        {
            if (enableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void txtsomaTudo_Leave(object sender, EventArgs e)
        {
            if (enableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void txtSomaDesconto_Leave(object sender, EventArgs e)
        {
            if (enableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void txtCdesconto_Leave(object sender, EventArgs e)
        {
            if (enableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (enableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void txtCdesconto_Enter(object sender, EventArgs e)
        {
            decimal totSemDesconto = Convert.ToDecimal(txtsomaTudo.Text.Trim());
            desconto = Convert.ToDecimal(txtSomaDesconto.Text.Trim());
            decimal totalComDesconto = totSemDesconto - desconto;
            txtCdesconto.Text = Convert.ToString(totalComDesconto);
        }

        private void txtcodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtVTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsomaTudo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSomaDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCdesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                u.messageboxDataInv();
            }
        }

        private void mskDtVenda_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            /*if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
        }
    }
}
