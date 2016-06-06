namespace GerenciamentoCelulas.Forms
{
    partial class UserAdd
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
            this.formUserAddCancelButton = new System.Windows.Forms.Button();
            this.formUserAddOkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.formUserAddNomeTextBox = new System.Windows.Forms.TextBox();
            this.formUserAddSenhaTextBox = new System.Windows.Forms.TextBox();
            this.formUserAddIgrejaComboBox = new System.Windows.Forms.ComboBox();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont10DataSet = new GerenciamentoCelulas.Igrejafont10DataSet();
            this.formUserAddRoleComboBox = new System.Windows.Forms.ComboBox();
            this.formUserAddCidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.formUserAddEstadoComboBox = new System.Windows.Forms.ComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.igrejasTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.IgrejasTableAdapter();
            this.estadosTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.EstadosTableAdapter();
            this.cidadesTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.CidadesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formUserAddCancelButton
            // 
            this.formUserAddCancelButton.Location = new System.Drawing.Point(590, 335);
            this.formUserAddCancelButton.Name = "formUserAddCancelButton";
            this.formUserAddCancelButton.Size = new System.Drawing.Size(120, 35);
            this.formUserAddCancelButton.TabIndex = 13;
            this.formUserAddCancelButton.Text = "Cancel";
            this.formUserAddCancelButton.UseVisualStyleBackColor = true;
            this.formUserAddCancelButton.Click += new System.EventHandler(this.formIgrejasRemoveCancelButton_Click);
            // 
            // formUserAddOkButton
            // 
            this.formUserAddOkButton.Location = new System.Drawing.Point(469, 335);
            this.formUserAddOkButton.Name = "formUserAddOkButton";
            this.formUserAddOkButton.Size = new System.Drawing.Size(115, 35);
            this.formUserAddOkButton.TabIndex = 12;
            this.formUserAddOkButton.Text = "Ok";
            this.formUserAddOkButton.UseVisualStyleBackColor = true;
            this.formUserAddOkButton.Click += new System.EventHandler(this.formIgrejasRemoveOkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome de Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Senha Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Igreja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Role";
            // 
            // formUserAddNomeTextBox
            // 
            this.formUserAddNomeTextBox.Location = new System.Drawing.Point(246, 38);
            this.formUserAddNomeTextBox.Name = "formUserAddNomeTextBox";
            this.formUserAddNomeTextBox.Size = new System.Drawing.Size(338, 29);
            this.formUserAddNomeTextBox.TabIndex = 18;
            // 
            // formUserAddSenhaTextBox
            // 
            this.formUserAddSenhaTextBox.Location = new System.Drawing.Point(246, 76);
            this.formUserAddSenhaTextBox.Name = "formUserAddSenhaTextBox";
            this.formUserAddSenhaTextBox.Size = new System.Drawing.Size(338, 29);
            this.formUserAddSenhaTextBox.TabIndex = 19;
            // 
            // formUserAddIgrejaComboBox
            // 
            this.formUserAddIgrejaComboBox.DataSource = this.igrejasBindingSource;
            this.formUserAddIgrejaComboBox.DisplayMember = "Nome";
            this.formUserAddIgrejaComboBox.FormattingEnabled = true;
            this.formUserAddIgrejaComboBox.Location = new System.Drawing.Point(246, 113);
            this.formUserAddIgrejaComboBox.Name = "formUserAddIgrejaComboBox";
            this.formUserAddIgrejaComboBox.Size = new System.Drawing.Size(338, 32);
            this.formUserAddIgrejaComboBox.TabIndex = 20;
            this.formUserAddIgrejaComboBox.ValueMember = "Nome";
            // 
            // igrejasBindingSource
            // 
            this.igrejasBindingSource.DataMember = "Igrejas";
            this.igrejasBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // Igrejafont10DataSet1
            // 
            this.igrejafont10DataSet.DataSetName = "Igrejafont10DataSet";
            this.igrejafont10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formUserAddRoleComboBox
            // 
            this.formUserAddRoleComboBox.FormattingEnabled = true;
            this.formUserAddRoleComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Coord Nacional",
            "Coord Estadual",
            "Igreja Local"});
            this.formUserAddRoleComboBox.Location = new System.Drawing.Point(246, 227);
            this.formUserAddRoleComboBox.Name = "formUserAddRoleComboBox";
            this.formUserAddRoleComboBox.Size = new System.Drawing.Size(338, 32);
            this.formUserAddRoleComboBox.TabIndex = 21;
            // 
            // formUserAddCidadeComboBox
            // 
            this.formUserAddCidadeComboBox.DataSource = this.cidadesBindingSource;
            this.formUserAddCidadeComboBox.DisplayMember = "Nome";
            this.formUserAddCidadeComboBox.FormattingEnabled = true;
            this.formUserAddCidadeComboBox.Location = new System.Drawing.Point(246, 151);
            this.formUserAddCidadeComboBox.Name = "formUserAddCidadeComboBox";
            this.formUserAddCidadeComboBox.Size = new System.Drawing.Size(338, 32);
            this.formUserAddCidadeComboBox.TabIndex = 23;
            this.formUserAddCidadeComboBox.ValueMember = "Nome";
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cidade";
            // 
            // formUserAddEstadoComboBox
            // 
            this.formUserAddEstadoComboBox.DataSource = this.estadosBindingSource;
            this.formUserAddEstadoComboBox.DisplayMember = "Sigla";
            this.formUserAddEstadoComboBox.FormattingEnabled = true;
            this.formUserAddEstadoComboBox.Location = new System.Drawing.Point(246, 189);
            this.formUserAddEstadoComboBox.Name = "formUserAddEstadoComboBox";
            this.formUserAddEstadoComboBox.Size = new System.Drawing.Size(338, 32);
            this.formUserAddEstadoComboBox.TabIndex = 25;
            this.formUserAddEstadoComboBox.ValueMember = "Sigla";
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "Estados";
            this.estadosBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Estado";
            // 
            // igrejasTableAdapter
            // 
            this.igrejasTableAdapter.ClearBeforeFill = true;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // FormUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciamentoCelulas.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 382);
            this.Controls.Add(this.formUserAddEstadoComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.formUserAddCidadeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.formUserAddRoleComboBox);
            this.Controls.Add(this.formUserAddIgrejaComboBox);
            this.Controls.Add(this.formUserAddSenhaTextBox);
            this.Controls.Add(this.formUserAddNomeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formUserAddCancelButton);
            this.Controls.Add(this.formUserAddOkButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormUserAdd";
            this.Text = "Adicionar Usuário";
            this.Load += new System.EventHandler(this.FormUserAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formUserAddCancelButton;
        private System.Windows.Forms.Button formUserAddOkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox formUserAddNomeTextBox;
        private System.Windows.Forms.TextBox formUserAddSenhaTextBox;
        private System.Windows.Forms.ComboBox formUserAddIgrejaComboBox;
        private System.Windows.Forms.ComboBox formUserAddRoleComboBox;
        private Igrejafont10DataSet igrejafont10DataSet;
       // private Igrejafont10DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.ComboBox formUserAddCidadeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox formUserAddEstadoComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        // private Igrejafont10DataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
       // private Igrejafont10DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
    }
}