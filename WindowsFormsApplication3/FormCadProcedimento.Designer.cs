namespace WindowsFormsApplication3
{
    partial class FormCadProcedimento
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
            this.procedimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jarbasDataSet = new WindowsFormsApplication3.jarbasDataSet();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.procedimentosTableAdapter = new WindowsFormsApplication3.jarbasDataSetTableAdapters.procedimentosTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication3.jarbasDataSetTableAdapters.TableAdapterManager();
            this.procedimentosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonDescricao = new System.Windows.Forms.RadioButton();
            this.radioButtonCodigo = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodProcedimento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeProcedimento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.procedimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.procedimentosDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // procedimentosBindingSource
            // 
            this.procedimentosBindingSource.DataMember = "procedimentos";
            this.procedimentosBindingSource.DataSource = this.jarbasDataSet;
            // 
            // jarbasDataSet
            // 
            this.jarbasDataSet.DataSetName = "jarbasDataSet";
            this.jarbasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(314, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 39);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.buttonLocaliza_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(393, 12);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 38);
            this.buttonSair.TabIndex = 7;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.buttonSair);
            this.groupBox1.Location = new System.Drawing.Point(2, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 62);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 15;
            this.button3.Text = "Localizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(235, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 39);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(156, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 40);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(77, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(76, 40);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // procedimentosTableAdapter
            // 
            this.procedimentosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.procedimentosTableAdapter = this.procedimentosTableAdapter;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication3.jarbasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.vendasTableAdapter = null;
            // 
            // procedimentosDataGridView
            // 
            this.procedimentosDataGridView.AllowUserToAddRows = false;
            this.procedimentosDataGridView.AllowUserToDeleteRows = false;
            this.procedimentosDataGridView.AutoGenerateColumns = false;
            this.procedimentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procedimentosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.procedimentosDataGridView.DataSource = this.procedimentosBindingSource;
            this.procedimentosDataGridView.Location = new System.Drawing.Point(0, 36);
            this.procedimentosDataGridView.Name = "procedimentosDataGridView";
            this.procedimentosDataGridView.ReadOnly = true;
            this.procedimentosDataGridView.Size = new System.Drawing.Size(473, 105);
            this.procedimentosDataGridView.TabIndex = 11;
            this.procedimentosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.procedimentosDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_procedimento";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "des_procedimento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Procedimento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 280;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonDescricao
            // 
            this.radioButtonDescricao.AutoSize = true;
            this.radioButtonDescricao.Checked = true;
            this.radioButtonDescricao.Location = new System.Drawing.Point(69, 147);
            this.radioButtonDescricao.Name = "radioButtonDescricao";
            this.radioButtonDescricao.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDescricao.TabIndex = 14;
            this.radioButtonDescricao.TabStop = true;
            this.radioButtonDescricao.Text = "Descrição";
            this.radioButtonDescricao.UseVisualStyleBackColor = true;
            this.radioButtonDescricao.Enter += new System.EventHandler(this.radioButtonDescricao_Enter);
            // 
            // radioButtonCodigo
            // 
            this.radioButtonCodigo.AutoSize = true;
            this.radioButtonCodigo.Location = new System.Drawing.Point(10, 147);
            this.radioButtonCodigo.Name = "radioButtonCodigo";
            this.radioButtonCodigo.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCodigo.TabIndex = 13;
            this.radioButtonCodigo.Text = "Código";
            this.radioButtonCodigo.UseVisualStyleBackColor = true;
            this.radioButtonCodigo.Enter += new System.EventHandler(this.radioButtonCodigo_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.procedimentosDataGridView);
            this.panel1.Controls.Add(this.radioButtonDescricao);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.radioButtonCodigo);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 173);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pesquisa de Procedimentos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCodProcedimento);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxNomeProcedimento);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 55);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // txtCodProcedimento
            // 
            this.txtCodProcedimento.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.procedimentosBindingSource, "cod_procedimento", true));
            this.txtCodProcedimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedimentosBindingSource, "cod_procedimento", true));
            this.txtCodProcedimento.Location = new System.Drawing.Point(6, 29);
            this.txtCodProcedimento.Name = "txtCodProcedimento";
            this.txtCodProcedimento.Size = new System.Drawing.Size(65, 20);
            this.txtCodProcedimento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Procediemento";
            // 
            // textBoxNomeProcedimento
            // 
            this.textBoxNomeProcedimento.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.procedimentosBindingSource, "cod_procedimento", true));
            this.textBoxNomeProcedimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procedimentosBindingSource, "des_procedimento", true));
            this.textBoxNomeProcedimento.Location = new System.Drawing.Point(87, 29);
            this.textBoxNomeProcedimento.Name = "textBoxNomeProcedimento";
            this.textBoxNomeProcedimento.Size = new System.Drawing.Size(258, 20);
            this.textBoxNomeProcedimento.TabIndex = 2;
            // 
            // FormCadProcedimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 245);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCadProcedimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Procedimento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCadProcedimento_FormClosed);
            this.Load += new System.EventHandler(this.FormCadProcedimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.procedimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarbasDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.procedimentosDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private jarbasDataSet jarbasDataSet;
        private System.Windows.Forms.BindingSource procedimentosBindingSource;
        private jarbasDataSetTableAdapters.procedimentosTableAdapter procedimentosTableAdapter;
        private jarbasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView procedimentosDataGridView;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.RadioButton radioButtonDescricao;
        private System.Windows.Forms.RadioButton radioButtonCodigo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodProcedimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomeProcedimento;
    }
}