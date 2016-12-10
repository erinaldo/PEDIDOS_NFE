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
    public partial class frmCadUsuario : Form

    {
        bool novo;
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void frmCadUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.formCadUsuarios = null;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            textBox1.Text = "";
            textBox2.Text = "";
            btnSalvar.Enabled = true;
            btnChamaPesquisa.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            buttonCancelaCadcliente.Enabled = true;
            buttonSaiCadClientes.Enabled = true;
        }

        private void buttonSaiCadClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancelaCadcliente_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            btnChamaPesquisa.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            buttonSaiCadClientes.Enabled = true;
            buttonCancelaCadcliente.Enabled = false;
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            btnChamaPesquisa.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            buttonSaiCadClientes.Enabled = true;
            buttonCancelaCadcliente.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string deletar = "delete from usuarios where usu_codigo = '" + txtCodigo.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand(deletar, con);
            cmd.CommandType = CommandType.Text;
            con.Open();            
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluído com sucesso !", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Erro ao gravar no banco de dados " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            btnChamaPesquisa.Enabled = true;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            buttonSaiCadClientes.Enabled = true;
            buttonCancelaCadcliente.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";

        }
    }
}
