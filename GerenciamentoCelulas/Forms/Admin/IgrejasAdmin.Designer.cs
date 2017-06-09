namespace GerenciamentoCelulas.Forms.Admin
{
    partial class IgrejasAdmin
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
            this.igrejasAdminEditButton = new System.Windows.Forms.Button();
            this.igrejasAdminAddButton = new System.Windows.Forms.Button();
            this.igrejasAdminRemoveButton = new System.Windows.Forms.Button();
            this.igrejasAdminSaveButton = new System.Windows.Forms.Button();
            this.igrejasAdminCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.igrejasAdminEstadoComboBox = new System.Windows.Forms.ComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont10DataSet = new GerenciamentoCelulas.Igrejafont10DataSet();
            this.igrejasAdminTextBox = new System.Windows.Forms.TextBox();
            this.igrejasAdminDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejasTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.IgrejasTableAdapter();
            this.estadosTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.EstadosTableAdapter();
            this.igrejasAdminCidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.igrejafont10DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadesTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.CidadesTableAdapter();
            this.cellMembersLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasAdminDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // igrejasAdminEditButton
            // 
            this.igrejasAdminEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminEditButton.Location = new System.Drawing.Point(13, 13);
            this.igrejasAdminEditButton.Name = "igrejasAdminEditButton";
            this.igrejasAdminEditButton.Size = new System.Drawing.Size(145, 42);
            this.igrejasAdminEditButton.TabIndex = 0;
            this.igrejasAdminEditButton.Text = "Editar";
            this.igrejasAdminEditButton.UseVisualStyleBackColor = true;
            this.igrejasAdminEditButton.Click += new System.EventHandler(this.IgrejasAdminEditButton_Click);
            // 
            // igrejasAdminAddButton
            // 
            this.igrejasAdminAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminAddButton.Location = new System.Drawing.Point(164, 13);
            this.igrejasAdminAddButton.Name = "igrejasAdminAddButton";
            this.igrejasAdminAddButton.Size = new System.Drawing.Size(145, 42);
            this.igrejasAdminAddButton.TabIndex = 1;
            this.igrejasAdminAddButton.Text = "Adicionar";
            this.igrejasAdminAddButton.UseVisualStyleBackColor = true;
            this.igrejasAdminAddButton.Click += new System.EventHandler(this.IgrejasAdminAddButton_Click);
            // 
            // igrejasAdminRemoveButton
            // 
            this.igrejasAdminRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminRemoveButton.Location = new System.Drawing.Point(315, 13);
            this.igrejasAdminRemoveButton.Name = "igrejasAdminRemoveButton";
            this.igrejasAdminRemoveButton.Size = new System.Drawing.Size(145, 42);
            this.igrejasAdminRemoveButton.TabIndex = 2;
            this.igrejasAdminRemoveButton.Text = "Remover";
            this.igrejasAdminRemoveButton.UseVisualStyleBackColor = true;
            this.igrejasAdminRemoveButton.Click += new System.EventHandler(this.IgrejasAdminRemoveButton_Click);
            // 
            // igrejasAdminSaveButton
            // 
            this.igrejasAdminSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminSaveButton.Location = new System.Drawing.Point(567, 241);
            this.igrejasAdminSaveButton.Name = "igrejasAdminSaveButton";
            this.igrejasAdminSaveButton.Size = new System.Drawing.Size(145, 42);
            this.igrejasAdminSaveButton.TabIndex = 3;
            this.igrejasAdminSaveButton.Text = "Salvar";
            this.igrejasAdminSaveButton.UseVisualStyleBackColor = true;
            this.igrejasAdminSaveButton.Click += new System.EventHandler(this.IgrejasAdminSaveButton_Click);
            // 
            // igrejasAdminCancelButton
            // 
            this.igrejasAdminCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminCancelButton.Location = new System.Drawing.Point(718, 241);
            this.igrejasAdminCancelButton.Name = "igrejasAdminCancelButton";
            this.igrejasAdminCancelButton.Size = new System.Drawing.Size(145, 42);
            this.igrejasAdminCancelButton.TabIndex = 4;
            this.igrejasAdminCancelButton.Text = "Cancel";
            this.igrejasAdminCancelButton.UseVisualStyleBackColor = true;
            this.igrejasAdminCancelButton.Click += new System.EventHandler(this.IgrejasAdminCancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Igreja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(723, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estado";
            // 
            // igrejasAdminEstadoComboBox
            // 
            this.igrejasAdminEstadoComboBox.DataSource = this.estadosBindingSource;
            this.igrejasAdminEstadoComboBox.DisplayMember = "Sigla";
            this.igrejasAdminEstadoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminEstadoComboBox.FormattingEnabled = true;
            this.igrejasAdminEstadoComboBox.Location = new System.Drawing.Point(727, 116);
            this.igrejasAdminEstadoComboBox.Name = "igrejasAdminEstadoComboBox";
            this.igrejasAdminEstadoComboBox.Size = new System.Drawing.Size(113, 32);
            this.igrejasAdminEstadoComboBox.TabIndex = 14;
            this.igrejasAdminEstadoComboBox.ValueMember = "Sigla";
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
            // igrejasAdminTextBox
            // 
            this.igrejasAdminTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminTextBox.Location = new System.Drawing.Point(13, 119);
            this.igrejasAdminTextBox.Name = "igrejasAdminTextBox";
            this.igrejasAdminTextBox.Size = new System.Drawing.Size(432, 29);
            this.igrejasAdminTextBox.TabIndex = 15;
            // 
            // igrejasAdminDataGridView
            // 
            this.igrejasAdminDataGridView.AllowUserToAddRows = false;
            this.igrejasAdminDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.igrejasAdminDataGridView.AutoGenerateColumns = false;
            this.igrejasAdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.igrejasAdminDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.igrejasAdminDataGridView.DataSource = this.igrejasBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.igrejasAdminDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.igrejasAdminDataGridView.Location = new System.Drawing.Point(12, 289);
            this.igrejasAdminDataGridView.Name = "igrejasAdminDataGridView";
            this.igrejasAdminDataGridView.ReadOnly = true;
            this.igrejasAdminDataGridView.Size = new System.Drawing.Size(868, 330);
            this.igrejasAdminDataGridView.TabIndex = 16;
            this.igrejasAdminDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IgrejasAdminDataGridView_CellClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 300;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeDataGridViewTextBoxColumn.Width = 300;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // igrejasBindingSource
            // 
            this.igrejasBindingSource.DataMember = "Igrejas";
            this.igrejasBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // igrejasTableAdapter
            // 
            this.igrejasTableAdapter.ClearBeforeFill = true;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // igrejasAdminCidadeComboBox
            // 
            this.igrejasAdminCidadeComboBox.DataSource = this.cidadesBindingSource;
            this.igrejasAdminCidadeComboBox.DisplayMember = "Nome";
            this.igrejasAdminCidadeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igrejasAdminCidadeComboBox.FormattingEnabled = true;
            this.igrejasAdminCidadeComboBox.Location = new System.Drawing.Point(455, 116);
            this.igrejasAdminCidadeComboBox.Name = "igrejasAdminCidadeComboBox";
            this.igrejasAdminCidadeComboBox.Size = new System.Drawing.Size(266, 32);
            this.igrejasAdminCidadeComboBox.TabIndex = 18;
            this.igrejasAdminCidadeComboBox.ValueMember = "Nome";
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
            this.label3.Location = new System.Drawing.Point(451, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cidade";
            // 
            // igrejafont10DataSetBindingSource
            // 
            this.igrejafont10DataSetBindingSource.DataSource = this.igrejafont10DataSet;
            this.igrejafont10DataSetBindingSource.Position = 0;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // cellMembersLabel
            // 
            this.cellMembersLabel.AutoSize = true;
            this.cellMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellMembersLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cellMembersLabel.Location = new System.Drawing.Point(808, 13);
            this.cellMembersLabel.Name = "cellMembersLabel";
            this.cellMembersLabel.Size = new System.Drawing.Size(24, 26);
            this.cellMembersLabel.TabIndex = 49;
            this.cellMembersLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(579, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(197, 26);
            this.label15.TabIndex = 48;
            this.label15.Text = "Número de Igrejas:";
            // 
            // IgrejasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciamentoCelulas.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 631);
            this.Controls.Add(this.cellMembersLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.igrejasAdminCidadeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.igrejasAdminDataGridView);
            this.Controls.Add(this.igrejasAdminTextBox);
            this.Controls.Add(this.igrejasAdminEstadoComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.igrejasAdminCancelButton);
            this.Controls.Add(this.igrejasAdminSaveButton);
            this.Controls.Add(this.igrejasAdminRemoveButton);
            this.Controls.Add(this.igrejasAdminAddButton);
            this.Controls.Add(this.igrejasAdminEditButton);
            this.Name = "IgrejasAdmin";
            this.Text = "Administração de Igrejas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IgrejasAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasAdminDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button igrejasAdminEditButton;
        private System.Windows.Forms.Button igrejasAdminAddButton;
        private System.Windows.Forms.Button igrejasAdminRemoveButton;
        private System.Windows.Forms.Button igrejasAdminSaveButton;
        private System.Windows.Forms.Button igrejasAdminCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox igrejasAdminEstadoComboBox;
        private System.Windows.Forms.TextBox igrejasAdminTextBox;
        private System.Windows.Forms.DataGridView igrejasAdminDataGridView;
        private Igrejafont10DataSet igrejafont10DataSet;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private Igrejafont10DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private Igrejafont10DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.ComboBox igrejasAdminCidadeComboBox;
        private System.Windows.Forms.BindingSource igrejafont10DataSetBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private Igrejafont10DataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.Label cellMembersLabel;
        private System.Windows.Forms.Label label15;
    }
}