namespace QuizApp
{
    partial class Form1
    {
        private Guna.UI2.WinForms.Guna2TextBox logPwd;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnRegister;
        private Guna.UI2.WinForms.Guna2Button subLogin;
        private Guna.UI2.WinForms.Guna2Panel panelToggle;

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
            this.panelToggle = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlRegister = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRegister = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.regEml = new Guna.UI2.WinForms.Guna2TextBox();
            this.regUsr = new Guna.UI2.WinForms.Guna2TextBox();
            this.regCpwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.regPwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.subRegister = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logPwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.subLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegister = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.logEml = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelToggle.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToggle
            // 
            this.panelToggle.BorderColor = System.Drawing.Color.Gray;
            this.panelToggle.BorderRadius = 10;
            this.panelToggle.BorderThickness = 1;
            this.panelToggle.Controls.Add(this.pnlRegister);
            this.panelToggle.Controls.Add(this.pnlLogin);
            this.panelToggle.Controls.Add(this.guna2HtmlLabel1);
            this.panelToggle.Controls.Add(this.btnLogin);
            this.panelToggle.Controls.Add(this.btnRegister);
            this.panelToggle.Location = new System.Drawing.Point(12, 12);
            this.panelToggle.Name = "panelToggle";
            this.panelToggle.Size = new System.Drawing.Size(795, 494);
            this.panelToggle.TabIndex = 0;
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.lblRegister);
            this.pnlRegister.Controls.Add(this.regEml);
            this.pnlRegister.Controls.Add(this.regUsr);
            this.pnlRegister.Controls.Add(this.regCpwd);
            this.pnlRegister.Controls.Add(this.regPwd);
            this.pnlRegister.Controls.Add(this.subRegister);
            this.pnlRegister.Location = new System.Drawing.Point(210, 95);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(377, 375);
            this.pnlRegister.TabIndex = 15;
            this.pnlRegister.Visible = false;
            // 
            // lblRegister
            // 
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblRegister.Location = new System.Drawing.Point(141, 21);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(110, 39);
            this.lblRegister.TabIndex = 14;
            this.lblRegister.Text = "Register";
            // 
            // regEml
            // 
            this.regEml.BorderRadius = 10;
            this.regEml.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regEml.DefaultText = "";
            this.regEml.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regEml.Location = new System.Drawing.Point(14, 140);
            this.regEml.Name = "regEml";
            this.regEml.PasswordChar = '\0';
            this.regEml.PlaceholderText = "Enter your Email";
            this.regEml.SelectedText = "";
            this.regEml.Size = new System.Drawing.Size(340, 40);
            this.regEml.TabIndex = 13;
            // 
            // regUsr
            // 
            this.regUsr.BorderRadius = 10;
            this.regUsr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regUsr.DefaultText = "";
            this.regUsr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regUsr.Location = new System.Drawing.Point(14, 85);
            this.regUsr.Name = "regUsr";
            this.regUsr.PasswordChar = '\0';
            this.regUsr.PlaceholderText = "Enter your Username";
            this.regUsr.SelectedText = "";
            this.regUsr.Size = new System.Drawing.Size(340, 40);
            this.regUsr.TabIndex = 9;
            // 
            // regCpwd
            // 
            this.regCpwd.BorderRadius = 10;
            this.regCpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regCpwd.DefaultText = "";
            this.regCpwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regCpwd.Location = new System.Drawing.Point(14, 258);
            this.regCpwd.Name = "regCpwd";
            this.regCpwd.PasswordChar = '●';
            this.regCpwd.PlaceholderText = "Confirm your Password";
            this.regCpwd.SelectedText = "";
            this.regCpwd.Size = new System.Drawing.Size(340, 40);
            this.regCpwd.TabIndex = 11;
            // 
            // regPwd
            // 
            this.regPwd.BorderRadius = 10;
            this.regPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.regPwd.DefaultText = "";
            this.regPwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regPwd.Location = new System.Drawing.Point(14, 198);
            this.regPwd.Name = "regPwd";
            this.regPwd.PasswordChar = '●';
            this.regPwd.PlaceholderText = "Enter your Password";
            this.regPwd.SelectedText = "";
            this.regPwd.Size = new System.Drawing.Size(340, 40);
            this.regPwd.TabIndex = 10;
            // 
            // subRegister
            // 
            this.subRegister.BorderRadius = 10;
            this.subRegister.FillColor = System.Drawing.Color.SeaGreen;
            this.subRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.subRegister.ForeColor = System.Drawing.Color.White;
            this.subRegister.Location = new System.Drawing.Point(14, 314);
            this.subRegister.Name = "subRegister";
            this.subRegister.Size = new System.Drawing.Size(340, 50);
            this.subRegister.TabIndex = 12;
            this.subRegister.Text = "Register";
            this.subRegister.Click += new System.EventHandler(this.subRegister_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.logEml);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.logPwd);
            this.pnlLogin.Controls.Add(this.subLogin);
            this.pnlLogin.Location = new System.Drawing.Point(210, 92);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(380, 264);
            this.pnlLogin.TabIndex = 14;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblLogin.Location = new System.Drawing.Point(146, 21);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(75, 39);
            this.lblLogin.TabIndex = 15;
            this.lblLogin.Text = "Login";
            // 
            // logPwd
            // 
            this.logPwd.BorderRadius = 10;
            this.logPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logPwd.DefaultText = "";
            this.logPwd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logPwd.Location = new System.Drawing.Point(18, 140);
            this.logPwd.Name = "logPwd";
            this.logPwd.PasswordChar = '●';
            this.logPwd.PlaceholderText = "Enter your Password";
            this.logPwd.SelectedText = "";
            this.logPwd.Size = new System.Drawing.Size(340, 40);
            this.logPwd.TabIndex = 4;
            // 
            // subLogin
            // 
            this.subLogin.BorderRadius = 10;
            this.subLogin.FillColor = System.Drawing.Color.SeaGreen;
            this.subLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.subLogin.ForeColor = System.Drawing.Color.White;
            this.subLogin.Location = new System.Drawing.Point(18, 198);
            this.subLogin.Name = "subLogin";
            this.subLogin.Size = new System.Drawing.Size(340, 50);
            this.subLogin.TabIndex = 6;
            this.subLogin.Text = "Login";
            this.subLogin.Click += new System.EventHandler(this.subLogin_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(30, 15);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(91, 40);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "QUIZZY";
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.FillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(554, 22);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 33);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BorderRadius = 10;
            this.btnRegister.FillColor = System.Drawing.Color.Gray;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(650, 22);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(96, 33);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // logEml
            // 
            this.logEml.BorderRadius = 10;
            this.logEml.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logEml.DefaultText = "";
            this.logEml.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logEml.Location = new System.Drawing.Point(18, 94);
            this.logEml.Name = "logEml";
            this.logEml.PasswordChar = '\0';
            this.logEml.PlaceholderText = "Enter your Email";
            this.logEml.SelectedText = "";
            this.logEml.Size = new System.Drawing.Size(340, 40);
            this.logEml.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 518);
            this.Controls.Add(this.panelToggle);
            this.Name = "Form1";
            this.Text = "Login/Register Form";
            this.panelToggle.ResumeLayout(false);
            this.panelToggle.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox regEml;
        private Guna.UI2.WinForms.Guna2TextBox regPwd;
        private Guna.UI2.WinForms.Guna2Button subRegister;
        private Guna.UI2.WinForms.Guna2TextBox regCpwd;
        private Guna.UI2.WinForms.Guna2TextBox regUsr;
        private Guna.UI2.WinForms.Guna2Panel pnlRegister;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRegister;
        private Guna.UI2.WinForms.Guna2Panel pnlLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TextBox logEml;
    }
}
