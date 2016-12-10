namespace WindowsFormsApplication3
{
    partial class FormFornecedores
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
            this.buttoncancel = new System.Windows.Forms.Button();
            this.buttonSaiAtendimento = new System.Windows.Forms.Button();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jarbasDataSet = new WindowsFormsApplication3.jarbasDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLocaliza = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.fornecedoresTableAdapter = new WindowsFormsApplication3.jarbasDataSetTableAdapters.fornecedoresTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication3.jarbasDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPcidade = new System.Windows.Forms.Button();
            this.txtNcidade = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodFornecedor = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxRazao = new System.Windows.Forms.TextBox();
            this.textBoxFantasia = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.fornecedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.radioButtonFantasia = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.radioButtonrRazao = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageObs = new System.Windows.Forms.TabPage();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.panelCid = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesq = new System.Windows.Forms.Button();
            this.rbNomeC = new System.Windows.Forms.RadioButton();
            this.rbCcid = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageObs.SuspendLayout();
            this.panelCid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(442, 12);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(75, 39);
            this.buttoncancel.TabIndex = 57;
            this.buttoncancel.Text = "Cancelar";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttonLocalizaatendimento_Click);
            // 
            // buttonSaiAtendimento
            // 
            this.buttonSaiAtendimento.Location = new System.Drawing.Point(523, 12);
            this.buttonSaiAtendimento.Name = "buttonSaiAtendimento";
            this.buttonSaiAtendimento.Size = new System.Drawing.Size(75, 39);
            this.buttonSaiAtendimento.TabIndex = 56;
            this.buttonSaiAtendimento.Text = "Sair";
            this.buttonSaiAtendimento.UseVisualStyleBackColor = true;
            this.buttonSaiAtendimento.Click += new System.EventHandler(this.buttonSaiAtendimento_Click);
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "fornecedores";
            this.fornecedoresBindingSource.DataSource = this.jarbasDataSet;
            // 
            // jarbasDataSet
            // 
            this.jarbasDataSet.DataSetName = "jarbasDataSet";
            this.jarbasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLocaliza);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Controls.Add(this.btnExcluir);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Controls.Add(this.buttonSaiAtendimento);
            this.groupBox3.Controls.Add(this.buttoncancel);
            this.groupBox3.Location = new System.Drawing.Point(5, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 60);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            // 
            // btnLocaliza
            // 
            this.btnLocaliza.Location = new System.Drawing.Point(118, 12);
            this.btnLocaliza.Name = "btnLocaliza";
            this.btnLocaliza.Size = new System.Drawing.Size(75, 39);
            this.btnLocaliza.TabIndex = 73;
            this.btnLocaliza.Text = "Localizar";
            this.btnLocaliza.UseVisualStyleBackColor = true;
            this.btnLocaliza.Click += new System.EventHandler(this.btnLocaliza_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(361, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 39);
            this.btnSalvar.TabIndex = 72;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(280, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 39);
            this.btnExcluir.TabIndex = 71;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(199, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 39);
            this.btnNovo.TabIndex = 70;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendaTableAdapter = null;
            this.tableAdapterManager.atendimentosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cidadesTableAdapter = null;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.CPAGARTableAdapter = null;
            this.tableAdapterManager.CRECEBERTableAdapter = null;
            this.tableAdapterManager.fornecedoresTableAdapter = this.fornecedoresTableAdapter;
            this.tableAdapterManager.funcionariosTableAdapter = null;
            this.tableAdapterManager.ITEMPEDIDOTableAdapter = null;
            this.tableAdapterManager.itensTableAdapter = null;
            this.tableAdapterManager.PEDIDOTableAdapter = null;
            this.tableAdapterManager.procedimentosTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication3.jarbasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPcidade);
            this.groupBox1.Controls.Add(this.txtNcidade);
            this.groupBox1.Controls.Add(this.maskedTextBoxCelular);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCodFornecedor);
            this.groupBox1.Controls.Add(this.maskedTextBoxCnpj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxRazao);
            this.groupBox1.Controls.Add(this.textBoxFantasia);
            this.groupBox1.Controls.Add(this.textBoxEndereco);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxNumero);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxBairro);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxCidade);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maskedTextBoxTelefone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.maskedTextBoxCep);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 194);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            // 
            // btnPcidade
            // 
            this.btnPcidade.Location = new System.Drawing.Point(397, 133);
            this.btnPcidade.Name = "btnPcidade";
            this.btnPcidade.Size = new System.Drawing.Size(24, 23);
            this.btnPcidade.TabIndex = 67;
            this.btnPcidade.Text = "...";
            this.btnPcidade.UseVisualStyleBackColor = true;
            this.btnPcidade.Click += new System.EventHandler(this.btnPcidade_Click);
            // 
            // txtNcidade
            // 
            this.txtNcidade.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.txtNcidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "cidade", true));
            this.txtNcidade.Location = new System.Drawing.Point(425, 135);
            this.txtNcidade.Name = "txtNcidade";
            this.txtNcidade.Size = new System.Drawing.Size(171, 20);
            this.txtNcidade.TabIndex = 66;
            // 
            // maskedTextBoxCelular
            // 
            this.maskedTextBoxCelular.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.maskedTextBoxCelular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "celular", true));
            this.maskedTextBoxCelular.Location = new System.Drawing.Point(227, 135);
            this.maskedTextBoxCelular.Mask = "(##)####-####";
            this.maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            this.maskedTextBoxCelular.Size = new System.Drawing.Size(78, 20);
            this.maskedTextBoxCelular.TabIndex = 10;
            this.maskedTextBoxCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(170, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Celular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código";
            this.label1.UseWaitCursor = true;
            // 
            // textBoxCodFornecedor
            // 
            this.textBoxCodFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.textBoxCodFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.textBoxCodFornecedor.Location = new System.Drawing.Point(56, 25);
            this.textBoxCodFornecedor.Name = "textBoxCodFornecedor";
            this.textBoxCodFornecedor.Size = new System.Drawing.Size(58, 20);
            this.textBoxCodFornecedor.TabIndex = 1;
            this.textBoxCodFornecedor.Leave += new System.EventHandler(this.textBoxCodFornecedor_Leave);
            // 
            // maskedTextBoxCnpj
            // 
            this.maskedTextBoxCnpj.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.maskedTextBoxCnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "cnpj", true));
            this.maskedTextBoxCnpj.Location = new System.Drawing.Point(324, 62);
            this.maskedTextBoxCnpj.Mask = "##.###.###/####-##";
            this.maskedTextBoxCnpj.Name = "maskedTextBoxCnpj";
            this.maskedTextBoxCnpj.Size = new System.Drawing.Size(107, 20);
            this.maskedTextBoxCnpj.TabIndex = 4;
            this.maskedTextBoxCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.maskedTextBoxCnpj.Leave += new System.EventHandler(this.maskedTextBoxCnpj_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Razão";
            this.label2.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(284, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "CNPJ";
            // 
            // textBoxRazao
            // 
            this.textBoxRazao.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.textBoxRazao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "razão", true));
            this.textBoxRazao.Location = new System.Drawing.Point(168, 25);
            this.textBoxRazao.Name = "textBoxRazao";
            this.textBoxRazao.Size = new System.Drawing.Size(427, 20);
            this.textBoxRazao.TabIndex = 2;
            this.textBoxRazao.Leave += new System.EventHandler(this.textBoxRazao_Leave);
            // 
            // textBoxFantasia
            // 
            this.textBoxFantasia.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.textBoxFantasia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "fantasia", true));
            this.textBoxFantasia.Location = new System.Drawing.Point(61, 62);
            this.textBoxFantasia.Name = "textBoxFantasia";
            this.textBoxFantasia.Size = new System.Drawing.Size(209, 20);
            this.textBoxFantasia.TabIndex = 3;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.textBoxEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "endereco", true));
            this.textBoxEndereco.Location = new System.Drawing.Point(67, 97);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(238, 20);
            this.textBoxEndereco.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "Fantasia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(443, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Número";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.textBoxNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "cpf", true));
            this.textBoxNumero.Location = new System.Drawing.Point(493, 63);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(102, 20);
            this.textBoxNumero.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(316, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Bairro";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.textBoxBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "bairro", true));
            this.textBoxBairro.Location = new System.Drawing.Point(356, 98);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(131, 20);
            this.textBoxBairro.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.textBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "email", true));
            this.textBoxEmail.Location = new System.Drawing.Point(46, 170);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(550, 20);
            this.textBoxEmail.TabIndex = 12;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.textBoxCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "cidade", true));
            this.textBoxCidade.Location = new System.Drawing.Point(356, 135);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(37, 20);
            this.textBoxCidade.TabIndex = 11;
            this.textBoxCidade.TextChanged += new System.EventHandler(this.textBoxCidade_TextChanged);
            this.textBoxCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCidade_KeyPress);
            this.textBoxCidade.Leave += new System.EventHandler(this.textBoxCidade_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(8, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(316, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Cidade";
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.maskedTextBoxTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "telefone", true));
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(64, 135);
            this.maskedTextBoxTelefone.Mask = "(##)####-####";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(79, 20);
            this.maskedTextBoxTelefone.TabIndex = 9;
            this.maskedTextBoxTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(502, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Cep";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(7, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Telefone";
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.maskedTextBoxCep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "cep", true));
            this.maskedTextBoxCep.Location = new System.Drawing.Point(535, 97);
            this.maskedTextBoxCep.Mask = "#####-###";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(61, 20);
            this.maskedTextBoxCep.TabIndex = 8;
            this.maskedTextBoxCep.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.fornecedoresDataGridView);
            this.panel1.Controls.Add(this.radioButtonFantasia);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.radioButtonCodigo);
            this.panel1.Controls.Add(this.radioButtonrRazao);
            this.panel1.Location = new System.Drawing.Point(5, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 252);
            this.panel1.TabIndex = 75;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 76;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(143, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(343, 31);
            this.label13.TabIndex = 75;
            this.label13.Text = "Pesquisa De Fornecedores";
            // 
            // fornecedoresDataGridView
            // 
            this.fornecedoresDataGridView.AllowUserToAddRows = false;
            this.fornecedoresDataGridView.AllowUserToDeleteRows = false;
            this.fornecedoresDataGridView.AutoGenerateColumns = false;
            this.fornecedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fornecedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.fornecedoresDataGridView.DataSource = this.fornecedoresBindingSource;
            this.fornecedoresDataGridView.Location = new System.Drawing.Point(0, 46);
            this.fornecedoresDataGridView.Name = "fornecedoresDataGridView";
            this.fornecedoresDataGridView.ReadOnly = true;
            this.fornecedoresDataGridView.Size = new System.Drawing.Size(601, 171);
            this.fornecedoresDataGridView.TabIndex = 69;
            this.fornecedoresDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fornecedoresDataGridView_CellClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_fornecedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "razão";
            this.dataGridViewTextBoxColumn2.HeaderText = "Razão";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fantasia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fantasia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn4.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn5.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "telefone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "celular";
            this.dataGridViewTextBoxColumn8.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "cep";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cep";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "obs";
            this.dataGridViewTextBoxColumn10.HeaderText = "Observações";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "cnpj";
            this.dataGridViewTextBoxColumn11.HeaderText = "Cnpj";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "cpf";
            this.dataGridViewTextBoxColumn12.HeaderText = "Cpf";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn13.HeaderText = "Email";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // radioButtonFantasia
            // 
            this.radioButtonFantasia.AutoSize = true;
            this.radioButtonFantasia.Location = new System.Drawing.Point(131, 224);
            this.radioButtonFantasia.Name = "radioButtonFantasia";
            this.radioButtonFantasia.Size = new System.Drawing.Size(65, 17);
            this.radioButtonFantasia.TabIndex = 74;
            this.radioButtonFantasia.Text = "Fantasia";
            this.radioButtonFantasia.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 70;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 73;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(4, 222);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCodigo.TabIndex = 71;
            this.radioButtonCodigo.Text = "Código";
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            // 
            // radioButtonrRazao
            // 
            this.radioButtonrRazao.AutoSize = true;
            this.radioButtonrRazao.Checked = true;
            this.radioButtonrRazao.Location = new System.Drawing.Point(68, 223);
            this.radioButtonrRazao.Name = "radioButtonrRazao";
            this.radioButtonrRazao.Size = new System.Drawing.Size(56, 17);
            this.radioButtonrRazao.TabIndex = 72;
            this.radioButtonrRazao.TabStop = true;
            this.radioButtonrRazao.Text = "Razão";
            this.radioButtonrRazao.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(5, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 185);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageObs);
            this.tabControl1.Location = new System.Drawing.Point(6, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 164);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageObs
            // 
            this.tabPageObs.Controls.Add(this.textBoxObs);
            this.tabPageObs.Location = new System.Drawing.Point(4, 22);
            this.tabPageObs.Name = "tabPageObs";
            this.tabPageObs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageObs.Size = new System.Drawing.Size(581, 138);
            this.tabPageObs.TabIndex = 1;
            this.tabPageObs.Text = "Observações";
            this.tabPageObs.UseVisualStyleBackColor = true;
            // 
            // textBoxObs
            // 
            this.textBoxObs.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fornecedoresBindingSource, "cod_fornecedor", true));
            this.textBoxObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "obs", true));
            this.textBoxObs.Location = new System.Drawing.Point(6, 6);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(569, 129);
            this.textBoxObs.TabIndex = 13;
            // 
            // panelCid
            // 
            this.panelCid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCid.Controls.Add(this.label14);
            this.panelCid.Controls.Add(this.txtcid);
            this.panelCid.Controls.Add(this.btnSair);
            this.panelCid.Controls.Add(this.btnPesq);
            this.panelCid.Controls.Add(this.rbNomeC);
            this.panelCid.Controls.Add(this.rbCcid);
            this.panelCid.Controls.Add(this.dataGridView1);
            this.panelCid.Location = new System.Drawing.Point(5, 2);
            this.panelCid.Name = "panelCid";
            this.panelCid.Size = new System.Drawing.Size(291, 213);
            this.panelCid.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 31);
            this.label14.TabIndex = 6;
            this.label14.Text = "Cidades";
            // 
            // txtcid
            // 
            this.txtcid.Location = new System.Drawing.Point(4, 187);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(203, 20);
            this.txtcid.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(213, 185);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(213, 164);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(75, 23);
            this.btnPesq.TabIndex = 3;
            this.btnPesq.Text = "Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // rbNomeC
            // 
            this.rbNomeC.AutoSize = true;
            this.rbNomeC.Location = new System.Drawing.Point(63, 168);
            this.rbNomeC.Name = "rbNomeC";
            this.rbNomeC.Size = new System.Drawing.Size(53, 17);
            this.rbNomeC.TabIndex = 2;
            this.rbNomeC.TabStop = true;
            this.rbNomeC.Text = "Nome";
            this.rbNomeC.UseVisualStyleBackColor = true;
            // 
            // rbCcid
            // 
            this.rbCcid.AutoSize = true;
            this.rbCcid.Location = new System.Drawing.Point(4, 168);
            this.rbCcid.Name = "rbCcid";
            this.rbCcid.Size = new System.Drawing.Size(58, 17);
            this.rbCcid.TabIndex = 1;
            this.rbCcid.TabStop = true;
            this.rbCcid.Text = "Código";
            this.rbCcid.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(285, 122);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 456);
            this.Controls.Add(this.panelCid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFornecedores_FormClosed);
            this.Load += new System.EventHandler(this.FormFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageObs.ResumeLayout(false);
            this.tabPageObs.PerformLayout();
            this.panelCid.ResumeLayout(false);
            this.panelCid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Button buttonSaiAtendimento;
        private System.Windows.Forms.GroupBox groupBox3;
        private jarbasDataSet jarbasDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private jarbasDataSetTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter;
        private jarbasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLocaliza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodFornecedor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxRazao;
        private System.Windows.Forms.TextBox textBoxFantasia;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView fornecedoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.RadioButton radioButtonFantasia;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.RadioButton radioButtonrRazao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageObs;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Button btnPcidade;
        private System.Windows.Forms.TextBox txtNcidade;
        private System.Windows.Forms.Panel panelCid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.RadioButton rbNomeC;
        private System.Windows.Forms.RadioButton rbCcid;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}