namespace GerenciamentoCelulas.Forms
{
    partial class UserRemove
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
            this.formUserRemoveCancelButton = new System.Windows.Forms.Button();
            this.formUserRemoveOkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.formUserRemoveComboBox = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont10DataSet = new GerenciamentoCelulas.Igrejafont10DataSet();
            this.usuariosTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // formUserRemoveCancelButton
            // 
            this.formUserRemoveCancelButton.Location = new System.Drawing.Point(574, 287);
            this.formUserRemoveCancelButton.Name = "formUserRemoveCancelButton";
            this.formUserRemoveCancelButton.Size = new System.Drawing.Size(120, 35);
            this.formUserRemoveCancelButton.TabIndex = 13;
            this.formUserRemoveCancelButton.Text = "Cancel";
            this.formUserRemoveCancelButton.UseVisualStyleBackColor = true;
            this.formUserRemoveCancelButton.Click += new System.EventHandler(this.formIgrejasRemoveCancelButton_Click);
            // 
            // formUserRemoveOkButton
            // 
            this.formUserRemoveOkButton.Location = new System.Drawing.Point(453, 287);
            this.formUserRemoveOkButton.Name = "formUserRemoveOkButton";
            this.formUserRemoveOkButton.Size = new System.Drawing.Size(115, 35);
            this.formUserRemoveOkButton.TabIndex = 12;
            this.formUserRemoveOkButton.Text = "Ok";
            this.formUserRemoveOkButton.UseVisualStyleBackColor = true;
            this.formUserRemoveOkButton.Click += new System.EventHandler(this.formIgrejasRemoveOkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome do Usuário";
            // 
            // formUserRemoveComboBox
            // 
            this.formUserRemoveComboBox.DataSource = this.usuariosBindingSource;
            this.formUserRemoveComboBox.DisplayMember = "Nome";
            this.formUserRemoveComboBox.FormattingEnabled = true;
            this.formUserRemoveComboBox.Location = new System.Drawing.Point(228, 98);
            this.formUserRemoveComboBox.Name = "formUserRemoveComboBox";
            this.formUserRemoveComboBox.Size = new System.Drawing.Size(303, 32);
            this.formUserRemoveComboBox.TabIndex = 15;
            this.formUserRemoveComboBox.ValueMember = "Nome";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // Igrejafont10DataSet
            // 
            this.igrejafont10DataSet.DataSetName = "Igrejafont10DataSet";
            this.igrejafont10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // FormUserRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciamentoCelulas.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.formUserRemoveComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formUserRemoveCancelButton);
            this.Controls.Add(this.formUserRemoveOkButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormUserRemove";
            this.Text = "Remover Usuário";
            this.Load += new System.EventHandler(this.FormUserRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formUserRemoveCancelButton;
        private System.Windows.Forms.Button formUserRemoveOkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox formUserRemoveComboBox;
        private GerenciamentoCelulas.Igrejafont10DataSet igrejafont10DataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        //private Igrejafont10DataSet igrejafont10DataSet;
        //private Igrejafont10DataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
    }
}