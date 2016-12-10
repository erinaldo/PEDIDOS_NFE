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
    public partial class FormAgenda : Form
    {
        bool novo;
        public FormAgenda()
        {
            InitializeComponent();
        }

        utils u = new utils();
        private Boolean EnableSalvar()
        {

            if (txtCliente.Text == string.Empty)
            {
                return false;
            }
            else if (txtFuncionario.Text == string.Empty)
            {
                return false;
            }

            return true;
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            u.limparTextBoxes(this);
            u.limparMTextBoxes(this);
            txtCliente.Enabled = false;
            txtFuncionario.Enabled = false;
            txtObs.Enabled = false;
            mskData.Enabled = false;
            mskHora.Enabled = false;
            cbSituação.Text = "Ocupado";
            btnCancela.Enabled = false;
            btnExluir.Enabled = false;
            btnSalvar.Enabled = false;
            panelPCliente.Visible = false;
            panelPfunc.Visible = false;
            btnLocalizar.Enabled = true;
           
        }

        private void buttonSaiAtendimento_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void FormAgenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FrmAgenda = null;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            u.limparTextBoxes(this);
            u.limparMTextBoxes(this);
            txtCliente.Enabled = false;
            txtFuncionario.Enabled = false;
            txtObs.Enabled = false;
            mskData.Enabled = false;
            mskHora.Enabled = false;
            cbSituação.Text = "Ocupado";
            btnCancela.Enabled = false;
            btnExluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnLocalizar.Enabled = true;
            

         }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            u.limparTextBoxes(this);
            u.limparMTextBoxes(this);
            txtCliente.Enabled = true;
            txtFuncionario.Enabled = true;
            txtObs.Enabled = true;
            mskData.Enabled = true;
            mskHora.Enabled = true;
            cbSituação.Text = "Ocupado";
            btnCancela.Enabled = true;
            btnExluir.Enabled = false;            
            btnLocalizar.Enabled = false;
            btnNovo.Enabled = false;
            btnLocalizar.Enabled = true;            
            novo = true;
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Deseja realmente excluir esse registro ?", "Mensagem do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (escolha == DialogResult.Cancel)
            {
                u.limparTextBoxes(this);
                u.limparMTextBoxes(this);
                txtCliente.Enabled = false;
                txtFuncionario.Enabled = false;
                txtObs.Enabled = false;
                mskData.Enabled = false;
                mskHora.Enabled = false;
                cbSituação.Text = "Ocupado";
                btnCancela.Enabled = false;
                btnExluir.Enabled = false;
                btnSalvar.Enabled = false;
                btnLocalizar.Enabled = true;
                
            }
            else
            {
                string excluir = "delete from agenda where age_codigo = " + txtControle.Text;

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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == string.Empty ||
                txtFuncionario.Text == string.Empty || 
                cbSituação.Text == string.Empty || 
                mskData.Text == string.Empty || 
                mskHora.Text == string.Empty)
            {
                txtFuncionario.BackColor = Color.Gold;
                txtCliente.BackColor = Color.Gold;
                cbSituação.BackColor = Color.Gold;
                mskHora.BackColor = Color.Gold;
                mskData.BackColor = Color.Gold;
                u.messageboxDataInv();
            }
            else
            {
                DateTime agdata = Convert.ToDateTime(mskData.Text);
                string aghora = mskHora.Text;
                string agconcluidos = cbSituação.Text;
                string agdescrisaun = txtObs.Text;
                int codfuncionario = Convert.ToInt32(txtFuncionario.Text);
                int codcliente = Convert.ToInt32(txtCliente.Text);




                if (novo)
                {
                    string grava = " insert into agenda(age_data, age_hora, age_concluidos, age_descricao, cod_funcionario, cod_cliente)" +
                        "values (@age_data, @age_hora, @age_concluidos, @age_descricao, @cod_funcionario, @cod_cliente)";
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(grava, con);
                    cmd.Parameters.Add("@age_data", SqlDbType.Date).Value = agdata;
                    cmd.Parameters.Add("@age_hora", SqlDbType.VarChar).Value = aghora;
                    cmd.Parameters.Add("@age_concluidos", SqlDbType.VarChar).Value = agconcluidos;
                    cmd.Parameters.Add("@age_descricao", SqlDbType.VarChar).Value = agdescrisaun;
                    cmd.Parameters.Add("@cod_funcionario", SqlDbType.Int).Value = codfuncionario;
                    cmd.Parameters.Add("@cod_cliente", SqlDbType.Int).Value = codcliente;

                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            u.messageboxSucesso();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString(), "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    string altera = " update agenda set age_data = @age_data, age_hora = @age_hora, age_concluido = @age_concluidos, age_descricao = @age_descricao, cod_funcionario = @cod_funcionario, cod_cliente = @cod_cliente where age_ccodigo = " + txtControle.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Ducaun;
                    SqlCommand cmd = new SqlCommand(altera, con);
                    cmd.Parameters.Add("@age_data", SqlDbType.Date).Value = agdata;
                    cmd.Parameters.Add("@age_hora", SqlDbType.VarChar).Value = aghora;
                    cmd.Parameters.Add("@age_concluidos", SqlDbType.VarChar).Value = agconcluidos;
                    cmd.Parameters.Add("@age_descricao", SqlDbType.VarChar).Value = agdescrisaun;
                    cmd.Parameters.Add("@cod_funcionario", SqlDbType.Int).Value = codfuncionario;
                    cmd.Parameters.Add("@cod_cliente", SqlDbType.Int).Value = codcliente;
                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            u.messageboxSucesso();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString(), "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                this.MaximizeBox = false;
                u.limparTextBoxes(this);
                u.limparMTextBoxes(this);
                txtCliente.Enabled = false;
                txtFuncionario.Enabled = false;
                txtObs.Enabled = false;
                mskData.Enabled = false;
                mskHora.Enabled = false;
                cbSituação.Text = "Ocupado";
                btnCancela.Enabled = false;
                btnExluir.Enabled = false;
                btnSalvar.Enabled = false;
                panelPCliente.Visible = false;
                panelPfunc.Visible = false;
                btnNovo.Enabled = true;
                btnLocalizar.Enabled = true;
                txtFuncionario.BackColor = SystemColors.Window;
                txtCliente.BackColor = SystemColors.Window;
                cbSituação.BackColor = SystemColors.Window;
                mskHora.BackColor = SystemColors.Window;
                mskData.BackColor = SystemColors.Window;

            }
        }





        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnCancela.Enabled = false;
            btnExluir.Enabled = false;
            btnLocalizar.Enabled = false;
            btnNovo.Enabled = false;
            btnSair.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DA.SelectCommand = new SqlCommand("select a.cod_produto, b.des_produto, a.ITP_QTDE, a.ITP_VALOR, a.ITP_TOTAL from ITEMPEDIDO a join produtos bon a.cod_produto = b.cod_produto where ped_codigo = " 
            // +txtControle.Text, new SqlConnection(Properties.Settings.Default.Ducaun));
            /*if (rbCliente.Checked)
            {
                string filtro = "select a.age_data as Data, a.age_hora as Hora,  b.n_cliente as Cliente from agenda a join clientes where n_cliente like '%" + mskFiltData.Text + "%' order by age_data, age_hora ";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(filtro, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataView dv = new DataView(dt);
                agendaDataGridView.DataSource = dv;
                con.Close();

            }
            if (rbData.Checked)
            {
                string filtro = "select a.age_data as Data, a.age_hora as Hora,  b.n_cliente as Cliente, a.cod_cliente from agenda a join clientes b on a.cod_cliente = b.cod_cliente  where age_data like '%" + mskFiltData.Text + "%' order by age_data, age_hora ";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd = new SqlCommand(filtro, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DataView dv = new DataView(dt);
                agendaDataGridView.DataSource = dv;
                con.Close();
                select * from agenda where age_data like '%" + mskFiltData.Text + "%' order by age_data, age_hora 
                select a.age_data as Data, a.age_hora as Hora,  b.n_cliente as Cliente, a.cod_cliente from agenda a join clientes b on a.cod_cliente = b.cod_cliente  where age_data like '%" + mskFiltData.Text + "%' order by age_data, age_hora
            }*/
            string filtro = "select * from agenda where age_data like '%" + mskFiltData.Text + "%' order by age_data, age_hora ";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand(filtro, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            agendaDataGridView.DataSource = dv;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            btnCancela.Enabled = false;
            btnExluir.Enabled = false;
            btnLocalizar.Enabled = true;
            btnNovo.Enabled = true;
            btnSair.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void agendaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = false;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.agendaDataGridView.Rows[e.RowIndex];
                txtControle.Text = row.Cells[0].Value.ToString();
                mskData.Text = row.Cells[1].Value.ToString();
                mskHora.Text = row.Cells[2].Value.ToString();
                cbSituação.Text = row.Cells[3].Value.ToString();
                txtObs.Text = row.Cells[5].Value.ToString();
                txtFuncionario.Text = row.Cells[6].Value.ToString();
                txtCliente.Text = row.Cells[7].Value.ToString();

            }


        }

        private void btnSaiCliente_Click(object sender, EventArgs e)
        {
            panelPCliente.Visible = false;
        }

        private void btnSaiFunc_Click(object sender, EventArgs e)
        {
            panelPfunc.Visible = false;
        }

        private void btnpclientes_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand("select * from clientes", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            if (radioCdClie.Checked)
            {
                dv.RowFilter = "cod_cliente =" + txtNcliente.Text;
            }
            if (radioDescClie.Checked)
            {
                dv.RowFilter = "n_cliente like'%" + txtNcliente.Text + "%'";
            }
            clientesDataGridView.DataSource = dv;

            con.Close();
        }

        private void btnPfunc_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand("select * from funcionarios", con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            if (radioCdFunc.Checked)
            {
                dv.RowFilter = "cod_funcionario = " + txtNfunc.Text;
            }
            if (radioDescFunc.Checked)
            {
                dv.RowFilter = "n_funcionario like '%" + txtNfunc.Text + "%'";
            }
            funcionariosDataGridView.DataSource = dv;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPCliente.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelPfunc.Visible = true;
        }

        private void clientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                panelPCliente.Visible = false;

                DataGridViewRow row = this.clientesDataGridView.Rows[e.RowIndex];

                txtCliente.Text = row.Cells[0].Value.ToString();
                txtNcliente.Text = row.Cells[1].Value.ToString();
            }
        }

        private void funcionariosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                panelPfunc.Visible = false;

                DataGridViewRow row = this.funcionariosDataGridView.Rows[e.RowIndex];

                txtFuncionario.Text = row.Cells[0].Value.ToString();
                txtNfunc.Text = row.Cells[1].Value.ToString();
            }
        }

        private void mskData_Enter(object sender, EventArgs e)
        {
            mskData.Text = Convert.ToString(DateTime.UtcNow);
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            if (txtFuncionario.Text == null)
            {
                txtNfunc.Focus();
            }
            else
            {
                string query = "Select n_funcionario From funcionarios where cod_funcionario = '" + txtFuncionario.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand sqlCommand = new SqlCommand(query, con);

                con.Open();
                SqlDataReader dR = sqlCommand.ExecuteReader();

                if (dR.Read())
                {
                    txtNfunc.Text = dR[0].ToString();
                }
                con.Close();
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Text == null)
            {
                txtNcliente.Focus();

            }
            else
            {
                string buscaCliente = "Select n_cliente From clientes where cod_cliente = '" + txtCliente.Text.Trim() + "'";

                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand sqlCommand = new SqlCommand(buscaCliente, con);

                con.Open();
                SqlDataReader dR = sqlCommand.ExecuteReader();

                if (dR.Read())
                {
                    txtNcliente.Text = dR[0].ToString();
                }
                con.Close();
            }
        }

        private void btnfilagendadia_Click(object sender, EventArgs e)
        {
            string filtro = "select a.age_data as Data, a.age_hora as Hora,  b.n_cliente as Cliente from agenda a join clientes b on a.cod_cliente = b.cod_cliente  where age_data like '%" + textBox1.Text + "%' order by age_data, age_hora";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand(filtro, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dataGridViewagedia.DataSource = dv;
            con.Close();
        }

        private void txtFuncionario_Leave(object sender, EventArgs e)
        {
            if (EnableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (EnableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void cbSituação_Leave(object sender, EventArgs e)
        {
            if (EnableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void txtObs_Leave(object sender, EventArgs e)
        {
            if (EnableSalvar())
            {
                btnSalvar.Enabled = true;
            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))


                e.Handled = true;
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))


                e.Handled = true;
            if (e.KeyChar == ','
            && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void mskData_TypeValidationCompleted(object sender, TypeValidationEventArgs e)          
        {
            if (!e.IsValidInput)
            {
                u.messageboxDataInv();
            }
        }
    
    }
}
