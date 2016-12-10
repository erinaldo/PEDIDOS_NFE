using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class MeusFormularios
    {
        public static FormClientes FrmClientes { get; set; }
        public static Form1 Frm1 { get; set; }
        public static FormAgenda FrmAgenda { get; set; }
        public static FormCadProcedimento FrmCadProcedimento { get; set; }
        public static FormCidades FrmCidades { get; set; }
        public static FormEntProdutos FrmEntProdutos { get; set; }
        public static FormFornecedores FrmFornecedores { get; set; }
        public static FormFuncionarios FrmFuncionarios { get; set; }
        public static FormPedido FrmPedido { get; set; }
        public static FormPrincipal FrmPrincipal { get; set; }        
        public static FormProdutos FrmProdutos { get; set; }
       
        
        public static frmCadUsuario formCadUsuarios { get; set; }
        public static formCpagar FrmCpagar { get; set; }
        public static FormCreceber FrmCreceber { get; set; }
        public static FrmRelCreceber formRlcreceber { get; set; }
        public static FrmRelCpagar formRelCpagar { get; set; }
        public static FrmRelEstoque formRelEstproduto { get; set; }
        public static FrmRelVendas formRelVendas { get; set; }
      
        public static FrmRelCadCli FormRelCadCli { get; set; }
        public static FormCadCFOP FrmCadCfop { get; set; }
        public static FormNotaFiscal FrmNotaFiscal { get; set; }
    }
}
