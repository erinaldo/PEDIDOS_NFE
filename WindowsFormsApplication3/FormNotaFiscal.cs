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
using NFeEletronica.Contexto;
using NFeEletronica.NotaFiscal;
using NFeEletronica.Certificado;
using NFeEletronica.Utils;
using NFeEletronica.Operacao;
using NFeEletronica.Versao;
using NFeEletronica.Retorno;
using NFeEletronica.RecepcaoEvento2;
using NFeEletronica.NfeRetRecepcao2;
using NFeEletronica.NfeRecepcao2;

using NFeEletronica.Consulta;
using NFeEletronica.Assinatura;


namespace WindowsFormsApplication3
{
    public partial class FormNotaFiscal : Form
    {
        utils u = new utils();
        public FormNotaFiscal()
        {
            InitializeComponent();
        }
        private void Unovo()
        {
            u.limparCombo(this);
            u.limparMTextBoxes(this);
            u.limparTextBoxes(this);
            u.DisableCombo(this);
            u.DisableTxt(this);
            btnNovo.Enabled = true;
            btnSair.Enabled = true;
            btnSalvar.Enabled = false;
            btnTransmitir.Enabled = false;
            btnInsProduto.Enabled = false;
            btnPProduto.Enabled = false;
        }
       


        private void btnPCliente_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelPProdutos.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelPProdutos.Visible = false;
        }

