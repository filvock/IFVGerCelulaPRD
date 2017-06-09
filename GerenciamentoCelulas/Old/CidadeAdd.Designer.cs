namespace GerenciamentoCelulas.Forms
{
    partial class CidadeAdd
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
            this.formCidadesAddCancelButton = new System.Windows.Forms.Button();
            this.formCidadesAddOkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.formCidadesAddTextBox = new System.Windows.Forms.TextBox();
            this.formCidadesAddComboBox = new System.Windows.Forms.ComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont10DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont10DataSet = new GerenciamentoCelulas.Igrejafont10DataSet();
            this.estadosTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.EstadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // formCidadesAddCancelButton
            // 
            this.formCidadesAddCancelButton.Location = new System.Drawing.Point(547, 285);
            this.formCidadesAddCancelButton.Name = "formCidadesAddCancelButton";
            this.formCidadesAddCancelButton.Size = new System.Drawing.Size(120, 35);
            this.formCidadesAddCancelButton.TabIndex = 9;
            this.formCidadesAddCancelButton.Text = "Cancel";
            this.formCidadesAddCancelButton.UseVisualStyleBackColor = true;
            this.formCidadesAddCancelButton.Click += new System.EventHandler(this.formCidadesAddCancelButton_Click);
            // 
            // formCidadesAddOkButton
            // 
            this.formCidadesAddOkButton.Location = new System.Drawing.Point(426, 285);
            this.formCidadesAddOkButton.Name = "formCidadesAddOkButton";
            this.formCidadesAddOkButton.Size = new System.Drawing.Size(115, 35);
            this.formCidadesAddOkButton.TabIndex = 8;
            this.formCidadesAddOkButton.Text = "Ok";
            this.formCidadesAddOkButton.UseVisualStyleBackColor = true;
            this.formCidadesAddOkButton.Click += new System.EventHandler(this.formCidadesAddOkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Estado";
            // 
            // formCidadesAddTextBox
            // 
            this.formCidadesAddTextBox.Location = new System.Drawing.Point(157, 72);
            this.formCidadesAddTextBox.Name = "formCidadesAddTextBox";
            this.formCidadesAddTextBox.Size = new System.Drawing.Size(446, 29);
            this.formCidadesAddTextBox.TabIndex = 12;
            // 
            // formCidadesAddComboBox
            // 
            this.formCidadesAddComboBox.DataSource = this.estadosBindingSource;
            this.formCidadesAddComboBox.DisplayMember = "Sigla";
            this.formCidadesAddComboBox.FormattingEnabled = true;
            this.formCidadesAddComboBox.Location = new System.Drawing.Point(157, 130);
            this.formCidadesAddComboBox.Name = "formCidadesAddComboBox";
            this.formCidadesAddComboBox.Size = new System.Drawing.Size(343, 32);
            this.formCidadesAddComboBox.TabIndex = 13;
            this.formCidadesAddComboBox.ValueMember = "Sigla";
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "Estados";
            this.estadosBindingSource.DataSource = this.igrejafont10DataSet1BindingSource;
            // 
            // Igrejafont10DataSet1BindingSource
            // 
            this.igrejafont10DataSet1BindingSource.DataSource = this.igrejafont10DataSet;
            this.igrejafont10DataSet1BindingSource.Position = 0;
            // 
            // Igrejafont10DataSet1
            // 
            this.igrejafont10DataSet.DataSetName = "Igrejafont10DataSet";
            this.igrejafont10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // FormCidadeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciamentoCelulas.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 332);
            this.Controls.Add(this.formCidadesAddComboBox);
            this.Controls.Add(this.formCidadesAddTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formCidadesAddCancelButton);
            this.Controls.Add(this.formCidadesAddOkButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormCidadeAdd";
            this.Text = "Adicionar Cidades";
            this.Load += new System.EventHandler(this.FormCidadeAdd_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formCidadesAddCancelButton;
        private System.Windows.Forms.Button formCidadesAddOkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox formCidadesAddTextBox;
        private System.Windows.Forms.ComboBox formCidadesAddComboBox;
        private Igrejafont10DataSet igrejafont10DataSet;
        private System.Windows.Forms.BindingSource igrejafont10DataSet1BindingSource;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
       // private Igrejafont10DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
    }
}