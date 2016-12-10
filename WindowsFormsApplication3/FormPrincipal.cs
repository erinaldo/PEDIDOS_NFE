using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }
       
        private void eNTRADADEPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form ChamaClientes = new FormClientes();
            //ChamaClientes.ShowDialog();
            if (MeusFormularios.FrmClientes == null)
                MeusFormularios.FrmClientes = new FormClientes();

            MeusFormularios.FrmClientes.Show();
            MeusFormularios.FrmClientes.Focus();


        }

        private void fORNECEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form ChamaFornecedores = new FormFornecedores();
            //ChamaFornecedores.ShowDialog();
            if (MeusFormularios.FrmFornecedores == null)
                MeusFormularios.FrmFornecedores = new FormFornecedores();

            MeusFormularios.FrmFornecedores.Show();
            MeusFormularios.FrmFornecedores.Focus();

        }

        private void pRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form ChamaProdutos = new FormProdutos();
            //ChamaProdutos.ShowDialog();
            if (MeusFormularios.FrmProdutos == null)
                MeusFormularios.FrmProdutos = new FormProdutos();

            MeusFormularios.FrmProdutos.Show();
            MeusFormularios.FrmProdutos.Focus();

        }

        private void cIDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form ChamaCidade = new FormCidades();
            //ChamaCidade.ShowDialog();
            if (MeusFormularios.FrmCidades == null)
                MeusFormularios.FrmCidades = new FormCidades();

            MeusFormularios.FrmCidades.Show();
            MeusFormularios.FrmCidades.Focus();
                
        }

        private void vENDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form ChamaPedido = new FormPedido();
            //ChamaPedido.ShowDialog();
            if (MeusFormularios.FrmPedido == null)
                MeusFormularios.FrmPedido = new FormPedido();

           MeusFormularios.FrmPedido.Show();
           MeusFormularios.FrmPedido.Focus();

        }

        private void vENDASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

        private void eNTRADADEPRODUTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Form ChamaEntrada = new FormEntProdutos();
            //ChamaEntrada.ShowDialog();
            if (MeusFormularios.FrmEntProdutos == null)
                MeusFormularios.FrmEntProdutos = new FormEntProdutos();

            MeusFormularios.FrmEntProdutos.Show();
            MeusFormularios.FrmEntProdutos.Focus();


        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
             
        }

       
        private void fechaForm(object sender, FormClosingEventArgs e)
        {
            DialogResult escolha = MessageBox.Show("Tem certeza que deseja sair?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (escolha == DialogResult.No)
                e.Cancel = true;
        }

        private void tÉCNICOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cOLABORADORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form ChamaFuncionarios = new FormFuncionarios();
            //ChamaFuncionarios.ShowDialog();
            if (MeusFormularios.FrmFuncionarios == null)
                MeusFormularios.FrmFuncionarios = new FormFuncionarios();

            MeusFormularios.FrmFuncionarios.Show();
            MeusFormularios.FrmFuncionarios.Focus();

        }

        private void pROCEDIMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form ChamaProcedimentos = new FormCadProcedimento();
            //ChamaProcedimentos.ShowDialog();
            if (MeusFormularios.FrmCadProcedimento == null)
                MeusFormularios.FrmCadProcedimento = new FormCadProcedimento();

            MeusFormularios.FrmCadProcedimento.Show();
            MeusFormularios.FrmCadProcedimento.Focus();

        }

        private void pROCEDIMENTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aGENDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form ChamaAgenda = new FormAgenda();
            //ChamaAgenda.ShowDialog();
            if (MeusFormularios.FrmAgenda == null)
                MeusFormularios.FrmAgenda = new FormAgenda();

            MeusFormularios.FrmAgenda.Show();
            MeusFormularios.FrmAgenda.Focus();

        }

        private void fUNCIONÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form ChamaFuncionarios = new FormFuncionarios();
            //ChamaFuncionarios.ShowDialog();
            if (MeusFormularios.FrmFuncionarios == null)
                MeusFormularios.FrmFuncionarios = new FormFuncionarios();

            MeusFormularios.FrmFuncionarios.Show();
            MeusFormularios.FrmFuncionarios.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToShortTimeString();
        }

        private void conexãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ChamaConexaun = new Conexaun();
            ChamaConexaun.ShowDialog();
        }
     
        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ChamarelCli = new FrmRelCadCli();
            ChamarelCli.ShowDialog();

        }

        private void lUCRATIVIDADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form chamaRel = new relCadForn();
            chamaRel.ShowDialog();
        }

        private void uSUÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.formCadUsuarios == null)
                MeusFormularios.formCadUsuarios = new frmCadUsuario();

            MeusFormularios.formCadUsuarios.Show();
            MeusFormularios.formCadUsuarios.Focus();
        }

        private void cONTASÀPAGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FrmCpagar == null)
                MeusFormularios.FrmCpagar = new formCpagar();

            MeusFormularios.FrmCpagar.Show();
            MeusFormularios.FrmCpagar.Focus();
        }

        private void cONTASÀPAGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FrmCpagar == null)
                MeusFormularios.FrmCpagar = new formCpagar();

            MeusFormularios.FrmCpagar.Show();
            MeusFormularios.FrmCpagar.Focus();
        }

        private void cONTASÀRECEBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FrmCreceber == null)
                MeusFormularios.FrmCreceber = new FormCreceber();

            MeusFormularios.FrmCreceber.Show();
            MeusFormularios.FrmCreceber.Focus();
        }

        private void cONTASÀRECEBERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.formRlcreceber == null)
                MeusFormularios.formRlcreceber = new FrmRelCreceber();

            MeusFormularios.formRlcreceber.Show();
            MeusFormularios.formRlcreceber.Focus();
        }

        private void cONTASÀPAGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.formRelCpagar == null)
                MeusFormularios.formRelCpagar = new FrmRelCpagar();

            MeusFormularios.formRelCpagar.Show();
            MeusFormularios.formRelCpagar.Focus();
        }     

        private void eSTOQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.formRelEstproduto == null)
                MeusFormularios.formRelEstproduto = new FrmRelEstoque();

            MeusFormularios.formRelEstproduto.Show();
            MeusFormularios.formRelEstproduto.Focus();
        }

        private void vENDASToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.formRelVendas == null)
                MeusFormularios.formRelVendas = new FrmRelVendas();

            MeusFormularios.formRelVendas.Show();
            MeusFormularios.formRelVendas.Focus();
        }

        private void cFOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FrmCadCfop == null)
                MeusFormularios.FrmCadCfop = new FormCadCFOP();

            MeusFormularios.FrmCadCfop.Show();
            MeusFormularios.FrmCadCfop.Focus();
        }

        private void nOTAFISCALELETRÔNICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MeusFormularios.FrmNotaFiscal == null)
                MeusFormularios.FrmNotaFiscal = new FormNotaFiscal();

            MeusFormularios.FrmNotaFiscal.Show();
            MeusFormularios.FrmNotaFiscal.Focus();
        }
    }
}