        private void buttonCancela_Click(object sender, EventArgs e)
        {
            Unovo();           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            u.EnableTxt(this);
            u.EnableCombo(this);
            btnNovo.Enabled = false;
            btnSair.Enabled = false;
            btnSalvar.Enabled = true;
            btnTransmitir.Enabled = false;
            btnInsProduto.Enabled = true;
            btnPProduto.Enabled = true;
            txtSerie.Text = "1";

            string ultimoReg = "Select not_codigo From nota where not_codigo = (Select MAX(not_codigo) From nota)";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand(ultimoReg, con);
            
            
            con.Open();
            SqlDataReader dR = cmd.ExecuteReader();

            if (dR.Read())
            {
                txtControle.Text = 1 + dR[0].ToString();
            }
            con.Close();
            int codigoNota = Convert.ToInt32(txtControle.Text.Trim());

            string inserirCod = "insert into nota(not_codigo) values(@not_codigo)";
            SqlCommand cmd1 = new SqlCommand(inserirCod, con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add("@not_codigo", SqlDbType.Int).Value = codigoNota;
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
            


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            string dataEmissao = mskDtVenda.Text.Trim();
            int numeroNota = Convert.ToInt32(txtNunNota.Text.Trim());
            string modeloNota = "55";
            string serie = txtSerie.Text;
            string finalidadeNota = comboBox1.SelectedIndex.ToString();
            int cadastro = Convert.ToInt32(txtcodFornecedor.Text.Trim());
            string cfop = txtCodCfod.Text.Trim();
            string nfeReferenciada = txtNFEreferenciada.Text.Trim();
            decimal subtotal = Convert.ToDecimal(txtsomaTudo.Text.Trim());
            decimal desconto = Convert.ToDecimal(txtSomaDesconto.Text.Trim());
            decimal totaldaNotacomdesconto = Convert.ToDecimal(txtCdesconto.Text.Trim());
            string obsNota = txtObs.Text.Trim();
            string transportador;
            if(txtCodTransp.Text == string.Empty)
            {
                transportador = "0";
            }
            else
            {
                transportador = txtCodTransp.Text.Trim();
            }
            string vencimento = txtVenc.Text;
            string chaveNfe;
            string protocolo;
            string recibo;
            string statusNota;
            string dataHoraProtocolo;
            int notcancelada;
            int notInutilizada;
            string motivoCancel;
            string peso;
            string volumes;
            string marca;            
            decimal icmsBase;
            decimal icmsValor;
            decimal icmsPercentual;
            decimal icmsStValor;
            string nfeXml;
            decimal ipiValor;

            string updateNota = "update nota set not_dtemissao = @not_dtemissao, not_numero = @not_numero, not_modelo = @not_modelo, not_serie = not_serie, not_finalidade = @not_finalidade, cadastro = @cadastro, cfo_codigo = @cfo_codigo, not_referenciada = @not_referenciada, not_subtotal = @not_subtotal, not_desconto = @not_desconto, not_nfetotal = @not_nfetotal, not_obs = @not_obs, cod_forncedor = @cad_fornecedor, not_vencimento = @not_vencimento, not_cancelada = @not_cancelada, not_inutilizada = @not_inutilizada, not_peso = @not_peso, not_volume = @not_volume, not_marca = @not_marca, not_icmsbase = @not_icmsbase, not_icmsvalor = @not_icmsvalor, not_icmspercentual = @not_icmspercentual, not_icmsstvalor = @not_icmsstvalor   where not_codigo = " + txtControle.Text;
 
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand(updateNota, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@not_dtemissao", SqlDbType.NVarChar).Value = dataEmissao;
            cmd.Parameters.Add("@not_numero", SqlDbType.Int).Value = numeroNota;
            cmd.Parameters.Add("@not_modelo", SqlDbType.NVarChar).Value = modeloNota;
            cmd.Parameters.Add("@not_serie", SqlDbType.NVarChar).Value = serie;
            cmd.Parameters.Add("@not_finalidade", SqlDbType.NVarChar).Value = finalidadeNota;
            cmd.Parameters.Add("@cadastro", SqlDbType.Int).Value = cadastro;
            cmd.Parameters.Add("@cfo_codigo", SqlDbType.Int).Value = cfop;
            cmd.Parameters.Add("@not_referenciada", SqlDbType.NVarChar).Value = nfeReferenciada;
            cmd.Parameters.Add("@not_subtotal", SqlDbType.Decimal).Value = subtotal;
            cmd.Parameters.Add("@not_desconto", SqlDbType.Decimal).Value = desconto;
            cmd.Parameters.Add("@not_nfetotal", SqlDbType.Decimal).Value = totaldaNotacomdesconto;
            cmd.Parameters.Add("@not_obs", SqlDbType.NVarChar).Value = obsNota;
            cmd.Parameters.Add("@cad_fornecedor", SqlDbType.Int).Value = transportador;
            cmd.Parameters.Add("@not_vencimento", SqlDbType.NVarChar).Value = vencimento;
            cmd.Parameters.Add("@not_cancelada", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@not_inutilizada", SqlDbType.Int).Value = 0;            
            cmd.Parameters.Add("@not_peso", SqlDbType.NVarChar).Value = 1;
            cmd.Parameters.Add("@not_volume", SqlDbType.NVarChar).Value = 1;
            cmd.Parameters.Add("@not_marca", SqlDbType.NVarChar).Value = "marca";
            cmd.Parameters.Add("@not_icmsbase", SqlDbType.Decimal).Value = 0;
            cmd.Parameters.Add("@not_icmsvalor", SqlDbType.Decimal).Value = 0;
            cmd.Parameters.Add("@not_icmspercentual", SqlDbType.Decimal).Value = 0;
            cmd.Parameters.Add("@not_icmsstvalor", SqlDbType.Decimal).Value = 0;
 

            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    u.messageboxSucesso();
                }
                var nfeContexto = new NFeContexto(false, NFeEletronica.Versao.NFeVersao.VERSAO_3_1_0, new GerenciadorDeCertificado());
                var nota = new Nota(nfeContexto);
                // nota.ide.cUF = txtci continuar daqui, colocar campo oculto na tela pra salvar o estado da  nota fiscalzr
                nota.ide.natOp = txtDescCfop.Text;
                nota.ide.indPag = "0";
                nota.ide.mod = "55";
                nota.ide.serie = txtSerie.Text;
                //"select a.cod_produto, b.des_produto, a.ITP_QTDE, a.ITP_VALOR, a.ITP_TOTAL from ITEMPEDIDO a join produtos b on a.cod_produto = b.cod_produto where ped_codigo
                string ultimoReg = "Select not_codigo From nota where not_codigo = (Select MAX(not_numero) From nota)";
                
                SqlConnection con1 = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Ducaun;
                SqlCommand cmd2 = new SqlCommand(ultimoReg, con1);


                con.Open();
                SqlDataReader dR = cmd2.ExecuteReader();

                if (dR.Read())
                {
                    txtNunNota.Text = 1 + dR[0].ToString();
                }
                con.Close();
                nota.ide.nNF = txtNunNota.Text;
                nota.ide.dEmi = mskDtVenda.Text;
                nota.ide.tpNF = "1"; //normal contingencia
                nota.ide.cMunFG = txtIbge.Text;
                nota.ide.tpImp = "1";
                nota.ide.tpEmis = "1";
                nota.ide.cDV = "0";                
                nota.ide.idDest = "1";
                nota.ide.indFinal = "0";
                nota.ide.indPres = "0";
                //nota.ide.tpAmb = "2";
                nota.ide.finNFe = finalidadeNota;
                nota.ide.procEmi = "3";// soft utilizado
                nota.ide.
               

              



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: Erro Ao Gravar no banco de dados " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            Unovo();

        }

        private void btnTransmitir_Click(object sender, EventArgs e)
        {

            //rotina transmitir, se receber resposta positiva faz update, senão mensagem na tela
            string chaveNfe;
            string protocolo;
            string recibo;
            string statusNota;
            string dataHoraProtocolo;
            string updateNota = "update nota set  not_chave = @not_chave, not_protocolo = @not_protocolo, not_recibo = @not_recibo, not_statusnota = @statusnota, not_dthoraprotocolo = @not_dthoraprotocolo   where not_codigo = " + txtControle.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Ducaun;
            SqlCommand cmd = new SqlCommand(updateNota, con);
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add("@not_chave", SqlDbType.NVarChar).Value = chaveNfe;
            //cmd.Parameters.Add("@not_protocolo", SqlDbType.NVarChar).Value = protocolo;
            //cmd.Parameters.Add("@not_recibo", SqlDbType.NVarChar).Value = recibo;
            //cmd.Parameters.Add("@not_statusnota", SqlDbType.NVarChar).Value = statusNota;
            //cmd.Parameters.Add("@not_dthoraprotocolo", SqlDbType.NVarChar).Value = dataHoraProtocolo;            
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
            Unovo();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNotaFiscal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MeusFormularios.FrmNotaFiscal = null;
        }
    }
}
