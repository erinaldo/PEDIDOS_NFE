namespace WindowsFormsApplication3
{
    partial class FormProdutos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboSituacao = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtNfornecedor = new System.Windows.Forms.TextBox();
            this.txtCfornecedor = new System.Windows.Forms.TextBox();
            this.btnBforn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDesRed = new System.Windows.Forms.TextBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jarbasDataSet = new WindowsFormsApplication3.jarbasDataSet();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxCodPoduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUnMedida = new System.Windows.Forms.TextBox();
            this.textBoxBarras = new System.Windows.Forms.TextBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jarbasDataSet1 = new WindowsFormsApplication3.jarbasDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMarge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVlVenda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1CustoPro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEstoque = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.est_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.un_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_reduzida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfo_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstIcms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstcofins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliqinter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliqIcms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliqipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliqpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliqcofins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApplication3.DataSet1();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCancela = new System.Windows.Forms.Button();
            this.produtosTableAdapter = new WindowsFormsApplication3.jarbasDataSetTableAdapters.produtosTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication3.jarbasDataSetTableAdapters.TableAdapterManager();
            this.fornecedoresTableAdapter = new WindowsFormsApplication3.jarbasDataSetTableAdapters.fornecedoresTableAdapter();
            this.panelPesquisa = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSaiPesquisa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonDescricao = new System.Windows.Forms.RadioButton();
            this.radioButtonBarras = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButtonrRazao = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButtonFantasia = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.fornecedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboAliqINter = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCest = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtNcm = new System.Windows.Forms.TextBox();
            this.comboOrigem = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAliqCofins = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAliqPis = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAliqIpi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAliqIcms = new System.Windows.Forms.TextBox();
            this.comboCstCofins = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboCstPis = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboCstIpi = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboCstIcms = new System.Windows.Forms.ComboBox();
            this.comboCfop = new System.Windows.Forms.ComboBox();
            this.cFOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.produtosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cFOPTableAdapter = new WindowsFormsApplication3.DataSet1TableAdapters.CFOPTableAdapter();
            this.produtosTableAdapter1 = new WindowsFormsApplication3.DataSet1TableAdapters.produtosTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panelPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cFOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboSituacao);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtNfornecedor);
            this.groupBox1.Controls.Add(this.txtCfornecedor);
            this.groupBox1.Controls.Add(this.btnBforn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDesRed);
            this.groupBox1.Controls.Add(this.textBoxDescricao);
            this.groupBox1.Controls.Add(this.textBoxCodPoduto);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // comboSituacao
            // 
            this.comboSituacao.FormattingEnabled = true;
            this.comboSituacao.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.comboSituacao.Location = new System.Drawing.Point(669, 14);
            this.comboSituacao.Name = "comboSituacao";
            this.comboSituacao.Size = new System.Drawing.Size(97, 21);
            this.comboSituacao.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(617, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 13);
            this.label25.TabIndex = 26;
            this.label25.Text = "Situação";
            // 
            // txtNfornecedor
            // 
            this.txtNfornecedor.Location = new System.Drawing.Point(470, 45);
            this.txtNfornecedor.Name = "txtNfornecedor";
            this.txtNfornecedor.Size = new System.Drawing.Size(296, 20);
            this.txtNfornecedor.TabIndex = 8;
            // 
            // txtCfornecedor
            // 
            this.txtCfornecedor.Location = new System.Drawing.Point(425, 45);
            this.txtCfornecedor.Name = "txtCfornecedor";
            this.txtCfornecedor.Size = new System.Drawing.Size(39, 20);
            this.txtCfornecedor.TabIndex = 7;
            this.txtCfornecedor.TextChanged += new System.EventHandler(this.txtCfornecedor_TextChanged_1);
            this.txtCfornecedor.Leave += new System.EventHandler(this.txtCfornecedor_Leave);
            // 
            // btnBforn
            // 
            this.btnBforn.Location = new System.Drawing.Point(388, 43);
            this.btnBforn.Name = "btnBforn";
            this.btnBforn.Size = new System.Drawing.Size(31, 23);
            this.btnBforn.TabIndex = 5;
            this.btnBforn.Text = "...";
            this.btnBforn.UseVisualStyleBackColor = true;
            this.btnBforn.Click += new System.EventHandler(this.btnBforn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fornecedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Desc. Reduzida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código";
            // 
            // textBoxDesRed
            // 
            this.textBoxDesRed.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtosBindingSource, "cod_produto", true));
            this.textBoxDesRed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "desc_reduzida", true));
            this.textBoxDesRed.Location = new System.Drawing.Point(91, 45);
            this.textBoxDesRed.Name = "textBoxDesRed";
            this.textBoxDesRed.Size = new System.Drawing.Size(232, 20);
            this.textBoxDesRed.TabIndex = 4;
            this.textBoxDesRed.Text = " ";
            this.textBoxDesRed.Enter += new System.EventHandler(this.textBoxDesRed_Enter);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.jarbasDataSet;
            // 
            // jarbasDataSet
            // 
            this.jarbasDataSet.DataSetName = "jarbasDataSet";
            this.jarbasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtosBindingSource, "cod_produto", true));
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "des_produto", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(173, 13);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(435, 20);
            this.textBoxDescricao.TabIndex = 2;
            this.textBoxDescricao.Leave += new System.EventHandler(this.textBoxDescricao_Leave);
            // 
            // textBoxCodPoduto
            // 
            this.textBoxCodPoduto.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtosBindingSource, "cod_produto", true));
            this.textBoxCodPoduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "cod_produto", true));
            this.textBoxCodPoduto.Location = new System.Drawing.Point(46, 13);
            this.textBoxCodPoduto.Name = "textBoxCodPoduto";
            this.textBoxCodPoduto.Size = new System.Drawing.Size(56, 20);
            this.textBoxCodPoduto.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Unidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cod. Barras";
            // 
            // textBoxUnMedida
            // 
            this.textBoxUnMedida.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "un_medida", true));
            this.textBoxUnMedida.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtosBindingSource, "cod_produto", true));
            this.textBoxUnMedida.Location = new System.Drawing.Point(212, 14);
            this.textBoxUnMedida.Name = "textBoxUnMedida";
            this.textBoxUnMedida.Size = new System.Drawing.Size(49, 20);
            this.textBoxUnMedida.TabIndex = 10;
            // 
            // textBoxBarras
            // 
            this.textBoxBarras.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtosBindingSource, "cod_produto", true));
            this.textBoxBarras.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "ean", true));
            this.textBoxBarras.Location = new System.Drawing.Point(68, 13);
            this.textBoxBarras.Name = "textBoxBarras";
            this.textBoxBarras.Size = new System.Drawing.Size(83, 20);
            this.textBoxBarras.TabIndex = 9;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "fornecedores";
            this.fornecedoresBindingSource.DataSource = this.jarbasDataSet;
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "produtos";
            this.produtosBindingSource1.DataSource = this.jarbasDataSet1;
            // 
            // jarbasDataSet1
            // 
            this.jarbasDataSet1.DataSetName = "jarbasDataSet";
            this.jarbasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMarge);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxVlVenda);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox1CustoPro);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxEstoque);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxBarras);
            this.groupBox2.Controls.Add(this.textBoxUnMedida);
            this.groupBox2.Location = new System.Drawing.Point(6, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 44);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBoxMarge
            // 
            this.textBoxMarge.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtosBindingSource, "cod_produto", true));
            this.textBoxMarge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "margem", true));
            this.textBoxMarge.Location = new System.Drawing.Point(553, 13);
            this.textBoxMarge.Name = "textBoxMarge";
            this.textBoxMarge.Size = new System.Drawing.Size(47, 20);
            this.textBoxMarge.TabIndex = 13;
            this.textBoxMarge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMarge_KeyPress);
            this.textBoxMarge.Leave += new System.EventHandler(this.textBoxMarge_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Margem";
            // 
            // textBoxVlVenda
            // 
            this.textBoxVlVenda.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtosBindingSource, "cod_produto", true));
            this.textBoxVlVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "vl_produto", true));
            this.textBoxVlVenda.Location = new System.Drawing.Point(688, 14);
            this.textBoxVlVenda.Name = "textBoxVlVenda";
            this.textBoxVlVenda.Size = new System.Drawing.Size(78, 20);
            this.textBoxVlVenda.TabIndex = 14;
            this.textBoxVlVenda.Enter += new System.EventHandler(this.textBoxVlVenda_Enter);
            this.textBoxVlVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVlVenda_KeyPress);
            this.textBoxVlVenda.Leave += new System.EventHandler(this.textBoxVlVenda_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(604, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Valor de Venda";
            // 
            // textBox1CustoPro
            // 
            this.textBox1CustoPro.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtosBindingSource, "cod_produto", true));
            this.textBox1CustoPro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "custo", true));
            this.textBox1CustoPro.Location = new System.Drawing.Point(425, 14);
            this.textBox1CustoPro.Name = "textBox1CustoPro";
            this.textBox1CustoPro.Size = new System.Drawing.Size(74, 20);
            this.textBox1CustoPro.TabIndex = 12;
            this.textBox1CustoPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1CustoPro_KeyPress);
            this.textBox1CustoPro.Leave += new System.EventHandler(this.textBox1CustoPro_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Custo";
            // 
            // textBoxEstoque
            // 
            this.textBoxEstoque.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.produtosBindingSource, "cod_produto", true));
            this.textBoxEstoque.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "est_produto", true));
            this.textBoxEstoque.Location = new System.Drawing.Point(311, 14);
            this.textBoxEstoque.Name = "textBoxEstoque";
            this.textBoxEstoque.Size = new System.Drawing.Size(70, 20);
            this.textBoxEstoque.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Estoque";
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AllowUserToAddRows = false;
            this.produtosDataGridView.AllowUserToDeleteRows = false;
            this.produtosDataGridView.AutoGenerateColumns = false;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.cod_fornecedor,
            this.est_produto,
            this.un_medida,
            this.desc_reduzida,
            this.vl_produto,
            this.custo,
            this.margem,
            this.cfo_codigo,
            this.cest,
            this.ncm,
            this.cstIcms,
            this.cstipi,
            this.cstpis,
            this.cstcofins,
            this.aliqinter,
            this.aliqIcms,
            this.aliqipi,
            this.aliqpis,
            this.aliqcofins,
            this.origem,
            this.situacao});
            this.produtosDataGridView.DataSource = this.produtosBindingSource3;
            this.produtosDataGridView.Location = new System.Drawing.Point(1, 39);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.ReadOnly = true;
            this.produtosDataGridView.Size = new System.Drawing.Size(381, 116);
            this.produtosDataGridView.TabIndex = 3;
            this.produtosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produtosDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_produto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "des_produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ean";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cód. Barras";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            // cfo_codigo
            // 
            this.cfo_codigo.DataPropertyName = "cfo_codigo";
            this.cfo_codigo.HeaderText = "cfo_codigo";
            this.cfo_codigo.Name = "cfo_codigo";
            this.cfo_codigo.ReadOnly = true;
            this.cfo_codigo.Visible = false;
            // 
            // cest
            // 
            this.cest.DataPropertyName = "cest";
            this.cest.HeaderText = "cest";
            this.cest.Name = "cest";
            this.cest.ReadOnly = true;
            this.cest.Visible = false;
            // 
            // ncm
            // 
            this.ncm.DataPropertyName = "ncm";
            this.ncm.HeaderText = "ncm";
            this.ncm.Name = "ncm";
            this.ncm.ReadOnly = true;
            this.ncm.Visible = false;
            // 
            // cstIcms
            // 
            this.cstIcms.DataPropertyName = "cstIcms";
            this.cstIcms.HeaderText = "cstIcms";
            this.cstIcms.Name = "cstIcms";
            this.cstIcms.ReadOnly = true;
            this.cstIcms.Visible = false;
            // 
            // cstipi
            // 
            this.cstipi.DataPropertyName = "cstipi";
            this.cstipi.HeaderText = "cstipi";
            this.cstipi.Name = "cstipi";
            this.cstipi.ReadOnly = true;
            this.cstipi.Visible = false;
            // 
            // cstpis
            // 
            this.cstpis.DataPropertyName = "cstpis";
            this.cstpis.HeaderText = "cstpis";
            this.cstpis.Name = "cstpis";
            this.cstpis.ReadOnly = true;
            this.cstpis.Visible = false;
            // 
            // cstcofins
            // 
            this.cstcofins.DataPropertyName = "cstcofins";
            this.cstcofins.HeaderText = "cstcofins";
            this.cstcofins.Name = "cstcofins";
            this.cstcofins.ReadOnly = true;
            this.cstcofins.Visible = false;
            // 
            // aliqinter
            // 
            this.aliqinter.DataPropertyName = "aliqinter";
            this.aliqinter.HeaderText = "aliqinter";
            this.aliqinter.Name = "aliqinter";
            this.aliqinter.ReadOnly = true;
            this.aliqinter.Visible = false;
            // 
            // aliqIcms
            // 
            this.aliqIcms.DataPropertyName = "aliqIcms";
            this.aliqIcms.HeaderText = "aliqIcms";
            this.aliqIcms.Name = "aliqIcms";
            this.aliqIcms.ReadOnly = true;
            this.aliqIcms.Visible = false;
            // 
            // aliqipi
            // 
            this.aliqipi.DataPropertyName = "aliqipi";
            this.aliqipi.HeaderText = "aliqipi";
            this.aliqipi.Name = "aliqipi";
            this.aliqipi.ReadOnly = true;
            this.aliqipi.Visible = false;
            // 
            // aliqpis
            // 
            this.aliqpis.DataPropertyName = "aliqpis";
            this.aliqpis.HeaderText = "aliqpis";
            this.aliqpis.Name = "aliqpis";
            this.aliqpis.ReadOnly = true;
            this.aliqpis.Visible = false;
            // 
            // aliqcofins
            // 
            this.aliqcofins.DataPropertyName = "aliqcofins";
            this.aliqcofins.HeaderText = "aliqcofins";
            this.aliqcofins.Name = "aliqcofins";
            this.aliqcofins.ReadOnly = true;
            this.aliqcofins.Visible = false;
            // 
            // origem
            // 
            this.origem.DataPropertyName = "origem";
            this.origem.HeaderText = "origem";
            this.origem.Name = "origem";
            this.origem.ReadOnly = true;
            this.origem.Visible = false;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            this.situacao.HeaderText = "situacao";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Visible = false;
            // 
            // produtosBindingSource3
            // 
            this.produtosBindingSource3.DataMember = "produtos";
            this.produtosBindingSource3.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPesquisar);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Controls.Add(this.btnExcluir);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.buttonCancela);
            this.groupBox3.Location = new System.Drawing.Point(6, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 67);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(271, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 36);
            this.btnPesquisar.TabIndex = 27;
            this.btnPesquisar.Text = "Localizar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(514, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 36);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(433, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 36);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(352, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 36);
            this.btnNovo.TabIndex = 28;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(678, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 32;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCancela
            // 
            this.buttonCancela.Location = new System.Drawing.Point(597, 19);
            this.buttonCancela.Name = "buttonCancela";
            this.buttonCancela.Size = new System.Drawing.Size(75, 36);
            this.buttonCancela.TabIndex = 31;
            this.buttonCancela.Text = "Cancelar";
            this.buttonCancela.UseVisualStyleBackColor = true;
            this.buttonCancela.Click += new System.EventHandler(this.buttonCancela_Click);
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.produtosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication3.jarbasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // panelPesquisa
            // 
            this.panelPesquisa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPesquisa.Controls.Add(this.label11);
            this.panelPesquisa.Controls.Add(this.btnSaiPesquisa);
            this.panelPesquisa.Controls.Add(this.button1);
            this.panelPesquisa.Controls.Add(this.textBox1);
            this.panelPesquisa.Controls.Add(this.radioButtonDescricao);
            this.panelPesquisa.Controls.Add(this.radioButtonBarras);
            this.panelPesquisa.Controls.Add(this.radioButtonCodigo);
            this.panelPesquisa.Controls.Add(this.produtosDataGridView);
            this.panelPesquisa.Location = new System.Drawing.Point(6, 7);
            this.panelPesquisa.Name = "panelPesquisa";
            this.panelPesquisa.Size = new System.Drawing.Size(406, 228);
            this.panelPesquisa.TabIndex = 6;
            this.panelPesquisa.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(284, 31);
            this.label11.TabIndex = 10;
            this.label11.Text = "Pesquisa De Produtos";
            // 
            // btnSaiPesquisa
            // 
            this.btnSaiPesquisa.Location = new System.Drawing.Point(279, 157);
            this.btnSaiPesquisa.Name = "btnSaiPesquisa";
            this.btnSaiPesquisa.Size = new System.Drawing.Size(99, 23);
            this.btnSaiPesquisa.TabIndex = 9;
            this.btnSaiPesquisa.Text = "Sair";
            this.btnSaiPesquisa.UseVisualStyleBackColor = true;
            this.btnSaiPesquisa.Click += new System.EventHandler(this.btnSaiPesquisa_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 7;
            // 
            // radioButtonDescricao
            // 
            this.radioButtonDescricao.AutoSize = true;
            this.radioButtonDescricao.Checked = true;
            this.radioButtonDescricao.Location = new System.Drawing.Point(129, 161);
            this.radioButtonDescricao.Name = "radioButtonDescricao";
            this.radioButtonDescricao.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDescricao.TabIndex = 6;
            this.radioButtonDescricao.TabStop = true;
            this.radioButtonDescricao.Text = "Descrição";
            this.radioButtonDescricao.UseVisualStyleBackColor = true;
            // 
            // radioButtonBarras
            // 
            this.radioButtonBarras.AutoSize = true;
            this.radioButtonBarras.Location = new System.Drawing.Point(68, 161);
            this.radioButtonBarras.Name = "radioButtonBarras";
            this.radioButtonBarras.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBarras.TabIndex = 5;
            this.radioButtonBarras.TabStop = true;
            this.radioButtonBarras.Text = "Barras";
            this.radioButtonBarras.UseVisualStyleBackColor = true;
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(4, 161);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCodigo.TabIndex = 4;
            this.radioButtonCodigo.TabStop = true;
            this.radioButtonCodigo.Text = "Código";
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(343, 31);
            this.label13.TabIndex = 83;
            this.label13.Text = "Pesquisa De Fornecedores";
            // 
            // radioButtonrRazao
            // 
            this.radioButtonrRazao.AutoSize = true;
            this.radioButtonrRazao.Checked = true;
            this.radioButtonrRazao.Location = new System.Drawing.Point(69, 178);
            this.radioButtonrRazao.Name = "radioButtonrRazao";
            this.radioButtonrRazao.Size = new System.Drawing.Size(56, 17);
            this.radioButtonrRazao.TabIndex = 80;
            this.radioButtonrRazao.TabStop = true;
            this.radioButtonrRazao.Text = "Razão";
            this.radioButtonrRazao.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 178);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 79;
            this.radioButton1.Text = "Código";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 81;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(5, 199);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(201, 20);
            this.textBox4.TabIndex = 78;
            // 
            // radioButtonFantasia
            // 
            this.radioButtonFantasia.AutoSize = true;
            this.radioButtonFantasia.Location = new System.Drawing.Point(131, 178);
            this.radioButtonFantasia.Name = "radioButtonFantasia";
            this.radioButtonFantasia.Size = new System.Drawing.Size(65, 17);
            this.radioButtonFantasia.TabIndex = 82;
            this.radioButtonFantasia.Text = "Fantasia";
            this.radioButtonFantasia.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 84;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fornecedoresDataGridView
            // 
            this.fornecedoresDataGridView.AllowUserToAddRows = false;
            this.fornecedoresDataGridView.AllowUserToDeleteRows = false;
            this.fornecedoresDataGridView.AutoGenerateColumns = false;
            this.fornecedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fornecedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.fornecedoresDataGridView.DataSource = this.fornecedoresBindingSource;
            this.fornecedoresDataGridView.Location = new System.Drawing.Point(3, 34);
            this.fornecedoresDataGridView.Name = "fornecedoresDataGridView";
            this.fornecedoresDataGridView.ReadOnly = true;
            this.fornecedoresDataGridView.Size = new System.Drawing.Size(396, 138);
            this.fornecedoresDataGridView.TabIndex = 77;
            this.fornecedoresDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fornecedoresDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cod_fornecedor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "razão";
            this.dataGridViewTextBoxColumn5.HeaderText = "Razão";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fantasia";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fantasia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn7.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn8.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn10.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "celular";
            this.dataGridViewTextBoxColumn11.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "cep";
            this.dataGridViewTextBoxColumn12.HeaderText = "Cep";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "obs";
            this.dataGridViewTextBoxColumn13.HeaderText = "Observações";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "cnpj";
            this.dataGridViewTextBoxColumn14.HeaderText = "Cnpj";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "cpf";
            this.dataGridViewTextBoxColumn15.HeaderText = "Cpf";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn16.HeaderText = "Email";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.fornecedoresDataGridView);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.radioButtonFantasia);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButtonrRazao);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(385, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 227);
            this.panel1.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboAliqINter);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.txtCest);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtNcm);
            this.groupBox4.Controls.Add(this.comboOrigem);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtAliqCofins);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtAliqPis);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtAliqIpi);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtAliqIcms);
            this.groupBox4.Controls.Add(this.comboCstCofins);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.comboCstPis);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.comboCstIpi);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.comboCstIcms);
            this.groupBox4.Controls.Add(this.comboCfop);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(6, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(779, 100);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tributação";
            // 
            // comboAliqINter
            // 
            this.comboAliqINter.FormattingEnabled = true;
            this.comboAliqINter.Items.AddRange(new object[] {
            "4",
            "7",
            "12"});
            this.comboAliqINter.Location = new System.Drawing.Point(352, 33);
            this.comboAliqINter.Name = "comboAliqINter";
            this.comboAliqINter.Size = new System.Drawing.Size(91, 21);
            this.comboAliqINter.TabIndex = 19;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(352, 17);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 13);
            this.label26.TabIndex = 27;
            this.label26.Text = "Aliq. Interestadual %";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(453, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "CEST";
            // 
            // txtCest
            // 
            this.txtCest.Location = new System.Drawing.Point(449, 34);
            this.txtCest.Name = "txtCest";
            this.txtCest.Size = new System.Drawing.Size(65, 20);
            this.txtCest.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 59);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 23;
            this.label23.Text = "NCM";
            // 
            // txtNcm
            // 
            this.txtNcm.Location = new System.Drawing.Point(5, 75);
            this.txtNcm.Name = "txtNcm";
            this.txtNcm.Size = new System.Drawing.Size(65, 20);
            this.txtNcm.TabIndex = 21;
            // 
            // comboOrigem
            // 
            this.comboOrigem.FormattingEnabled = true;
            this.comboOrigem.Items.AddRange(new object[] {
            "0 - Nacional, exceto as indicadas nos códigos 3 a 5 ",
            "1 - Estrangeira - Importação direta, exceto a indicada no código 6 ",
            "2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7 ",
            "3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40% (quaren" +
                "ta por cento) ",
            "4 - Nacional, cuja produção tenha sido feita em conformidade com os processos pro" +
                "dutivos básicos de que tratam o Decreto-Lei nº 288/67, e as Leis nºs 8.248/91, 8" +
                ".387/91, 10.176/01 e 11 . 4 8 4 / 0 7 ",
            "5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40" +
                "% (quarenta por cento) ",
            "6 - Estrangeira - Importação direta, sem similar nacional, constante em lista de " +
                "Resolução CAMEX ",
            "7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante e" +
                "m lista de Resolução CAMEX” "});
            this.comboOrigem.Location = new System.Drawing.Point(352, 74);
            this.comboOrigem.Name = "comboOrigem";
            this.comboOrigem.Size = new System.Drawing.Size(421, 21);
            this.comboOrigem.TabIndex = 26;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(349, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "Origem";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(277, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "ALIQ. COFINS";
            // 
            // txtAliqCofins
            // 
            this.txtAliqCofins.Location = new System.Drawing.Point(276, 75);
            this.txtAliqCofins.Name = "txtAliqCofins";
            this.txtAliqCofins.Size = new System.Drawing.Size(65, 20);
            this.txtAliqCofins.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(210, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "ALIQ. PIS";
            // 
            // txtAliqPis
            // 
            this.txtAliqPis.Location = new System.Drawing.Point(209, 75);
            this.txtAliqPis.Name = "txtAliqPis";
            this.txtAliqPis.Size = new System.Drawing.Size(65, 20);
            this.txtAliqPis.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(143, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "ALIQ. IPI";
            // 
            // txtAliqIpi
            // 
            this.txtAliqIpi.Location = new System.Drawing.Point(142, 75);
            this.txtAliqIpi.Name = "txtAliqIpi";
            this.txtAliqIpi.Size = new System.Drawing.Size(65, 20);
            this.txtAliqIpi.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(74, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "ALIQ. ICMS";
            // 
            // txtAliqIcms
            // 
            this.txtAliqIcms.Location = new System.Drawing.Point(73, 75);
            this.txtAliqIcms.Name = "txtAliqIcms";
            this.txtAliqIcms.Size = new System.Drawing.Size(65, 20);
            this.txtAliqIcms.TabIndex = 22;
            // 
            // comboCstCofins
            // 
            this.comboCstCofins.FormattingEnabled = true;
            this.comboCstCofins.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "98",
            "99"});
            this.comboCstCofins.Location = new System.Drawing.Point(278, 33);
            this.comboCstCofins.Name = "comboCstCofins";
            this.comboCstCofins.Size = new System.Drawing.Size(63, 21);
            this.comboCstCofins.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(278, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "CST COFINS";
            // 
            // comboCstPis
            // 
            this.comboCstPis.FormattingEnabled = true;
            this.comboCstPis.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "98",
            "99"});
            this.comboCstPis.Location = new System.Drawing.Point(209, 33);
            this.comboCstPis.Name = "comboCstPis";
            this.comboCstPis.Size = new System.Drawing.Size(63, 21);
            this.comboCstPis.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(209, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "CST PIS";
            // 
            // comboCstIpi
            // 
            this.comboCstIpi.FormattingEnabled = true;
            this.comboCstIpi.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "99"});
            this.comboCstIpi.Location = new System.Drawing.Point(142, 33);
            this.comboCstIpi.Name = "comboCstIpi";
            this.comboCstIpi.Size = new System.Drawing.Size(63, 21);
            this.comboCstIpi.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(142, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "CST IPI";
            // 
            // comboCstIcms
            // 
            this.comboCstIcms.FormattingEnabled = true;
            this.comboCstIcms.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "41",
            "50",
            "51",
            "70",
            "60",
            "90",
            "101",
            "102",
            "103",
            "201",
            "202",
            "203",
            "300",
            "400",
            "500",
            "900"});
            this.comboCstIcms.Location = new System.Drawing.Point(75, 33);
            this.comboCstIcms.Name = "comboCstIcms";
            this.comboCstIcms.Size = new System.Drawing.Size(63, 21);
            this.comboCstIcms.TabIndex = 16;
            // 
            // comboCfop
            // 
            this.comboCfop.DataSource = this.cFOPBindingSource;
            this.comboCfop.DisplayMember = "cfo_codigo";
            this.comboCfop.FormattingEnabled = true;
            this.comboCfop.Location = new System.Drawing.Point(6, 33);
            this.comboCfop.Name = "comboCfop";
            this.comboCfop.Size = new System.Drawing.Size(63, 21);
            this.comboCfop.TabIndex = 15;
            this.comboCfop.ValueMember = "cfo_codigo";
            // 
            // cFOPBindingSource
            // 
            this.cFOPBindingSource.DataMember = "CFOP";
            this.cFOPBindingSource.DataSource = this.dataSet1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "CFOP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "CST ICMS";
            // 
            // produtosBindingSource2
            // 
            this.produtosBindingSource2.DataMember = "produtos";
            this.produtosBindingSource2.DataSource = this.dataSet1;
            // 
            // cFOPTableAdapter
            // 
            this.cFOPTableAdapter.ClearBeforeFill = true;
            // 
            // produtosTableAdapter1
            // 
            this.produtosTableAdapter1.ClearBeforeFill = true;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(790, 313);
            this.Controls.Add(this.panelPesquisa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProdutos_FormClosed);
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panelPesquisa.ResumeLayout(false);
            this.panelPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cFOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDesRed;
        private System.Windows.Forms.TextBox textBoxUnMedida;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxBarras;
        private System.Windows.Forms.TextBox textBoxCodPoduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEstoque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1CustoPro;
        private jarbasDataSet jarbasDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private jarbasDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private jarbasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonCancela;
        private System.Windows.Forms.TextBox textBoxMarge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVlVenda;
        private jarbasDataSet jarbasDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private jarbasDataSetTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonDescricao;
        private System.Windows.Forms.RadioButton radioButtonBarras;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.Button btnSaiPesquisa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNfornecedor;
        private System.Windows.Forms.TextBox txtCfornecedor;
        private System.Windows.Forms.Button btnBforn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView fornecedoresDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButtonFantasia;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButtonrRazao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtAliqCofins;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtAliqPis;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAliqIpi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAliqIcms;
        private System.Windows.Forms.ComboBox comboCstCofins;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboCstPis;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboCstIpi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboCstIcms;
        private System.Windows.Forms.ComboBox comboCfop;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboOrigem;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboSituacao;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtCest;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtNcm;
        private System.Windows.Forms.ComboBox comboAliqINter;
        private System.Windows.Forms.Label label26;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cFOPBindingSource;
        private DataSet1TableAdapters.CFOPTableAdapter cFOPTableAdapter;
        private System.Windows.Forms.BindingSource produtosBindingSource2;
        private DataSet1TableAdapters.produtosTableAdapter produtosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn est_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn un_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_reduzida;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn custo;
        private System.Windows.Forms.DataGridViewTextBoxColumn margem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfo_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncm;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstIcms;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstcofins;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliqinter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliqIcms;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliqipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliqpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliqcofins;
        private System.Windows.Forms.DataGridViewTextBoxColumn origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.BindingSource produtosBindingSource3;
    }
}