
namespace QuizApp
{
    partial class temp
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
            this.UserPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnStartQuiz = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewResults = new Guna.UI2.WinForms.Guna2Button();
            this.pblSub = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUserLogout = new Guna.UI2.WinForms.Guna2Button();
            this.UserPanel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserPanel
            // 
            this.UserPanel.BorderColor = System.Drawing.Color.Gray;
            this.UserPanel.BorderRadius = 10;
            this.UserPanel.BorderThickness = 1;
            this.UserPanel.Controls.Add(this.guna2Panel2);
            this.UserPanel.Controls.Add(this.pblSub);
            this.UserPanel.Controls.Add(this.btnUserLogout);
            this.UserPanel.Location = new System.Drawing.Point(12, 12);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(776, 476);
            this.UserPanel.TabIndex = 3;
            this.UserPanel.Visible = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.btnStartQuiz);
            this.guna2Panel2.Controls.Add(this.btnViewResults);
            this.guna2Panel2.CustomizableEdges.BottomRight = false;
            this.guna2Panel2.CustomizableEdges.TopRight = false;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(163, 476);
            this.guna2Panel2.TabIndex = 7;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(28, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(106, 40);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "User Panel";
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.BorderRadius = 10;
            this.btnStartQuiz.FillColor = System.Drawing.Color.White;
            this.btnStartQuiz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStartQuiz.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnStartQuiz.Location = new System.Drawing.Point(12, 97);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(140, 33);
            this.btnStartQuiz.TabIndex = 2;
            this.btnStartQuiz.Text = "Start Quiz";
            // 
            // btnViewResults
            // 
            this.btnViewResults.BorderRadius = 10;
            this.btnViewResults.FillColor = System.Drawing.Color.White;
            this.btnViewResults.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewResults.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnViewResults.Location = new System.Drawing.Point(12, 144);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(140, 33);
            this.btnViewResults.TabIndex = 3;
            this.btnViewResults.Text = "View Results";
            // 
            // pblSub
            // 
            this.pblSub.Location = new System.Drawing.Point(169, 71);
            this.pblSub.Name = "pblSub";
            this.pblSub.Size = new System.Drawing.Size(596, 387);
            this.pblSub.TabIndex = 8;
            // 
            // btnUserLogout
            // 
            this.btnUserLogout.BorderRadius = 10;
            this.btnUserLogout.FillColor = System.Drawing.Color.SeaGreen;
            this.btnUserLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserLogout.ForeColor = System.Drawing.Color.White;
            this.btnUserLogout.Location = new System.Drawing.Point(675, 15);
            this.btnUserLogout.Name = "btnUserLogout";
            this.btnUserLogout.Size = new System.Drawing.Size(90, 33);
            this.btnUserLogout.TabIndex = 1;
            this.btnUserLogout.Text = "Log out";
            // 
            // temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.UserPanel);
            this.Name = "temp";
            this.Text = "temp";
            this.UserPanel.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel UserPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnStartQuiz;
        private Guna.UI2.WinForms.Guna2Button btnViewResults;
        private Guna.UI2.WinForms.Guna2Panel pblSub;
        private Guna.UI2.WinForms.Guna2Button btnUserLogout;
    }
}