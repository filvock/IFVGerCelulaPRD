namespace GerenciamentoCelulas.Forms.Admin
{
    partial class UsersAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usersAdminEditButton = new System.Windows.Forms.Button();
            this.usersAdminAddButton = new System.Windows.Forms.Button();
            this.usersAdminRemoveButton = new System.Windows.Forms.Button();
            this.usersAdminSaveButton = new System.Windows.Forms.Button();
            this.usersAdminCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usersAdminEstadoComboBox = new System.Windows.Forms.ComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont10DataSet = new GerenciamentoCelulas.Igrejafont10DataSet();
            this.usersAdminLoginTextBox = new System.Windows.Forms.TextBox();
            this.usersAdminDataGridView = new System.Windows.Forms.DataGridView();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersAdminCidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.usuariosTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.UsuariosTableAdapter();
            this.usersAdminRoleComboBox = new System.Windows.Forms.ComboBox();
            this.usersAdminSenhaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usersAdminIgrejaComboBox = new System.Windows.Forms.ComboBox();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.igrejasTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.IgrejasTableAdapter();
            this.cidadesTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.CidadesTableAdapter();
            this.estadosTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.EstadosTableAdapter();
            this.cellMembersLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igrejaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersAdminDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usersAdminEditButton
            // 
            this.usersAdminEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminEditButton.Location = new System.Drawing.Point(13, 13);
            this.usersAdminEditButton.Name = "usersAdminEditButton";
            this.usersAdminEditButton.Size = new System.Drawing.Size(145, 42);
            this.usersAdminEditButton.TabIndex = 0;
            this.usersAdminEditButton.Text = "Editar";
            this.usersAdminEditButton.UseVisualStyleBackColor = true;
            this.usersAdminEditButton.Click += new System.EventHandler(this.IgrejasAdminEditButton_Click);
            // 
            // usersAdminAddButton
            // 
            this.usersAdminAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminAddButton.Location = new System.Drawing.Point(164, 13);
            this.usersAdminAddButton.Name = "usersAdminAddButton";
            this.usersAdminAddButton.Size = new System.Drawing.Size(145, 42);
            this.usersAdminAddButton.TabIndex = 1;
            this.usersAdminAddButton.Text = "Adicionar";
            this.usersAdminAddButton.UseVisualStyleBackColor = true;
            this.usersAdminAddButton.Click += new System.EventHandler(this.IgrejasAdminAddButton_Click);
            // 
            // usersAdminRemoveButton
            // 
            this.usersAdminRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminRemoveButton.Location = new System.Drawing.Point(315, 13);
            this.usersAdminRemoveButton.Name = "usersAdminRemoveButton";
            this.usersAdminRemoveButton.Size = new System.Drawing.Size(145, 42);
            this.usersAdminRemoveButton.TabIndex = 2;
            this.usersAdminRemoveButton.Text = "Remover";
            this.usersAdminRemoveButton.UseVisualStyleBackColor = true;
            this.usersAdminRemoveButton.Click += new System.EventHandler(this.IgrejasAdminRemoveButton_Click);
            // 
            // usersAdminSaveButton
            // 
            this.usersAdminSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminSaveButton.Location = new System.Drawing.Point(567, 241);
            this.usersAdminSaveButton.Name = "usersAdminSaveButton";
            this.usersAdminSaveButton.Size = new System.Drawing.Size(145, 42);
            this.usersAdminSaveButton.TabIndex = 9;
            this.usersAdminSaveButton.Text = "Salvar";
            this.usersAdminSaveButton.UseVisualStyleBackColor = true;
            this.usersAdminSaveButton.Click += new System.EventHandler(this.IgrejasAdminSaveButton_Click);
            // 
            // usersAdminCancelButton
            // 
            this.usersAdminCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminCancelButton.Location = new System.Drawing.Point(718, 241);
            this.usersAdminCancelButton.Name = "usersAdminCancelButton";
            this.usersAdminCancelButton.Size = new System.Drawing.Size(145, 42);
            this.usersAdminCancelButton.TabIndex = 10;
            this.usersAdminCancelButton.Text = "Cancel";
            this.usersAdminCancelButton.UseVisualStyleBackColor = true;
            this.usersAdminCancelButton.Click += new System.EventHandler(this.IgrejasAdminCancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estado";
            // 
            // usersAdminEstadoComboBox
            // 
            this.usersAdminEstadoComboBox.DataSource = this.estadosBindingSource;
            this.usersAdminEstadoComboBox.DisplayMember = "Sigla";
            this.usersAdminEstadoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminEstadoComboBox.FormattingEnabled = true;
            this.usersAdminEstadoComboBox.Location = new System.Drawing.Point(455, 175);
            this.usersAdminEstadoComboBox.Name = "usersAdminEstadoComboBox";
            this.usersAdminEstadoComboBox.Size = new System.Drawing.Size(113, 32);
            this.usersAdminEstadoComboBox.TabIndex = 6;
            this.usersAdminEstadoComboBox.ValueMember = "Sigla";
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "Estados";
            this.estadosBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // igrejafont10DataSet
            // 
            this.igrejafont10DataSet.DataSetName = "Igrejafont10DataSet";
            this.igrejafont10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersAdminLoginTextBox
            // 
            this.usersAdminLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminLoginTextBox.Location = new System.Drawing.Point(13, 119);
            this.usersAdminLoginTextBox.Name = "usersAdminLoginTextBox";
            this.usersAdminLoginTextBox.Size = new System.Drawing.Size(432, 29);
            this.usersAdminLoginTextBox.TabIndex = 3;
            // 
            // usersAdminDataGridView
            // 
            this.usersAdminDataGridView.AllowUserToAddRows = false;
            this.usersAdminDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersAdminDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersAdminDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usersAdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersAdminDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.igrejaDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.usersAdminDataGridView.DataSource = this.usuariosBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersAdminDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.usersAdminDataGridView.Location = new System.Drawing.Point(12, 289);
            this.usersAdminDataGridView.Name = "usersAdminDataGridView";
            this.usersAdminDataGridView.ReadOnly = true;
            this.usersAdminDataGridView.Size = new System.Drawing.Size(868, 330);
            this.usersAdminDataGridView.TabIndex = 11;
            this.usersAdminDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IgrejasAdminDataGridView_CellClick);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // usersAdminCidadeComboBox
            // 
            this.usersAdminCidadeComboBox.DataSource = this.cidadesBindingSource;
            this.usersAdminCidadeComboBox.DisplayMember = "Nome";
            this.usersAdminCidadeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminCidadeComboBox.FormattingEnabled = true;
            this.usersAdminCidadeComboBox.Location = new System.Drawing.Point(12, 175);
            this.usersAdminCidadeComboBox.Name = "usersAdminCidadeComboBox";
            this.usersAdminCidadeComboBox.Size = new System.Drawing.Size(433, 32);
            this.usersAdminCidadeComboBox.TabIndex = 5;
            this.usersAdminCidadeComboBox.ValueMember = "Nome";
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cidade";
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // usersAdminRoleComboBox
            // 
            this.usersAdminRoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminRoleComboBox.FormattingEnabled = true;
            this.usersAdminRoleComboBox.ItemHeight = 24;
            this.usersAdminRoleComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Presidente Nacional",
            "Presidente Regional",
            "Presidente Estadual",
            "Igreja Local"});
            this.usersAdminRoleComboBox.Location = new System.Drawing.Point(584, 175);
            this.usersAdminRoleComboBox.Name = "usersAdminRoleComboBox";
            this.usersAdminRoleComboBox.Size = new System.Drawing.Size(279, 32);
            this.usersAdminRoleComboBox.TabIndex = 25;
            // 
            // usersAdminSenhaTextBox
            // 
            this.usersAdminSenhaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminSenhaTextBox.Location = new System.Drawing.Point(13, 237);
            this.usersAdminSenhaTextBox.Name = "usersAdminSenhaTextBox";
            this.usersAdminSenhaTextBox.Size = new System.Drawing.Size(338, 29);
            this.usersAdminSenhaTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(580, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Senha Temp";
            // 
            // usersAdminIgrejaComboBox
            // 
            this.usersAdminIgrejaComboBox.DataSource = this.igrejasBindingSource;
            this.usersAdminIgrejaComboBox.DisplayMember = "Nome";
            this.usersAdminIgrejaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAdminIgrejaComboBox.FormattingEnabled = true;
            this.usersAdminIgrejaComboBox.Location = new System.Drawing.Point(455, 116);
            this.usersAdminIgrejaComboBox.Name = "usersAdminIgrejaComboBox";
            this.usersAdminIgrejaComboBox.Size = new System.Drawing.Size(408, 32);
            this.usersAdminIgrejaComboBox.TabIndex = 4;
            this.usersAdminIgrejaComboBox.ValueMember = "Nome";
            // 
            // igrejasBindingSource
            // 
            this.igrejasBindingSource.DataMember = "Igrejas";
            this.igrejasBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(451, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Igreja";
            // 
            // igrejasTableAdapter
            // 
            this.igrejasTableAdapter.ClearBeforeFill = true;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // cellMembersLabel
            // 
            this.cellMembersLabel.AutoSize = true;
            this.cellMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellMembersLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cellMembersLabel.Location = new System.Drawing.Point(808, 9);
            this.cellMembersLabel.Name = "cellMembersLabel";
            this.cellMembersLabel.Size = new System.Drawing.Size(24, 26);
            this.cellMembersLabel.TabIndex = 51;
            this.cellMembersLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(579, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 26);
            this.label15.TabIndex = 50;
            this.label15.Text = "Número de Usuários";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // igrejaDataGridViewTextBoxColumn
            // 
            this.igrejaDataGridViewTextBoxColumn.DataPropertyName = "Igreja";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.igrejaDataGridViewTextBoxColumn.HeaderText = "Igreja";
            this.igrejaDataGridViewTextBoxColumn.Name = "igrejaDataGridViewTextBoxColumn";
            this.igrejaDataGridViewTextBoxColumn.ReadOnly = true;
            this.igrejaDataGridViewTextBoxColumn.Width = 200;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 200;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeDataGridViewTextBoxColumn.Width = 200;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // UsersAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciamentoCelulas.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 631);
            this.Controls.Add(this.cellMembersLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.usersAdminIgrejaComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.usersAdminRoleComboBox);
            this.Controls.Add(this.usersAdminSenhaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usersAdminCidadeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usersAdminDataGridView);
            this.Controls.Add(this.usersAdminLoginTextBox);
            this.Controls.Add(this.usersAdminEstadoComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersAdminCancelButton);
            this.Controls.Add(this.usersAdminSaveButton);
            this.Controls.Add(this.usersAdminRemoveButton);
            this.Controls.Add(this.usersAdminAddButton);
            this.Controls.Add(this.usersAdminEditButton);
            this.Name = "UsersAdmin";
            this.Text = "Administração de Usuários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IgrejasAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersAdminDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button usersAdminEditButton;
        private System.Windows.Forms.Button usersAdminAddButton;
        private System.Windows.Forms.Button usersAdminRemoveButton;
        private System.Windows.Forms.Button usersAdminSaveButton;
        private System.Windows.Forms.Button usersAdminCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox usersAdminEstadoComboBox;
        private System.Windows.Forms.TextBox usersAdminLoginTextBox;
        private System.Windows.Forms.DataGridView usersAdminDataGridView;
        private System.Windows.Forms.ComboBox usersAdminCidadeComboBox;
        private System.Windows.Forms.Label label3;
        private Igrejafont10DataSet igrejafont10DataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private Igrejafont10DataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.ComboBox usersAdminRoleComboBox;
        private System.Windows.Forms.TextBox usersAdminSenhaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox usersAdminIgrejaComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private Igrejafont10DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private Igrejafont10DataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private Igrejafont10DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.Label cellMembersLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igrejaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}