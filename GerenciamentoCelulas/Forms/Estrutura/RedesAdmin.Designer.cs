namespace GerenciamentoCelulas.Forms.Estrutura
{
    partial class RedesAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedesAdmin));
            this.igrejafont10DataSet = new GerenciamentoCelulas.Igrejafont10DataSet();
            this.closeButton = new System.Windows.Forms.Button();
            this.addRedeButton = new System.Windows.Forms.Button();
            this.editRedeButton = new System.Windows.Forms.Button();
            this.deactivateRedeButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeRespDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igrejaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.cellMembersLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.igrejasTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.IgrejasTableAdapter();
            this.redesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.redesTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.RedesTableAdapter();
            this.redesTableAdapter1 = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.Redes1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // igrejafont10DataSet
            // 
            this.igrejafont10DataSet.DataSetName = "Igrejafont10DataSet";
            this.igrejafont10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // addRedeButton
            // 
            this.addRedeButton.Location = new System.Drawing.Point(12, 12);
            this.addRedeButton.Name = "addRedeButton";
            this.addRedeButton.Size = new System.Drawing.Size(174, 35);
            this.addRedeButton.TabIndex = 1;
            this.addRedeButton.Text = "Adicionar Rede";
            this.addRedeButton.UseVisualStyleBackColor = true;
            this.addRedeButton.Click += new System.EventHandler(this.RedeWindowAddRede_Click);
            // 
            // editRedeButton
            // 
            this.editRedeButton.Location = new System.Drawing.Point(192, 12);
            this.editRedeButton.Name = "editRedeButton";
            this.editRedeButton.Size = new System.Drawing.Size(174, 35);
            this.editRedeButton.TabIndex = 2;
            this.editRedeButton.Text = "Alterar Rede";
            this.editRedeButton.UseVisualStyleBackColor = true;
            this.editRedeButton.Click += new System.EventHandler(this.RedeWindowEditRede_Click);
            // 
            // deactivateRedeButton
            // 
            this.deactivateRedeButton.Location = new System.Drawing.Point(375, 12);
            this.deactivateRedeButton.Name = "deactivateRedeButton";
            this.deactivateRedeButton.Size = new System.Drawing.Size(174, 35);
            this.deactivateRedeButton.TabIndex = 3;
            this.deactivateRedeButton.Text = "Desativar Rede";
            this.deactivateRedeButton.UseVisualStyleBackColor = true;
            this.deactivateRedeButton.Click += new System.EventHandler(this.RedeWindowDeactivateRede_Click);
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
            this.responsavelDataGridViewTextBoxColumn,
            this.foneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn,
            this.metaDataGridViewTextBoxColumn,
            this.ativaDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.redesBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.Location = new System.Drawing.Point(0, 378);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1093, 355);
            this.dataGridView.TabIndex = 16;
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
            // redesBindingSource
            // 
            this.redesBindingSource.DataMember = "Redes";
            this.redesBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(86, 103);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 29);
            this.codeTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(289, 105);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(441, 29);
            this.nameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Igreja";
            // 
            // respTextBox
            // 
            this.respTextBox.Location = new System.Drawing.Point(327, 192);
            this.respTextBox.Name = "respTextBox";
            this.respTextBox.Size = new System.Drawing.Size(403, 29);
            this.respTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Responsável";
            // 
            // foneTextBox
            // 
            this.foneTextBox.Location = new System.Drawing.Point(99, 227);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(168, 29);
            this.foneTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefone";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(336, 227);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(394, 29);
            this.emailTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Email";
            // 
            // codTextBox
            // 
            this.codTextBox.Location = new System.Drawing.Point(86, 192);
            this.codTextBox.Name = "codTextBox";
            this.codTextBox.Size = new System.Drawing.Size(100, 29);
            this.codTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Código";
            // 
            // obsTextBox
            // 
            this.obsTextBox.Location = new System.Drawing.Point(16, 278);
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(1056, 29);
            this.obsTextBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 251);
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
            this.igrejaComboBox.Size = new System.Drawing.Size(315, 32);
            this.igrejaComboBox.TabIndex = 5;
            this.igrejaComboBox.ValueMember = "Nome";
            this.igrejaComboBox.SelectedValueChanged += new System.EventHandler(this.RedeWindowIgrejaComboBox_SelectedValueChanged);
            // 
            // igrejasBindingSource
            // 
            this.igrejasBindingSource.DataMember = "Igrejas";
            this.igrejasBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // searchMemberButton
            // 
            this.searchMemberButton.Location = new System.Drawing.Point(12, 140);
            this.searchMemberButton.Name = "searchMemberButton";
            this.searchMemberButton.Size = new System.Drawing.Size(276, 35);
            this.searchMemberButton.TabIndex = 8;
            this.searchMemberButton.Text = "Buscar Membro Responsável";
            this.searchMemberButton.UseVisualStyleBackColor = true;
            this.searchMemberButton.Click += new System.EventHandler(this.searchMemberButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(760, 313);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(153, 32);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Salvar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.RedesAdminSaveButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(919, 313);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(153, 32);
            this.cleanButton.TabIndex = 15;
            this.cleanButton.Text = "Limpar";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.RedesAdminCleanButton_Click);
            // 
            // cellMembersLabel
            // 
            this.cellMembersLabel.AutoSize = true;
            this.cellMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellMembersLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cellMembersLabel.Location = new System.Drawing.Point(1030, 12);
            this.cellMembersLabel.Name = "cellMembersLabel";
            this.cellMembersLabel.Size = new System.Drawing.Size(24, 26);
            this.cellMembersLabel.TabIndex = 45;
            this.cellMembersLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(801, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 26);
            this.label15.TabIndex = 44;
            this.label15.Text = "Número de Redes:";
            // 
            // igrejasTableAdapter
            // 
            this.igrejasTableAdapter.ClearBeforeFill = true;
            // 
            // redesBindingSource1
            // 
            this.redesBindingSource1.DataMember = "Redes1";
            this.redesBindingSource1.DataSource = this.igrejafont10DataSet;
            // 
            // redesTableAdapter
            // 
            this.redesTableAdapter.ClearBeforeFill = true;
            // 
            // redesTableAdapter1
            // 
            this.redesTableAdapter1.ClearBeforeFill = true;
            // 
            // RedesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 733);
            this.Controls.Add(this.cellMembersLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.saveButton);
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
            this.Controls.Add(this.deactivateRedeButton);
            this.Controls.Add(this.editRedeButton);
            this.Controls.Add(this.addRedeButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RedesAdmin";
            this.Text = "Administrar Redes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RedesAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addRedeButton;
        private System.Windows.Forms.Button editRedeButton;
        private System.Windows.Forms.Button deactivateRedeButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private Igrejafont10DataSet igrejafont10DataSet;
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
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Label cellMembersLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private Igrejafont10DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.BindingSource redesBindingSource;
        private Igrejafont10DataSetTableAdapters.RedesTableAdapter redesTableAdapter;
        private System.Windows.Forms.BindingSource redesBindingSource1;
        private Igrejafont10DataSetTableAdapters.Redes1TableAdapter redesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeRespDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn igrejaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativaDataGridViewTextBoxColumn;
    }
}