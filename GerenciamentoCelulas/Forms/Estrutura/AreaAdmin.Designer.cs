namespace GerenciamentoCelulas.Forms.Estrutura

{
    partial class AreaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaAdmin));
            this.closeButton = new System.Windows.Forms.Button();
            this.addAreaButton = new System.Windows.Forms.Button();
            this.editAreaButton = new System.Windows.Forms.Button();
            this.deactivateAreaButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeRespDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igrejaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distritoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont10DataSet = new GerenciamentoCelulas.Igrejafont10DataSet();
            this.areasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.setoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distritosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.redesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejasTableAdapter1 = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.IgrejasTableAdapter();
            this.redesTableAdapter1 = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.RedesTableAdapter();
            this.distritosTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.DistritosTableAdapter();
            this.areasTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.AreasTableAdapter();
            this.areasTableAdapter1 = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.Areas1TableAdapter();
            this.setoresTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.SetoresTableAdapter();
            this.codTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchMemberButton = new System.Windows.Forms.Button();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.respTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.distritoCheckBox = new System.Windows.Forms.CheckBox();
            this.redeCheckBox = new System.Windows.Forms.CheckBox();
            this.distritoComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.redeComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.igrejaComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cleanButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cellMembersLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(556, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(174, 35);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Fechar";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.RedeWindowClose_Click);
            // 
            // addAreaButton
            // 
            this.addAreaButton.Location = new System.Drawing.Point(12, 12);
            this.addAreaButton.Name = "addAreaButton";
            this.addAreaButton.Size = new System.Drawing.Size(174, 35);
            this.addAreaButton.TabIndex = 1;
            this.addAreaButton.Text = "Adicionar Área";
            this.addAreaButton.UseVisualStyleBackColor = true;
            this.addAreaButton.Click += new System.EventHandler(this.RedeWindowAddRede_Click);
            // 
            // editAreaButton
            // 
            this.editAreaButton.Location = new System.Drawing.Point(192, 12);
            this.editAreaButton.Name = "editAreaButton";
            this.editAreaButton.Size = new System.Drawing.Size(174, 35);
            this.editAreaButton.TabIndex = 2;
            this.editAreaButton.Text = "Alterar Área";
            this.editAreaButton.UseVisualStyleBackColor = true;
            this.editAreaButton.Click += new System.EventHandler(this.RedeWindowEditRede_Click);
            // 
            // deactivateAreaButton
            // 
            this.deactivateAreaButton.Location = new System.Drawing.Point(375, 12);
            this.deactivateAreaButton.Name = "deactivateAreaButton";
            this.deactivateAreaButton.Size = new System.Drawing.Size(174, 35);
            this.deactivateAreaButton.TabIndex = 3;
            this.deactivateAreaButton.Text = "Desativar Área";
            this.deactivateAreaButton.UseVisualStyleBackColor = true;
            this.deactivateAreaButton.Click += new System.EventHandler(this.RedeWindowDeactivateRede_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nomeRespDataGridViewTextBoxColumn,
            this.igrejaDataGridViewTextBoxColumn,
            this.redeDataGridViewTextBoxColumn,
            this.distritoDataGridViewTextBoxColumn,
            this.responsavelDataGridViewTextBoxColumn,
            this.foneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn,
            this.metaDataGridViewTextBoxColumn,
            this.ativaDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.areasBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.Location = new System.Drawing.Point(0, 351);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1311, 382);
            this.dataGridView.TabIndex = 20;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RedeWindowDataGridView_CellClick);
            this.dataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEnter);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // nomeRespDataGridViewTextBoxColumn
            // 
            this.nomeRespDataGridViewTextBoxColumn.DataPropertyName = "NomeResp";
            this.nomeRespDataGridViewTextBoxColumn.HeaderText = "Responsável";
            this.nomeRespDataGridViewTextBoxColumn.Name = "nomeRespDataGridViewTextBoxColumn";
            this.nomeRespDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeRespDataGridViewTextBoxColumn.Width = 300;
            // 
            // igrejaDataGridViewTextBoxColumn
            // 
            this.igrejaDataGridViewTextBoxColumn.DataPropertyName = "Igreja";
            this.igrejaDataGridViewTextBoxColumn.HeaderText = "Igreja";
            this.igrejaDataGridViewTextBoxColumn.Name = "igrejaDataGridViewTextBoxColumn";
            this.igrejaDataGridViewTextBoxColumn.ReadOnly = true;
            this.igrejaDataGridViewTextBoxColumn.Width = 200;
            // 
            // redeDataGridViewTextBoxColumn
            // 
            this.redeDataGridViewTextBoxColumn.DataPropertyName = "Rede";
            this.redeDataGridViewTextBoxColumn.HeaderText = "Rede";
            this.redeDataGridViewTextBoxColumn.Name = "redeDataGridViewTextBoxColumn";
            this.redeDataGridViewTextBoxColumn.ReadOnly = true;
            this.redeDataGridViewTextBoxColumn.Visible = false;
            // 
            // distritoDataGridViewTextBoxColumn
            // 
            this.distritoDataGridViewTextBoxColumn.DataPropertyName = "Distrito";
            this.distritoDataGridViewTextBoxColumn.HeaderText = "Distrito";
            this.distritoDataGridViewTextBoxColumn.Name = "distritoDataGridViewTextBoxColumn";
            this.distritoDataGridViewTextBoxColumn.ReadOnly = true;
            this.distritoDataGridViewTextBoxColumn.Visible = false;
            // 
            // responsavelDataGridViewTextBoxColumn
            // 
            this.responsavelDataGridViewTextBoxColumn.DataPropertyName = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn.HeaderText = "Responsavel";
            this.responsavelDataGridViewTextBoxColumn.Name = "responsavelDataGridViewTextBoxColumn";
            this.responsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.responsavelDataGridViewTextBoxColumn.Visible = false;
            // 
            // foneDataGridViewTextBoxColumn
            // 
            this.foneDataGridViewTextBoxColumn.DataPropertyName = "Fone";
            this.foneDataGridViewTextBoxColumn.HeaderText = "Fone";
            this.foneDataGridViewTextBoxColumn.Name = "foneDataGridViewTextBoxColumn";
            this.foneDataGridViewTextBoxColumn.ReadOnly = true;
            this.foneDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            this.obsDataGridViewTextBoxColumn.DataPropertyName = "Obs";
            this.obsDataGridViewTextBoxColumn.HeaderText = "Obs";
            this.obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            this.obsDataGridViewTextBoxColumn.ReadOnly = true;
            this.obsDataGridViewTextBoxColumn.Width = 300;
            // 
            // metaDataGridViewTextBoxColumn
            // 
            this.metaDataGridViewTextBoxColumn.DataPropertyName = "Meta";
            this.metaDataGridViewTextBoxColumn.HeaderText = "Meta";
            this.metaDataGridViewTextBoxColumn.Name = "metaDataGridViewTextBoxColumn";
            this.metaDataGridViewTextBoxColumn.ReadOnly = true;
            this.metaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ativaDataGridViewTextBoxColumn
            // 
            this.ativaDataGridViewTextBoxColumn.DataPropertyName = "Ativa";
            this.ativaDataGridViewTextBoxColumn.HeaderText = "Ativa";
            this.ativaDataGridViewTextBoxColumn.Name = "ativaDataGridViewTextBoxColumn";
            this.ativaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ativaDataGridViewTextBoxColumn.Visible = false;
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataMember = "Areas";
            this.areasBindingSource.DataSource = this.igrejafont10DataSet;
            this.setoresBindingSource.DataMember = "Setores";
            this.setoresBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // igrejafont10DataSet
            // 
            this.igrejafont10DataSet.DataSetName = "Igrejafont10DataSet";
            this.igrejafont10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // areasBindingSource1
            // 
            this.areasBindingSource1.DataMember = "Areas1";
            this.areasBindingSource1.DataSource = this.igrejafont10DataSet;
            // 
            // distritosBindingSource
            // 
            this.distritosBindingSource.DataMember = "Distritos";
            this.distritosBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // igrejasBindingSource
            // 
            this.igrejasBindingSource.DataMember = "Igrejas";
            this.igrejasBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // redesBindingSource
            // 
            this.redesBindingSource.DataMember = "Redes";
            this.redesBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // igrejasTableAdapter1
            // 
            this.igrejasTableAdapter1.ClearBeforeFill = true;
            // 
            // redesTableAdapter1
            // 
            this.redesTableAdapter1.ClearBeforeFill = true;
            this.setoresTableAdapter.ClearBeforeFill = true;
            // 
            // distritosTableAdapter
            // 
            this.distritosTableAdapter.ClearBeforeFill = true;
            // 
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // areasTableAdapter1
            // 
            this.areasTableAdapter1.ClearBeforeFill = true;
            // 
            // codTextBox
            // 
            this.codTextBox.Location = new System.Drawing.Point(447, 133);
            this.codTextBox.Name = "codTextBox";
            this.codTextBox.Size = new System.Drawing.Size(76, 29);
            this.codTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 56;
            this.label7.Text = "Código";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(591, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(275, 29);
            this.nameTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Nome";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(447, 57);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(76, 29);
            this.codeTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Código";
            // 
            // searchMemberButton
            // 
            this.searchMemberButton.Location = new System.Drawing.Point(375, 92);
            this.searchMemberButton.Name = "searchMemberButton";
            this.searchMemberButton.Size = new System.Drawing.Size(276, 35);
            this.searchMemberButton.TabIndex = 12;
            this.searchMemberButton.Text = "Buscar Membro Responsável";
            this.searchMemberButton.UseVisualStyleBackColor = true;
            this.searchMemberButton.Click += new System.EventHandler(this.searchMemberButton_Click);
            // 
            // obsTextBox
            // 
            this.obsTextBox.Location = new System.Drawing.Point(380, 229);
            this.obsTextBox.Multiline = true;
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(915, 32);
            this.obsTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 24);
            this.label8.TabIndex = 65;
            this.label8.Text = "Obs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(795, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 64;
            this.label6.Text = "Email";
            // 
            // foneTextBox
            // 
            this.foneTextBox.Location = new System.Drawing.Point(466, 168);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(314, 29);
            this.foneTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 63;
            this.label5.Text = "Telefone";
            // 
            // respTextBox
            // 
            this.respTextBox.Location = new System.Drawing.Point(654, 133);
            this.respTextBox.Name = "respTextBox";
            this.respTextBox.Size = new System.Drawing.Size(532, 29);
            this.respTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 60;
            this.label4.Text = "Responsável";
            // 
            // distritoCheckBox
            // 
            this.distritoCheckBox.AutoSize = true;
            this.distritoCheckBox.Checked = true;
            this.distritoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.distritoCheckBox.Location = new System.Drawing.Point(331, 163);
            this.distritoCheckBox.Name = "distritoCheckBox";
            this.distritoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.distritoCheckBox.TabIndex = 9;
            this.distritoCheckBox.UseVisualStyleBackColor = true;
            this.distritoCheckBox.CheckedChanged += new System.EventHandler(this.distritoCheckBox_CheckedChanged);
            // 
            // redeCheckBox
            // 
            this.redeCheckBox.AutoSize = true;
            this.redeCheckBox.Checked = true;
            this.redeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redeCheckBox.Location = new System.Drawing.Point(331, 123);
            this.redeCheckBox.Name = "redeCheckBox";
            this.redeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.redeCheckBox.TabIndex = 7;
            this.redeCheckBox.UseVisualStyleBackColor = true;
            this.redeCheckBox.CheckedChanged += new System.EventHandler(this.redeCheckBox_CheckedChanged);
            this.redeCheckBox.CheckStateChanged += new System.EventHandler(this.distritoCheckBox_CheckedChanged);
            // 
            // distritoComboBox
            // 
            this.distritoComboBox.DataSource = this.distritosBindingSource;
            this.distritoComboBox.DisplayMember = "Nome";
            this.distritoComboBox.FormattingEnabled = true;
            this.distritoComboBox.Location = new System.Drawing.Point(70, 154);
            this.distritoComboBox.Name = "distritoComboBox";
            this.distritoComboBox.Size = new System.Drawing.Size(255, 32);
            this.distritoComboBox.TabIndex = 8;
            this.distritoComboBox.ValueMember = "Codigo";
            this.distritoComboBox.SelectedValueChanged += new System.EventHandler(this.distritoComboBox_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 24);
            this.label11.TabIndex = 71;
            this.label11.Text = "Distrito";
            // 
            // redeComboBox
            // 
            this.redeComboBox.DataSource = this.redesBindingSource;
            this.redeComboBox.DisplayMember = "Nome";
            this.redeComboBox.FormattingEnabled = true;
            this.redeComboBox.Location = new System.Drawing.Point(70, 114);
            this.redeComboBox.Name = "redeComboBox";
            this.redeComboBox.Size = new System.Drawing.Size(255, 32);
            this.redeComboBox.TabIndex = 6;
            this.redeComboBox.ValueMember = "Codigo";
            this.redeComboBox.SelectedValueChanged += new System.EventHandler(this.redeComboBox_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 24);
            this.label12.TabIndex = 69;
            this.label12.Text = "Rede";
            // 
            // igrejaComboBox
            // 
            this.igrejaComboBox.DataSource = this.igrejasBindingSource;
            this.igrejaComboBox.DisplayMember = "Nome";
            this.igrejaComboBox.FormattingEnabled = true;
            this.igrejaComboBox.Location = new System.Drawing.Point(70, 74);
            this.igrejaComboBox.Name = "igrejaComboBox";
            this.igrejaComboBox.Size = new System.Drawing.Size(255, 32);
            this.igrejaComboBox.TabIndex = 5;
            this.igrejaComboBox.ValueMember = "Nome";
            this.igrejaComboBox.SelectedValueChanged += new System.EventHandler(this.igrejaComboBox_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 24);
            this.label13.TabIndex = 67;
            this.label13.Text = "Igreja";
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(872, 267);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(153, 32);
            this.cleanButton.TabIndex = 19;
            this.cleanButton.Text = "Limpar";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.RedesAdminCleanButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(713, 267);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(153, 32);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Salvar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.RedesAdminSaveButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(858, 168);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(432, 29);
            this.emailTextBox.TabIndex = 16;
            // 
            // cellMembersLabel
            // 
            this.cellMembersLabel.AutoSize = true;
            this.cellMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellMembersLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cellMembersLabel.Location = new System.Drawing.Point(1186, 9);
            this.cellMembersLabel.Name = "cellMembersLabel";
            this.cellMembersLabel.Size = new System.Drawing.Size(24, 26);
            this.cellMembersLabel.TabIndex = 77;
            this.cellMembersLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(957, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 26);
            this.label15.TabIndex = 76;
            this.label15.Text = "Número de Áreas:";
            // 
            // AreaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1311, 733);
            this.Controls.Add(this.cellMembersLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.distritoCheckBox);
            this.Controls.Add(this.redeCheckBox);
            this.Controls.Add(this.distritoComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.redeComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.igrejaComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.searchMemberButton);
            this.Controls.Add(this.obsTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.respTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.codTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.deactivateAreaButton);
            this.Controls.Add(this.editAreaButton);
            this.Controls.Add(this.addAreaButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AreaAdmin";
            this.Text = "Administrar Áreas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RedesAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addAreaButton;
        private System.Windows.Forms.Button editAreaButton;
        private System.Windows.Forms.Button deactivateAreaButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private Igrejafont10DataSet igrejafont10DataSet;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private Igrejafont10DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter1;
        private System.Windows.Forms.BindingSource redesBindingSource;
        private Igrejafont10DataSetTableAdapters.RedesTableAdapter redesTableAdapter1;
        private System.Windows.Forms.BindingSource distritosBindingSource;
        private Igrejafont10DataSetTableAdapters.DistritosTableAdapter distritosTableAdapter;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private System.Windows.Forms.BindingSource areasBindingSource1;
        private Igrejafont10DataSetTableAdapters.AreasTableAdapter areasTableAdapter;
        private Igrejafont10DataSetTableAdapters.Areas1TableAdapter areasTableAdapter1;
        private System.Windows.Forms.BindingSource setoresBindingSource;
        private Igrejafont10DataSetTableAdapters.SetoresTableAdapter setoresTableAdapter;
        private System.Windows.Forms.TextBox codTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchMemberButton;
        private System.Windows.Forms.TextBox obsTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox respTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox distritoCheckBox;
        private System.Windows.Forms.CheckBox redeCheckBox;
        private System.Windows.Forms.ComboBox distritoComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox redeComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox igrejaComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label cellMembersLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeRespDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igrejaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn redeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distritoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativaDataGridViewTextBoxColumn;
    }
}