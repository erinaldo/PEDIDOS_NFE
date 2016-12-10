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
    public partial class FormProdutos : Form
    {
        bool novo;
        public FormProdutos()
        {
            InitializeComponent();
        }

        utils u = new utils();
        private void Unovo()
        {
            panel1.Visible = false;
            u.limparMTextBoxes(this);
            u.limparTextBoxes(this);
            u.limparCombo(this);
            u.DisableTxt(this);
            u.DisableCombo(this);
            textBoxCodPoduto.Enabled = false;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            textBoxVlVenda.Text = "0,00";
            textBoxMarge.Text = "0,00";
            textBoxEstoque.Text = "0,00";
            textBox1CustoPro.Text = "0,00";
            txtAliqCofins.Text = "0,00";
            txtAliqIcms.Text = "0,00";
            txtAliqIpi.Text = "0,00";
            txtAliqPis.Text = "0,00";
            buttonCancela.Enabled = false;  
           

            btnNovo.Focus();
        }
        private void Ualterar()
        {
            
            u.EnableTxt(this);
            u.EnableCombo(this);
            textBoxCodPoduto.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = true;
            buttonCancela.Enabled = true;
        }       

        private Boolean EnableSalvar()
        {

            if (textBoxDescricao.Text == string.Empty)
            {
                return false;
            }
            
            return true;
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {            
            this.MaximizeBox = false;
            Unovo();
            //u.SelectIndex(this);                       
            btnNovo.Focus();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxVlVenda_Leave(object sender, EventArgs e)
        {
            if (EnableSalvar())
            {
                btnSalvar.Enabled = true;
            }
            btnSalvar.Focus();
        }

        private void textBox1CustoPro_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxMarge_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxVlVenda_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxVlVenda_Enter(object sender, EventArgs e)
        {
            
            double vl_venda;
            double margem;
            double kusto;
            double calc_venda;
            if (double.TryParse(textBox1CustoPro.Text, out kusto) && double.TryParse(textBoxMarge.Text, out margem))
            {
                kusto = Convert.ToDouble(textBox1CustoPro.Text);
                margem = Convert.ToDouble(textBoxMarge.Text);
                calc_venda = kusto * (margem / 100);
                vl_venda = kusto + calc_venda;
                textBoxVlVenda.Text = vl_venda.ToString("N2");
                textBox1CustoPro.Text = Convert.ToString(kusto);
                textBoxMarge.Text = Convert.ToString(margem);
            }
            else
            {
                textBoxVlVenda.Text = "";
                MessageBox.Show("Algum valor informado é invalido.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void textBoxDesRed_Enter(object sender, EventArgs e)
        {
            string descrisaun;
            string descrisaunRed;

            descrisaun = textBoxDescricao.Text;
            descrisaunRed = descrisaun;
            textBoxDesRed.Text = descrisaunRed;
        }
        private void FormProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FrmProdutos = null;
        }

        private void button1_Click(object sender, EventArgs e)//btn novo
        {
            u.EnableCombo(this);
            u.EnableTxt(this);
            //u.SelectIndex(this);
            comboOrigem.SelectedIndex = 0;
            comboSituacao.SelectedIndex = 0;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;            
            textBoxVlVenda.Text = "0,00";
            textBoxMarge.Text = "0,00";
            textBoxEstoque.Text = "0,00";
            textBox1CustoPro.Text = "0,00";
            txtAliqCofins.Text = "0,00";
            txtAliqIcms.Text = "0,00";
            txtAliqIpi.Text = "0,00";
            txtAliqPis.Text = "0,00";
            buttonCancela.Enabled = true;
            textBoxDescricao.Focus();
            novo = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (
                textBox1CustoPro.Text == string.Empty ||
                textBoxDescricao.Text == string.Empty ||
                textBoxMarge.Text == string.Empty ||
                textBoxVlVenda.Text == string.Empty ||
                txtCfornecedor.Text == string.Empty)
            {

                txtCfornecedor.BackColor = Color.Gold;
                textBox1CustoPro.BackColor = Color.Gold;
                textBoxDescricao.BackColor = Color.Gold;
                textBoxMarge.BackColor = Color.Gold;
                textBoxVlVenda.BackColor = Color.Gold;
                u.messageboxCamposObrigatorio();
            }
            else
            {
                int cfop = Convert.ToInt32(comboCfop.Text);
                string cest = txtCest.Text;
                string ncm = txtNcm.Text;
                string origem = comboOrigem.SelectedIndex.ToString();
                int situacao = Convert.ToInt32(comboSituacao.SelectedIndex.ToString());
                string aliqInter = comboAliqINter.SelectedIndex.ToString();
                string aliqIcms = txtAliqIcms.Text;
                string aliqIpi = txtAliqIpi.Text;
                string aliqPis = txtAliqPis.Text;
                string aliqCofins = txtAliqCofins.Text;
                string cstIcms = comboCstIcms.Text;
                string cstIpi = comboCstIpi.Text;
                string cstPis = comboCstPis.Text;
                string cstCofins = comboCstCofins.Text;

                decimal valoproduto = Convert.ToDecimal(textBoxVlVenda.Text);
                decimal custuProduto = Convert.ToDecimal(textBox1CustoPro.Text);
                decimal marjeProduto = Convert.ToDecimal(textBoxMarge.Text);
                decimal estproduto = Convert.ToDecimal(textBoxEstoque.Text);
                string deprodutoV = textBoxDescricao.Text;
                string eanV = textBoxBarras.Text;
                string unmedidaV = textBoxUnMedida.Text;
                string desreduzidaV = textBoxDesRed.Text;
                int codforncedor = Convert.ToInt32(txtCfornecedor.Text.Trim());


                if (novo)
                {

                    string sql = "insert into produtos(des_produto,ean, cod_fornecedor, est_produto,un_medida,desc_reduzida,vl_produto,custo,margem,cfo_codigo,cest,ncm,origem,situacao,aliqinter,aliqicms,aliqipi,aliqpis,aliqcofins,csticms,cstipi,cstpis,cstcofins) Values(@des_produto,@ean, @cod_fornecedor, @est_produto,@un_medida,@desc_reduzida,@vl_produto,@custo,@margem,@cfo_codigo,@cest,@ncm,@origem,@situacao,@aliqinter,@aliqicms,@aliqipi,@aliqpis,@aliqcofins,@csticms,@cstipi,@cstpis,@cstcofins)";


                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add("@cfo_codigo",SqlDbType.Int).Value = cfop;
                    cmd.Parameters.Add("@cest", SqlDbType.NVarChar).Value = cest;
                    cmd.Parameters.Add("@ncm", SqlDbType.NVarChar).Value = ncm;
                    cmd.Parameters.Add("@origem", SqlDbType.Int).Value = origem;
                    cmd.Parameters.Add("@situacao", SqlDbType.Int).Value = situacao;
                    cmd.Parameters.Add("@aliqinter", SqlDbType.NVarChar).Value = aliqInter;
                    cmd.Parameters.Add("@aliqicms", SqlDbType.NVarChar).Value = aliqIcms;
                    cmd.Parameters.Add("@aliqipi", SqlDbType.NVarChar).Value = aliqIpi;
                    cmd.Parameters.Add("@aliqpis", SqlDbType.NVarChar).Value = aliqPis;
                    cmd.Parameters.Add("@aliqcofins", SqlDbType.NVarChar).Value = aliqCofins;
                    cmd.Parameters.Add("@csticms", SqlDbType.NVarChar).Value = cstIcms;
                    cmd.Parameters.Add("@cstipi", SqlDbType.NVarChar).Value = cstIpi;
                    cmd.Parameters.Add("@cstpis", SqlDbType.NVarChar).Value = cstPis;
                    cmd.Parameters.Add("@cstcofins", SqlDbType.NVarChar).Value = cstCofins;
                    cmd.Parameters.Add("@ean", SqlDbType.VarChar).Value = eanV;
                    cmd.Parameters.Add("@cod_fornecedor", SqlDbType.Int).Value = codforncedor;
                    cmd.Parameters.Add("@un_medida", SqlDbType.VarChar).Value = unmedidaV;
                    cmd.Parameters.Add("@desc_reduzida", SqlDbType.VarChar).Value = desreduzidaV;
                    cmd.Parameters.Add("@des_produto", SqlDbType.VarChar).Value = deprodutoV;
                    cmd.Parameters.Add("@est_produto", SqlDbType.Decimal).Value = estproduto;
                    cmd.Parameters.Add("@vl_produto", SqlDbType.Decimal).Value = valoproduto;
                    cmd.Parameters.Add("@custo", SqlDbType.Decimal).Value = custuProduto;
                    cmd.Parameters.Add("@margem", SqlDbType.Decimal).Value = marjeProduto;
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    produtosDataGridView.Refresh();
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
                    string sql = "update produtos set des_produto = @des_produto, cod_fornecedor = @cod_fornecedor, ean = @ean, est_produto = @est_produto, un_medida = @un_medida, vl_produto = @vl_produto, custo = @custo, margem = @margem, cfo_codigo = @cfo_codigo,cest = @cest,ncm = @ncm,origem = @origem,situacao = @situacao,aliqinter = @aliqinter,aliqicms = @aliqicms,aliqipi = @aliqipi,aliqpis = @aliqpis,aliqcofins = @aliqcofins,csticms = @csticms,cstipi = @cstipi,cstpis = @cstpis,cstcofins = @cstcofins where cod_produto = " + textBoxCodPoduto.Text;


                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add("@cfo_codigo", SqlDbType.Int).Value = cfop;
                    cmd.Parameters.Add("@cest", SqlDbType.NVarChar).Value = cest;
                    cmd.Parameters.Add("@ncm", SqlDbType.NVarChar).Value = ncm;
                    cmd.Parameters.Add("@origem", SqlDbType.Int).Value = origem;
                    cmd.Parameters.Add("@situacao", SqlDbType.Int).Value = situacao;
                    cmd.Parameters.Add("@aliqinter", SqlDbType.NVarChar).Value = aliqInter;
                    cmd.Parameters.Add("@aliqicms", SqlDbType.NVarChar).Value = aliqIcms;
                    cmd.Parameters.Add("@aliqipi", SqlDbType.NVarChar).Value = aliqIpi;
                    cmd.Parameters.Add("@aliqpis", SqlDbType.NVarChar).Value = aliqPis;
                    cmd.Parameters.Add("@aliqcofins", SqlDbType.NVarChar).Value = aliqCofins;
                    cmd.Parameters.Add("@csticms", SqlDbType.NVarChar).Value = cstIcms;
                    cmd.Parameters.Add("@cstipi", SqlDbType.NVarChar).Value = cstIpi;
                    cmd.Parameters.Add("@cstpis", SqlDbType.NVarChar).Value = cstPis;
                    cmd.Parameters.Add("@cstcofins", SqlDbType.NVarChar).Value = cstCofins;
                    cmd.Parameters.Add("@ean", SqlDbType.VarChar).Value = eanV;
                    cmd.Parameters.Add("@cod_fornecedor", SqlDbType.Int).Value = codforncedor;
                    cmd.Parameters.Add("@un_medida", SqlDbType.VarChar).Value = unmedidaV;
                    cmd.Parameters.Add("@desc_reduzida", SqlDbType.VarChar).Value = desreduzidaV;
                    cmd.Parameters.Add("@des_produto", SqlDbType.VarChar).Value = deprodutoV;
                    cmd.Parameters.Add("@est_produto", SqlDbType.Decimal).Value = estproduto;
                    cmd.Parameters.Add("@vl_produto", SqlDbType.Decimal).Value = valoproduto;
                    cmd.Parameters.Add("@custo", SqlDbType.Decimal).Value = custuProduto;
                    cmd.Parameters.Add("@margem", SqlDbType.Decimal).Value = marjeProduto;
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
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString(), "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                Unovo();
                txtCfornecedor.BackColor = SystemColors.Window;
                textBox1CustoPro.BackColor = SystemColors.Window;
                textBoxDescricao.BackColor = SystemColors.Window;
                textBoxMarge.BackColor = SystemColors.Window;
                textBoxVlVenda.BackColor = SystemColors.Window;
               
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Você realmente deseja excluir esse registro?", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (escolha == DialogResult.Cancel)
            {
         
            }
            else
            {
                string excrui = "delete from produtos where cod_produto = " + textBoxCodPoduto.Text;
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
                    con.Close();
                }
                Unovo();
                btnNovo.Focus();
                
            }
        }

        private void buttonCancela_Click(object sender, EventArgs e)
        {
            Unovo();
            btnNovo.Focus();          
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            panelPesquisa.Visible = true;
            novo = false;
        }

        private void btnSaiPesquisa_Click(object sender, EventArgs e)
        {
            panelPesquisa.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
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
                dv.RowFilter = "ean like '" + textBox1.Text + "%'";
            }
            if (radioButtonCodigo.Checked)
            {
                dv.RowFilter = "cod_produto = " + textBox1.Text;
            }
            if (radioButtonDescricao.Checked)
            {
                dv.RowFilter = "des_produto like '%" + textBox1.Text + "%'";
            }
            produtosDataGridView.DataSource = dv;
            con.Close();
        }

        private void produtosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelPesquisa.Visible = false;
            if (e.RowIndex >= 0)
            {
                //cfo_codigo,cest,ncm,origem,situacao,aliqinter,aliqicms,aliqipi,aliqpis,aliqcofins,csticms,cstipi,cstpis,cstcofins
                DataGridViewRow row = this.produtosDataGridView.Rows[e.RowIndex];
                textBoxCodPoduto.Text = row.Cells[0].Value.ToString();
                textBoxDescricao.Text = row.Cells[1].Value.ToString();
                textBoxBarras.Text = row.Cells[2].Value.ToString();
                txtCfornecedor.Text = row.Cells[3].Value.ToString();
                textBoxEstoque.Text = row.Cells[4].Value.ToString();
                textBoxUnMedida.Text = row.Cells[5].Value.ToString();
                textBoxDesRed.Text = row.Cells[6].Value.ToString();
                textBoxVlVenda.Text = row.Cells[7].Value.ToString();
                textBox1CustoPro.Text = row.Cells[8].Value.ToString();
                textBoxMarge.Text = row.Cells[9].Value.ToString();
                comboCfop.Text = row.Cells[10].Value.ToString();
                txtCest.Text = row.Cells[11].Value.ToString();
                txtNcm.Text = row.Cells[12].Value.ToString();
                comboOrigem.SelectedIndex = Convert.ToInt32(row.Cells[22].Value.ToString());
                comboSituacao.SelectedIndex = Convert.ToInt32(row.Cells[23].Value.ToString());
                comboAliqINter.Text = row.Cells[17].Value.ToString();
                txtAliqIcms.Text = row.Cells[18].Value.ToString();
                txtAliqIpi.Text = row.Cells[19].Value.ToString();
                txtAliqPis.Text = row.Cells[20].Value.ToString();
                txtAliqCofins.Text = row.Cells[21].Value.ToString();
                comboCstIcms.Text = row.Cells[13].Value.ToString();
                comboCstIpi.Text = row.Cells[14].Value.ToString();
                comboCstPis.Text = row.Cells[15].Value.ToString();
                comboCstCofins.Text = row.Cells[16].Value.ToString();

                
                Ualterar();
                textBoxDescricao.Focus();
            }
        }

        private void btnBforn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
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
                dv.RowFilter = "cod_fornecedor =" + txtCfornecedor.Text;
            }
            if (radioButtonFantasia.Checked)
            {
                dv.RowFilter = "fantasia like'%" + txtCfornecedor.Text + "%'";
            }
            if (radioButtonrRazao.Checked)
            {
                dv.RowFilter = "razão like '%" + txtCfornecedor.Text + "%'";
            }
            fornecedoresDataGridView.DataSource = dv;
            con.Close();
        }

        private void fornecedoresDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = false;

            DataGridViewRow row = this.fornecedoresDataGridView.Rows[e.RowIndex];
            txtCfornecedor.Text = row.Cells[0].Value.ToString();
            txtNfornecedor.Text = row.Cells[1].Value.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCfornecedor_TextChanged(object sender, EventArgs e)
        {
            if (txtCfornecedor.Text == null)
            {
                txtNfornecedor.Focus();

            }
            else
            {
                string buscaFornecedor = "Select fantasia From fornecedores where cod_fornecedor = '" + txtCfornecedor.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand sqlCommand = new SqlCommand(buscaFornecedor, con);

                con.Open();
                SqlDataReader dR = sqlCommand.ExecuteReader();

                if (dR.Read())
                {
                    txtNfornecedor.Text = dR[0].ToString();
                }

                con.Close();
            }
        }

        private void txtCfornecedor_TextChanged_1(object sender, EventArgs e)
        {
            if (txtCfornecedor.Text == null)
            {
                txtNfornecedor.Focus();

            }
            else
            {
                string buscaFornecedor = "Select fantasia From fornecedores where cod_fornecedor = '" + txtCfornecedor.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand sqlCommand = new SqlCommand(buscaFornecedor, con);

                con.Open();
                SqlDataReader dR = sqlCommand.ExecuteReader();

                if (dR.Read())
                {
                    txtNfornecedor.Text = dR[0].ToString();
                }

                con.Close();
            }
        }

        private void txtCfornecedor_Leave(object sender, EventArgs e)
        {
            if (txtCfornecedor.Text == null)
            {
                txtNfornecedor.Focus();

            }
            else
            {
                string buscaFornecedor = "Select fantasia From fornecedores where cod_fornecedor = '" + txtCfornecedor.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand sqlCommand = new SqlCommand(buscaFornecedor, con);

                con.Open();
                SqlDataReader dR = sqlCommand.ExecuteReader();

                if (dR.Read())
                {
                    txtNfornecedor.Text = dR[0].ToString();
                }

                con.Close();
            }
            if (EnableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void textBox1CustoPro_Leave(object sender, EventArgs e)
        {
            if (EnableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void textBoxMarge_Leave(object sender, EventArgs e)
        {
            if (EnableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void textBoxDescricao_Leave(object sender, EventArgs e)
        {
            if (EnableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.produtosTableAdapter1.FillBy(this.dataSet1.produtos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
    



