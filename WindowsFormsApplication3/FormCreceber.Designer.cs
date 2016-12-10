namespace WindowsFormsApplication3
{
    partial class FormCreceber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.rbRazao = new System.Windows.Forms.RadioButton();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.panelCreceber = new System.Windows.Forms.Panel();
            this.txtNpesquicon = new System.Windows.Forms.TextBox();
            this.btnBuscaCadSecundario = new System.Windows.Forms.Button();
            this.txtpesqConRec = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbDvenc = new System.Windows.Forms.RadioButton();
            this.dataGridViewCpagar = new System.Windows.Forms.DataGridView();
            this.btnsaircPagar = new System.Windows.Forms.Button();
            this.rbValor = new System.Windows.Forms.RadioButton();
            this.txtPcPagar = new System.Windows.Forms.TextBox();
            this.btnFilCpagar = new System.Windows.Forms.Button();
            this.rbControle = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVlRecebido = new System.Windows.Forms.TextBox();
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
            this.txtNcadastroPrincipal = new System.Windows.Forms.TextBox();
            this.btnBClientePrincipal = new System.Windows.Forms.Button();
            this.txtCCadastro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtControle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.btnPesquisaCliSecundario = new System.Windows.Forms.Button();
            this.panelCreceber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCpagar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelPesquisaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // txtJuros
            // 
            this.txtJuros.Enabled = false;
            this.txtJuros.Location = new System.Drawing.Point(157, 49);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(74, 20);
            this.txtJuros.TabIndex = 15;
            this.txtJuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJuros_KeyPress);
            // 
            // panelCreceber
            // 
            this.panelCreceber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCreceber.Controls.Add(this.txtNpesquicon);
            this.panelCreceber.Controls.Add(this.btnBuscaCadSecundario);
            this.panelCreceber.Controls.Add(this.txtpesqConRec);
            this.panelCreceber.Controls.Add(this.label11);
            this.panelCreceber.Controls.Add(this.rbDvenc);
            this.panelCreceber.Controls.Add(this.dataGridViewCpagar);
            this.panelCreceber.Controls.Add(this.btnsaircPagar);
            this.panelCreceber.Controls.Add(this.rbValor);
            this.panelCreceber.Controls.Add(this.txtPcPagar);
            this.panelCreceber.Controls.Add(this.btnFilCpagar);
            this.panelCreceber.Controls.Add(this.rbControle);
            this.panelCreceber.Controls.Add(this.rbRazao);
            this.panelCreceber.Controls.Add(this.label10);
            this.panelCreceber.Location = new System.Drawing.Point(1, 3);
            this.panelCreceber.Name = "panelCreceber";
            this.panelCreceber.Size = new System.Drawing.Size(400, 227);
            this.panelCreceber.TabIndex = 15;
            // 
            // txtNpesquicon
            // 
            this.txtNpesquicon.Location = new System.Drawing.Point(137, 152);
            this.txtNpesquicon.Name = "txtNpesquicon";
            this.txtNpesquicon.Size = new System.Drawing.Size(260, 20);
            this.txtNpesquicon.TabIndex = 89;
            // 
            // btnBuscaCadSecundario
            // 
            this.btnBuscaCadSecundario.Location = new System.Drawing.Point(105, 150);
            this.btnBuscaCadSecundario.Name = "btnBuscaCadSecundario";
            this.btnBuscaCadSecundario.Size = new System.Drawing.Size(26, 23);
            this.btnBuscaCadSecundario.TabIndex = 88;
            this.btnBuscaCadSecundario.Text = "...";
            this.btnBuscaCadSecundario.UseVisualStyleBackColor = true;
            this.btnBuscaCadSecundario.Click += new System.EventHandler(this.btnBuscaCadSecundario_Click);
            // 
            // txtpesqConRec
            // 
            this.txtpesqConRec.Location = new System.Drawing.Point(60, 151);
            this.txtpesqConRec.Name = "txtpesqConRec";
            this.txtpesqConRec.Size = new System.Drawing.Size(40, 20);
            this.txtpesqConRec.TabIndex = 87;
            this.txtpesqConRec.TextChanged += new System.EventHandler(this.txtpesqConRec_TextChanged);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(384, 31);
            this.label10.TabIndex = 83;
            this.label10.Text = "Contas à Receber/ Recebidas ";
            // 
            // txtVlRecebido
            // 
            this.txtVlRecebido.Location = new System.Drawing.Point(218, 22);
            this.txtVlRecebido.Name = "txtVlRecebido";
            this.txtVlRecebido.Size = new System.Drawing.Size(74, 20);
            this.txtVlRecebido.TabIndex = 13;
            this.txtVlRecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlRecebido_KeyPress);
            this.txtVlRecebido.Leave += new System.EventHandler(this.txtVlRecebido_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPesquisar);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Controls.Add(this.btnExcluir);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Controls.Add(this.btnCancela);
            this.groupBox3.Location = new System.Drawing.Point(3, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 67);
            this.groupBox3.TabIndex = 11;
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
            this.groupBox1.Controls.Add(this.txtNcadastroPrincipal);
            this.groupBox1.Controls.Add(this.btnBClientePrincipal);
            this.groupBox1.Controls.Add(this.txtCCadastro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtControle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 169);
            this.groupBox1.TabIndex = 12;
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
            // txtNcadastroPrincipal
            // 
            this.txtNcadastroPrincipal.Location = new System.Drawing.Point(240, 14);
            this.txtNcadastroPrincipal.Name = "txtNcadastroPrincipal";
            this.txtNcadastroPrincipal.Size = new System.Drawing.Size(322, 20);
            this.txtNcadastroPrincipal.TabIndex = 5;
            this.txtNcadastroPrincipal.Leave += new System.EventHandler(this.txtNcadastroPrincipal_Leave);
            // 
            // btnBClientePrincipal
            // 
            this.btnBClientePrincipal.Location = new System.Drawing.Point(210, 12);
            this.btnBClientePrincipal.Name = "btnBClientePrincipal";
            this.btnBClientePrincipal.Size = new System.Drawing.Size(26, 23);
            this.btnBClientePrincipal.TabIndex = 4;
            this.btnBClientePrincipal.Text = "...";
            this.btnBClientePrincipal.UseVisualStyleBackColor = true;
            this.btnBClientePrincipal.Click += new System.EventHandler(this.btnBClientePrincipal_Click);
            // 
            // txtCCadastro
            // 
            this.txtCCadastro.Location = new System.Drawing.Point(164, 13);
            this.txtCCadastro.Name = "txtCCadastro";
            this.txtCCadastro.Size = new System.Drawing.Size(41, 20);
            this.txtCCadastro.TabIndex = 3;
            this.txtCCadastro.TextChanged += new System.EventHandler(this.txtCCadastro_TextChanged);
            this.txtCCadastro.Leave += new System.EventHandler(this.txtCCadastro_Leave);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtJuros);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtVlRecebido);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(3, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 79);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Baixa";
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
            this.panelPesquisaClientes.Controls.Add(this.btnPesquisaCliSecundario);
            this.panelPesquisaClientes.Location = new System.Drawing.Point(1, 2);
            this.panelPesquisaClientes.Name = "panelPesquisaClientes";
            this.panelPesquisaClientes.Size = new System.Drawing.Size(257, 248);
            this.panelPesquisaClientes.TabIndex = 16;
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
            // btnPesquisaCliSecundario
            // 
            this.btnPesquisaCliSecundario.Location = new System.Drawing.Point(162, 220);
            this.btnPesquisaCliSecundario.Name = "btnPesquisaCliSecundario";
            this.btnPesquisaCliSecundario.Size = new System.Drawing.Size(83, 23);
            this.btnPesquisaCliSecundario.TabIndex = 53;
            this.btnPesquisaCliSecundario.Text = "Pesquisar";
            this.btnPesquisaCliSecundario.UseVisualStyleBackColor = true;
            this.btnPesquisaCliSecundario.Click += new System.EventHandler(this.btnPesquisaCliSecundario_Click);
            // 
            // FormCreceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 327);
            this.Controls.Add(this.panelPesquisaClientes);
            this.Controls.Add(this.panelCreceber);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCreceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas à Receber";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCreceber_FormClosed);
            this.Load += new System.EventHandler(this.FormCreceber_Load);
            this.panelCreceber.ResumeLayout(false);
            this.panelCreceber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCpagar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelPesquisaClientes.ResumeLayout(false);
            this.panelPesquisaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbRazao;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Panel panelCreceber;
        private System.Windows.Forms.TextBox txtNpesquicon;
        private System.Windows.Forms.Button btnBuscaCadSecundario;
        private System.Windows.Forms.TextBox txtpesqConRec;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbDvenc;
        private System.Windows.Forms.DataGridView dataGridViewCpagar;
        private System.Windows.Forms.Button btnsaircPagar;
        private System.Windows.Forms.RadioButton rbValor;
        private System.Windows.Forms.TextBox txtPcPagar;
        private System.Windows.Forms.Button btnFilCpagar;
        private System.Windows.Forms.RadioButton rbControle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVlRecebido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cdSituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.MaskedTextBox mskDtVenc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNcadastroPrincipal;
        private System.Windows.Forms.Button btnBClientePrincipal;
        private System.Windows.Forms.TextBox txtCCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtControle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelPesquisaClientes;
        private System.Windows.Forms.TextBox txtpcli;
        private System.Windows.Forms.RadioButton radioButtonDescricao;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaiPesquisa;
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
        private System.Windows.Forms.Button btnPesquisaCliSecundario;
    }
}