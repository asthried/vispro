namespace Database_Assignment
{
    partial class login_form
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
            this.panel_signin = new System.Windows.Forms.Panel();
            this.label_username = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.signin_label = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.panel_signin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_signin
            // 
            this.panel_signin.BackColor = System.Drawing.Color.Firebrick;
            this.panel_signin.Controls.Add(this.login_btn);
            this.panel_signin.Controls.Add(this.pass_txt);
            this.panel_signin.Controls.Add(this.pass_label);
            this.panel_signin.Controls.Add(this.username_txt);
            this.panel_signin.Controls.Add(this.label_username);
            this.panel_signin.Location = new System.Drawing.Point(212, 112);
            this.panel_signin.Name = "panel_signin";
            this.panel_signin.Size = new System.Drawing.Size(444, 269);
            this.panel_signin.TabIndex = 0;
            this.panel_signin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_signin_Paint);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Maroon;
            this.label_username.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(180, 68);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(82, 18);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(79, 89);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(304, 20);
            this.username_txt.TabIndex = 1;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(79, 146);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(304, 20);
            this.pass_txt.TabIndex = 3;
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.BackColor = System.Drawing.Color.Maroon;
            this.pass_label.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.ForeColor = System.Drawing.Color.White;
            this.pass_label.Location = new System.Drawing.Point(180, 125);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(76, 18);
            this.pass_label.TabIndex = 2;
            this.pass_label.Text = "Password";
            // 
            // signin_label
            // 
            this.signin_label.AutoSize = true;
            this.signin_label.BackColor = System.Drawing.Color.Silver;
            this.signin_label.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_label.Location = new System.Drawing.Point(299, 66);
            this.signin_label.Name = "signin_label";
            this.signin_label.Size = new System.Drawing.Size(265, 78);
            this.signin_label.TabIndex = 4;
            this.signin_label.Text = "SIGN IN";
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(169, 192);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(117, 29);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = true;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(854, 519);
            this.Controls.Add(this.signin_label);
            this.Controls.Add(this.panel_signin);
            this.Name = "login_form";
            this.Text = "Form1";
            this.panel_signin.ResumeLayout(false);
            this.panel_signin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_signin;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label signin_label;
        private System.Windows.Forms.Button login_btn;
    }
}

