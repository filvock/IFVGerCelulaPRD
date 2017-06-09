namespace GerenciamentoCelulas.Forms
{
    partial class IgrejasRemove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IgrejasRemove));
            this.formIgrejasRemoveCancelButton = new System.Windows.Forms.Button();
            this.formIgrejasRemoveOkButton = new System.Windows.Forms.Button();
            this.formIgrejasRemoveComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.igrejafont10DataSet = new GerenciamentoCelulas.Igrejafont10DataSet();
            this.igrejasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejasTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.IgrejasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formIgrejasRemoveCancelButton
            // 
            this.formIgrejasRemoveCancelButton.Location = new System.Drawing.Point(564, 331);
            this.formIgrejasRemoveCancelButton.Name = "formIgrejasRemoveCancelButton";
            this.formIgrejasRemoveCancelButton.Size = new System.Drawing.Size(120, 35);
            this.formIgrejasRemoveCancelButton.TabIndex = 11;
            this.formIgrejasRemoveCancelButton.Text = "Cancel";
            this.formIgrejasRemoveCancelButton.UseVisualStyleBackColor = true;
            this.formIgrejasRemoveCancelButton.Click += new System.EventHandler(this.formIgrejasRemoveCancelButton_Click);
            // 
            // formIgrejasRemoveOkButton
            // 
            this.formIgrejasRemoveOkButton.Location = new System.Drawing.Point(443, 331);
            this.formIgrejasRemoveOkButton.Name = "formIgrejasRemoveOkButton";
            this.formIgrejasRemoveOkButton.Size = new System.Drawing.Size(115, 35);
            this.formIgrejasRemoveOkButton.TabIndex = 10;
            this.formIgrejasRemoveOkButton.Text = "Ok";
            this.formIgrejasRemoveOkButton.UseVisualStyleBackColor = true;
            this.formIgrejasRemoveOkButton.Click += new System.EventHandler(this.formIgrejasRemoveOkButton_Click);
            // 
            // formIgrejasRemoveComboBox
            // 
            this.formIgrejasRemoveComboBox.DataSource = this.igrejasBindingSource;
            this.formIgrejasRemoveComboBox.DisplayMember = "Nome";
            this.formIgrejasRemoveComboBox.FormattingEnabled = true;
            this.formIgrejasRemoveComboBox.Location = new System.Drawing.Point(241, 142);
            this.formIgrejasRemoveComboBox.Name = "formIgrejasRemoveComboBox";
            this.formIgrejasRemoveComboBox.Size = new System.Drawing.Size(365, 32);
            this.formIgrejasRemoveComboBox.TabIndex = 12;
            this.formIgrejasRemoveComboBox.ValueMember = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Igreja";
            // 
            // Igrejafont10DataSet
            // 
            this.igrejafont10DataSet.DataSetName = "Igrejafont10DataSet";
            this.igrejafont10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // FormIgrejasRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formIgrejasRemoveComboBox);
            this.Controls.Add(this.formIgrejasRemoveCancelButton);
            this.Controls.Add(this.formIgrejasRemoveOkButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormIgrejasRemove";
            this.Text = "FormIgrejasRemove";
            this.Load += new System.EventHandler(this.FormIgrejasRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formIgrejasRemoveCancelButton;
        private System.Windows.Forms.Button formIgrejasRemoveOkButton;
        private System.Windows.Forms.ComboBox formIgrejasRemoveComboBox;
        private System.Windows.Forms.Label label1;
        private Igrejafont10DataSet igrejafont10DataSet;
        private System.Windows.Forms.BindingSource igrejasBindingSource;
        private Igrejafont10DataSetTableAdapters.IgrejasTableAdapter igrejasTableAdapter;
    }
}