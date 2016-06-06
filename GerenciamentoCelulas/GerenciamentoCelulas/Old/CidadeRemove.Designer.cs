namespace GerenciamentoCelulas.Forms
{
    partial class CidadeRemove
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
            this.formCidadesRemoveCancelButton = new System.Windows.Forms.Button();
            this.formCidadesRemoveOkButton = new System.Windows.Forms.Button();
            this.formCidadeRemoveComboBox = new System.Windows.Forms.ComboBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont10DataSet = new GerenciamentoCelulas.Igrejafont10DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.cidadesTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.CidadesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // formCidadesRemoveCancelButton
            // 
            this.formCidadesRemoveCancelButton.Location = new System.Drawing.Point(602, 329);
            this.formCidadesRemoveCancelButton.Name = "formCidadesRemoveCancelButton";
            this.formCidadesRemoveCancelButton.Size = new System.Drawing.Size(120, 35);
            this.formCidadesRemoveCancelButton.TabIndex = 9;
            this.formCidadesRemoveCancelButton.Text = "Cancel";
            this.formCidadesRemoveCancelButton.UseVisualStyleBackColor = true;
            this.formCidadesRemoveCancelButton.Click += new System.EventHandler(this.formCidadesRemoveCancelButton_Click);
            // 
            // formCidadesRemoveOkButton
            // 
            this.formCidadesRemoveOkButton.Location = new System.Drawing.Point(481, 329);
            this.formCidadesRemoveOkButton.Name = "formCidadesRemoveOkButton";
            this.formCidadesRemoveOkButton.Size = new System.Drawing.Size(115, 35);
            this.formCidadesRemoveOkButton.TabIndex = 8;
            this.formCidadesRemoveOkButton.Text = "Ok";
            this.formCidadesRemoveOkButton.UseVisualStyleBackColor = true;
            this.formCidadesRemoveOkButton.Click += new System.EventHandler(this.formCidadesRemoveOkButton_Click);
            // 
            // formCidadeRemoveComboBox
            // 
            this.formCidadeRemoveComboBox.DataSource = this.cidadesBindingSource;
            this.formCidadeRemoveComboBox.DisplayMember = "Nome";
            this.formCidadeRemoveComboBox.FormattingEnabled = true;
            this.formCidadeRemoveComboBox.Location = new System.Drawing.Point(244, 129);
            this.formCidadeRemoveComboBox.Name = "formCidadeRemoveComboBox";
            this.formCidadeRemoveComboBox.Size = new System.Drawing.Size(360, 32);
            this.formCidadeRemoveComboBox.TabIndex = 10;
            this.formCidadeRemoveComboBox.ValueMember = "Nome";
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // Igrejafont10DataSet
            // 
            this.igrejafont10DataSet.DataSetName = "Igrejafont10DataSet";
            this.igrejafont10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cidade";
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // FormCidadeRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciamentoCelulas.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formCidadeRemoveComboBox);
            this.Controls.Add(this.formCidadesRemoveCancelButton);
            this.Controls.Add(this.formCidadesRemoveOkButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormCidadeRemove";
            this.Text = "Remover Cidades";
            this.Load += new System.EventHandler(this.FormCidadeRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formCidadesRemoveCancelButton;
        private System.Windows.Forms.Button formCidadesRemoveOkButton;
        private System.Windows.Forms.ComboBox formCidadeRemoveComboBox;
        private System.Windows.Forms.Label label2;
        private GerenciamentoCelulas.Igrejafont10DataSet igrejafont10DataSet;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        //        private Igrejafont10DataSet igrejafont10DataSet;
        //private Igrejafont10DataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
    }
}