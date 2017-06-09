namespace GerenciamentoCelulas.Forms.Admin
{
    partial class cidadesAdmin
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
            this.cidadesAdminEditButton = new System.Windows.Forms.Button();
            this.cidadesAdminAddButton = new System.Windows.Forms.Button();
            this.cidadesAdminRemoveButton = new System.Windows.Forms.Button();
            this.cidadesAdminSaveButton = new System.Windows.Forms.Button();
            this.cidadesAdminCancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cidadesAdminComboBox = new System.Windows.Forms.ComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont10DataSet = new GerenciamentoCelulas.Igrejafont10DataSet();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.EstadosTableAdapter();
            this.cidadesAdminTextBox = new System.Windows.Forms.TextBox();
            this.cidadesAdminDataGridView = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadesTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.CidadesTableAdapter();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejasTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.IgrejasTableAdapter();
            this.cellMembersLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesAdminDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cidadesAdminEditButton
            // 
            this.cidadesAdminEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminEditButton.Location = new System.Drawing.Point(13, 13);
            this.cidadesAdminEditButton.Name = "cidadesAdminEditButton";
            this.cidadesAdminEditButton.Size = new System.Drawing.Size(145, 42);
            this.cidadesAdminEditButton.TabIndex = 0;
            this.cidadesAdminEditButton.Text = "Editar";
            this.cidadesAdminEditButton.UseVisualStyleBackColor = true;
            this.cidadesAdminEditButton.Click += new System.EventHandler(this.cidadeAdminEditButton_Click);
            // 
            // cidadesAdminAddButton
            // 
            this.cidadesAdminAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminAddButton.Location = new System.Drawing.Point(164, 13);
            this.cidadesAdminAddButton.Name = "cidadesAdminAddButton";
            this.cidadesAdminAddButton.Size = new System.Drawing.Size(145, 42);
            this.cidadesAdminAddButton.TabIndex = 1;
            this.cidadesAdminAddButton.Text = "Adicionar";
            this.cidadesAdminAddButton.UseVisualStyleBackColor = true;
            this.cidadesAdminAddButton.Click += new System.EventHandler(this.cidadeAdminAddButton_Click);
            // 
            // cidadesAdminRemoveButton
            // 
            this.cidadesAdminRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminRemoveButton.Location = new System.Drawing.Point(315, 13);
            this.cidadesAdminRemoveButton.Name = "cidadesAdminRemoveButton";
            this.cidadesAdminRemoveButton.Size = new System.Drawing.Size(145, 42);
            this.cidadesAdminRemoveButton.TabIndex = 2;
            this.cidadesAdminRemoveButton.Text = "Remover";
            this.cidadesAdminRemoveButton.UseVisualStyleBackColor = true;
            this.cidadesAdminRemoveButton.Click += new System.EventHandler(this.cidadeAdminRemoveButton_Click);
            // 
            // cidadesAdminSaveButton
            // 
            this.cidadesAdminSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminSaveButton.Location = new System.Drawing.Point(567, 241);
            this.cidadesAdminSaveButton.Name = "cidadesAdminSaveButton";
            this.cidadesAdminSaveButton.Size = new System.Drawing.Size(145, 42);
            this.cidadesAdminSaveButton.TabIndex = 3;
            this.cidadesAdminSaveButton.Text = "Salvar";
            this.cidadesAdminSaveButton.UseVisualStyleBackColor = true;
            this.cidadesAdminSaveButton.Click += new System.EventHandler(this.cidadeAdminSaveButton_Click);
            // 
            // cidadesAdminCancelButton
            // 
            this.cidadesAdminCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminCancelButton.Location = new System.Drawing.Point(718, 241);
            this.cidadesAdminCancelButton.Name = "cidadesAdminCancelButton";
            this.cidadesAdminCancelButton.Size = new System.Drawing.Size(145, 42);
            this.cidadesAdminCancelButton.TabIndex = 4;
            this.cidadesAdminCancelButton.Text = "Cancel";
            this.cidadesAdminCancelButton.UseVisualStyleBackColor = true;
            this.cidadesAdminCancelButton.Click += new System.EventHandler(this.cidadeAdminCancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estados";
            // 
            // cidadesAdminComboBox
            // 
            this.cidadesAdminComboBox.DataSource = this.estadosBindingSource;
            this.cidadesAdminComboBox.DisplayMember = "Sigla";
            this.cidadesAdminComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminComboBox.FormattingEnabled = true;
            this.cidadesAdminComboBox.Location = new System.Drawing.Point(451, 116);
            this.cidadesAdminComboBox.Name = "cidadesAdminComboBox";
            this.cidadesAdminComboBox.Size = new System.Drawing.Size(113, 32);
            this.cidadesAdminComboBox.TabIndex = 14;
            this.cidadesAdminComboBox.ValueMember = "Sigla";
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
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // cidadesAdminTextBox
            // 
            this.cidadesAdminTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadesAdminTextBox.Location = new System.Drawing.Point(13, 119);
            this.cidadesAdminTextBox.Name = "cidadesAdminTextBox";
            this.cidadesAdminTextBox.Size = new System.Drawing.Size(432, 29);
            this.cidadesAdminTextBox.TabIndex = 15;
            // 
            // cidadesAdminDataGridView
            // 
            this.cidadesAdminDataGridView.AllowUserToAddRows = false;
            this.cidadesAdminDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cidadesAdminDataGridView.AutoGenerateColumns = false;
            this.cidadesAdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cidadesAdminDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.estadoDataGridViewTextBoxColumn});
            this.cidadesAdminDataGridView.DataSource = this.cidadesBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cidadesAdminDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.cidadesAdminDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cidadesAdminDataGridView.Location = new System.Drawing.Point(12, 289);
            this.cidadesAdminDataGridView.Name = "cidadesAdminDataGridView";
            this.cidadesAdminDataGridView.ReadOnly = true;
            this.cidadesAdminDataGridView.Size = new System.Drawing.Size(868, 330);
            this.cidadesAdminDataGridView.TabIndex = 16;
            this.cidadesAdminDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CidadeAdminDataGridView_CellClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 200;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
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
            // cellMembersLabel
            // 
            this.cellMembersLabel.AutoSize = true;
            this.cellMembersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cellMembersLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cellMembersLabel.Location = new System.Drawing.Point(819, 13);
            this.cellMembersLabel.Name = "cellMembersLabel";
            this.cellMembersLabel.Size = new System.Drawing.Size(24, 26);
            this.cellMembersLabel.TabIndex = 47;
            this.cellMembersLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(590, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 26);
            this.label15.TabIndex = 46;
            this.label15.Text = "Número de Cidades:";
            // 
            // cidadesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciamentoCelulas.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 631);
            this.Controls.Add(this.cellMembersLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cidadesAdminDataGridView);
            this.Controls.Add(this.cidadesAdminTextBox);
            this.Controls.Add(this.cidadesAdminComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cidadesAdminCancelButton);
            this.Controls.Add(this.cidadesAdminSaveButton);
            this.Controls.Add(this.cidadesAdminRemoveButton);
            this.Controls.Add(this.cidadesAdminAddButton);
            this.Controls.Add(this.cidadesAdminEditButton);
            this.Name = "cidadesAdmin";
            this.Text = "Administração de Cidades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CidadesAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesAdminDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cidadesAdminEditButton;
        private System.Windows.Forms.Button cidadesAdminAddButton;
        private System.Windows.Forms.Button cidadesAdminRemoveButton;
        private System.Windows.Forms.Button cidadesAdminSaveButton;
        private System.Windows.Forms.Button cidadesAdminCancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cidadesAdminComboBox;
        private Igrejafont10DataSet igrejafont10DataSet;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private Igrejafont10DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.TextBox cidadesAdminTextBox;
        private System.Windows.Forms.DataGridView cidadesAdminDataGridView;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private Igrejafont10DataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private Igrejafont10DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label cellMembersLabel;
        private System.Windows.Forms.Label label15;
    }
}