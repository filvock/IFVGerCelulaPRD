namespace GerenciamentoCelulas.Forms.Celula
{
    partial class CelulaMembrosAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CelulaMembrosAdmin));
            this.closeButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.membrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont10DataSet = new GerenciamentoCelulas.Igrejafont10DataSet();
            this.celulasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distritosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.respTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.codTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.igrejaComboBox = new System.Windows.Forms.ComboBox();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchMemberButton = new System.Windows.Forms.Button();
            this.redeComboBox = new System.Windows.Forms.ComboBox();
            this.redesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.igrejasTableAdapter1 = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.IgrejasTableAdapter();
            this.redesTableAdapter1 = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.RedesTableAdapter();
            this.distritosTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.DistritosTableAdapter();
            this.distritoComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.areasTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.AreasTableAdapter();
            this.areaComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.setoresTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.SetoresTableAdapter();
            this.setorComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.celulasTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.CelulasTableAdapter();
            this.celulaComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.membrosTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.MembrosTableAdapter();
            this.redeCheckBox = new System.Windows.Forms.CheckBox();
            this.distritoCheckBox = new System.Windows.Forms.CheckBox();
            this.areaCheckBox = new System.Windows.Forms.CheckBox();
            this.setorCheckBox = new System.Windows.Forms.CheckBox();
            this.celulaCheckBox = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cellMembersLabel = new System.Windows.Forms.Label();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celulasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(744, 252);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(174, 35);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Fechar";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.RedeWindowClose_Click);
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
            this.CelName,
            this.Celular,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.membrosBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.Location = new System.Drawing.Point(0, 351);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1354, 382);
            this.dataGridView.TabIndex = 14;
            // 
            // membrosBindingSource
            // 
            this.membrosBindingSource.DataMember = "Membros";
            this.membrosBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // igrejafont10DataSet
            // 
            this.igrejafont10DataSet.DataSetName = "Igrejafont10DataSet";
            this.igrejafont10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // celulasBindingSource
            // 
            this.celulasBindingSource.DataMember = "Celulas";
            this.celulasBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // setoresBindingSource
            // 
            this.setoresBindingSource.DataMember = "Setores";
            this.setoresBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataMember = "Areas";
            this.areasBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // distritosBindingSource
            // 
            this.distritosBindingSource.DataMember = "Distritos";
            this.distritosBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(465, 54);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 29);
            this.codeTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(700, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(206, 29);
            this.nameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Igreja";
            // 
            // respTextBox
            // 
            this.respTextBox.Location = new System.Drawing.Point(700, 102);
            this.respTextBox.Name = "respTextBox";
            this.respTextBox.Size = new System.Drawing.Size(302, 29);
            this.respTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Responsável";
            // 
            // foneTextBox
            // 
            this.foneTextBox.Location = new System.Drawing.Point(465, 144);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(168, 29);
            this.foneTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefone";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(702, 144);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(355, 29);
            this.emailTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // codTextBox
            // 
            this.codTextBox.Location = new System.Drawing.Point(465, 102);
            this.codTextBox.Name = "codTextBox";
            this.codTextBox.Size = new System.Drawing.Size(100, 29);
            this.codTextBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Código";
            // 
            // obsTextBox
            // 
            this.obsTextBox.Location = new System.Drawing.Point(378, 217);
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(679, 29);
            this.obsTextBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Obs";
            // 
            // igrejaComboBox
            // 
            this.igrejaComboBox.DataSource = this.igrejasBindingSource;
            this.igrejaComboBox.DisplayMember = "Nome";
            this.igrejaComboBox.FormattingEnabled = true;
            this.igrejaComboBox.Location = new System.Drawing.Point(74, 59);
            this.igrejaComboBox.Name = "igrejaComboBox";
            this.igrejaComboBox.Size = new System.Drawing.Size(267, 32);
            this.igrejaComboBox.TabIndex = 5;
            this.igrejaComboBox.ValueMember = "Nome";
            this.igrejaComboBox.SelectedValueChanged += new System.EventHandler(this.igrejaComboBox_SelectedValueChanged);
            // 
            // igrejasBindingSource
            // 
            this.igrejasBindingSource.DataMember = "Igrejas";
            this.igrejasBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // searchMemberButton
            // 
            this.searchMemberButton.Location = new System.Drawing.Point(478, 253);
            this.searchMemberButton.Name = "searchMemberButton";
            this.searchMemberButton.Size = new System.Drawing.Size(260, 35);
            this.searchMemberButton.TabIndex = 9;
            this.searchMemberButton.Text = "Adicionar Membro na Célula";
            this.searchMemberButton.UseVisualStyleBackColor = true;
            this.searchMemberButton.Click += new System.EventHandler(this.RedeWindowSearchMember_Click);
            // 
            // redeComboBox
            // 
            this.redeComboBox.DataSource = this.redesBindingSource;
            this.redeComboBox.DisplayMember = "Nome";
            this.redeComboBox.Enabled = false;
            this.redeComboBox.FormattingEnabled = true;
            this.redeComboBox.Location = new System.Drawing.Point(74, 99);
            this.redeComboBox.Name = "redeComboBox";
            this.redeComboBox.Size = new System.Drawing.Size(267, 32);
            this.redeComboBox.TabIndex = 23;
            this.redeComboBox.ValueMember = "Codigo";
            this.redeComboBox.SelectedValueChanged += new System.EventHandler(this.redeComboBox_SelectedValueChanged);
            // 
            // redesBindingSource
            // 
            this.redesBindingSource.DataMember = "Redes";
            this.redesBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Rede";
            // 
            // igrejasTableAdapter1
            // 
            this.igrejasTableAdapter1.ClearBeforeFill = true;
            // 
            // redesTableAdapter1
            // 
            this.redesTableAdapter1.ClearBeforeFill = true;
            // 
            // distritosTableAdapter
            // 
            this.distritosTableAdapter.ClearBeforeFill = true;
            // 
            // distritoComboBox
            // 
            this.distritoComboBox.DataSource = this.distritosBindingSource;
            this.distritoComboBox.DisplayMember = "Nome";
            this.distritoComboBox.Enabled = false;
            this.distritoComboBox.FormattingEnabled = true;
            this.distritoComboBox.Location = new System.Drawing.Point(74, 139);
            this.distritoComboBox.Name = "distritoComboBox";
            this.distritoComboBox.Size = new System.Drawing.Size(267, 32);
            this.distritoComboBox.TabIndex = 25;
            this.distritoComboBox.ValueMember = "Codigo";
            this.distritoComboBox.SelectedValueChanged += new System.EventHandler(this.distritoComboBox_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Distrito";
            // 
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // areaComboBox
            // 
            this.areaComboBox.DataSource = this.areasBindingSource;
            this.areaComboBox.DisplayMember = "Nome";
            this.areaComboBox.Enabled = false;
            this.areaComboBox.FormattingEnabled = true;
            this.areaComboBox.Location = new System.Drawing.Point(74, 179);
            this.areaComboBox.Name = "areaComboBox";
            this.areaComboBox.Size = new System.Drawing.Size(267, 32);
            this.areaComboBox.TabIndex = 27;
            this.areaComboBox.ValueMember = "Codigo";
            this.areaComboBox.SelectedValueChanged += new System.EventHandler(this.areaComboBox_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "Area";
            // 
            // setoresTableAdapter
            // 
            this.setoresTableAdapter.ClearBeforeFill = true;
            // 
            // setorComboBox
            // 
            this.setorComboBox.DataSource = this.setoresBindingSource;
            this.setorComboBox.DisplayMember = "Nome";
            this.setorComboBox.Enabled = false;
            this.setorComboBox.FormattingEnabled = true;
            this.setorComboBox.Location = new System.Drawing.Point(74, 219);
            this.setorComboBox.Name = "setorComboBox";
            this.setorComboBox.Size = new System.Drawing.Size(267, 32);
            this.setorComboBox.TabIndex = 29;
            this.setorComboBox.ValueMember = "Codigo";
            this.setorComboBox.SelectedValueChanged += new System.EventHandler(this.setorComboBox_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "Setor";
            // 
            // celulasTableAdapter
            // 
            this.celulasTableAdapter.ClearBeforeFill = true;
            // 
            // celulaComboBox
            // 
            this.celulaComboBox.DataSource = this.celulasBindingSource;
            this.celulaComboBox.DisplayMember = "Nome";
            this.celulaComboBox.Enabled = false;
            this.celulaComboBox.FormattingEnabled = true;
            this.celulaComboBox.Location = new System.Drawing.Point(74, 259);
            this.celulaComboBox.Name = "celulaComboBox";
            this.celulaComboBox.Size = new System.Drawing.Size(267, 32);
            this.celulaComboBox.TabIndex = 31;
            this.celulaComboBox.ValueMember = "Codigo";
            this.celulaComboBox.SelectedValueChanged += new System.EventHandler(this.celulaComboBox_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 264);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 24);
            this.label13.TabIndex = 32;
            this.label13.Text = "Célula";
            // 
            // membrosTableAdapter
            // 
            this.membrosTableAdapter.ClearBeforeFill = true;
            // 
            // redeCheckBox
            // 
            this.redeCheckBox.AutoSize = true;
            this.redeCheckBox.Checked = true;
            this.redeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.redeCheckBox.Location = new System.Drawing.Point(348, 106);
            this.redeCheckBox.Name = "redeCheckBox";
            this.redeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.redeCheckBox.TabIndex = 34;
            this.redeCheckBox.UseVisualStyleBackColor = true;
            this.redeCheckBox.CheckedChanged += new System.EventHandler(this.redeCheckBox_CheckedChanged);
            // 
            // distritoCheckBox
            // 
            this.distritoCheckBox.AutoSize = true;
            this.distritoCheckBox.Checked = true;
            this.distritoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.distritoCheckBox.Location = new System.Drawing.Point(348, 148);
            this.distritoCheckBox.Name = "distritoCheckBox";
            this.distritoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.distritoCheckBox.TabIndex = 35;
            this.distritoCheckBox.UseVisualStyleBackColor = true;
            this.distritoCheckBox.CheckedChanged += new System.EventHandler(this.distritoCheckBox_CheckedChanged);
            // 
            // areaCheckBox
            // 
            this.areaCheckBox.AutoSize = true;
            this.areaCheckBox.Checked = true;
            this.areaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.areaCheckBox.Location = new System.Drawing.Point(348, 188);
            this.areaCheckBox.Name = "areaCheckBox";
            this.areaCheckBox.Size = new System.Drawing.Size(15, 14);
            this.areaCheckBox.TabIndex = 36;
            this.areaCheckBox.UseVisualStyleBackColor = true;
            this.areaCheckBox.CheckedChanged += new System.EventHandler(this.areaCheckBox_CheckedChanged);
            // 
            // setorCheckBox
            // 
            this.setorCheckBox.AutoSize = true;
            this.setorCheckBox.Checked = true;
            this.setorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.setorCheckBox.Location = new System.Drawing.Point(347, 226);
            this.setorCheckBox.Name = "setorCheckBox";
            this.setorCheckBox.Size = new System.Drawing.Size(15, 14);
            this.setorCheckBox.TabIndex = 37;
            this.setorCheckBox.UseVisualStyleBackColor = true;
            this.setorCheckBox.CheckedChanged += new System.EventHandler(this.setorCheckBox_CheckedChanged);
            // 
            // celulaCheckBox
            // 
            this.celulaCheckBox.AutoSize = true;
            this.celulaCheckBox.Checked = true;
            this.celulaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.celulaCheckBox.Location = new System.Drawing.Point(347, 268);
            this.celulaCheckBox.Name = "celulaCheckBox";
            this.celulaCheckBox.Size = new System.Drawing.Size(15, 14);
            this.celulaCheckBox.TabIndex = 38;
            this.celulaCheckBox.UseVisualStyleBackColor = true;
            this.celulaCheckBox.CheckedChanged += new System.EventHandler(this.celulaCheckBox_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(989, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(223, 26);
            this.label15.TabIndex = 42;
            this.label15.Text = "Número de Membros:";
            // 
            // cellMembersLabel
            // 
            this.cellMembersLabel.AutoSize = true;
            this.cellMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellMembersLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cellMembersLabel.Location = new System.Drawing.Point(1218, 9);
            this.cellMembersLabel.Name = "cellMembersLabel";
            this.cellMembersLabel.Size = new System.Drawing.Size(24, 26);
            this.cellMembersLabel.TabIndex = 43;
            this.cellMembersLabel.Text = "0";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // CelName
            // 
            this.CelName.DataPropertyName = "CelName";
            this.CelName.HeaderText = "Célula";
            this.CelName.Name = "CelName";
            this.CelName.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 200;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 300;
            // 
            // CelulaMembrosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.cellMembersLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.celulaCheckBox);
            this.Controls.Add(this.setorCheckBox);
            this.Controls.Add(this.areaCheckBox);
            this.Controls.Add(this.distritoCheckBox);
            this.Controls.Add(this.redeCheckBox);
            this.Controls.Add(this.celulaComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.setorComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.areaComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.distritoComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.redeComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchMemberButton);
            this.Controls.Add(this.igrejaComboBox);
            this.Controls.Add(this.obsTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.codTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.respTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CelulaMembrosAdmin";
            this.Text = "Administração de Células";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RedesAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celulasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distritosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox respTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox codTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox obsTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox igrejaComboBox;
        private System.Windows.Forms.Button searchMemberButton;
        private System.Windows.Forms.ComboBox redeComboBox;
        private System.Windows.Forms.Label label9;
        private Igrejafont10DataSet igrejafont10DataSet;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private Igrejafont10DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter1;
        private System.Windows.Forms.BindingSource redesBindingSource;
        private Igrejafont10DataSetTableAdapters.RedesTableAdapter redesTableAdapter1;
        private System.Windows.Forms.BindingSource distritosBindingSource;
        private Igrejafont10DataSetTableAdapters.DistritosTableAdapter distritosTableAdapter;
        private System.Windows.Forms.ComboBox distritoComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private Igrejafont10DataSetTableAdapters.AreasTableAdapter areasTableAdapter;
        private System.Windows.Forms.ComboBox areaComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource setoresBindingSource;
        private Igrejafont10DataSetTableAdapters.SetoresTableAdapter setoresTableAdapter;
        private System.Windows.Forms.ComboBox setorComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource celulasBindingSource;
        private Igrejafont10DataSetTableAdapters.CelulasTableAdapter celulasTableAdapter;
        private System.Windows.Forms.ComboBox celulaComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource membrosBindingSource;
        private Igrejafont10DataSetTableAdapters.MembrosTableAdapter membrosTableAdapter;
        private System.Windows.Forms.CheckBox redeCheckBox;
        private System.Windows.Forms.CheckBox distritoCheckBox;
        private System.Windows.Forms.CheckBox areaCheckBox;
        private System.Windows.Forms.CheckBox setorCheckBox;
        private System.Windows.Forms.CheckBox celulaCheckBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label cellMembersLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}