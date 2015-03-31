namespace E_Voting_Data
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 346);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 332);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Controls.Add(this.loginBtn);
            this.panel4.Location = new System.Drawing.Point(88, 253);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 30);
            this.panel4.TabIndex = 15;
            // 
            // loginBtn
            // 
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(-1, 0);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(245, 31);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(255, 187);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Forgot Password";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(93, 186);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.passwordText);
            this.panel3.Location = new System.Drawing.Point(93, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 23);
            this.panel3.TabIndex = 12;
            // 
            // passwordText
            // 
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.HideSelection = false;
            this.passwordText.Location = new System.Drawing.Point(1, 1);
            this.passwordText.Multiline = true;
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(240, 21);
            this.passwordText.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.usernameText);
            this.panel2.Location = new System.Drawing.Point(93, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 25);
            this.panel2.TabIndex = 11;
            // 
            // usernameText
            // 
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameText.Font = new System.Drawing.Font("Khmer UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(1, 1);
            this.usernameText.Multiline = true;
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(240, 23);
            this.usernameText.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 346);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox usernameText;


    }
}

