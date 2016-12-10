namespace WindowsFormsApplication3
{
    partial class FormCidades
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
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.buttonExclui = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.cIDADESDataGridView = new System.Windows.Forms.DataGridView();
            this.cidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jarbasDataSet1 = new WindowsFormsApplication3.jarbasDataSet();
            this.radioButtonDescricao = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelPesquisa = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIbge = new System.Windows.Forms.TextBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jarbasDataSet = new WindowsFormsApplication3.jarbasDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodCidade = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.comboBoxUf = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cidadesTableAdapter = new WindowsFormsApplication3.jarbasDataSetTableAdapters.cidadesTableAdapter();
            this.cidcodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidnomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid_ibge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cIDADESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet1)).BeginInit();
            this.panelPesquisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(97, 10);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 38);
            this.buttonNovo.TabIndex = 6;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.NovoRegistro);
            // 
            // buttonSalva
            // 
            this.buttonSalva.Location = new System.Drawing.Point(176, 10);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(75, 38);
            this.buttonSalva.TabIndex = 7;
            this.buttonSalva.Text = "Salvar";
            this.buttonSalva.UseVisualStyleBackColor = true;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(256, 10);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 38);
            this.btnCancela.TabIndex = 8;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // buttonExclui
            // 
            this.buttonExclui.Location = new System.Drawing.Point(335, 10);
            this.buttonExclui.Name = "buttonExclui";
            this.buttonExclui.Size = new System.Drawing.Size(75, 38);
            this.buttonExclui.TabIndex = 9;
            this.buttonExclui.Text = "Excluir";
            this.buttonExclui.UseVisualStyleBackColor = true;
            this.buttonExclui.Click += new System.EventHandler(this.buttonExclui_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(414, 10);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 38);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.button5_Click);
            // 
            // cIDADESDataGridView
            // 
            this.cIDADESDataGridView.AllowUserToAddRows = false;
            this.cIDADESDataGridView.AllowUserToDeleteRows = false;
            this.cIDADESDataGridView.AutoGenerateColumns = false;
            this.cIDADESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cIDADESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidcodigoDataGridViewTextBoxColumn,
            this.cidnomeDataGridViewTextBoxColumn,
            this.cidufDataGridViewTextBoxColumn,
            this.cid_ibge});
            this.cIDADESDataGridView.DataSource = this.cidadesBindingSource1;
            this.cIDADESDataGridView.Location = new System.Drawing.Point(0, 39);
            this.cIDADESDataGridView.Name = "cIDADESDataGridView";
            this.cIDADESDataGridView.ReadOnly = true;
            this.cIDADESDataGridView.Size = new System.Drawing.Size(498, 105);
            this.cIDADESDataGridView.TabIndex = 12;
            this.cIDADESDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cIDADESDataGridView_CellClick);
            // 
            // cidadesBindingSource1
            // 
            this.cidadesBindingSource1.DataMember = "cidades";
            this.cidadesBindingSource1.DataSource = this.jarbasDataSet1;
            // 
            // jarbasDataSet1
            // 
            this.jarbasDataSet1.DataSetName = "jarbasDataSet";
            this.jarbasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radioButtonDescricao
            // 
            this.radioButtonDescricao.AutoSize = true;
            this.radioButtonDescricao.Location = new System.Drawing.Point(76, 150);
            this.radioButtonDescricao.Name = "radioButtonDescricao";
            this.radioButtonDescricao.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDescricao.TabIndex = 19;
            this.radioButtonDescricao.TabStop = true;
            this.radioButtonDescricao.Text = "Descrição";
            this.radioButtonDescricao.UseVisualStyleBackColor = true;
            this.radioButtonDescricao.Enter += new System.EventHandler(this.radioButtonDescricao_Enter);
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(11, 149);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCodigo.TabIndex = 18;
            this.radioButtonCodigo.TabStop = true;
            this.radioButtonCodigo.Text = "Código";
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            this.radioButtonCodigo.Enter += new System.EventHandler(this.radioButtonCodigo_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panelPesquisa
            // 
            this.panelPesquisa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPesquisa.Controls.Add(this.label4);
            this.panelPesquisa.Controls.Add(this.button2);
            this.panelPesquisa.Controls.Add(this.button1);
            this.panelPesquisa.Controls.Add(this.radioButtonDescricao);
            this.panelPesquisa.Controls.Add(this.cIDADESDataGridView);
            this.panelPesquisa.Controls.Add(this.radioButtonCodigo);
            this.panelPesquisa.Controls.Add(this.textBox1);
            this.panelPesquisa.Location = new System.Drawing.Point(2, 1);
            this.panelPesquisa.Name = "panelPesquisa";
            this.panelPesquisa.Size = new System.Drawing.Size(499, 181);
            this.panelPesquisa.TabIndex = 15;
            this.panelPesquisa.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Pesquisa de Cidade";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 31);
            this.button2.TabIndex = 20;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIbge);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodCidade);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.comboBoxUf);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 177);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Código IBGE";
            // 
            // txtIbge
            // 
            this.txtIbge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "cid_codigo", true));
            this.txtIbge.Location = new System.Drawing.Point(282, 74);
            this.txtIbge.Name = "txtIbge";
            this.txtIbge.Size = new System.Drawing.Size(207, 20);
            this.txtIbge.TabIndex = 6;
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "cidades";
            this.cidadesBindingSource.DataSource = this.jarbasDataSet;
            // 
            // jarbasDataSet
            // 
            this.jarbasDataSet.DataSetName = "jarbasDataSet";
            this.jarbasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // txtCodCidade
            // 
            this.txtCodCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "cid_codigo", true));
            this.txtCodCidade.Location = new System.Drawing.Point(9, 33);
            this.txtCodCidade.Name = "txtCodCidade";
            this.txtCodCidade.Size = new System.Drawing.Size(49, 20);
            this.txtCodCidade.TabIndex = 0;
            // 
            // txtCidade
            // 
            this.txtCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "cid_nome", true));
            this.txtCidade.Location = new System.Drawing.Point(64, 33);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(425, 20);
            this.txtCidade.TabIndex = 1;
            // 
            // comboBoxUf
            // 
            this.comboBoxUf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "cid_uf", true));
            this.comboBoxUf.FormattingEnabled = true;
            this.comboBoxUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            ""});
            this.comboBoxUf.Location = new System.Drawing.Point(7, 73);
            this.comboBoxUf.Name = "comboBoxUf";
            this.comboBoxUf.Size = new System.Drawing.Size(260, 21);
            this.comboBoxUf.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "UF";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 17;
            this.button3.Text = "Localizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.buttonNovo);
            this.groupBox2.Controls.Add(this.buttonSalva);
            this.groupBox2.Controls.Add(this.btnCancela);
            this.groupBox2.Controls.Add(this.buttonSair);
            this.groupBox2.Controls.Add(this.buttonExclui);
            this.groupBox2.Location = new System.Drawing.Point(3, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 54);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // cidcodigoDataGridViewTextBoxColumn
            // 
            this.cidcodigoDataGridViewTextBoxColumn.DataPropertyName = "cid_codigo";
            this.cidcodigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.cidcodigoDataGridViewTextBoxColumn.Name = "cidcodigoDataGridViewTextBoxColumn";
            this.cidcodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidcodigoDataGridViewTextBoxColumn.Width = 50;
            // 
            // cidnomeDataGridViewTextBoxColumn
            // 
            this.cidnomeDataGridViewTextBoxColumn.DataPropertyName = "cid_nome";
            this.cidnomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.cidnomeDataGridViewTextBoxColumn.Name = "cidnomeDataGridViewTextBoxColumn";
            this.cidnomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidnomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // cidufDataGridViewTextBoxColumn
            // 
            this.cidufDataGridViewTextBoxColumn.DataPropertyName = "cid_uf";
            this.cidufDataGridViewTextBoxColumn.HeaderText = "UF";
            this.cidufDataGridViewTextBoxColumn.Name = "cidufDataGridViewTextBoxColumn";
            this.cidufDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidufDataGridViewTextBoxColumn.Width = 50;
            // 
            // cid_ibge
            // 
            this.cid_ibge.DataPropertyName = "cid_ibge";
            this.cid_ibge.HeaderText = "cid_ibge";
            this.cid_ibge.Name = "cid_ibge";
            this.cid_ibge.ReadOnly = true;
            this.cid_ibge.Visible = false;
            // 
            // FormCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 244);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelPesquisa);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cidades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCidades_FormClosed);
            this.Load += new System.EventHandler(this.FormCidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cIDADESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet1)).EndInit();
            this.panelPesquisa.ResumeLayout(false);
            this.panelPesquisa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button buttonExclui;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.DataGridView cIDADESDataGridView;
        private jarbasDataSet jarbasDataSet;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private jarbasDataSetTableAdapters.cidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonDescricao;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox comboBoxUf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIbge;
        private jarbasDataSet jarbasDataSet1;
        private System.Windows.Forms.BindingSource cidadesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidnomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid_ibge;
    }
}