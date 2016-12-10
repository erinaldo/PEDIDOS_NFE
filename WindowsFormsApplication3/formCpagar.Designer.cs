namespace WindowsFormsApplication3
{
    partial class formCpagar
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cdSituacao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.mskDtVenc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNcadastro = new System.Windows.Forms.TextBox();
            this.btnBForn = new System.Windows.Forms.Button();
            this.txtCCadastro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtControle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVlPago = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelpFORNECEDOR = new System.Windows.Forms.Panel();
            this.fornecedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSaiPforn = new System.Windows.Forms.Button();
            this.radioButtonFantasia = new System.Windows.Forms.RadioButton();
            this.txtpForn = new System.Windows.Forms.TextBox();
            this.btnfilForn = new System.Windows.Forms.Button();
            this.rbCodForn = new System.Windows.Forms.RadioButton();
            this.radioButtonrRazao = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.panelCpagar = new System.Windows.Forms.Panel();
            this.txtNpesquicon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpesqConPag = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbDvenc = new System.Windows.Forms.RadioButton();
            this.dataGridViewCpagar = new System.Windows.Forms.DataGridView();
            this.btnsaircPagar = new System.Windows.Forms.Button();
            this.rbValor = new System.Windows.Forms.RadioButton();
            this.txtPcPagar = new System.Windows.Forms.TextBox();
            this.btnFilCpagar = new System.Windows.Forms.Button();
            this.rbControle = new System.Windows.Forms.RadioButton();
            this.rbRazao = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelpFORNECEDOR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresDataGridView)).BeginInit();
            this.panelCpagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCpagar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPesquisar);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Controls.Add(this.btnExcluir);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Controls.Add(this.btnCancela);
            this.groupBox3.Location = new System.Drawing.Point(4, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 67);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(80, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 36);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Localizar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(323, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 36);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(242, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 36);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(161, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 36);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(487, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 36);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(406, 19);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 36);
            this.btnCancela.TabIndex = 3;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cdSituacao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.mskDtVenc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNcadastro);
            this.groupBox1.Controls.Add(this.btnBForn);
            this.groupBox1.Controls.Add(this.txtCCadastro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtControle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 169);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Situação";
            // 
            // cdSituacao
            // 
            this.cdSituacao.FormattingEnabled = true;
            this.cdSituacao.Items.AddRange(new object[] {
            "PENDENTE",
            "BAIXADO"});
            this.cdSituacao.Location = new System.Drawing.Point(360, 45);
            this.cdSituacao.Name = "cdSituacao";
            this.cdSituacao.Size = new System.Drawing.Size(121, 21);
            this.cdSituacao.TabIndex = 12;
            this.cdSituacao.Leave += new System.EventHandler(this.cdSituacao_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Observação";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(11, 91);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(551, 73);
            this.txtObs.TabIndex = 10;
            this.txtObs.Leave += new System.EventHandler(this.txtObs_Leave);
            // 
            // mskDtVenc
            // 
            this.mskDtVenc.BackColor = System.Drawing.SystemColors.Window;
            this.mskDtVenc.Location = new System.Drawing.Point(217, 45);
            this.mskDtVenc.Mask = "00/00/0000";
            this.mskDtVenc.Name = "mskDtVenc";
            this.mskDtVenc.Size = new System.Drawing.Size(75, 20);
            this.mskDtVenc.TabIndex = 9;
            this.mskDtVenc.ValidatingType = typeof(System.DateTime);
            this.mskDtVenc.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mskDtVenc_TypeValidationCompleted);
            this.mskDtVenc.Leave += new System.EventHandler(this.mskDtVenc_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Vencimento";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(41, 46);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(74, 20);
            this.txtValor.TabIndex = 7;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor ";
            // 
            // txtNcadastro
            // 
            this.txtNcadastro.Location = new System.Drawing.Point(240, 14);
            this.txtNcadastro.Name = "txtNcadastro";
            this.txtNcadastro.Size = new System.Drawing.Size(322, 20);
            this.txtNcadastro.TabIndex = 5;
            // 
            // btnBForn
            // 
            this.btnBForn.Location = new System.Drawing.Point(210, 12);
            this.btnBForn.Name = "btnBForn";
            this.btnBForn.Size = new System.Drawing.Size(26, 23);
            this.btnBForn.TabIndex = 4;
            this.btnBForn.Text = "...";
            this.btnBForn.UseVisualStyleBackColor = true;
            this.btnBForn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCCadastro
            // 
            this.txtCCadastro.Location = new System.Drawing.Point(164, 13);
            this.txtCCadastro.Name = "txtCCadastro";
            this.txtCCadastro.Size = new System.Drawing.Size(41, 20);
            this.txtCCadastro.TabIndex = 3;
            this.txtCCadastro.TextChanged += new System.EventHandler(this.txtCCadastro_TextChanged);
            this.txtCCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCadastro_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadastro";
            // 
            // txtControle
            // 
            this.txtControle.Enabled = false;
            this.txtControle.Location = new System.Drawing.Point(54, 13);
            this.txtControle.Name = "txtControle";
            this.txtControle.Size = new System.Drawing.Size(50, 20);
            this.txtControle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtJuros);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtVlPago);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(4, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 79);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Baixa";
            // 
            // txtJuros
            // 
            this.txtJuros.Enabled = false;
            this.txtJuros.Location = new System.Drawing.Point(157, 49);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(74, 20);
            this.txtJuros.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Despesas e Juros Adicionais";
            // 
            // txtVlPago
            // 
            this.txtVlPago.Location = new System.Drawing.Point(218, 22);
            this.txtVlPago.Name = "txtVlPago";
            this.txtVlPago.Size = new System.Drawing.Size(74, 20);
            this.txtVlPago.TabIndex = 13;
            this.txtVlPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtVlPago.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Valor Pago";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(70, 21);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(75, 20);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBox1_TypeValidationCompleted);
            this.maskedTextBox1.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Data Baixa";
            // 
            // panelpFORNECEDOR
            // 
            this.panelpFORNECEDOR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelpFORNECEDOR.Controls.Add(this.fornecedoresDataGridView);
            this.panelpFORNECEDOR.Controls.Add(this.btnSaiPforn);
            this.panelpFORNECEDOR.Controls.Add(this.radioButtonFantasia);
            this.panelpFORNECEDOR.Controls.Add(this.txtpForn);
            this.panelpFORNECEDOR.Controls.Add(this.btnfilForn);
            this.panelpFORNECEDOR.Controls.Add(this.rbCodForn);
            this.panelpFORNECEDOR.Controls.Add(this.radioButtonrRazao);
            this.panelpFORNECEDOR.Controls.Add(this.label13);
            this.panelpFORNECEDOR.Location = new System.Drawing.Point(2, 93);
            this.panelpFORNECEDOR.Name = "panelpFORNECEDOR";
            this.panelpFORNECEDOR.Size = new System.Drawing.Size(400, 227);
            this.panelpFORNECEDOR.TabIndex = 9;
            // 
            // fornecedoresDataGridView
            // 
            this.fornecedoresDataGridView.AllowUserToAddRows = false;
            this.fornecedoresDataGridView.AllowUserToDeleteRows = false;
            this.fornecedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fornecedoresDataGridView.Location = new System.Drawing.Point(3, 34);
            this.fornecedoresDataGridView.Name = "fornecedoresDataGridView";
            this.fornecedoresDataGridView.ReadOnly = true;
            this.fornecedoresDataGridView.Size = new System.Drawing.Size(396, 138);
            this.fornecedoresDataGridView.TabIndex = 77;
            this.fornecedoresDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fornecedoresDataGridView_CellClick);
            // 
            // btnSaiPforn
            // 
            this.btnSaiPforn.Location = new System.Drawing.Point(298, 174);
            this.btnSaiPforn.Name = "btnSaiPforn";
            this.btnSaiPforn.Size = new System.Drawing.Size(101, 23);
            this.btnSaiPforn.TabIndex = 84;
            this.btnSaiPforn.Text = "Sair";
            this.btnSaiPforn.UseVisualStyleBackColor = true;
            this.btnSaiPforn.Click += new System.EventHandler(this.btnSaiPforn_Click);
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
            // txtpForn
            // 
            this.txtpForn.Location = new System.Drawing.Point(5, 199);
            this.txtpForn.Name = "txtpForn";
            this.txtpForn.Size = new System.Drawing.Size(201, 20);
            this.txtpForn.TabIndex = 78;
            // 
            // btnfilForn
            // 
            this.btnfilForn.Location = new System.Drawing.Point(297, 199);
            this.btnfilForn.Name = "btnfilForn";
            this.btnfilForn.Size = new System.Drawing.Size(102, 23);
            this.btnfilForn.TabIndex = 81;
            this.btnfilForn.Text = "Pesquisar";
            this.btnfilForn.UseVisualStyleBackColor = true;
            this.btnfilForn.Click += new System.EventHandler(this.btnfilForn_Click);
            // 
            // rbCodForn
            // 
            this.rbCodForn.AutoSize = true;
            this.rbCodForn.Location = new System.Drawing.Point(5, 178);
            this.rbCodForn.Name = "rbCodForn";
            this.rbCodForn.Size = new System.Drawing.Size(58, 17);
            this.rbCodForn.TabIndex = 79;
            this.rbCodForn.Text = "Código";
            this.rbCodForn.UseVisualStyleBackColor = true;
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
            // panelCpagar
            // 
            this.panelCpagar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCpagar.Controls.Add(this.txtNpesquicon);
            this.panelCpagar.Controls.Add(this.button1);
            this.panelCpagar.Controls.Add(this.txtpesqConPag);
            this.panelCpagar.Controls.Add(this.label11);
            this.panelCpagar.Controls.Add(this.rbDvenc);
            this.panelCpagar.Controls.Add(this.dataGridViewCpagar);
            this.panelCpagar.Controls.Add(this.btnsaircPagar);
            this.panelCpagar.Controls.Add(this.rbValor);
            this.panelCpagar.Controls.Add(this.txtPcPagar);
            this.panelCpagar.Controls.Add(this.btnFilCpagar);
            this.panelCpagar.Controls.Add(this.rbControle);
            this.panelCpagar.Controls.Add(this.rbRazao);
            this.panelCpagar.Controls.Add(this.label10);
            this.panelCpagar.Location = new System.Drawing.Point(1, 20);
            this.panelCpagar.Name = "panelCpagar";
            this.panelCpagar.Size = new System.Drawing.Size(400, 227);
            this.panelCpagar.TabIndex = 10;
            // 
            // txtNpesquicon
            // 
            this.txtNpesquicon.Location = new System.Drawing.Point(137, 152);
            this.txtNpesquicon.Name = "txtNpesquicon";
            this.txtNpesquicon.Size = new System.Drawing.Size(260, 20);
            this.txtNpesquicon.TabIndex = 89;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 88;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtpesqConPag
            // 
            this.txtpesqConPag.Location = new System.Drawing.Point(60, 151);
            this.txtpesqConPag.Name = "txtpesqConPag";
            this.txtpesqConPag.Size = new System.Drawing.Size(40, 20);
            this.txtpesqConPag.TabIndex = 87;
            this.txtpesqConPag.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "Cadastro";
            // 
            // rbDvenc
            // 
            this.rbDvenc.AutoSize = true;
            this.rbDvenc.Enabled = false;
            this.rbDvenc.Location = new System.Drawing.Point(174, 178);
            this.rbDvenc.Name = "rbDvenc";
            this.rbDvenc.Size = new System.Drawing.Size(107, 17);
            this.rbDvenc.TabIndex = 85;
            this.rbDvenc.Text = "Data Vencimento";
            this.rbDvenc.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCpagar
            // 
            this.dataGridViewCpagar.AllowUserToAddRows = false;
            this.dataGridViewCpagar.AllowUserToDeleteRows = false;
            this.dataGridViewCpagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCpagar.Location = new System.Drawing.Point(3, 34);
            this.dataGridViewCpagar.Name = "dataGridViewCpagar";
            this.dataGridViewCpagar.ReadOnly = true;
            this.dataGridViewCpagar.Size = new System.Drawing.Size(396, 115);
            this.dataGridViewCpagar.TabIndex = 77;
            this.dataGridViewCpagar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCpagar_CellClick);
            // 
            // btnsaircPagar
            // 
            this.btnsaircPagar.Location = new System.Drawing.Point(298, 174);
            this.btnsaircPagar.Name = "btnsaircPagar";
            this.btnsaircPagar.Size = new System.Drawing.Size(101, 23);
            this.btnsaircPagar.TabIndex = 84;
            this.btnsaircPagar.Text = "Sair";
            this.btnsaircPagar.UseVisualStyleBackColor = true;
            this.btnsaircPagar.Click += new System.EventHandler(this.btnsaircPagar_Click);
            // 
            // rbValor
            // 
            this.rbValor.AutoSize = true;
            this.rbValor.Enabled = false;
            this.rbValor.Location = new System.Drawing.Point(117, 178);
            this.rbValor.Name = "rbValor";
            this.rbValor.Size = new System.Drawing.Size(49, 17);
            this.rbValor.TabIndex = 82;
            this.rbValor.Text = "Valor";
            this.rbValor.UseVisualStyleBackColor = true;
            // 
            // txtPcPagar
            // 
            this.txtPcPagar.Enabled = false;
            this.txtPcPagar.Location = new System.Drawing.Point(5, 199);
            this.txtPcPagar.Name = "txtPcPagar";
            this.txtPcPagar.Size = new System.Drawing.Size(201, 20);
            this.txtPcPagar.TabIndex = 78;
            // 
            // btnFilCpagar
            // 
            this.btnFilCpagar.Location = new System.Drawing.Point(297, 199);
            this.btnFilCpagar.Name = "btnFilCpagar";
            this.btnFilCpagar.Size = new System.Drawing.Size(102, 23);
            this.btnFilCpagar.TabIndex = 81;
            this.btnFilCpagar.Text = "Pesquisar";
            this.btnFilCpagar.UseVisualStyleBackColor = true;
            this.btnFilCpagar.Click += new System.EventHandler(this.btnFilCpagar_Click);
            // 
            // rbControle
            // 
            this.rbControle.AutoSize = true;
            this.rbControle.Enabled = false;
            this.rbControle.Location = new System.Drawing.Point(5, 178);
            this.rbControle.Name = "rbControle";
            this.rbControle.Size = new System.Drawing.Size(58, 17);
            this.rbControle.TabIndex = 79;
            this.rbControle.Text = "Código";
            this.rbControle.UseVisualStyleBackColor = true;
            // 
            // rbRazao
            // 
            this.rbRazao.AutoSize = true;
            this.rbRazao.Checked = true;
            this.rbRazao.Enabled = false;
            this.rbRazao.Location = new System.Drawing.Point(63, 178);
            this.rbRazao.Name = "rbRazao";
            this.rbRazao.Size = new System.Drawing.Size(56, 17);
            this.rbRazao.TabIndex = 80;
            this.rbRazao.TabStop = true;
            this.rbRazao.Text = "Razão";
            this.rbRazao.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(301, 31);
            this.label10.TabIndex = 83;
            this.label10.Text = "Contas à Pagar/ Pagas ";
            // 
            // formCpagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 322);
            this.Controls.Add(this.panelpFORNECEDOR);
            this.Controls.Add(this.panelCpagar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formCpagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas à Pagar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formCpagar_FormClosed);
            this.Load += new System.EventHandler(this.formCpagar_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelpFORNECEDOR.ResumeLayout(false);
            this.panelpFORNECEDOR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresDataGridView)).EndInit();
            this.panelCpagar.ResumeLayout(false);
            this.panelCpagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCpagar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNcadastro;
        private System.Windows.Forms.Button btnBForn;
        private System.Windows.Forms.TextBox txtCCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtControle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cdSituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.MaskedTextBox mskDtVenc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVlPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Panel panelpFORNECEDOR;
        private System.Windows.Forms.DataGridView fornecedoresDataGridView;
        private System.Windows.Forms.Button btnSaiPforn;
        private System.Windows.Forms.RadioButton radioButtonFantasia;
        private System.Windows.Forms.TextBox txtpForn;
        private System.Windows.Forms.Button btnfilForn;
        private System.Windows.Forms.RadioButton rbCodForn;
        private System.Windows.Forms.RadioButton radioButtonrRazao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelCpagar;
        private System.Windows.Forms.RadioButton rbDvenc;
        private System.Windows.Forms.DataGridView dataGridViewCpagar;
        private System.Windows.Forms.Button btnsaircPagar;
        private System.Windows.Forms.RadioButton rbValor;
        private System.Windows.Forms.TextBox txtPcPagar;
        private System.Windows.Forms.Button btnFilCpagar;
        private System.Windows.Forms.RadioButton rbControle;
        private System.Windows.Forms.RadioButton rbRazao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNpesquicon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpesqConPag;
        private System.Windows.Forms.Label label11;
    }
}