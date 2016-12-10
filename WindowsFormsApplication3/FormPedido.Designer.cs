namespace WindowsFormsApplication3
{
    partial class FormPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jarbasDataSet = new WindowsFormsApplication3.jarbasDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPvendedor = new System.Windows.Forms.Button();
            this.txtcodVendedor = new System.Windows.Forms.TextBox();
            this.btnPCliente = new System.Windows.Forms.Button();
            this.txtcodCliente = new System.Windows.Forms.TextBox();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.mskDtVenda = new System.Windows.Forms.MaskedTextBox();
            this.txtControle = new System.Windows.Forms.TextBox();
            this.panelPfunc = new System.Windows.Forms.Panel();
            this.funcionariosDataGridView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpfunc = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtsomaTudo = new System.Windows.Forms.TextBox();
            this.itensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSomaDesconto = new System.Windows.Forms.TextBox();
            this.txtCdesconto = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtVTotal = new System.Windows.Forms.TextBox();
            this.btnInsProduto = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnPProduto = new System.Windows.Forms.Button();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPesquisaClientes = new System.Windows.Forms.Panel();
            this.txtpcli = new System.Windows.Forms.TextBox();
            this.radioButtonDescricao = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSaiPesquisa = new System.Windows.Forms.Button();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_nas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.buttonCancela = new System.Windows.Forms.Button();
            this.panelPClie = new System.Windows.Forms.Panel();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.cod_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.un_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_reduzida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButtonBarras = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panelPed = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.rbProduto = new System.Windows.Forms.RadioButton();
            this.rbCodPed = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.txtPesquiPedido = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pedidoDataGrid = new System.Windows.Forms.DataGridView();
            this.pEDCODIGODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDDTEMISSAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDTOTALBRUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDPERCDESCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDDESCONTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDTOTALLIQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDOBSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByimprimeobaguiToolStrip = new System.Windows.Forms.ToolStrip();
            this.pedidoCodigoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pedidoCodigoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByimprimeobaguiToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataTable1TableAdapter1 = new WindowsFormsApplication3.jarbasDataSetTableAdapters.DataTable1TableAdapter();
            this.vendasTableAdapter = new WindowsFormsApplication3.jarbasDataSetTableAdapters.vendasTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication3.jarbasDataSetTableAdapters.TableAdapterManager();
            this.itensTableAdapter = new WindowsFormsApplication3.jarbasDataSetTableAdapters.itensTableAdapter();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new WindowsFormsApplication3.jarbasDataSetTableAdapters.produtosTableAdapter();
            this.pEDIDOTableAdapter = new WindowsFormsApplication3.jarbasDataSetTableAdapters.PEDIDOTableAdapter();
            this.iTEMPEDIDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTEMPEDIDOTableAdapter = new WindowsFormsApplication3.jarbasDataSetTableAdapters.ITEMPEDIDOTableAdapter();
            this.DataTable1TableAdapter = new WindowsFormsApplication3.jarbasDataSetTableAdapters.vendasTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relDataSet = new WindowsFormsApplication3.relDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new WindowsFormsApplication3.jarbasDataSetTableAdapters.clientesTableAdapter();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelPfunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelPesquisaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panelPClie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            this.panelPed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).BeginInit();
            this.fillByimprimeobaguiToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMPEDIDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.jarbasDataSet;
            // 
            // jarbasDataSet
            // 
            this.jarbasDataSet.DataSetName = "jarbasDataSet";
            this.jarbasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPvendedor);
            this.groupBox1.Controls.Add(this.txtcodVendedor);
            this.groupBox1.Controls.Add(this.btnPCliente);
            this.groupBox1.Controls.Add(this.txtcodCliente);
            this.groupBox1.Controls.Add(this.txtNomeVendedor);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.mskDtVenda);
            this.groupBox1.Controls.Add(this.txtControle);
            this.groupBox1.Location = new System.Drawing.Point(6, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controle";
            // 
            // btnPvendedor
            // 
            this.btnPvendedor.Location = new System.Drawing.Point(296, 11);
            this.btnPvendedor.Name = "btnPvendedor";
            this.btnPvendedor.Size = new System.Drawing.Size(28, 23);
            this.btnPvendedor.TabIndex = 3;
            this.btnPvendedor.Text = "...";
            this.btnPvendedor.UseVisualStyleBackColor = true;
            this.btnPvendedor.Click += new System.EventHandler(this.btnPvendedor_Click);
            // 
            // txtcodVendedor
            // 
            this.txtcodVendedor.Location = new System.Drawing.Point(330, 13);
            this.txtcodVendedor.Name = "txtcodVendedor";
            this.txtcodVendedor.Size = new System.Drawing.Size(46, 20);
            this.txtcodVendedor.TabIndex = 4;
            this.txtcodVendedor.TextChanged += new System.EventHandler(this.txtcodVendedor_TextChanged);
            this.txtcodVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodCliente_KeyPress);
            this.txtcodVendedor.Leave += new System.EventHandler(this.txtcodVendedor_Leave);
            // 
            // btnPCliente
            // 
            this.btnPCliente.Location = new System.Drawing.Point(44, 38);
            this.btnPCliente.Name = "btnPCliente";
            this.btnPCliente.Size = new System.Drawing.Size(28, 23);
            this.btnPCliente.TabIndex = 6;
            this.btnPCliente.Text = "...";
            this.btnPCliente.UseVisualStyleBackColor = true;
            this.btnPCliente.Click += new System.EventHandler(this.btnPCliente_Click);
            // 
            // txtcodCliente
            // 
            this.txtcodCliente.Location = new System.Drawing.Point(78, 40);
            this.txtcodCliente.Name = "txtcodCliente";
            this.txtcodCliente.Size = new System.Drawing.Size(46, 20);
            this.txtcodCliente.TabIndex = 7;
            this.txtcodCliente.TextChanged += new System.EventHandler(this.txtcodCliente_TextChanged);
            this.txtcodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodCliente_KeyPress_1);
            this.txtcodCliente.Leave += new System.EventHandler(this.txtcodCliente_Leave);
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(382, 13);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(314, 20);
            this.txtNomeVendedor.TabIndex = 5;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(130, 40);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(262, 20);
            this.txtNomeCliente.TabIndex = 8;
            // 
            // mskDtVenda
            // 
            this.mskDtVenda.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskDtVenda.Location = new System.Drawing.Point(160, 13);
            this.mskDtVenda.Mask = "00/00/0000";
            this.mskDtVenda.Name = "mskDtVenda";
            this.mskDtVenda.Size = new System.Drawing.Size(68, 20);
            this.mskDtVenda.TabIndex = 2;
            this.mskDtVenda.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mskDtVenda.ValidatingType = typeof(System.DateTime);
            this.mskDtVenda.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mskDtVenda_TypeValidationCompleted);
            this.mskDtVenda.Leave += new System.EventHandler(this.mskDtVenda_Leave);
            // 
            // txtControle
            // 
            this.txtControle.Enabled = false;
            this.txtControle.Location = new System.Drawing.Point(53, 13);
            this.txtControle.Name = "txtControle";
            this.txtControle.Size = new System.Drawing.Size(67, 20);
            this.txtControle.TabIndex = 1;
            // 
            // panelPfunc
            // 
            this.panelPfunc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPfunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPfunc.Controls.Add(this.funcionariosDataGridView);
            this.panelPfunc.Controls.Add(this.label10);
            this.panelPfunc.Controls.Add(this.button2);
            this.panelPfunc.Controls.Add(this.button1);
            this.panelPfunc.Controls.Add(this.txtpfunc);
            this.panelPfunc.Controls.Add(this.radioButton1);
            this.panelPfunc.Controls.Add(this.radioButton2);
            this.panelPfunc.Location = new System.Drawing.Point(442, 74);
            this.panelPfunc.Name = "panelPfunc";
            this.panelPfunc.Size = new System.Drawing.Size(256, 248);
            this.panelPfunc.TabIndex = 69;
            // 
            // funcionariosDataGridView
            // 
            this.funcionariosDataGridView.AllowUserToAddRows = false;
            this.funcionariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funcionariosDataGridView.Location = new System.Drawing.Point(3, 40);
            this.funcionariosDataGridView.Name = "funcionariosDataGridView";
            this.funcionariosDataGridView.ReadOnly = true;
            this.funcionariosDataGridView.Size = new System.Drawing.Size(244, 158);
            this.funcionariosDataGridView.TabIndex = 67;
            this.funcionariosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.funcionariosDataGridView_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Funcionários";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 72;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 71;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpfunc
            // 
            this.txtpfunc.Location = new System.Drawing.Point(3, 222);
            this.txtpfunc.Name = "txtpfunc";
            this.txtpfunc.Size = new System.Drawing.Size(163, 20);
            this.txtpfunc.TabIndex = 70;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(69, 201);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 69;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Descrição";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(5, 201);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 68;
            this.radioButton2.Text = "Código";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtsomaTudo
            // 
            this.txtsomaTudo.Location = new System.Drawing.Point(6, 290);
            this.txtsomaTudo.Name = "txtsomaTudo";
            this.txtsomaTudo.Size = new System.Drawing.Size(72, 20);
            this.txtsomaTudo.TabIndex = 17;
            // 
            // itensBindingSource
            // 
            this.itensBindingSource.DataMember = "fkitensvendas";
            this.itensBindingSource.DataSource = this.vendasBindingSource;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "vendas";
            this.vendasBindingSource.DataSource = this.jarbasDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSomaDesconto);
            this.groupBox2.Controls.Add(this.txtCdesconto);
            this.groupBox2.Controls.Add(this.txtDesconto);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.txtsomaTudo);
            this.groupBox2.Controls.Add(this.txtVTotal);
            this.groupBox2.Controls.Add(this.btnInsProduto);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.btnPProduto);
            this.groupBox2.Controls.Add(this.txtCodProduto);
            this.groupBox2.Controls.Add(this.txtNomeProduto);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(6, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 319);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens da Venda";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(591, 293);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 34;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBox1_TypeValidationCompleted);
            this.maskedTextBox1.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(592, 276);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Data de Vencimento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(87, 274);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Desconto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(174, 274);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Valor Total do Pedido";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(452, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Desconto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Observações";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Valor do Pedido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Valor Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valor Unitário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Produto";
            // 
            // txtSomaDesconto
            // 
            this.txtSomaDesconto.Location = new System.Drawing.Point(87, 290);
            this.txtSomaDesconto.Name = "txtSomaDesconto";
            this.txtSomaDesconto.Size = new System.Drawing.Size(78, 20);
            this.txtSomaDesconto.TabIndex = 18;
            this.txtSomaDesconto.Enter += new System.EventHandler(this.txtSomaDesconto_Enter);
            this.txtSomaDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSomaDesconto_KeyPress);
            this.txtSomaDesconto.Leave += new System.EventHandler(this.txtSomaDesconto_Leave);
            // 
            // txtCdesconto
            // 
            this.txtCdesconto.Location = new System.Drawing.Point(174, 290);
            this.txtCdesconto.Name = "txtCdesconto";
            this.txtCdesconto.Size = new System.Drawing.Size(93, 20);
            this.txtCdesconto.TabIndex = 18;
            this.txtCdesconto.Enter += new System.EventHandler(this.txtCdesconto_Enter);
            this.txtCdesconto.Leave += new System.EventHandler(this.txtCdesconto_Leave);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(455, 33);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(75, 20);
            this.txtDesconto.TabIndex = 14;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(274, 290);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(256, 20);
            this.txtObs.TabIndex = 19;
            // 
            // txtVTotal
            // 
            this.txtVTotal.Location = new System.Drawing.Point(550, 33);
            this.txtVTotal.Name = "txtVTotal";
            this.txtVTotal.Size = new System.Drawing.Size(75, 20);
            this.txtVTotal.TabIndex = 15;
            this.txtVTotal.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnInsProduto
            // 
            this.btnInsProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsProduto.Location = new System.Drawing.Point(631, 21);
            this.btnInsProduto.Name = "btnInsProduto";
            this.btnInsProduto.Size = new System.Drawing.Size(65, 34);
            this.btnInsProduto.TabIndex = 16;
            this.btnInsProduto.Text = "+";
            this.btnInsProduto.UseVisualStyleBackColor = true;
            this.btnInsProduto.Click += new System.EventHandler(this.btnInsProduto_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(306, 33);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(59, 20);
            this.txtQuantidade.TabIndex = 12;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(374, 33);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(75, 20);
            this.txtValor.TabIndex = 13;
            this.txtValor.Enter += new System.EventHandler(this.txtValor_Enter);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // btnPProduto
            // 
            this.btnPProduto.Location = new System.Drawing.Point(6, 31);
            this.btnPProduto.Name = "btnPProduto";
            this.btnPProduto.Size = new System.Drawing.Size(28, 23);
            this.btnPProduto.TabIndex = 9;
            this.btnPProduto.Text = "...";
            this.btnPProduto.UseVisualStyleBackColor = true;
            this.btnPProduto.Click += new System.EventHandler(this.btnPProduto_Click);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(40, 33);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(46, 20);
            this.txtCodProduto.TabIndex = 10;
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(92, 33);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(205, 20);
            this.txtNomeProduto.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(5, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(690, 210);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantidade";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor Unitário";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Desconto";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Valor Total";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panelPesquisaClientes
            // 
            this.panelPesquisaClientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPesquisaClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPesquisaClientes.Controls.Add(this.txtpcli);
            this.panelPesquisaClientes.Controls.Add(this.radioButtonDescricao);
            this.panelPesquisaClientes.Controls.Add(this.radioButtonCodigo);
            this.panelPesquisaClientes.Controls.Add(this.label13);
            this.panelPesquisaClientes.Controls.Add(this.btnSaiPesquisa);
            this.panelPesquisaClientes.Controls.Add(this.clientesDataGridView);
            this.panelPesquisaClientes.Controls.Add(this.button6);
            this.panelPesquisaClientes.Location = new System.Drawing.Point(5, 9);
            this.panelPesquisaClientes.Name = "panelPesquisaClientes";
            this.panelPesquisaClientes.Size = new System.Drawing.Size(257, 248);
            this.panelPesquisaClientes.TabIndex = 14;
            this.panelPesquisaClientes.Visible = false;
            // 
            // txtpcli
            // 
            this.txtpcli.Location = new System.Drawing.Point(1, 222);
            this.txtpcli.Name = "txtpcli";
            this.txtpcli.Size = new System.Drawing.Size(155, 20);
            this.txtpcli.TabIndex = 52;
            // 
            // radioButtonDescricao
            // 
            this.radioButtonDescricao.AutoSize = true;
            this.radioButtonDescricao.Checked = true;
            this.radioButtonDescricao.Location = new System.Drawing.Point(67, 202);
            this.radioButtonDescricao.Name = "radioButtonDescricao";
            this.radioButtonDescricao.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDescricao.TabIndex = 51;
            this.radioButtonDescricao.TabStop = true;
            this.radioButtonDescricao.Text = "Descrição";
            this.radioButtonDescricao.UseVisualStyleBackColor = true;
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(3, 202);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCodigo.TabIndex = 50;
            this.radioButtonCodigo.Text = "Código";
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.MaximumSize = new System.Drawing.Size(500, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 31);
            this.label13.TabIndex = 49;
            this.label13.Text = "Clientes";
            // 
            // btnSaiPesquisa
            // 
            this.btnSaiPesquisa.Location = new System.Drawing.Point(162, 199);
            this.btnSaiPesquisa.Name = "btnSaiPesquisa";
            this.btnSaiPesquisa.Size = new System.Drawing.Size(83, 23);
            this.btnSaiPesquisa.TabIndex = 54;
            this.btnSaiPesquisa.Text = "Sair";
            this.btnSaiPesquisa.UseVisualStyleBackColor = true;
            this.btnSaiPesquisa.Click += new System.EventHandler(this.btnSaiPesquisa_Click);
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AllowUserToAddRows = false;
            this.clientesDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.endereco,
            this.bairro,
            this.cidade,
            this.telefone,
            this.celular,
            this.cep,
            this.obs,
            this.cpf,
            this.email,
            this.data_nas,
            this.numero});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.clientesDataGridView.Location = new System.Drawing.Point(1, 35);
            this.clientesDataGridView.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.ReadOnly = true;
            this.clientesDataGridView.Size = new System.Drawing.Size(245, 161);
            this.clientesDataGridView.TabIndex = 48;
            this.clientesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesDataGridView_CellClick);
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "endereco";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Visible = false;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Visible = false;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Visible = false;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Visible = false;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Visible = false;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            this.cep.HeaderText = "cep";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            this.cep.Visible = false;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "obs";
            this.obs.HeaderText = "obs";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            this.obs.Visible = false;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "cpf";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // data_nas
            // 
            this.data_nas.DataPropertyName = "data_nas";
            this.data_nas.HeaderText = "data_nas";
            this.data_nas.Name = "data_nas";
            this.data_nas.ReadOnly = true;
            this.data_nas.Visible = false;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(162, 220);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 23);
            this.button6.TabIndex = 53;
            this.button6.Text = "Pesquisar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPesquisar);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Controls.Add(this.btnExcluir);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Controls.Add(this.buttonCancela);
            this.groupBox3.Location = new System.Drawing.Point(7, 391);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(703, 78);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.Location = new System.Drawing.Point(209, 28);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 39);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.Text = "Localizar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Visible = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(452, 28);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 39);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(371, 28);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 39);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(290, 28);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 39);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(616, 28);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 39);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // buttonCancela
            // 
            this.buttonCancela.Location = new System.Drawing.Point(535, 28);
            this.buttonCancela.Name = "buttonCancela";
            this.buttonCancela.Size = new System.Drawing.Size(75, 39);
            this.buttonCancela.TabIndex = 24;
            this.buttonCancela.Text = "Cancelar";
            this.buttonCancela.UseVisualStyleBackColor = true;
            this.buttonCancela.Click += new System.EventHandler(this.buttonCancela_Click);
            // 
            // panelPClie
            // 
            this.panelPClie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPClie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPClie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPClie.Controls.Add(this.produtosDataGridView);
            this.panelPClie.Controls.Add(this.label11);
            this.panelPClie.Controls.Add(this.button3);
            this.panelPClie.Controls.Add(this.button4);
            this.panelPClie.Controls.Add(this.textBox1);
            this.panelPClie.Controls.Add(this.radioButton3);
            this.panelPClie.Controls.Add(this.radioButtonBarras);
            this.panelPClie.Controls.Add(this.radioButton4);
            this.panelPClie.Location = new System.Drawing.Point(6, 259);
            this.panelPClie.Name = "panelPClie";
            this.panelPClie.Size = new System.Drawing.Size(672, 210);
            this.panelPClie.TabIndex = 70;
            this.panelPClie.Visible = false;
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AllowUserToAddRows = false;
            this.produtosDataGridView.AllowUserToDeleteRows = false;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_fornecedor,
            this.est_produto,
            this.un_medida,
            this.desc_reduzida,
            this.vl_produto,
            this.custo,
            this.margem});
            this.produtosDataGridView.Location = new System.Drawing.Point(11, 39);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.ReadOnly = true;
            this.produtosDataGridView.Size = new System.Drawing.Size(644, 136);
            this.produtosDataGridView.TabIndex = 3;
            this.produtosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtosDataGridView_CellClick);
            // 
            // cod_fornecedor
            // 
            this.cod_fornecedor.DataPropertyName = "cod_fornecedor";
            this.cod_fornecedor.HeaderText = "cod_fornecedor";
            this.cod_fornecedor.Name = "cod_fornecedor";
            this.cod_fornecedor.ReadOnly = true;
            this.cod_fornecedor.Visible = false;
            // 
            // est_produto
            // 
            this.est_produto.DataPropertyName = "est_produto";
            this.est_produto.HeaderText = "Estoque ";
            this.est_produto.Name = "est_produto";
            this.est_produto.ReadOnly = true;
            this.est_produto.Visible = false;
            // 
            // un_medida
            // 
            this.un_medida.DataPropertyName = "un_medida";
            this.un_medida.HeaderText = "Unidade de Medida";
            this.un_medida.Name = "un_medida";
            this.un_medida.ReadOnly = true;
            this.un_medida.Visible = false;
            // 
            // desc_reduzida
            // 
            this.desc_reduzida.DataPropertyName = "desc_reduzida";
            this.desc_reduzida.HeaderText = "Descrição Reduzida";
            this.desc_reduzida.Name = "desc_reduzida";
            this.desc_reduzida.ReadOnly = true;
            this.desc_reduzida.Visible = false;
            // 
            // vl_produto
            // 
            this.vl_produto.DataPropertyName = "vl_produto";
            this.vl_produto.HeaderText = "Valor de Venda";
            this.vl_produto.Name = "vl_produto";
            this.vl_produto.ReadOnly = true;
            this.vl_produto.Visible = false;
            // 
            // custo
            // 
            this.custo.DataPropertyName = "custo";
            this.custo.HeaderText = "Custo";
            this.custo.Name = "custo";
            this.custo.ReadOnly = true;
            this.custo.Visible = false;
            // 
            // margem
            // 
            this.margem.DataPropertyName = "margem";
            this.margem.HeaderText = "Margem";
            this.margem.Name = "margem";
            this.margem.ReadOnly = true;
            this.margem.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(188, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(284, 31);
            this.label11.TabIndex = 10;
            this.label11.Text = "Pesquisa De Produtos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(458, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 7;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(135, 181);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Descrição";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButtonBarras
            // 
            this.radioButtonBarras.AutoSize = true;
            this.radioButtonBarras.Location = new System.Drawing.Point(74, 181);
            this.radioButtonBarras.Name = "radioButtonBarras";
            this.radioButtonBarras.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBarras.TabIndex = 5;
            this.radioButtonBarras.TabStop = true;
            this.radioButtonBarras.Text = "Barras";
            this.radioButtonBarras.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(10, 181);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Código";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panelPed
            // 
            this.panelPed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPed.Controls.Add(this.button5);
            this.panelPed.Controls.Add(this.button7);
            this.panelPed.Controls.Add(this.rbProduto);
            this.panelPed.Controls.Add(this.rbCodPed);
            this.panelPed.Controls.Add(this.rbData);
            this.panelPed.Controls.Add(this.rbCliente);
            this.panelPed.Controls.Add(this.txtPesquiPedido);
            this.panelPed.Controls.Add(this.label17);
            this.panelPed.Controls.Add(this.pedidoDataGrid);
            this.panelPed.Location = new System.Drawing.Point(5, 161);
            this.panelPed.Name = "panelPed";
            this.panelPed.Size = new System.Drawing.Size(475, 263);
            this.panelPed.TabIndex = 71;
            this.panelPed.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(400, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 23);
            this.button5.TabIndex = 60;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(322, 236);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 23);
            this.button7.TabIndex = 59;
            this.button7.Text = "Pesquisar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Location = new System.Drawing.Point(67, 242);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(62, 17);
            this.rbProduto.TabIndex = 58;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "Produto";
            this.rbProduto.UseVisualStyleBackColor = true;
            // 
            // rbCodPed
            // 
            this.rbCodPed.AutoSize = true;
            this.rbCodPed.Checked = true;
            this.rbCodPed.Location = new System.Drawing.Point(67, 219);
            this.rbCodPed.Name = "rbCodPed";
            this.rbCodPed.Size = new System.Drawing.Size(58, 17);
            this.rbCodPed.TabIndex = 57;
            this.rbCodPed.TabStop = true;
            this.rbCodPed.Text = "Código";
            this.rbCodPed.UseVisualStyleBackColor = true;
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(4, 243);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(48, 17);
            this.rbData.TabIndex = 56;
            this.rbData.TabStop = true;
            this.rbData.Text = "Data";
            this.rbData.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(4, 219);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(57, 17);
            this.rbCliente.TabIndex = 55;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // txtPesquiPedido
            // 
            this.txtPesquiPedido.Location = new System.Drawing.Point(129, 239);
            this.txtPesquiPedido.Name = "txtPesquiPedido";
            this.txtPesquiPedido.Size = new System.Drawing.Size(186, 20);
            this.txtPesquiPedido.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(181, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 31);
            this.label17.TabIndex = 1;
            this.label17.Text = "Pedidos";
            // 
            // pedidoDataGrid
            // 
            this.pedidoDataGrid.AllowUserToAddRows = false;
            this.pedidoDataGrid.AllowUserToDeleteRows = false;
            this.pedidoDataGrid.AutoGenerateColumns = false;
            this.pedidoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pEDCODIGODataGridViewTextBoxColumn,
            this.pEDDTEMISSAODataGridViewTextBoxColumn,
            this.pEDTOTALBRUTODataGridViewTextBoxColumn,
            this.pEDPERCDESCDataGridViewTextBoxColumn,
            this.pEDDESCONTODataGridViewTextBoxColumn,
            this.pEDTOTALLIQDataGridViewTextBoxColumn,
            this.pEDOBSDataGridViewTextBoxColumn,
            this.codfuncionarioDataGridViewTextBoxColumn,
            this.codclienteDataGridViewTextBoxColumn});
            this.pedidoDataGrid.DataSource = this.pEDIDOBindingSource;
            this.pedidoDataGrid.Location = new System.Drawing.Point(3, 42);
            this.pedidoDataGrid.Name = "pedidoDataGrid";
            this.pedidoDataGrid.ReadOnly = true;
            this.pedidoDataGrid.Size = new System.Drawing.Size(469, 170);
            this.pedidoDataGrid.TabIndex = 0;
            this.pedidoDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pedidoDataGrid_CellClick);
            // 
            // pEDCODIGODataGridViewTextBoxColumn
            // 
            this.pEDCODIGODataGridViewTextBoxColumn.DataPropertyName = "PED_CODIGO";
            this.pEDCODIGODataGridViewTextBoxColumn.HeaderText = "Código";
            this.pEDCODIGODataGridViewTextBoxColumn.Name = "pEDCODIGODataGridViewTextBoxColumn";
            this.pEDCODIGODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pEDDTEMISSAODataGridViewTextBoxColumn
            // 
            this.pEDDTEMISSAODataGridViewTextBoxColumn.DataPropertyName = "PED_DTEMISSAO";
            this.pEDDTEMISSAODataGridViewTextBoxColumn.HeaderText = "Data";
            this.pEDDTEMISSAODataGridViewTextBoxColumn.Name = "pEDDTEMISSAODataGridViewTextBoxColumn";
            this.pEDDTEMISSAODataGridViewTextBoxColumn.ReadOnly = true;
            this.pEDDTEMISSAODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pEDTOTALBRUTODataGridViewTextBoxColumn
            // 
            this.pEDTOTALBRUTODataGridViewTextBoxColumn.DataPropertyName = "PED_TOTALBRUTO";
            this.pEDTOTALBRUTODataGridViewTextBoxColumn.HeaderText = "PED_TOTALBRUTO";
            this.pEDTOTALBRUTODataGridViewTextBoxColumn.Name = "pEDTOTALBRUTODataGridViewTextBoxColumn";
            this.pEDTOTALBRUTODataGridViewTextBoxColumn.ReadOnly = true;
            this.pEDTOTALBRUTODataGridViewTextBoxColumn.Visible = false;
            // 
            // pEDPERCDESCDataGridViewTextBoxColumn
            // 
            this.pEDPERCDESCDataGridViewTextBoxColumn.DataPropertyName = "PED_PERCDESC";
            this.pEDPERCDESCDataGridViewTextBoxColumn.HeaderText = "PED_PERCDESC";
            this.pEDPERCDESCDataGridViewTextBoxColumn.Name = "pEDPERCDESCDataGridViewTextBoxColumn";
            this.pEDPERCDESCDataGridViewTextBoxColumn.ReadOnly = true;
            this.pEDPERCDESCDataGridViewTextBoxColumn.Visible = false;
            // 
            // pEDDESCONTODataGridViewTextBoxColumn
            // 
            this.pEDDESCONTODataGridViewTextBoxColumn.DataPropertyName = "PED_DESCONTO";
            this.pEDDESCONTODataGridViewTextBoxColumn.HeaderText = "PED_DESCONTO";
            this.pEDDESCONTODataGridViewTextBoxColumn.Name = "pEDDESCONTODataGridViewTextBoxColumn";
            this.pEDDESCONTODataGridViewTextBoxColumn.ReadOnly = true;
            this.pEDDESCONTODataGridViewTextBoxColumn.Visible = false;
            // 
            // pEDTOTALLIQDataGridViewTextBoxColumn
            // 
            this.pEDTOTALLIQDataGridViewTextBoxColumn.DataPropertyName = "PED_TOTALLIQ";
            this.pEDTOTALLIQDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.pEDTOTALLIQDataGridViewTextBoxColumn.Name = "pEDTOTALLIQDataGridViewTextBoxColumn";
            this.pEDTOTALLIQDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pEDOBSDataGridViewTextBoxColumn
            // 
            this.pEDOBSDataGridViewTextBoxColumn.DataPropertyName = "PED_OBS";
            this.pEDOBSDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.pEDOBSDataGridViewTextBoxColumn.Name = "pEDOBSDataGridViewTextBoxColumn";
            this.pEDOBSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codfuncionarioDataGridViewTextBoxColumn
            // 
            this.codfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "cod_funcionario";
            this.codfuncionarioDataGridViewTextBoxColumn.HeaderText = "cod_funcionario";
            this.codfuncionarioDataGridViewTextBoxColumn.Name = "codfuncionarioDataGridViewTextBoxColumn";
            this.codfuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.codfuncionarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // codclienteDataGridViewTextBoxColumn
            // 
            this.codclienteDataGridViewTextBoxColumn.DataPropertyName = "cod_cliente";
            this.codclienteDataGridViewTextBoxColumn.HeaderText = "cod_cliente";
            this.codclienteDataGridViewTextBoxColumn.Name = "codclienteDataGridViewTextBoxColumn";
            this.codclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codclienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // pEDIDOBindingSource
            // 
            this.pEDIDOBindingSource.DataMember = "PEDIDO";
            this.pEDIDOBindingSource.DataSource = this.jarbasDataSet;
            // 
            // fillByimprimeobaguiToolStrip
            // 
            this.fillByimprimeobaguiToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByimprimeobaguiToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoCodigoToolStripLabel,
            this.pedidoCodigoToolStripTextBox,
            this.fillByimprimeobaguiToolStripButton});
            this.fillByimprimeobaguiToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByimprimeobaguiToolStrip.Name = "fillByimprimeobaguiToolStrip";
            this.fillByimprimeobaguiToolStrip.Size = new System.Drawing.Size(321, 25);
            this.fillByimprimeobaguiToolStrip.TabIndex = 72;
            this.fillByimprimeobaguiToolStrip.Text = "fillByimprimeobaguiToolStrip";
            this.fillByimprimeobaguiToolStrip.Visible = false;
            // 
            // pedidoCodigoToolStripLabel
            // 
            this.pedidoCodigoToolStripLabel.Name = "pedidoCodigoToolStripLabel";
            this.pedidoCodigoToolStripLabel.Size = new System.Drawing.Size(86, 22);
            this.pedidoCodigoToolStripLabel.Text = "pedidoCodigo:";
            // 
            // pedidoCodigoToolStripTextBox
            // 
            this.pedidoCodigoToolStripTextBox.Name = "pedidoCodigoToolStripTextBox";
            this.pedidoCodigoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByimprimeobaguiToolStripButton
            // 
            this.fillByimprimeobaguiToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByimprimeobaguiToolStripButton.Name = "fillByimprimeobaguiToolStripButton";
            this.fillByimprimeobaguiToolStripButton.Size = new System.Drawing.Size(121, 22);
            this.fillByimprimeobaguiToolStripButton.Text = "FillByimprimeobagui";
            this.fillByimprimeobaguiToolStripButton.Click += new System.EventHandler(this.fillByimprimeobaguiToolStripButton_Click);
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendaTableAdapter = null;
            this.tableAdapterManager.atendimentosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cidadesTableAdapter = null;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.compraitemTableAdapter = null;
            this.tableAdapterManager.compraTableAdapter = null;
            this.tableAdapterManager.CPAGARTableAdapter = null;
            this.tableAdapterManager.CRECEBERTableAdapter = null;
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.ITEMPEDIDOTableAdapter = null;
            this.tableAdapterManager.itensTableAdapter = null;
            this.tableAdapterManager.PEDIDOTableAdapter = null;
            this.tableAdapterManager.procedimentosTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication3.jarbasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = this.vendasTableAdapter;
            // 
            // itensTableAdapter
            // 
            this.itensTableAdapter.ClearBeforeFill = true;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.jarbasDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // pEDIDOTableAdapter
            // 
            this.pEDIDOTableAdapter.ClearBeforeFill = true;
            // 
            // iTEMPEDIDOBindingSource
            // 
            this.iTEMPEDIDOBindingSource.DataMember = "ITEMPEDIDO";
            this.iTEMPEDIDOBindingSource.DataSource = this.jarbasDataSet;
            // 
            // iTEMPEDIDOTableAdapter
            // 
            this.iTEMPEDIDOTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 8;
            reportDataSource1.Name = "DataSetNovo";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.repPedidoCerto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(714, 475);
            this.reportViewer1.TabIndex = 73;
            this.reportViewer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reportViewer1_KeyPress);
            // 
            // relDataSet
            // 
            this.relDataSet.DataSetName = "relDataSet";
            this.relDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.jarbasDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Location = new System.Drawing.Point(5, 476);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(714, 23);
            this.button8.TabIndex = 74;
            this.button8.Text = "Fechar";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 501);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.fillByimprimeobaguiToolStrip);
            this.Controls.Add(this.panelPed);
            this.Controls.Add(this.panelPfunc);
            this.Controls.Add(this.panelPClie);
            this.Controls.Add(this.panelPesquisaClientes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPedido_FormClosed);
            this.Load += new System.EventHandler(this.FormPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelPfunc.ResumeLayout(false);
            this.panelPfunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelPesquisaClientes.ResumeLayout(false);
            this.panelPesquisaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panelPClie.ResumeLayout(false);
            this.panelPClie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            this.panelPed.ResumeLayout(false);
            this.panelPed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEDIDOBindingSource)).EndInit();
            this.fillByimprimeobaguiToolStrip.ResumeLayout(false);
            this.fillByimprimeobaguiToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMPEDIDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private jarbasDataSet jarbasDataSet;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private jarbasDataSetTableAdapters.vendasTableAdapter vendasTableAdapter;
        private jarbasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskDtVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtControle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource itensBindingSource;
        private jarbasDataSetTableAdapters.itensTableAdapter itensTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPvendedor;
        private System.Windows.Forms.TextBox txtcodVendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPCliente;
        private System.Windows.Forms.TextBox txtcodCliente;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Panel panelPesquisaClientes;
        private System.Windows.Forms.Button btnSaiPesquisa;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtpcli;
        private System.Windows.Forms.RadioButton radioButtonDescricao;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_nas;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button buttonCancela;
        private System.Windows.Forms.TextBox txtVTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpfunc;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView funcionariosDataGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelPClie;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn est_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn un_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_reduzida;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn margem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButtonBarras;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox txtsomaTudo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private jarbasDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSomaDesconto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCdesconto;
        public System.Windows.Forms.Panel panelPfunc;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panelPed;
        private System.Windows.Forms.RadioButton rbProduto;
        private System.Windows.Forms.RadioButton rbCodPed;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.TextBox txtPesquiPedido;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView pedidoDataGrid;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource pEDIDOBindingSource;
        private jarbasDataSetTableAdapters.PEDIDOTableAdapter pEDIDOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDCODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDDTEMISSAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDTOTALBRUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDPERCDESCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDDESCONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDTOTALLIQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDOBSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource iTEMPEDIDOBindingSource;
        private jarbasDataSetTableAdapters.ITEMPEDIDOTableAdapter iTEMPEDIDOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label18;
        private relDataSet relDataSet1;
        private jarbasDataSetTableAdapters.vendasTableAdapter DataTable1TableAdapter;
        private jarbasDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.ToolStrip fillByimprimeobaguiToolStrip;
        private System.Windows.Forms.ToolStripLabel pedidoCodigoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox pedidoCodigoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByimprimeobaguiToolStripButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private relDataSet relDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private jarbasDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.Button button8;
    }
}