namespace GerenciamentoCelulas.Forms
{
    partial class IgrejasAdd
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
            this.formIgrejasAddCancelButton = new System.Windows.Forms.Button();
            this.formIgrejasAddOkButton = new System.Windows.Forms.Button();
            this.Igreja = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.formIgrejasAddTextBox = new System.Windows.Forms.TextBox();
            this.formIgrejasAddComboBox = new System.Windows.Forms.ComboBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.igrejafont10DataSet = new GerenciamentoCelulas.Igrejafont10DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.formIgrejaAddEstadoComboBox = new System.Windows.Forms.ComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadesTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.CidadesTableAdapter();
            this.estadosTableAdapter = new GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.EstadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // formIgrejasAddCancelButton
            // 
            this.formIgrejasAddCancelButton.Location = new System.Drawing.Point(579, 307);
            this.formIgrejasAddCancelButton.Name = "formIgrejasAddCancelButton";
            this.formIgrejasAddCancelButton.Size = new System.Drawing.Size(120, 35);
            this.formIgrejasAddCancelButton.TabIndex = 13;
            this.formIgrejasAddCancelButton.Text = "Cancel";
            this.formIgrejasAddCancelButton.UseVisualStyleBackColor = true;
            this.formIgrejasAddCancelButton.Click += new System.EventHandler(this.formIgrejasAddCancelButton_Click);
            // 
            // formIgrejasAddOkButton
            // 
            this.formIgrejasAddOkButton.Location = new System.Drawing.Point(458, 307);
            this.formIgrejasAddOkButton.Name = "formIgrejasAddOkButton";
            this.formIgrejasAddOkButton.Size = new System.Drawing.Size(115, 35);
            this.formIgrejasAddOkButton.TabIndex = 12;
            this.formIgrejasAddOkButton.Text = "Ok";
            this.formIgrejasAddOkButton.UseVisualStyleBackColor = true;
            this.formIgrejasAddOkButton.Click += new System.EventHandler(this.formIgrejasAddOkButton_Click);
            // 
            // Igreja
            // 
            this.Igreja.AutoSize = true;
            this.Igreja.Location = new System.Drawing.Point(147, 101);
            this.Igreja.Name = "Igreja";
            this.Igreja.Size = new System.Drawing.Size(56, 24);
            this.Igreja.TabIndex = 14;
            this.Igreja.Text = "Igreja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cidade";
            // 
            // formIgrejasAddTextBox
            // 
            this.formIgrejasAddTextBox.Location = new System.Drawing.Point(235, 96);
            this.formIgrejasAddTextBox.Name = "formIgrejasAddTextBox";
            this.formIgrejasAddTextBox.Size = new System.Drawing.Size(358, 29);
            this.formIgrejasAddTextBox.TabIndex = 16;
            // 
            // formIgrejasAddComboBox
            // 
            this.formIgrejasAddComboBox.DataSource = this.cidadesBindingSource;
            this.formIgrejasAddComboBox.DisplayMember = "Nome";
            this.formIgrejasAddComboBox.FormattingEnabled = true;
            this.formIgrejasAddComboBox.Location = new System.Drawing.Point(235, 151);
            this.formIgrejasAddComboBox.Name = "formIgrejasAddComboBox";
            this.formIgrejasAddComboBox.Size = new System.Drawing.Size(358, 32);
            this.formIgrejasAddComboBox.TabIndex = 17;
            this.formIgrejasAddComboBox.ValueMember = "Nome";
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // Igrejafont10DataSet1
            // 
            this.igrejafont10DataSet.DataSetName = "Igrejafont10DataSet";
            this.igrejafont10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Estado";
            // 
            // formIgrejaAddEstadoComboBox
            // 
            this.formIgrejaAddEstadoComboBox.DataSource = this.estadosBindingSource;
            this.formIgrejaAddEstadoComboBox.DisplayMember = "Sigla";
            this.formIgrejaAddEstadoComboBox.FormattingEnabled = true;
            this.formIgrejaAddEstadoComboBox.Location = new System.Drawing.Point(235, 203);
            this.formIgrejaAddEstadoComboBox.Name = "formIgrejaAddEstadoComboBox";
            this.formIgrejaAddEstadoComboBox.Size = new System.Drawing.Size(358, 32);
            this.formIgrejaAddEstadoComboBox.TabIndex = 19;
            this.formIgrejaAddEstadoComboBox.ValueMember = "Sigla";
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "Estados";
            this.estadosBindingSource.DataSource = this.igrejafont10DataSet;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // FormIgrejasAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GerenciamentoCelulas.Properties.Resources.Fonte_de_vida_marca_dágua_novo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 354);
            this.Controls.Add(this.formIgrejaAddEstadoComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formIgrejasAddComboBox);
            this.Controls.Add(this.formIgrejasAddTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Igreja);
            this.Controls.Add(this.formIgrejasAddCancelButton);
            this.Controls.Add(this.formIgrejasAddOkButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormIgrejasAdd";
            this.Text = "FormIgrejasAdd";
            this.Load += new System.EventHandler(this.FormIgrejasAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igrejafont10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button formIgrejasAddCancelButton;
        private System.Windows.Forms.Button formIgrejasAddOkButton;
        private System.Windows.Forms.Label Igreja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox formIgrejasAddTextBox;
        private System.Windows.Forms.ComboBox formIgrejasAddComboBox;
        private Igrejafont10DataSet igrejafont10DataSet;
        //private Igrejafont10DataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox formIgrejaAddEstadoComboBox;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private GerenciamentoCelulas.Igrejafont10DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
        //private Igrejafont10DataSetTableAdapters.EstadosTableAdapter estadosTableAdapter;
    }
}