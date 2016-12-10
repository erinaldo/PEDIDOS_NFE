namespace WindowsFormsApplication3
{
    partial class FormCadCFOP
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonExclui = new System.Windows.Forms.Button();
            this.panelPesquisa = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonDescricao = new System.Windows.Forms.RadioButton();
            this.cfopDataGridView = new System.Windows.Forms.DataGridView();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodCopf = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSet1 = new WindowsFormsApplication3.DataSet1();
            this.cFOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cFOPTableAdapter = new WindowsFormsApplication3.DataSet1TableAdapters.CFOPTableAdapter();
            this.cfocodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cfodescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.panelPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfopDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.buttonNovo);
            this.groupBox2.Controls.Add(this.buttonSalva);
            this.groupBox2.Controls.Add(this.btnCancela);
            this.groupBox2.Controls.Add(this.buttonSair);
            this.groupBox2.Controls.Add(this.buttonExclui);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 54);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
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
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(97, 10);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 38);
            this.buttonNovo.TabIndex = 6;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
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
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(414, 10);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 38);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
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
            // panelPesquisa
            // 
            this.panelPesquisa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPesquisa.Controls.Add(this.label4);
            this.panelPesquisa.Controls.Add(this.button2);
            this.panelPesquisa.Controls.Add(this.button1);
            this.panelPesquisa.Controls.Add(this.radioButtonDescricao);
            this.panelPesquisa.Controls.Add(this.cfopDataGridView);
            this.panelPesquisa.Controls.Add(this.radioButtonCodigo);
            this.panelPesquisa.Controls.Add(this.textBox1);
            this.panelPesquisa.Location = new System.Drawing.Point(5, 1);
            this.panelPesquisa.Name = "panelPesquisa";
            this.panelPesquisa.Size = new System.Drawing.Size(499, 181);
            this.panelPesquisa.TabIndex = 19;
            this.panelPesquisa.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Pesquisa de CFOP";
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
            // radioButtonDescricao
            // 
            this.radioButtonDescricao.AutoSize = true;
            this.radioButtonDescricao.Checked = true;
            this.radioButtonDescricao.Location = new System.Drawing.Point(76, 150);
            this.radioButtonDescricao.Name = "radioButtonDescricao";
            this.radioButtonDescricao.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDescricao.TabIndex = 19;
            this.radioButtonDescricao.TabStop = true;
            this.radioButtonDescricao.Text = "Descrição";
            this.radioButtonDescricao.UseVisualStyleBackColor = true;
            // 
            // cfopDataGridView
            // 
            this.cfopDataGridView.AllowUserToAddRows = false;
            this.cfopDataGridView.AllowUserToDeleteRows = false;
            this.cfopDataGridView.AutoGenerateColumns = false;
            this.cfopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cfopDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cfocodigoDataGridViewTextBoxColumn,
            this.cfodescricaoDataGridViewTextBoxColumn});
            this.cfopDataGridView.DataSource = this.cFOPBindingSource;
            this.cfopDataGridView.Location = new System.Drawing.Point(3, 38);
            this.cfopDataGridView.Name = "cfopDataGridView";
            this.cfopDataGridView.ReadOnly = true;
            this.cfopDataGridView.Size = new System.Drawing.Size(498, 105);
            this.cfopDataGridView.TabIndex = 12;
            this.cfopDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cIDADESDataGridView_CellClick);
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodCopf);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 169);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CFOP";
            // 
            // txtCodCopf
            // 
            this.txtCodCopf.Location = new System.Drawing.Point(9, 33);
            this.txtCodCopf.MaxLength = 5;
            this.txtCodCopf.Name = "txtCodCopf";
            this.txtCodCopf.Size = new System.Drawing.Size(49, 20);
            this.txtCodCopf.TabIndex = 0;
            this.txtCodCopf.TextChanged += new System.EventHandler(this.txtCodCopf_TextChanged);
            this.txtCodCopf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCopf_KeyPress);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(64, 33);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(425, 20);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cFOPBindingSource
            // 
            this.cFOPBindingSource.DataMember = "CFOP";
            this.cFOPBindingSource.DataSource = this.dataSet1;
            // 
            // cFOPTableAdapter
            // 
            this.cFOPTableAdapter.ClearBeforeFill = true;
            // 
            // cfocodigoDataGridViewTextBoxColumn
            // 
            this.cfocodigoDataGridViewTextBoxColumn.DataPropertyName = "cfo_codigo";
            this.cfocodigoDataGridViewTextBoxColumn.HeaderText = "CFOP";
            this.cfocodigoDataGridViewTextBoxColumn.Name = "cfocodigoDataGridViewTextBoxColumn";
            this.cfocodigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cfodescricaoDataGridViewTextBoxColumn
            // 
            this.cfodescricaoDataGridViewTextBoxColumn.DataPropertyName = "cfo_descricao";
            this.cfodescricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.cfodescricaoDataGridViewTextBoxColumn.Name = "cfodescricaoDataGridViewTextBoxColumn";
            this.cfodescricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormCadCFOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 246);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelPesquisa);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCadCFOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadCFOP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCadCFOP_FormClosed);
            this.Load += new System.EventHandler(this.FormCadCFOP_Load);
            this.groupBox2.ResumeLayout(false);
            this.panelPesquisa.ResumeLayout(false);
            this.panelPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfopDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFOPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonExclui;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonDescricao;
        private System.Windows.Forms.DataGridView cfopDataGridView;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodCopf;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cFOPBindingSource;
        private DataSet1TableAdapters.CFOPTableAdapter cFOPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfocodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfodescricaoDataGridViewTextBoxColumn;
    }
}