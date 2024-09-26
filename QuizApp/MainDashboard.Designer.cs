namespace QuizApp
{
    partial class MainDashboard
    {
        private System.ComponentModel.IContainer components = null;

        // Panels
        private Guna.UI2.WinForms.Guna2Panel AdminPanel;
        private Guna.UI2.WinForms.Guna2Panel pnlAddQuiz;
        private Guna.UI2.WinForms.Guna2Panel sideMenuPanel;

        // Form elements
        private Guna.UI2.WinForms.Guna2TextBox txtQuizName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuizName;
        private Guna.UI2.WinForms.Guna2TextBox txtQuizDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuizDescription;
        private Guna.UI2.WinForms.Guna2Button btnSubmitQuiz;

        // Buttons
        private Guna.UI2.WinForms.Guna2Button btnAdminLogout;
        private Guna.UI2.WinForms.Guna2Button btnShowQuiz;
        private Guna.UI2.WinForms.Guna2Button btnAddQuiz;
        private Guna.UI2.WinForms.Guna2Button btnShowUsers;
        private Guna.UI2.WinForms.Guna2Button btnRecentAttempts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.AdminPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAddQue = new Guna.UI2.WinForms.Guna2Panel();
            this.txtOpt4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOpt4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOpt3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOpt3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOpt2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOpt2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOpt1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOpt1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblQuizSet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAddQuiz = new Guna.UI2.WinForms.Guna2Panel();
            this.txtQuizName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuizName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtQuizDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuizDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSubmitQuiz = new Guna.UI2.WinForms.Guna2Button();
            this.sideMenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnShowQuiz = new Guna.UI2.WinForms.Guna2Button();
            this.btnRecentAttempts = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddQuiz = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminLogout = new Guna.UI2.WinForms.Guna2Button();
            this.txtCorAns = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCorAns = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AdminPanel.SuspendLayout();
            this.pnlAddQue.SuspendLayout();
            this.pnlAddQuiz.SuspendLayout();
            this.sideMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminPanel
            // 
            this.AdminPanel.BorderColor = System.Drawing.Color.Gray;
            this.AdminPanel.BorderRadius = 10;
            this.AdminPanel.BorderThickness = 1;
            this.AdminPanel.Controls.Add(this.pnlAddQue);
            this.AdminPanel.Controls.Add(this.pnlAddQuiz);
            this.AdminPanel.Controls.Add(this.sideMenuPanel);
            this.AdminPanel.Controls.Add(this.btnAdminLogout);
            this.AdminPanel.Location = new System.Drawing.Point(3, 7);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(776, 516);
            this.AdminPanel.TabIndex = 1;
            // 
            // pnlAddQue
            // 
            this.pnlAddQue.BorderColor = System.Drawing.Color.Silver;
            this.pnlAddQue.BorderRadius = 5;
            this.pnlAddQue.BorderThickness = 1;
            this.pnlAddQue.Controls.Add(this.txtCorAns);
            this.pnlAddQue.Controls.Add(this.lblCorAns);
            this.pnlAddQue.Controls.Add(this.txtOpt4);
            this.pnlAddQue.Controls.Add(this.lblOpt4);
            this.pnlAddQue.Controls.Add(this.txtOpt3);
            this.pnlAddQue.Controls.Add(this.lblOpt3);
            this.pnlAddQue.Controls.Add(this.txtOpt2);
            this.pnlAddQue.Controls.Add(this.lblOpt2);
            this.pnlAddQue.Controls.Add(this.txtOpt1);
            this.pnlAddQue.Controls.Add(this.lblOpt1);
            this.pnlAddQue.Controls.Add(this.guna2ComboBox1);
            this.pnlAddQue.Controls.Add(this.lblQuizSet);
            this.pnlAddQue.Controls.Add(this.guna2TextBox2);
            this.pnlAddQue.Controls.Add(this.guna2HtmlLabel2);
            this.pnlAddQue.Controls.Add(this.guna2Button1);
            this.pnlAddQue.Location = new System.Drawing.Point(183, 48);
            this.pnlAddQue.Name = "pnlAddQue";
            this.pnlAddQue.Size = new System.Drawing.Size(590, 449);
            this.pnlAddQue.TabIndex = 8;
            // 
            // txtOpt4
            // 
            this.txtOpt4.BorderRadius = 5;
            this.txtOpt4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpt4.DefaultText = "";
            this.txtOpt4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOpt4.Location = new System.Drawing.Point(304, 271);
            this.txtOpt4.Multiline = true;
            this.txtOpt4.Name = "txtOpt4";
            this.txtOpt4.PasswordChar = '\0';
            this.txtOpt4.PlaceholderText = "Enter Option D";
            this.txtOpt4.SelectedText = "";
            this.txtOpt4.Size = new System.Drawing.Size(239, 40);
            this.txtOpt4.TabIndex = 12;
            // 
            // lblOpt4
            // 
            this.lblOpt4.BackColor = System.Drawing.Color.Transparent;
            this.lblOpt4.Location = new System.Drawing.Point(304, 246);
            this.lblOpt4.Name = "lblOpt4";
            this.lblOpt4.Size = new System.Drawing.Size(45, 15);
            this.lblOpt4.TabIndex = 13;
            this.lblOpt4.Text = "Option D";
            // 
            // txtOpt3
            // 
            this.txtOpt3.BorderRadius = 5;
            this.txtOpt3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpt3.DefaultText = "";
            this.txtOpt3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOpt3.Location = new System.Drawing.Point(52, 271);
            this.txtOpt3.Multiline = true;
            this.txtOpt3.Name = "txtOpt3";
            this.txtOpt3.PasswordChar = '\0';
            this.txtOpt3.PlaceholderText = "Enter Option C";
            this.txtOpt3.SelectedText = "";
            this.txtOpt3.Size = new System.Drawing.Size(239, 40);
            this.txtOpt3.TabIndex = 10;
            // 
            // lblOpt3
            // 
            this.lblOpt3.BackColor = System.Drawing.Color.Transparent;
            this.lblOpt3.Location = new System.Drawing.Point(52, 246);
            this.lblOpt3.Name = "lblOpt3";
            this.lblOpt3.Size = new System.Drawing.Size(44, 15);
            this.lblOpt3.TabIndex = 11;
            this.lblOpt3.Text = "Option C";
            // 
            // txtOpt2
            // 
            this.txtOpt2.BorderRadius = 5;
            this.txtOpt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpt2.DefaultText = "";
            this.txtOpt2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOpt2.Location = new System.Drawing.Point(304, 195);
            this.txtOpt2.Multiline = true;
            this.txtOpt2.Name = "txtOpt2";
            this.txtOpt2.PasswordChar = '\0';
            this.txtOpt2.PlaceholderText = "Enter Option B";
            this.txtOpt2.SelectedText = "";
            this.txtOpt2.Size = new System.Drawing.Size(239, 40);
            this.txtOpt2.TabIndex = 8;
            // 
            // lblOpt2
            // 
            this.lblOpt2.BackColor = System.Drawing.Color.Transparent;
            this.lblOpt2.Location = new System.Drawing.Point(304, 170);
            this.lblOpt2.Name = "lblOpt2";
            this.lblOpt2.Size = new System.Drawing.Size(44, 15);
            this.lblOpt2.TabIndex = 9;
            this.lblOpt2.Text = "Option B";
            // 
            // txtOpt1
            // 
            this.txtOpt1.BorderRadius = 5;
            this.txtOpt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpt1.DefaultText = "";
            this.txtOpt1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOpt1.Location = new System.Drawing.Point(52, 195);
            this.txtOpt1.Multiline = true;
            this.txtOpt1.Name = "txtOpt1";
            this.txtOpt1.PasswordChar = '\0';
            this.txtOpt1.PlaceholderText = "Enter Option A";
            this.txtOpt1.SelectedText = "";
            this.txtOpt1.Size = new System.Drawing.Size(239, 40);
            this.txtOpt1.TabIndex = 6;
            // 
            // lblOpt1
            // 
            this.lblOpt1.BackColor = System.Drawing.Color.Transparent;
            this.lblOpt1.Location = new System.Drawing.Point(52, 170);
            this.lblOpt1.Name = "lblOpt1";
            this.lblOpt1.Size = new System.Drawing.Size(44, 15);
            this.lblOpt1.TabIndex = 7;
            this.lblOpt1.Text = "Option A";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(50, 39);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(144, 36);
            this.guna2ComboBox1.TabIndex = 5;
            // 
            // lblQuizSet
            // 
            this.lblQuizSet.BackColor = System.Drawing.Color.Transparent;
            this.lblQuizSet.Location = new System.Drawing.Point(50, 17);
            this.lblQuizSet.Name = "lblQuizSet";
            this.lblQuizSet.Size = new System.Drawing.Size(46, 15);
            this.lblQuizSet.TabIndex = 1;
            this.lblQuizSet.Text = "Quiz Set:";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderRadius = 5;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.Location = new System.Drawing.Point(50, 112);
            this.guna2TextBox2.Multiline = true;
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "Enter Question";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(494, 50);
            this.guna2TextBox2.TabIndex = 2;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(50, 87);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(48, 15);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Question:\r\n";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(50, 398);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(100, 36);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Submit";
            // 
            // pnlAddQuiz
            // 
            this.pnlAddQuiz.BorderColor = System.Drawing.Color.Silver;
            this.pnlAddQuiz.BorderRadius = 5;
            this.pnlAddQuiz.BorderThickness = 1;
            this.pnlAddQuiz.Controls.Add(this.txtQuizName);
            this.pnlAddQuiz.Controls.Add(this.lblQuizName);
            this.pnlAddQuiz.Controls.Add(this.txtQuizDescription);
            this.pnlAddQuiz.Controls.Add(this.lblQuizDescription);
            this.pnlAddQuiz.Controls.Add(this.btnSubmitQuiz);
            this.pnlAddQuiz.Location = new System.Drawing.Point(169, 48);
            this.pnlAddQuiz.Name = "pnlAddQuiz";
            this.pnlAddQuiz.Size = new System.Drawing.Size(590, 277);
            this.pnlAddQuiz.TabIndex = 7;
            // 
            // txtQuizName
            // 
            this.txtQuizName.BorderRadius = 5;
            this.txtQuizName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuizName.DefaultText = "";
            this.txtQuizName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuizName.Location = new System.Drawing.Point(50, 50);
            this.txtQuizName.Name = "txtQuizName";
            this.txtQuizName.PasswordChar = '\0';
            this.txtQuizName.PlaceholderText = "Enter quiz name";
            this.txtQuizName.SelectedText = "";
            this.txtQuizName.Size = new System.Drawing.Size(200, 36);
            this.txtQuizName.TabIndex = 0;
            // 
            // lblQuizName
            // 
            this.lblQuizName.BackColor = System.Drawing.Color.Transparent;
            this.lblQuizName.Location = new System.Drawing.Point(50, 25);
            this.lblQuizName.Name = "lblQuizName";
            this.lblQuizName.Size = new System.Drawing.Size(58, 15);
            this.lblQuizName.TabIndex = 1;
            this.lblQuizName.Text = "Quiz Name:";
            // 
            // txtQuizDescription
            // 
            this.txtQuizDescription.BorderRadius = 5;
            this.txtQuizDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuizDescription.DefaultText = "";
            this.txtQuizDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuizDescription.Location = new System.Drawing.Point(50, 120);
            this.txtQuizDescription.Name = "txtQuizDescription";
            this.txtQuizDescription.PasswordChar = '\0';
            this.txtQuizDescription.PlaceholderText = "Enter description";
            this.txtQuizDescription.SelectedText = "";
            this.txtQuizDescription.Size = new System.Drawing.Size(300, 80);
            this.txtQuizDescription.TabIndex = 2;
            // 
            // lblQuizDescription
            // 
            this.lblQuizDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblQuizDescription.Location = new System.Drawing.Point(50, 95);
            this.lblQuizDescription.Name = "lblQuizDescription";
            this.lblQuizDescription.Size = new System.Drawing.Size(59, 15);
            this.lblQuizDescription.TabIndex = 3;
            this.lblQuizDescription.Text = "Description:";
            // 
            // btnSubmitQuiz
            // 
            this.btnSubmitQuiz.BorderRadius = 10;
            this.btnSubmitQuiz.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSubmitQuiz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmitQuiz.ForeColor = System.Drawing.Color.White;
            this.btnSubmitQuiz.Location = new System.Drawing.Point(50, 220);
            this.btnSubmitQuiz.Name = "btnSubmitQuiz";
            this.btnSubmitQuiz.Size = new System.Drawing.Size(100, 36);
            this.btnSubmitQuiz.TabIndex = 4;
            this.btnSubmitQuiz.Text = "Submit";
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.sideMenuPanel.BorderRadius = 10;
            this.sideMenuPanel.Controls.Add(this.btnShowQuiz);
            this.sideMenuPanel.Controls.Add(this.btnRecentAttempts);
            this.sideMenuPanel.Controls.Add(this.btnShowUsers);
            this.sideMenuPanel.Controls.Add(this.btnAddQuiz);
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(163, 516);
            this.sideMenuPanel.TabIndex = 6;
            // 
            // btnShowQuiz
            // 
            this.btnShowQuiz.BorderRadius = 10;
            this.btnShowQuiz.FillColor = System.Drawing.Color.White;
            this.btnShowQuiz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowQuiz.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnShowQuiz.Location = new System.Drawing.Point(10, 104);
            this.btnShowQuiz.Name = "btnShowQuiz";
            this.btnShowQuiz.Size = new System.Drawing.Size(140, 33);
            this.btnShowQuiz.TabIndex = 2;
            this.btnShowQuiz.Text = "Show Quiz";
            // 
            // btnRecentAttempts
            // 
            this.btnRecentAttempts.BorderRadius = 10;
            this.btnRecentAttempts.FillColor = System.Drawing.Color.White;
            this.btnRecentAttempts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecentAttempts.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRecentAttempts.Location = new System.Drawing.Point(10, 255);
            this.btnRecentAttempts.Name = "btnRecentAttempts";
            this.btnRecentAttempts.Size = new System.Drawing.Size(140, 33);
            this.btnRecentAttempts.TabIndex = 5;
            this.btnRecentAttempts.Text = "Recent Attempts";
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.BorderRadius = 10;
            this.btnShowUsers.FillColor = System.Drawing.Color.White;
            this.btnShowUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowUsers.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnShowUsers.Location = new System.Drawing.Point(10, 206);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(140, 33);
            this.btnShowUsers.TabIndex = 4;
            this.btnShowUsers.Text = "Show Users";
            // 
            // btnAddQuiz
            // 
            this.btnAddQuiz.BorderRadius = 10;
            this.btnAddQuiz.FillColor = System.Drawing.Color.White;
            this.btnAddQuiz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddQuiz.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddQuiz.Location = new System.Drawing.Point(10, 155);
            this.btnAddQuiz.Name = "btnAddQuiz";
            this.btnAddQuiz.Size = new System.Drawing.Size(140, 33);
            this.btnAddQuiz.TabIndex = 3;
            this.btnAddQuiz.Text = "Add Quiz";
            
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.BorderRadius = 10;
            this.btnAdminLogout.FillColor = System.Drawing.Color.SeaGreen;
            this.btnAdminLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdminLogout.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogout.Location = new System.Drawing.Point(675, 15);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(90, 33);
            this.btnAdminLogout.TabIndex = 0;
            this.btnAdminLogout.Text = "Logout";
            // 
            // txtCorAns
            // 
            this.txtCorAns.BorderRadius = 5;
            this.txtCorAns.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorAns.DefaultText = "";
            this.txtCorAns.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCorAns.Location = new System.Drawing.Point(49, 348);
            this.txtCorAns.Multiline = true;
            this.txtCorAns.Name = "txtCorAns";
            this.txtCorAns.PasswordChar = '\0';
            this.txtCorAns.PlaceholderText = "Enter Correct Answer";
            this.txtCorAns.SelectedText = "";
            this.txtCorAns.Size = new System.Drawing.Size(494, 40);
            this.txtCorAns.TabIndex = 14;
            // 
            // lblCorAns
            // 
            this.lblCorAns.BackColor = System.Drawing.Color.Transparent;
            this.lblCorAns.Location = new System.Drawing.Point(50, 327);
            this.lblCorAns.Name = "lblCorAns";
            this.lblCorAns.Size = new System.Drawing.Size(67, 15);
            this.lblCorAns.TabIndex = 15;
            this.lblCorAns.Text = "Correct Anser";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.AdminPanel);
            this.Name = "MainDashboard";
            this.Text = "Quiz App - Admin Dashboard";
            this.AdminPanel.ResumeLayout(false);
            this.pnlAddQue.ResumeLayout(false);
            this.pnlAddQue.PerformLayout();
            this.pnlAddQuiz.ResumeLayout(false);
            this.pnlAddQuiz.PerformLayout();
            this.sideMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlAddQue;
        private Guna.UI2.WinForms.Guna2TextBox txtOpt4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOpt4;
        private Guna.UI2.WinForms.Guna2TextBox txtOpt3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOpt3;
        private Guna.UI2.WinForms.Guna2TextBox txtOpt2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOpt2;
        private Guna.UI2.WinForms.Guna2TextBox txtOpt1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOpt1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuizSet;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtCorAns;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCorAns;
    }
}
