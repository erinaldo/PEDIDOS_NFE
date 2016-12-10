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
    public partial class FormCidades : Form
    {
        
        bool novo;
        public FormCidades()
        {
            InitializeComponent();

        }
        utils limpartxt = new utils();
        utils u = new utils();
        
        

        private void FormCidades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jarbasDataSet1.cidades' table. You can move, or remove it, as needed.
            this.MaximizeBox = false;
            buttonExclui.Enabled = false;
            btnCancela.Enabled = false;
            buttonNovo.Enabled = true;
            buttonSair.Enabled = true;
            buttonSalva.Enabled = false;
            txtCodCidade.Enabled = false;
            txtCidade.Enabled = false;
            txtIbge.Enabled = false;
            comboBoxUf.Enabled = false;
            radioButtonDescricao.Checked = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NovoRegistro(object sender, EventArgs e)
        {
            buttonExclui.Enabled = false;
            btnCancela.Enabled = true;
            buttonNovo.Enabled = false;
            buttonSair.Enabled = true;
            buttonSalva.Enabled = true;
            txtCidade.Enabled = true;
            comboBoxUf.Enabled = true;  
            txtIbge.Enabled = true;
            limpartxt.limparTextBoxes(this);
            comboBoxUf.Text = "PR";
            txtCidade.Focus();
            novo = true;

        }

        private void FormCidades_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FrmCidades = null;
        }
        private bool valida()
        {
            if (txtCidade.Text.Trim() == string.Empty)
            {
                 return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand("select * from cidades", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            if (radioButtonCodigo.Checked)
            {

                dv.RowFilter = "cid_codigo =" + Convert.ToUInt32(textBox1.Text);

            }
            if (radioButtonDescricao.Checked)
            {
                dv.RowFilter = "cid_nome like'%" + textBox1.Text + "%'";
            }
            cIDADESDataGridView.DataSource = dv;

            con.Close();


        }

        private void buttonExclui_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Você deseja realmente excluir o registro selecionado?", "Mensagem do Sitema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (escolha == DialogResult.Cancel)
            {
                buttonExclui.Enabled = false;
                btnCancela.Enabled = true;
                buttonNovo.Enabled = true;
                buttonSair.Enabled = true;
                buttonSalva.Enabled = false;
                txtCodCidade.Enabled = false;
                txtCidade.Enabled = false;
                comboBoxUf.Enabled = false;    
                txtIbge.Enabled = false;
                limpartxt.limparTextBoxes(this);
                comboBoxUf.Text = "PR";
            }
            else
            {
                string sql = "delete from cidades where cid_codigo = " + txtCodCidade.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(sql, con);
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
            cIDADESDataGridView.Refresh();
            buttonExclui.Enabled = false;
            btnCancela.Enabled = true;
            buttonNovo.Enabled = true;
            buttonSair.Enabled = true;
            buttonSalva.Enabled = false;
            txtCodCidade.Enabled = false;
            txtIbge.Enabled = false;
            txtCidade.Enabled = false;
            comboBoxUf.Enabled = false;            
            limpartxt.limparTextBoxes(this);
            comboBoxUf.Text = "PR";
        }
        
        private void btnCancela_Click(object sender, EventArgs e)
        {
            buttonExclui.Enabled = false;
            btnCancela.Enabled = true;
            buttonNovo.Enabled = true;
            buttonSair.Enabled = true;
            buttonSalva.Enabled = false;
            txtCodCidade.Enabled = false;
            txtCidade.Enabled = false;
            txtIbge.Enabled = false;

            comboBoxUf.Enabled = false;            
            limpartxt.limparTextBoxes(this);
            comboBoxUf.Text = "PR";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelPesquisa.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            novo = false;
            panelPesquisa.Visible = true;
            textBox1.Focus();
            cIDADESDataGridView.Refresh();
        }

        private void cIDADESDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                panelPesquisa.Visible = false;
                DataGridViewRow row = this.cIDADESDataGridView.Rows[e.RowIndex];
                txtCodCidade.Text = row.Cells[0].Value.ToString();
                txtCidade.Text = row.Cells[1].Value.ToString();
                comboBoxUf.Text = row.Cells[2].Value.ToString();
                txtIbge.Text = row.Cells[3].Value.ToString();
                buttonExclui.Enabled = true;
                btnCancela.Enabled = true;
                buttonNovo.Enabled = false;
                buttonSair.Enabled = true;
                buttonSalva.Enabled = true;
                txtCodCidade.Enabled = true;
                txtCidade.Enabled = true;
                txtIbge.Enabled = true;

                comboBoxUf.Enabled = true;
                txtCidade.Focus();
            }
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            //Arquivotexto arq = new Arquivotexto();

            //Arquivotexto.writeData(txtCodCidade.Text, txtCidade.Text, comboBoxUf.Text);
            if (txtCidade.Text == string.Empty || comboBoxUf.Text == string.Empty)
            {
                txtCidade.BackColor = Color.Gold;
                comboBoxUf.BackColor = Color.Gold;
                u.messageboxCamposObrigatorio();
            }
            else
            {
                if (novo)
                {
                    string sql = "insert into cidades(cid_nome,cid_uf,cid_ibge) " + "values('" + txtCidade.Text + "','" 
                        + comboBoxUf.Text + "','" + txtIbge.Text +  "')";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(sql, con);
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
                    string sql = "update cidades set cid_nome = '" + txtCidade.Text +
                        "', cid_uf = '" + comboBoxUf.Text + "', cid_ibge = '" + txtIbge.Text + "'" + "where cid_codigo = '" + txtCodCidade.Text + "'" ;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(sql, con);
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
                        MessageBox.Show("Erro: Ao gravar no banco de dados" + ex.ToString(), "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cIDADESDataGridView.Refresh();
                        con.Close();
                    }
                }
                limpartxt.limparTextBoxes(this);
                buttonExclui.Enabled = false;
                btnCancela.Enabled = false;
                buttonNovo.Enabled = true;
                buttonSair.Enabled = true;
                buttonSalva.Enabled = false;
                txtCodCidade.Enabled = false;
                txtIbge.Enabled = false;
                txtCidade.Enabled = false;
                comboBoxUf.Enabled = false;
                txtCidade.BackColor = SystemColors.Window;
                comboBoxUf.BackColor = SystemColors.Window;

            }
        }

        private void radioButtonCodigo_Enter(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void radioButtonDescricao_Enter(object sender, EventArgs e)
        {
            textBox1.Focus();
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
    }
}




