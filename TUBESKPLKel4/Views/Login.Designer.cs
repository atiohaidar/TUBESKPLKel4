namespace TUBESKPLKel4.Views
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.formUsername = new System.Windows.Forms.TextBox();
            this.formPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // formUsername
            // 
            this.formUsername.Location = new System.Drawing.Point(276, 114);
            this.formUsername.Name = "formUsername";
            this.formUsername.Size = new System.Drawing.Size(249, 22);
            this.formUsername.TabIndex = 1;
            this.formUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // formPassword
            // 
            this.formPassword.Location = new System.Drawing.Point(276, 154);
            this.formPassword.Name = "formPassword";
            this.formPassword.Size = new System.Drawing.Size(249, 22);
            this.formPassword.TabIndex = 2;
            this.formPassword.TextChanged += new System.EventHandler(this.formPassword_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.formPassword);
            this.Controls.Add(this.formUsername);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox formUsername;
        private System.Windows.Forms.TextBox formPassword;
        private System.Windows.Forms.Button button1;
    }
}