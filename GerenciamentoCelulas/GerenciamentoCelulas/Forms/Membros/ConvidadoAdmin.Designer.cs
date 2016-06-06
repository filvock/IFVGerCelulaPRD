namespace GerenciamentoCelulas.Forms.Membros
{
    partial class ConvidadoAdmin
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
            this.ConvidadoAdminClose = new System.Windows.Forms.Button();
            this.ConvidadoAdminAddMember = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.membrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gerenciaCelulasDataSet = new GerenciamentoCelulas.GerenciaCelulasDataSet();
            this.membrosTableAdapter = new GerenciamentoCelulas.GerenciaCelulasDataSetTableAdapters.MembrosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.igrejaComboBox = new System.Windows.Forms.ComboBox();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.redeComboBox = new System.Windows.Forms.ComboBox();
            this.redesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distritoComboBox = new System.Windows.Forms.ComboBox();
            this.distritosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areaComboBox = new System.Windows.Forms.ComboBox();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setorComboBox = new System.Windows.Forms.ComboBox();
            this.setoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.celulasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejasTableAdapter = new GerenciamentoCelulas.GerenciaCelulasDataSetTableAdapters.IgrejasTableAdapter();
            this.redesTableAdapter = new GerenciamentoCelulas.GerenciaCelulasDataSetTableAdapters.RedesTableAdapter();
            this.setorCheckBox = new System.Windows.Forms.CheckBox();
            this.areaCheckBox = new System.Windows.Forms.CheckBox();
            this.distritoCheckBox = new System.Windows.Forms.CheckBox();
            this.redeCheckBox = new System.Windows.Forms.CheckBox();
            this.distritosTableAdapter = new GerenciamentoCelulas.GerenciaCelulasDataSetTableAdapters.DistritosTableAdapter();
            this.areasTableAdapter = new GerenciamentoCelulas.GerenciaCelulasDataSetTableAdapters.AreasTableAdapter();
            this.setoresTableAdapter = new GerenciamentoCelulas.GerenciaCelulasDataSetTableAdapters.SetoresTableAdapter();
            this.celulasTableAdapter = new GerenciamentoCelulas.GerenciaCelulasDataSetTableAdapters.CelulasTableAdapter();
            this.semCelCheckBox = new System.Windows.Forms.CheckBox();
            this.semDiscCheckBox = new System.Windows.Forms.CheckBox();
            this.convidadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.convidadosTableAdapter = new GerenciamentoCelulas.GerenciaCelulasDataSetTableAdapters.ConvidadosTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutraIgreja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuemConvidou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operadoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaCelulasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celulasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convidadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ConvidadoAdminClose
            // 
            this.ConvidadoAdminClose.Location = new System.Drawing.Point(948, 258);
            this.ConvidadoAdminClose.Margin = new System.Windows.Forms.Padding(6);
            this.ConvidadoAdminClose.Name = "ConvidadoAdminClose";
            this.ConvidadoAdminClose.Size = new System.Drawing.Size(174, 35);
            this.ConvidadoAdminClose.TabIndex = 15;
            this.ConvidadoAdminClose.Text = "Fechar";
            this.ConvidadoAdminClose.UseVisualStyleBackColor = true;
            this.ConvidadoAdminClose.Click += new System.EventHandler(this.ConvidadoAdminClose_Click);
            // 
            // ConvidadoAdminAddMember
            // 
            this.ConvidadoAdminAddMember.Location = new System.Drawing.Point(740, 258);
            this.ConvidadoAdminAddMember.Margin = new System.Windows.Forms.Padding(6);
            this.ConvidadoAdminAddMember.Name = "ConvidadoAdminAddMember";
            this.ConvidadoAdminAddMember.Size = new System.Drawing.Size(207, 35);
            this.ConvidadoAdminAddMember.TabIndex = 14;
            this.ConvidadoAdminAddMember.Text = "Adicionar Convidado";
            this.ConvidadoAdminAddMember.UseVisualStyleBackColor = true;
            this.ConvidadoAdminAddMember.Click += new System.EventHandler(this.ConvidadoAdminAddMember_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.OutraIgreja,
            this.QuemConvidou,
            this.Cidade,
            this.celularDataGridViewTextBoxColumn,
            this.operadoraDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.convidadosBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 305);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1127, 382);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConvidadoAdminDataGridView_CellContentDoubleClick);
            // 
            // membrosBindingSource
            // 
            this.membrosBindingSource.DataMember = "Membros";
            this.membrosBindingSource.DataSource = this.gerenciaCelulasDataSet;
            // 
            // gerenciaCelulasDataSet
            // 
            this.gerenciaCelulasDataSet.DataSetName = "GerenciaCelulasDataSet";
            this.gerenciaCelulasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membrosTableAdapter
            // 
            this.membrosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista de Convidados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filtros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Igreja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Distrito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rede";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Área";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Setor";
            // 
            // igrejaComboBox
            // 
            this.igrejaComboBox.DataSource = this.igrejasBindingSource;
            this.igrejaComboBox.DisplayMember = "Nome";
            this.igrejaComboBox.FormattingEnabled = true;
            this.igrejaComboBox.Location = new System.Drawing.Point(79, 82);
            this.igrejaComboBox.Name = "igrejaComboBox";
            this.igrejaComboBox.Size = new System.Drawing.Size(335, 32);
            this.igrejaComboBox.TabIndex = 1;
            this.igrejaComboBox.ValueMember = "Nome";
            this.igrejaComboBox.SelectedValueChanged += new System.EventHandler(this.igrejaComboBox_SelectedValueChanged);
            // 
            // igrejasBindingSource
            // 
            this.igrejasBindingSource.DataMember = "Igrejas";
            this.igrejasBindingSource.DataSource = this.gerenciaCelulasDataSet;
            // 
            // redeComboBox
            // 
            this.redeComboBox.DataSource = this.redesBindingSource;
            this.redeComboBox.DisplayMember = "Nome";
            this.redeComboBox.FormattingEnabled = true;
            this.redeComboBox.Location = new System.Drawing.Point(79, 120);
            this.redeComboBox.Name = "redeComboBox";
            this.redeComboBox.Size = new System.Drawing.Size(335, 32);
            this.redeComboBox.TabIndex = 2;
            this.redeComboBox.ValueMember = "Codigo";
            this.redeComboBox.SelectedValueChanged += new System.EventHandler(this.redeComboBox_SelectedValueChanged);
            // 
            // redesBindingSource
            // 
            this.redesBindingSource.DataMember = "Redes";
            this.redesBindingSource.DataSource = this.gerenciaCelulasDataSet;
            // 
            // distritoComboBox
            // 
            this.distritoComboBox.DataSource = this.distritosBindingSource;
            this.distritoComboBox.DisplayMember = "Nome";
            this.distritoComboBox.FormattingEnabled = true;
            this.distritoComboBox.Location = new System.Drawing.Point(79, 155);
            this.distritoComboBox.Name = "distritoComboBox";
            this.distritoComboBox.Size = new System.Drawing.Size(335, 32);
            this.distritoComboBox.TabIndex = 3;
            this.distritoComboBox.ValueMember = "Codigo";
            this.distritoComboBox.SelectedValueChanged += new System.EventHandler(this.distritoComboBox_SelectedValueChanged);
            // 
            // distritosBindingSource
            // 
            this.distritosBindingSource.DataMember = "Distritos";
            this.distritosBindingSource.DataSource = this.gerenciaCelulasDataSet;
            // 
            // areaComboBox
            // 
            this.areaComboBox.DataSource = this.areasBindingSource;
            this.areaComboBox.DisplayMember = "Nome";
            this.areaComboBox.FormattingEnabled = true;
            this.areaComboBox.Location = new System.Drawing.Point(79, 194);
            this.areaComboBox.Name = "areaComboBox";
            this.areaComboBox.Size = new System.Drawing.Size(335, 32);
            this.areaComboBox.TabIndex = 4;
            this.areaComboBox.ValueMember = "Codigo";
            this.areaComboBox.SelectedValueChanged += new System.EventHandler(this.areaComboBox_SelectedValueChanged);
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataMember = "Areas";
            this.areasBindingSource.DataSource = this.gerenciaCelulasDataSet;
            // 
            // setorComboBox
            // 
            this.setorComboBox.DataSource = this.setoresBindingSource;
            this.setorComboBox.DisplayMember = "Nome";
            this.setorComboBox.FormattingEnabled = true;
            this.setorComboBox.Location = new System.Drawing.Point(79, 232);
            this.setorComboBox.Name = "setorComboBox";
            this.setorComboBox.Size = new System.Drawing.Size(335, 32);
            this.setorComboBox.TabIndex = 5;
            this.setorComboBox.ValueMember = "Codigo";
            this.setorComboBox.SelectedValueChanged += new System.EventHandler(this.setorComboBox_SelectedValueChanged);
            // 
            // setoresBindingSource
            // 
            this.setoresBindingSource.DataMember = "Setores";
            this.setoresBindingSource.DataSource = this.gerenciaCelulasDataSet;
            // 
            // celulasBindingSource
            // 
            this.celulasBindingSource.DataMember = "Celulas";
            this.celulasBindingSource.DataSource = this.gerenciaCelulasDataSet;
            // 
            // igrejasTableAdapter
            // 
            this.igrejasTableAdapter.ClearBeforeFill = true;
            // 
            // redesTableAdapter
            // 
            this.redesTableAdapter.ClearBeforeFill = true;
            // 
            // setorCheckBox
            // 
            this.setorCheckBox.AutoSize = true;
            this.setorCheckBox.Checked = true;
            this.setorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.setorCheckBox.Location = new System.Drawing.Point(420, 241);
            this.setorCheckBox.Name = "setorCheckBox";
            this.setorCheckBox.Size = new System.Drawing.Size(15, 14);
            this.setorCheckBox.TabIndex = 42;
            this.setorCheckBox.UseVisualStyleBackColor = true;
            this.setorCheckBox.CheckedChanged += new System.EventHandler(this.setorCheckBox_CheckedChanged);
            // 
            // areaCheckBox
            // 
            this.areaCheckBox.AutoSize = true;
            this.areaCheckBox.Checked = true;
            this.areaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.areaCheckBox.Location = new System.Drawing.Point(420, 203);
            this.areaCheckBox.Name = "areaCheckBox";
            this.areaCheckBox.Size = new System.Drawing.Size(15, 14);
            this.areaCheckBox.TabIndex = 41;
            this.areaCheckBox.UseVisualStyleBackColor = true;
            this.areaCheckBox.CheckedChanged += new System.EventHandler(this.areaCheckBox_CheckedChanged);
            // 
            // distritoCheckBox
            // 
            this.distritoCheckBox.AutoSize = true;
            this.distritoCheckBox.Checked = true;
            this.distritoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.distritoCheckBox.Location = new System.Drawing.Point(420, 164);
            this.distritoCheckBox.Name = "distritoCheckBox";
            this.distritoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.distritoCheckBox.TabIndex = 40;
            this.distritoCheckBox.UseVisualStyleBackColor = true;
            this.distritoCheckBox.CheckedChanged += new System.EventHandler(this.distritoCheckBox_CheckedChanged);
            // 
            // redeCheckBox
            // 
            this.redeCheckBox.AutoSize = true;
            this.redeCheckBox.Checked = true;
            this.redeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redeCheckBox.Location = new System.Drawing.Point(420, 129);
            this.redeCheckBox.Name = "redeCheckBox";
            this.redeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.redeCheckBox.TabIndex = 39;
            this.redeCheckBox.UseVisualStyleBackColor = true;
            this.redeCheckBox.CheckedChanged += new System.EventHandler(this.redeCheckBox_CheckedChanged);
            // 
            // distritosTableAdapter
            // 
            this.distritosTableAdapter.ClearBeforeFill = true;
            // 
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // setoresTableAdapter
            // 
            this.setoresTableAdapter.ClearBeforeFill = true;
            // 
            // celulasTableAdapter
            // 
            this.celulasTableAdapter.ClearBeforeFill = true;
            // 
            // semCelCheckBox
            // 
            this.semCelCheckBox.AutoSize = true;
            this.semCelCheckBox.Location = new System.Drawing.Point(496, 163);
            this.semCelCheckBox.Name = "semCelCheckBox";
            this.semCelCheckBox.Size = new System.Drawing.Size(196, 28);
            this.semCelCheckBox.TabIndex = 11;
            this.semCelCheckBox.Text = "Não Encaminhados";
            this.semCelCheckBox.UseVisualStyleBackColor = true;
            // 
            // semDiscCheckBox
            // 
            this.semDiscCheckBox.AutoSize = true;
            this.semDiscCheckBox.Location = new System.Drawing.Point(496, 129);
            this.semDiscCheckBox.Name = "semDiscCheckBox";
            this.semDiscCheckBox.Size = new System.Drawing.Size(156, 28);
            this.semDiscCheckBox.TabIndex = 10;
            this.semDiscCheckBox.Text = "Encaminhados";
            this.semDiscCheckBox.UseVisualStyleBackColor = true;
            // 
            // convidadosBindingSource
            // 
            this.convidadosBindingSource.DataMember = "Convidados";
            this.convidadosBindingSource.DataSource = this.gerenciaCelulasDataSet;
            // 
            // convidadosTableAdapter
            // 
            this.convidadosTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 90;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 250;
            // 
            // OutraIgreja
            // 
            this.OutraIgreja.DataPropertyName = "OutraIgreja";
            this.OutraIgreja.HeaderText = "OutraIgreja";
            this.OutraIgreja.Name = "OutraIgreja";
            this.OutraIgreja.ReadOnly = true;
            this.OutraIgreja.Width = 200;
            // 
            // QuemConvidou
            // 
            this.QuemConvidou.DataPropertyName = "QuemConvidou";
            this.QuemConvidou.HeaderText = "QuemConvidou";
            this.QuemConvidou.Name = "QuemConvidou";
            this.QuemConvidou.ReadOnly = true;
            this.QuemConvidou.Width = 200;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Width = 200;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularDataGridViewTextBoxColumn.Width = 150;
            // 
            // operadoraDataGridViewTextBoxColumn
            // 
            this.operadoraDataGridViewTextBoxColumn.DataPropertyName = "Operadora";
            this.operadoraDataGridViewTextBoxColumn.HeaderText = "Operadora";
            this.operadoraDataGridViewTextBoxColumn.Name = "operadoraDataGridViewTextBoxColumn";
            this.operadoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 250;
            // 
            // ConvidadoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciamentoCelulas.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1127, 687);
            this.Controls.Add(this.setorCheckBox);
            this.Controls.Add(this.areaCheckBox);
            this.Controls.Add(this.distritoCheckBox);
            this.Controls.Add(this.redeCheckBox);
            this.Controls.Add(this.semDiscCheckBox);
            this.Controls.Add(this.semCelCheckBox);
            this.Controls.Add(this.setorComboBox);
            this.Controls.Add(this.areaComboBox);
            this.Controls.Add(this.distritoComboBox);
            this.Controls.Add(this.redeComboBox);
            this.Controls.Add(this.igrejaComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ConvidadoAdminClose);
            this.Controls.Add(this.ConvidadoAdminAddMember);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ConvidadoAdmin";
            this.Text = "Administração de Convidados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConvidadoAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenciaCelulasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celulasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convidadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvidadoAdminClose;
        private System.Windows.Forms.Button ConvidadoAdminAddMember;
        private System.Windows.Forms.DataGridView dataGridView;
        private GerenciaCelulasDataSet gerenciaCelulasDataSet;
        private System.Windows.Forms.BindingSource membrosBindingSource;
        private GerenciaCelulasDataSetTableAdapters.MembrosTableAdapter membrosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox igrejaComboBox;
        private System.Windows.Forms.ComboBox redeComboBox;
        private System.Windows.Forms.ComboBox distritoComboBox;
        private System.Windows.Forms.ComboBox areaComboBox;
        private System.Windows.Forms.ComboBox setorComboBox;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private GerenciaCelulasDataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.BindingSource redesBindingSource;
        private GerenciaCelulasDataSetTableAdapters.RedesTableAdapter redesTableAdapter;
        private System.Windows.Forms.CheckBox setorCheckBox;
        private System.Windows.Forms.CheckBox areaCheckBox;
        private System.Windows.Forms.CheckBox distritoCheckBox;
        private System.Windows.Forms.CheckBox redeCheckBox;
        private System.Windows.Forms.BindingSource distritosBindingSource;
        private GerenciaCelulasDataSetTableAdapters.DistritosTableAdapter distritosTableAdapter;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private GerenciaCelulasDataSetTableAdapters.AreasTableAdapter areasTableAdapter;
        private System.Windows.Forms.BindingSource setoresBindingSource;
        private GerenciaCelulasDataSetTableAdapters.SetoresTableAdapter setoresTableAdapter;
        private System.Windows.Forms.BindingSource celulasBindingSource;
        private GerenciaCelulasDataSetTableAdapters.CelulasTableAdapter celulasTableAdapter;
        private System.Windows.Forms.CheckBox semCelCheckBox;
        private System.Windows.Forms.CheckBox semDiscCheckBox;
        private System.Windows.Forms.BindingSource convidadosBindingSource;
        private GerenciaCelulasDataSetTableAdapters.ConvidadosTableAdapter convidadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutraIgreja;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuemConvidou;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operadoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}