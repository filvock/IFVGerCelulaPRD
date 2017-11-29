namespace GerenciamentoCelulas.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginFormUserTextBox = new System.Windows.Forms.TextBox();
            this.loginFormPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginFormCancelButton = new System.Windows.Forms.Button();
            this.loginFormOkButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.formLoginNewPwTextBox = new System.Windows.Forms.TextBox();
            this.formLoginNewPw2TextBox = new System.Windows.Forms.TextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário";
            // 
            // loginFormUserTextBox
            // 
            this.loginFormUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormUserTextBox.Location = new System.Drawing.Point(208, 41);
            this.loginFormUserTextBox.Name = "loginFormUserTextBox";
            this.loginFormUserTextBox.Size = new System.Drawing.Size(160, 29);
            this.loginFormUserTextBox.TabIndex = 1;
            // 
            // loginFormPasswordTextBox
            // 
            this.loginFormPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormPasswordTextBox.Location = new System.Drawing.Point(208, 89);
            this.loginFormPasswordTextBox.Name = "loginFormPasswordTextBox";
            this.loginFormPasswordTextBox.Size = new System.Drawing.Size(160, 29);
            this.loginFormPasswordTextBox.TabIndex = 2;
            this.loginFormPasswordTextBox.UseSystemPasswordChar = true;
            this.loginFormPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginFormPasswordTextBox_KeyDown);
            // 
            // loginFormCancelButton
            // 
            this.loginFormCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormCancelButton.Location = new System.Drawing.Point(568, 143);
            this.loginFormCancelButton.Name = "loginFormCancelButton";
            this.loginFormCancelButton.Size = new System.Drawing.Size(121, 45);
            this.loginFormCancelButton.TabIndex = 4;
            this.loginFormCancelButton.Text = "Cancel";
            this.loginFormCancelButton.UseVisualStyleBackColor = true;
            this.loginFormCancelButton.Click += new System.EventHandler(this.loginFormCancelButton_Click);
            // 
            // loginFormOkButton
            // 
            this.loginFormOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormOkButton.Location = new System.Drawing.Point(438, 143);
            this.loginFormOkButton.Name = "loginFormOkButton";
            this.loginFormOkButton.Size = new System.Drawing.Size(124, 45);
            this.loginFormOkButton.TabIndex = 3;
            this.loginFormOkButton.Text = "Ok";
            this.loginFormOkButton.UseVisualStyleBackColor = true;
            this.loginFormOkButton.Click += new System.EventHandler(this.loginFormOkButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nova Senha";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repita Nova Senha";
            this.label4.Visible = false;
            // 
            // formLoginNewPwTextBox
            // 
            this.formLoginNewPwTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLoginNewPwTextBox.Location = new System.Drawing.Point(279, 148);
            this.formLoginNewPwTextBox.Name = "formLoginNewPwTextBox";
            this.formLoginNewPwTextBox.Size = new System.Drawing.Size(160, 29);
            this.formLoginNewPwTextBox.TabIndex = 5;
            this.formLoginNewPwTextBox.UseSystemPasswordChar = true;
            this.formLoginNewPwTextBox.Visible = false;
            // 
            // formLoginNewPw2TextBox
            // 
            this.formLoginNewPw2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLoginNewPw2TextBox.Location = new System.Drawing.Point(279, 193);
            this.formLoginNewPw2TextBox.Name = "formLoginNewPw2TextBox";
            this.formLoginNewPw2TextBox.Size = new System.Drawing.Size(160, 29);
            this.formLoginNewPw2TextBox.TabIndex = 6;
            this.formLoginNewPw2TextBox.UseSystemPasswordChar = true;
            this.formLoginNewPw2TextBox.Visible = false;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.versionLabel.Location = new System.Drawing.Point(12, 313);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(75, 24);
            this.versionLabel.TabIndex = 8;
            this.versionLabel.Text = "Version";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 346);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.formLoginNewPw2TextBox);
            this.Controls.Add(this.formLoginNewPwTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginFormOkButton);
            this.Controls.Add(this.loginFormCancelButton);
            this.Controls.Add(this.loginFormPasswordTextBox);
            this.Controls.Add(this.loginFormUserTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Entrar no Sistema";
            this.Load += new System.EventHandler(this.LoginForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginFormUserTextBox;
        private System.Windows.Forms.TextBox loginFormPasswordTextBox;
        private System.Windows.Forms.Button loginFormCancelButton;
        private System.Windows.Forms.Button loginFormOkButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox formLoginNewPwTextBox;
        private System.Windows.Forms.TextBox formLoginNewPw2TextBox;
        private System.Windows.Forms.Label versionLabel;
    }
}