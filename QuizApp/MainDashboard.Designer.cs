namespace QuizApp
{
    partial class MainDashboard
    {
        private System.ComponentModel.IContainer components = null;

        // Panels
        private Guna.UI2.WinForms.Guna2Panel AdminPanel;
        private Guna.UI2.WinForms.Guna2Panel pnlAddQuiz;
        private Guna.UI2.WinForms.Guna2Panel AdminSidebar;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AdminPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAddQue = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbCorAns = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCorAns = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOpt4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOpt4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOpt3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOpt3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOpt2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOpt2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOpt1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblOpt1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbQuizSet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblQuizSet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQueName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.pnlShowAttempts = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvAttempts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlShowUsers = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvShowUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlShowQues = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvShowQues = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlShowQuiz = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvQuizSet = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlAddQuiz = new Guna.UI2.WinForms.Guna2Panel();
            this.txtQuizName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuizName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtQuizDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuizDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSubmitQuiz = new Guna.UI2.WinForms.Guna2Button();
            this.AdminSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnShowQue = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddQue = new Guna.UI2.WinForms.Guna2Button();
            this.lblTabName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnShowQuiz = new Guna.UI2.WinForms.Guna2Button();
            this.btnRecentAttempts = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddQuiz = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdminLogout = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.UserPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlHistory = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlUserProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.btnShowUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.pnlUpdate = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUpdateName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtUpdateEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUpdateName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUpdateEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlQuizDash = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.lblTimer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQuestion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnOptionA = new Guna.UI2.WinForms.Guna2Button();
            this.btnOptionB = new Guna.UI2.WinForms.Guna2Button();
            this.btnOptionC = new Guna.UI2.WinForms.Guna2Button();
            this.btnOptionD = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubmitAttempt = new Guna.UI2.WinForms.Guna2Button();
            this.UserSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUserTabName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewResults = new Guna.UI2.WinForms.Guna2Button();
            this.pnlQuizList = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvQuizList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUserLogout = new Guna.UI2.WinForms.Guna2Button();
            this.AdminPanel.SuspendLayout();
            this.pnlAddQue.SuspendLayout();
            this.pnlShowAttempts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttempts)).BeginInit();
            this.pnlShowUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUsers)).BeginInit();
            this.pnlShowQues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowQues)).BeginInit();
            this.pnlShowQuiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuizSet)).BeginInit();
            this.pnlAddQuiz.SuspendLayout();
            this.AdminSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.UserPanel.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.pnlUserProfile.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlQuizDash.SuspendLayout();
            this.UserSidebar.SuspendLayout();
            this.pnlQuizList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuizList)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminPanel
            // 
            this.AdminPanel.BorderColor = System.Drawing.Color.Gray;
            this.AdminPanel.BorderRadius = 10;
            this.AdminPanel.BorderThickness = 1;
            this.AdminPanel.Controls.Add(this.pnlAddQue);
            this.AdminPanel.Controls.Add(this.pnlShowAttempts);
            this.AdminPanel.Controls.Add(this.pnlShowUsers);
            this.AdminPanel.Controls.Add(this.pnlShowQues);
            this.AdminPanel.Controls.Add(this.pnlShowQuiz);
            this.AdminPanel.Controls.Add(this.pnlAddQuiz);
            this.AdminPanel.Controls.Add(this.AdminSidebar);
            this.AdminPanel.Controls.Add(this.btnAdminLogout);
            this.AdminPanel.Location = new System.Drawing.Point(3, 7);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(1235, 516);
            this.AdminPanel.TabIndex = 1;
            this.AdminPanel.Visible = false;
            // 
            // pnlAddQue
            // 
            this.pnlAddQue.BorderColor = System.Drawing.Color.Silver;
            this.pnlAddQue.BorderRadius = 5;
            this.pnlAddQue.BorderThickness = 1;
            this.pnlAddQue.Controls.Add(this.cmbCorAns);
            this.pnlAddQue.Controls.Add(this.lblCorAns);
            this.pnlAddQue.Controls.Add(this.txtOpt4);
            this.pnlAddQue.Controls.Add(this.lblOpt4);
            this.pnlAddQue.Controls.Add(this.txtOpt3);
            this.pnlAddQue.Controls.Add(this.lblOpt3);
            this.pnlAddQue.Controls.Add(this.txtOpt2);
            this.pnlAddQue.Controls.Add(this.lblOpt2);
            this.pnlAddQue.Controls.Add(this.txtOpt1);
            this.pnlAddQue.Controls.Add(this.lblOpt1);
            this.pnlAddQue.Controls.Add(this.cmbQuizSet);
            this.pnlAddQue.Controls.Add(this.lblQuizSet);
            this.pnlAddQue.Controls.Add(this.txtQuestion);
            this.pnlAddQue.Controls.Add(this.lblQueName);
            this.pnlAddQue.Controls.Add(this.btnAdd);
            this.pnlAddQue.Location = new System.Drawing.Point(175, 75);
            this.pnlAddQue.Name = "pnlAddQue";
            this.pnlAddQue.Size = new System.Drawing.Size(1050, 432);
            this.pnlAddQue.TabIndex = 13;
            this.pnlAddQue.Visible = false;
            // 
            // cmbCorAns
            // 
            this.cmbCorAns.AutoRoundedCorners = true;
            this.cmbCorAns.BackColor = System.Drawing.Color.Transparent;
            this.cmbCorAns.BorderRadius = 17;
            this.cmbCorAns.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCorAns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorAns.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCorAns.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCorAns.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbCorAns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCorAns.ItemHeight = 30;
            this.cmbCorAns.Items.AddRange(new object[] {
            "---Correct Answer---",
            "A",
            "B",
            "C",
            "D"});
            this.cmbCorAns.Location = new System.Drawing.Point(50, 300);
            this.cmbCorAns.Name = "cmbCorAns";
            this.cmbCorAns.Size = new System.Drawing.Size(220, 36);
            this.cmbCorAns.StartIndex = 0;
            this.cmbCorAns.TabIndex = 16;
            // 
            // lblCorAns
            // 
            this.lblCorAns.BackColor = System.Drawing.Color.Transparent;
            this.lblCorAns.Location = new System.Drawing.Point(50, 279);
            this.lblCorAns.Name = "lblCorAns";
            this.lblCorAns.Size = new System.Drawing.Size(75, 15);
            this.lblCorAns.TabIndex = 15;
            this.lblCorAns.Text = "Correct Answer";
            // 
            // txtOpt4
            // 
            this.txtOpt4.BorderRadius = 5;
            this.txtOpt4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOpt4.DefaultText = "";
            this.txtOpt4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOpt4.Location = new System.Drawing.Point(304, 242);
            this.txtOpt4.Multiline = true;
            this.txtOpt4.Name = "txtOpt4";
            this.txtOpt4.PasswordChar = '\0';
            this.txtOpt4.PlaceholderText = "Enter Option D";
            this.txtOpt4.SelectedText = "";
            this.txtOpt4.Size = new System.Drawing.Size(239, 35);
            this.txtOpt4.TabIndex = 12;
            // 
            // lblOpt4
            // 
            this.lblOpt4.BackColor = System.Drawing.Color.Transparent;
            this.lblOpt4.Location = new System.Drawing.Point(304, 217);
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
            this.txtOpt3.Location = new System.Drawing.Point(52, 242);
            this.txtOpt3.Multiline = true;
            this.txtOpt3.Name = "txtOpt3";
            this.txtOpt3.PasswordChar = '\0';
            this.txtOpt3.PlaceholderText = "Enter Option C";
            this.txtOpt3.SelectedText = "";
            this.txtOpt3.Size = new System.Drawing.Size(239, 35);
            this.txtOpt3.TabIndex = 10;
            // 
            // lblOpt3
            // 
            this.lblOpt3.BackColor = System.Drawing.Color.Transparent;
            this.lblOpt3.Location = new System.Drawing.Point(52, 217);
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
            this.txtOpt2.Location = new System.Drawing.Point(304, 178);
            this.txtOpt2.Multiline = true;
            this.txtOpt2.Name = "txtOpt2";
            this.txtOpt2.PasswordChar = '\0';
            this.txtOpt2.PlaceholderText = "Enter Option B";
            this.txtOpt2.SelectedText = "";
            this.txtOpt2.Size = new System.Drawing.Size(239, 35);
            this.txtOpt2.TabIndex = 8;
            // 
            // lblOpt2
            // 
            this.lblOpt2.BackColor = System.Drawing.Color.Transparent;
            this.lblOpt2.Location = new System.Drawing.Point(304, 153);
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
            this.txtOpt1.Location = new System.Drawing.Point(52, 178);
            this.txtOpt1.Multiline = true;
            this.txtOpt1.Name = "txtOpt1";
            this.txtOpt1.PasswordChar = '\0';
            this.txtOpt1.PlaceholderText = "Enter Option A";
            this.txtOpt1.SelectedText = "";
            this.txtOpt1.Size = new System.Drawing.Size(239, 35);
            this.txtOpt1.TabIndex = 6;
            // 
            // lblOpt1
            // 
            this.lblOpt1.BackColor = System.Drawing.Color.Transparent;
            this.lblOpt1.Location = new System.Drawing.Point(52, 153);
            this.lblOpt1.Name = "lblOpt1";
            this.lblOpt1.Size = new System.Drawing.Size(44, 15);
            this.lblOpt1.TabIndex = 7;
            this.lblOpt1.Text = "Option A";
            // 
            // cmbQuizSet
            // 
            this.cmbQuizSet.AutoRoundedCorners = true;
            this.cmbQuizSet.BackColor = System.Drawing.Color.Transparent;
            this.cmbQuizSet.BorderRadius = 17;
            this.cmbQuizSet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbQuizSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuizSet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbQuizSet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbQuizSet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmbQuizSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbQuizSet.ItemHeight = 30;
            this.cmbQuizSet.Items.AddRange(new object[] {
            "---Category---"});
            this.cmbQuizSet.Location = new System.Drawing.Point(50, 34);
            this.cmbQuizSet.Name = "cmbQuizSet";
            this.cmbQuizSet.Size = new System.Drawing.Size(220, 36);
            this.cmbQuizSet.StartIndex = 0;
            this.cmbQuizSet.TabIndex = 5;
            // 
            // lblQuizSet
            // 
            this.lblQuizSet.BackColor = System.Drawing.Color.Transparent;
            this.lblQuizSet.Location = new System.Drawing.Point(50, 12);
            this.lblQuizSet.Name = "lblQuizSet";
            this.lblQuizSet.Size = new System.Drawing.Size(46, 15);
            this.lblQuizSet.TabIndex = 1;
            this.lblQuizSet.Text = "Quiz Set:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.BorderRadius = 5;
            this.txtQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuestion.DefaultText = "";
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuestion.Location = new System.Drawing.Point(50, 95);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.PasswordChar = '\0';
            this.txtQuestion.PlaceholderText = "Enter Question";
            this.txtQuestion.SelectedText = "";
            this.txtQuestion.Size = new System.Drawing.Size(494, 50);
            this.txtQuestion.TabIndex = 2;
            // 
            // lblQueName
            // 
            this.lblQueName.BackColor = System.Drawing.Color.Transparent;
            this.lblQueName.Location = new System.Drawing.Point(50, 70);
            this.lblQueName.Name = "lblQueName";
            this.lblQueName.Size = new System.Drawing.Size(48, 15);
            this.lblQueName.TabIndex = 3;
            this.lblQueName.Text = "Question:\r\n";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.FillColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(50, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            // 
            // pnlShowAttempts
            // 
            this.pnlShowAttempts.BackColor = System.Drawing.Color.Transparent;
            this.pnlShowAttempts.BorderColor = System.Drawing.Color.Transparent;
            this.pnlShowAttempts.BorderRadius = 10;
            this.pnlShowAttempts.BorderThickness = 1;
            this.pnlShowAttempts.Controls.Add(this.dgvAttempts);
            this.pnlShowAttempts.FillColor = System.Drawing.Color.Transparent;
            this.pnlShowAttempts.Location = new System.Drawing.Point(175, 75);
            this.pnlShowAttempts.Name = "pnlShowAttempts";
            this.pnlShowAttempts.Size = new System.Drawing.Size(1050, 432);
            this.pnlShowAttempts.TabIndex = 12;
            this.pnlShowAttempts.Visible = false;
            // 
            // dgvAttempts
            // 
            this.dgvAttempts.AllowUserToAddRows = false;
            this.dgvAttempts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAttempts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttempts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttempts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttempts.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttempts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAttempts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAttempts.Location = new System.Drawing.Point(9, 8);
            this.dgvAttempts.Name = "dgvAttempts";
            this.dgvAttempts.ReadOnly = true;
            this.dgvAttempts.RowHeadersVisible = false;
            this.dgvAttempts.RowTemplate.Height = 25;
            this.dgvAttempts.Size = new System.Drawing.Size(1043, 415);
            this.dgvAttempts.TabIndex = 1;
            this.dgvAttempts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAttempts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAttempts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAttempts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAttempts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAttempts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAttempts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAttempts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SeaGreen;
            this.dgvAttempts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAttempts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAttempts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAttempts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAttempts.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvAttempts.ThemeStyle.ReadOnly = true;
            this.dgvAttempts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAttempts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAttempts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAttempts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAttempts.ThemeStyle.RowsStyle.Height = 25;
            this.dgvAttempts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAttempts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlShowUsers
            // 
            this.pnlShowUsers.BackColor = System.Drawing.Color.Transparent;
            this.pnlShowUsers.BorderColor = System.Drawing.Color.Transparent;
            this.pnlShowUsers.BorderRadius = 10;
            this.pnlShowUsers.BorderThickness = 1;
            this.pnlShowUsers.Controls.Add(this.dgvShowUsers);
            this.pnlShowUsers.FillColor = System.Drawing.Color.Transparent;
            this.pnlShowUsers.Location = new System.Drawing.Point(175, 75);
            this.pnlShowUsers.Name = "pnlShowUsers";
            this.pnlShowUsers.Size = new System.Drawing.Size(1050, 432);
            this.pnlShowUsers.TabIndex = 11;
            this.pnlShowUsers.Visible = false;
            // 
            // dgvShowUsers
            // 
            this.dgvShowUsers.AllowUserToAddRows = false;
            this.dgvShowUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvShowUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowUsers.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowUsers.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShowUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShowUsers.Location = new System.Drawing.Point(7, 8);
            this.dgvShowUsers.Name = "dgvShowUsers";
            this.dgvShowUsers.ReadOnly = true;
            this.dgvShowUsers.RowHeadersVisible = false;
            this.dgvShowUsers.RowTemplate.Height = 25;
            this.dgvShowUsers.Size = new System.Drawing.Size(1043, 415);
            this.dgvShowUsers.TabIndex = 1;
            this.dgvShowUsers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvShowUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvShowUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvShowUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvShowUsers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowUsers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShowUsers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SeaGreen;
            this.dgvShowUsers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvShowUsers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowUsers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShowUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowUsers.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvShowUsers.ThemeStyle.ReadOnly = true;
            this.dgvShowUsers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowUsers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvShowUsers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowUsers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvShowUsers.ThemeStyle.RowsStyle.Height = 25;
            this.dgvShowUsers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShowUsers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlShowQues
            // 
            this.pnlShowQues.BackColor = System.Drawing.Color.Transparent;
            this.pnlShowQues.BorderColor = System.Drawing.Color.Transparent;
            this.pnlShowQues.BorderRadius = 10;
            this.pnlShowQues.BorderThickness = 1;
            this.pnlShowQues.Controls.Add(this.dgvShowQues);
            this.pnlShowQues.FillColor = System.Drawing.Color.Transparent;
            this.pnlShowQues.Location = new System.Drawing.Point(175, 75);
            this.pnlShowQues.Name = "pnlShowQues";
            this.pnlShowQues.Size = new System.Drawing.Size(1050, 432);
            this.pnlShowQues.TabIndex = 10;
            this.pnlShowQues.Visible = false;
            // 
            // dgvShowQues
            // 
            this.dgvShowQues.AllowUserToAddRows = false;
            this.dgvShowQues.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvShowQues.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvShowQues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowQues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvShowQues.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowQues.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvShowQues.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShowQues.Location = new System.Drawing.Point(7, 8);
            this.dgvShowQues.Name = "dgvShowQues";
            this.dgvShowQues.ReadOnly = true;
            this.dgvShowQues.RowHeadersVisible = false;
            this.dgvShowQues.RowTemplate.Height = 25;
            this.dgvShowQues.Size = new System.Drawing.Size(1043, 415);
            this.dgvShowQues.TabIndex = 1;
            this.dgvShowQues.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowQues.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvShowQues.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvShowQues.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvShowQues.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvShowQues.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowQues.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShowQues.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SeaGreen;
            this.dgvShowQues.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvShowQues.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowQues.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShowQues.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowQues.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvShowQues.ThemeStyle.ReadOnly = true;
            this.dgvShowQues.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowQues.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvShowQues.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowQues.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvShowQues.ThemeStyle.RowsStyle.Height = 25;
            this.dgvShowQues.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShowQues.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlShowQuiz
            // 
            this.pnlShowQuiz.BackColor = System.Drawing.Color.Transparent;
            this.pnlShowQuiz.BorderColor = System.Drawing.Color.Transparent;
            this.pnlShowQuiz.BorderRadius = 10;
            this.pnlShowQuiz.BorderThickness = 1;
            this.pnlShowQuiz.Controls.Add(this.dgvQuizSet);
            this.pnlShowQuiz.FillColor = System.Drawing.Color.Transparent;
            this.pnlShowQuiz.Location = new System.Drawing.Point(175, 75);
            this.pnlShowQuiz.Name = "pnlShowQuiz";
            this.pnlShowQuiz.Size = new System.Drawing.Size(1050, 432);
            this.pnlShowQuiz.TabIndex = 9;
            this.pnlShowQuiz.Visible = false;
            // 
            // dgvQuizSet
            // 
            this.dgvQuizSet.AllowUserToAddRows = false;
            this.dgvQuizSet.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvQuizSet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvQuizSet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuizSet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvQuizSet.ColumnHeadersHeight = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuizSet.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvQuizSet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQuizSet.Location = new System.Drawing.Point(7, 8);
            this.dgvQuizSet.Name = "dgvQuizSet";
            this.dgvQuizSet.ReadOnly = true;
            this.dgvQuizSet.RowHeadersVisible = false;
            this.dgvQuizSet.RowTemplate.Height = 25;
            this.dgvQuizSet.Size = new System.Drawing.Size(1043, 415);
            this.dgvQuizSet.TabIndex = 1;
            this.dgvQuizSet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQuizSet.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQuizSet.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQuizSet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQuizSet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQuizSet.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvQuizSet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQuizSet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SeaGreen;
            this.dgvQuizSet.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQuizSet.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQuizSet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQuizSet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQuizSet.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQuizSet.ThemeStyle.ReadOnly = true;
            this.dgvQuizSet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQuizSet.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQuizSet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQuizSet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQuizSet.ThemeStyle.RowsStyle.Height = 25;
            this.dgvQuizSet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQuizSet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.pnlAddQuiz.Location = new System.Drawing.Point(175, 75);
            this.pnlAddQuiz.Name = "pnlAddQuiz";
            this.pnlAddQuiz.Size = new System.Drawing.Size(1050, 432);
            this.pnlAddQuiz.TabIndex = 7;
            this.pnlAddQuiz.Visible = false;
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
            this.txtQuizDescription.Multiline = true;
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
            this.btnSubmitQuiz.Click += new System.EventHandler(this.btnSubmitQuiz_Click);
            // 
            // AdminSidebar
            // 
            this.AdminSidebar.BackColor = System.Drawing.Color.SeaGreen;
            this.AdminSidebar.BorderRadius = 10;
            this.AdminSidebar.Controls.Add(this.btnShowQue);
            this.AdminSidebar.Controls.Add(this.btnAddQue);
            this.AdminSidebar.Controls.Add(this.lblTabName);
            this.AdminSidebar.Controls.Add(this.btnShowQuiz);
            this.AdminSidebar.Controls.Add(this.btnRecentAttempts);
            this.AdminSidebar.Controls.Add(this.btnShowUsers);
            this.AdminSidebar.Controls.Add(this.btnAddQuiz);
            this.AdminSidebar.Location = new System.Drawing.Point(0, 0);
            this.AdminSidebar.Name = "AdminSidebar";
            this.AdminSidebar.Size = new System.Drawing.Size(163, 516);
            this.AdminSidebar.TabIndex = 6;
            // 
            // btnShowQue
            // 
            this.btnShowQue.BorderRadius = 10;
            this.btnShowQue.FillColor = System.Drawing.Color.White;
            this.btnShowQue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowQue.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnShowQue.Location = new System.Drawing.Point(14, 255);
            this.btnShowQue.Name = "btnShowQue";
            this.btnShowQue.Size = new System.Drawing.Size(140, 33);
            this.btnShowQue.TabIndex = 8;
            this.btnShowQue.Text = "Show Questions";
            this.btnShowQue.Click += new System.EventHandler(this.btnShowQue_Click);
            // 
            // btnAddQue
            // 
            this.btnAddQue.BorderRadius = 10;
            this.btnAddQue.FillColor = System.Drawing.Color.White;
            this.btnAddQue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddQue.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddQue.Location = new System.Drawing.Point(14, 178);
            this.btnAddQue.Name = "btnAddQue";
            this.btnAddQue.Size = new System.Drawing.Size(140, 33);
            this.btnAddQue.TabIndex = 7;
            this.btnAddQue.Text = "Add Questions";
            this.btnAddQue.Click += new System.EventHandler(this.btnAddQue_Click);
            // 
            // lblTabName
            // 
            this.lblTabName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTabName.BackColor = System.Drawing.Color.Transparent;
            this.lblTabName.Font = new System.Drawing.Font("Microsoft Uighur", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTabName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTabName.Location = new System.Drawing.Point(14, 34);
            this.lblTabName.Name = "lblTabName";
            this.lblTabName.Size = new System.Drawing.Size(134, 33);
            this.lblTabName.TabIndex = 6;
            this.lblTabName.Text = "Welcome, Admin";
            // 
            // btnShowQuiz
            // 
            this.btnShowQuiz.BorderRadius = 10;
            this.btnShowQuiz.FillColor = System.Drawing.Color.White;
            this.btnShowQuiz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowQuiz.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnShowQuiz.Location = new System.Drawing.Point(14, 217);
            this.btnShowQuiz.Name = "btnShowQuiz";
            this.btnShowQuiz.Size = new System.Drawing.Size(140, 33);
            this.btnShowQuiz.TabIndex = 2;
            this.btnShowQuiz.Text = "Show Quiz";
            this.btnShowQuiz.Click += new System.EventHandler(this.btnShowQuiz_Click);
            // 
            // btnRecentAttempts
            // 
            this.btnRecentAttempts.BorderRadius = 10;
            this.btnRecentAttempts.FillColor = System.Drawing.Color.White;
            this.btnRecentAttempts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecentAttempts.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRecentAttempts.Location = new System.Drawing.Point(14, 333);
            this.btnRecentAttempts.Name = "btnRecentAttempts";
            this.btnRecentAttempts.Size = new System.Drawing.Size(140, 33);
            this.btnRecentAttempts.TabIndex = 5;
            this.btnRecentAttempts.Text = "Recent Attempts";
            this.btnRecentAttempts.Click += new System.EventHandler(this.btnRecentAttempts_Click);
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.BorderRadius = 10;
            this.btnShowUsers.FillColor = System.Drawing.Color.White;
            this.btnShowUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnShowUsers.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnShowUsers.Location = new System.Drawing.Point(14, 294);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(140, 33);
            this.btnShowUsers.TabIndex = 4;
            this.btnShowUsers.Text = "Show Users";
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // btnAddQuiz
            // 
            this.btnAddQuiz.BorderRadius = 10;
            this.btnAddQuiz.FillColor = System.Drawing.Color.White;
            this.btnAddQuiz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddQuiz.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddQuiz.Location = new System.Drawing.Point(14, 139);
            this.btnAddQuiz.Name = "btnAddQuiz";
            this.btnAddQuiz.Size = new System.Drawing.Size(140, 33);
            this.btnAddQuiz.TabIndex = 3;
            this.btnAddQuiz.Text = "Add Quiz";
            this.btnAddQuiz.Click += new System.EventHandler(this.btnAddQuiz_Click);
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.BorderRadius = 10;
            this.btnAdminLogout.FillColor = System.Drawing.Color.SeaGreen;
            this.btnAdminLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdminLogout.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogout.Location = new System.Drawing.Point(1129, 15);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(90, 33);
            this.btnAdminLogout.TabIndex = 0;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // UserPanel
            // 
            this.UserPanel.BorderColor = System.Drawing.Color.Gray;
            this.UserPanel.BorderRadius = 10;
            this.UserPanel.BorderThickness = 1;
            this.UserPanel.Controls.Add(this.pnlHistory);
            this.UserPanel.Controls.Add(this.pnlUserProfile);
            this.UserPanel.Controls.Add(this.pnlQuizDash);
            this.UserPanel.Controls.Add(this.UserSidebar);
            this.UserPanel.Controls.Add(this.pnlQuizList);
            this.UserPanel.Controls.Add(this.btnUserLogout);
            this.UserPanel.Location = new System.Drawing.Point(3, 7);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(1235, 516);
            this.UserPanel.TabIndex = 4;
            this.UserPanel.Visible = false;
            // 
            // pnlHistory
            // 
            this.pnlHistory.BorderColor = System.Drawing.Color.Transparent;
            this.pnlHistory.BorderRadius = 15;
            this.pnlHistory.BorderThickness = 1;
            this.pnlHistory.Controls.Add(this.guna2DataGridView1);
            this.pnlHistory.FillColor = System.Drawing.Color.Transparent;
            this.pnlHistory.Location = new System.Drawing.Point(213, 54);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(1012, 432);
            this.pnlHistory.TabIndex = 21;
            this.pnlHistory.Visible = false;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.guna2DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.guna2DataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(3, 3);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 25;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1043, 415);
            this.guna2DataGridView1.TabIndex = 2;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnlUserProfile
            // 
            this.pnlUserProfile.BorderColor = System.Drawing.Color.Transparent;
            this.pnlUserProfile.BorderRadius = 15;
            this.pnlUserProfile.BorderThickness = 1;
            this.pnlUserProfile.Controls.Add(this.btnShowUpdate);
            this.pnlUserProfile.Controls.Add(this.pnlUpdate);
            this.pnlUserProfile.Controls.Add(this.lblEmail);
            this.pnlUserProfile.Controls.Add(this.guna2HtmlLabel4);
            this.pnlUserProfile.Controls.Add(this.guna2HtmlLabel5);
            this.pnlUserProfile.Controls.Add(this.lblName);
            this.pnlUserProfile.Controls.Add(this.guna2HtmlLabel3);
            this.pnlUserProfile.Controls.Add(this.guna2HtmlLabel2);
            this.pnlUserProfile.FillColor = System.Drawing.Color.Transparent;
            this.pnlUserProfile.Location = new System.Drawing.Point(213, 54);
            this.pnlUserProfile.Name = "pnlUserProfile";
            this.pnlUserProfile.Size = new System.Drawing.Size(1012, 432);
            this.pnlUserProfile.TabIndex = 9;
            this.pnlUserProfile.Visible = false;
            // 
            // btnShowUpdate
            // 
            this.btnShowUpdate.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnShowUpdate.BorderRadius = 10;
            this.btnShowUpdate.BorderThickness = 1;
            this.btnShowUpdate.FillColor = System.Drawing.Color.SeaGreen;
            this.btnShowUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUpdate.ForeColor = System.Drawing.Color.White;
            this.btnShowUpdate.Location = new System.Drawing.Point(168, 213);
            this.btnShowUpdate.Name = "btnShowUpdate";
            this.btnShowUpdate.Size = new System.Drawing.Size(140, 30);
            this.btnShowUpdate.TabIndex = 20;
            this.btnShowUpdate.Text = "Update Profile";
            this.btnShowUpdate.Click += new System.EventHandler(this.btnShowUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.lblUpdateName);
            this.pnlUpdate.Controls.Add(this.txtUpdateEmail);
            this.pnlUpdate.Controls.Add(this.txtUpdateName);
            this.pnlUpdate.Controls.Add(this.lblUpdateEmail);
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Location = new System.Drawing.Point(624, 102);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(269, 204);
            this.pnlUpdate.TabIndex = 19;
            this.pnlUpdate.Visible = false;
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateName.Location = new System.Drawing.Point(12, 17);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(31, 15);
            this.lblUpdateName.TabIndex = 16;
            this.lblUpdateName.Text = "Name";
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.BorderRadius = 5;
            this.txtUpdateEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdateEmail.DefaultText = "";
            this.txtUpdateEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUpdateEmail.Location = new System.Drawing.Point(12, 106);
            this.txtUpdateEmail.Multiline = true;
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.PasswordChar = '\0';
            this.txtUpdateEmail.PlaceholderText = "Email";
            this.txtUpdateEmail.SelectedText = "";
            this.txtUpdateEmail.Size = new System.Drawing.Size(239, 35);
            this.txtUpdateEmail.TabIndex = 17;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.BorderRadius = 5;
            this.txtUpdateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpdateName.DefaultText = "";
            this.txtUpdateName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUpdateName.Location = new System.Drawing.Point(12, 42);
            this.txtUpdateName.Multiline = true;
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.PasswordChar = '\0';
            this.txtUpdateName.PlaceholderText = "Name";
            this.txtUpdateName.SelectedText = "";
            this.txtUpdateName.Size = new System.Drawing.Size(239, 35);
            this.txtUpdateName.TabIndex = 15;
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateEmail.Location = new System.Drawing.Point(12, 81);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(28, 15);
            this.lblUpdateEmail.TabIndex = 18;
            this.lblUpdateEmail.Text = "Email";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.FillColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(99, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 32);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(275, 174);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 18);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "name";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(233, 167);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(10, 27);
            this.guna2HtmlLabel4.TabIndex = 13;
            this.guna2HtmlLabel4.Text = ":";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(153, 174);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(42, 18);
            this.guna2HtmlLabel5.TabIndex = 12;
            this.guna2HtmlLabel5.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(275, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 18);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "name";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(233, 136);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(10, 27);
            this.guna2HtmlLabel3.TabIndex = 10;
            this.guna2HtmlLabel3.Text = ":";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(153, 144);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(44, 18);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "Name";
            // 
            // pnlQuizDash
            // 
            this.pnlQuizDash.BorderColor = System.Drawing.Color.Transparent;
            this.pnlQuizDash.BorderRadius = 15;
            this.pnlQuizDash.BorderThickness = 1;
            this.pnlQuizDash.Controls.Add(this.btnNext);
            this.pnlQuizDash.Controls.Add(this.lblTimer);
            this.pnlQuizDash.Controls.Add(this.lblQuestion);
            this.pnlQuizDash.Controls.Add(this.btnOptionA);
            this.pnlQuizDash.Controls.Add(this.btnOptionB);
            this.pnlQuizDash.Controls.Add(this.btnOptionC);
            this.pnlQuizDash.Controls.Add(this.btnOptionD);
            this.pnlQuizDash.Controls.Add(this.btnSubmitAttempt);
            this.pnlQuizDash.FillColor = System.Drawing.Color.Transparent;
            this.pnlQuizDash.Location = new System.Drawing.Point(213, 73);
            this.pnlQuizDash.Name = "pnlQuizDash";
            this.pnlQuizDash.Size = new System.Drawing.Size(1012, 432);
            this.pnlQuizDash.TabIndex = 0;
            this.pnlQuizDash.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnNext.BorderRadius = 10;
            this.btnNext.BorderThickness = 1;
            this.btnNext.FillColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNext.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNext.Location = new System.Drawing.Point(702, 310);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(170, 45);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTimer.Location = new System.Drawing.Point(662, 25);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 23);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "Time Left: 60";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = false;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblQuestion.Location = new System.Drawing.Point(142, 54);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(700, 50);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(700, 50);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question will be displayed here.";
            this.lblQuestion.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOptionA
            // 
            this.btnOptionA.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnOptionA.BorderRadius = 10;
            this.btnOptionA.BorderThickness = 1;
            this.btnOptionA.FillColor = System.Drawing.Color.White;
            this.btnOptionA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOptionA.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOptionA.Location = new System.Drawing.Point(142, 182);
            this.btnOptionA.Name = "btnOptionA";
            this.btnOptionA.Size = new System.Drawing.Size(350, 45);
            this.btnOptionA.TabIndex = 3;
            this.btnOptionA.Text = "Option A";
            this.btnOptionA.Click += new System.EventHandler(this.btnOptionA_Click);
            // 
            // btnOptionB
            // 
            this.btnOptionB.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnOptionB.BorderRadius = 10;
            this.btnOptionB.BorderThickness = 1;
            this.btnOptionB.FillColor = System.Drawing.Color.White;
            this.btnOptionB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOptionB.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOptionB.Location = new System.Drawing.Point(522, 182);
            this.btnOptionB.Name = "btnOptionB";
            this.btnOptionB.Size = new System.Drawing.Size(350, 45);
            this.btnOptionB.TabIndex = 4;
            this.btnOptionB.Text = "Option B";
            this.btnOptionB.Click += new System.EventHandler(this.btnOptionB_Click);
            // 
            // btnOptionC
            // 
            this.btnOptionC.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnOptionC.BorderRadius = 10;
            this.btnOptionC.BorderThickness = 1;
            this.btnOptionC.FillColor = System.Drawing.Color.White;
            this.btnOptionC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOptionC.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOptionC.Location = new System.Drawing.Point(142, 242);
            this.btnOptionC.Name = "btnOptionC";
            this.btnOptionC.Size = new System.Drawing.Size(350, 45);
            this.btnOptionC.TabIndex = 5;
            this.btnOptionC.Text = "Option C";
            this.btnOptionC.Click += new System.EventHandler(this.btnOptionC_Click);
            // 
            // btnOptionD
            // 
            this.btnOptionD.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnOptionD.BorderRadius = 10;
            this.btnOptionD.BorderThickness = 1;
            this.btnOptionD.FillColor = System.Drawing.Color.White;
            this.btnOptionD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOptionD.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOptionD.Location = new System.Drawing.Point(522, 242);
            this.btnOptionD.Name = "btnOptionD";
            this.btnOptionD.Size = new System.Drawing.Size(350, 45);
            this.btnOptionD.TabIndex = 6;
            this.btnOptionD.Text = "Option D";
            this.btnOptionD.Click += new System.EventHandler(this.btnOptionD_Click);
            // 
            // btnSubmitAttempt
            // 
            this.btnSubmitAttempt.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnSubmitAttempt.BorderRadius = 10;
            this.btnSubmitAttempt.BorderThickness = 1;
            this.btnSubmitAttempt.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSubmitAttempt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSubmitAttempt.ForeColor = System.Drawing.Color.White;
            this.btnSubmitAttempt.Location = new System.Drawing.Point(142, 310);
            this.btnSubmitAttempt.Name = "btnSubmitAttempt";
            this.btnSubmitAttempt.Size = new System.Drawing.Size(170, 45);
            this.btnSubmitAttempt.TabIndex = 7;
            this.btnSubmitAttempt.Text = "Submit";
            // 
            // UserSidebar
            // 
            this.UserSidebar.BackColor = System.Drawing.Color.SeaGreen;
            this.UserSidebar.BorderRadius = 20;
            this.UserSidebar.Controls.Add(this.lblUserTabName);
            this.UserSidebar.Controls.Add(this.btnProfile);
            this.UserSidebar.Controls.Add(this.btnViewResults);
            this.UserSidebar.CustomizableEdges.BottomRight = false;
            this.UserSidebar.CustomizableEdges.TopRight = false;
            this.UserSidebar.Location = new System.Drawing.Point(0, 0);
            this.UserSidebar.Name = "UserSidebar";
            this.UserSidebar.Size = new System.Drawing.Size(207, 516);
            this.UserSidebar.TabIndex = 7;
            // 
            // lblUserTabName
            // 
            this.lblUserTabName.BackColor = System.Drawing.Color.SeaGreen;
            this.lblUserTabName.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold);
            this.lblUserTabName.ForeColor = System.Drawing.Color.Transparent;
            this.lblUserTabName.Location = new System.Drawing.Point(29, 20);
            this.lblUserTabName.Name = "lblUserTabName";
            this.lblUserTabName.Size = new System.Drawing.Size(148, 40);
            this.lblUserTabName.TabIndex = 0;
            this.lblUserTabName.Text = "WelCome User";
            // 
            // btnProfile
            // 
            this.btnProfile.BorderRadius = 10;
            this.btnProfile.FillColor = System.Drawing.Color.White;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProfile.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnProfile.Location = new System.Drawing.Point(30, 139);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(140, 33);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnViewResults
            // 
            this.btnViewResults.BorderRadius = 10;
            this.btnViewResults.FillColor = System.Drawing.Color.White;
            this.btnViewResults.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewResults.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnViewResults.Location = new System.Drawing.Point(30, 195);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(140, 33);
            this.btnViewResults.TabIndex = 3;
            this.btnViewResults.Text = "Show History";
            // 
            // pnlQuizList
            // 
            this.pnlQuizList.Controls.Add(this.dgvQuizList);
            this.pnlQuizList.Location = new System.Drawing.Point(213, 75);
            this.pnlQuizList.Name = "pnlQuizList";
            this.pnlQuizList.Size = new System.Drawing.Size(1012, 432);
            this.pnlQuizList.TabIndex = 8;
            // 
            // dgvQuizList
            // 
            this.dgvQuizList.AllowUserToAddRows = false;
            this.dgvQuizList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvQuizList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvQuizList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuizList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvQuizList.ColumnHeadersHeight = 30;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuizList.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvQuizList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQuizList.Location = new System.Drawing.Point(9, 6);
            this.dgvQuizList.Name = "dgvQuizList";
            this.dgvQuizList.ReadOnly = true;
            this.dgvQuizList.RowHeadersVisible = false;
            this.dgvQuizList.RowTemplate.Height = 25;
            this.dgvQuizList.Size = new System.Drawing.Size(995, 423);
            this.dgvQuizList.TabIndex = 2;
            this.dgvQuizList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQuizList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvQuizList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvQuizList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvQuizList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvQuizList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvQuizList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQuizList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.SeaGreen;
            this.dgvQuizList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQuizList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQuizList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvQuizList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQuizList.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvQuizList.ThemeStyle.ReadOnly = true;
            this.dgvQuizList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvQuizList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvQuizList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvQuizList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvQuizList.ThemeStyle.RowsStyle.Height = 25;
            this.dgvQuizList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvQuizList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnUserLogout
            // 
            this.btnUserLogout.BorderRadius = 10;
            this.btnUserLogout.FillColor = System.Drawing.Color.SeaGreen;
            this.btnUserLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUserLogout.ForeColor = System.Drawing.Color.White;
            this.btnUserLogout.Location = new System.Drawing.Point(1129, 15);
            this.btnUserLogout.Name = "btnUserLogout";
            this.btnUserLogout.Size = new System.Drawing.Size(90, 33);
            this.btnUserLogout.TabIndex = 1;
            this.btnUserLogout.Text = "Log out";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 561);
            this.Controls.Add(this.UserPanel);
            this.Controls.Add(this.AdminPanel);
            this.Name = "MainDashboard";
            this.Text = "Quiz App - Admin Dashboard";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.AdminPanel.ResumeLayout(false);
            this.pnlAddQue.ResumeLayout(false);
            this.pnlAddQue.PerformLayout();
            this.pnlShowAttempts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttempts)).EndInit();
            this.pnlShowUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowUsers)).EndInit();
            this.pnlShowQues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowQues)).EndInit();
            this.pnlShowQuiz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuizSet)).EndInit();
            this.pnlAddQuiz.ResumeLayout(false);
            this.pnlAddQuiz.PerformLayout();
            this.AdminSidebar.ResumeLayout(false);
            this.AdminSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.UserPanel.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.pnlUserProfile.ResumeLayout(false);
            this.pnlUserProfile.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.pnlQuizDash.ResumeLayout(false);
            this.pnlQuizDash.PerformLayout();
            this.UserSidebar.ResumeLayout(false);
            this.UserSidebar.PerformLayout();
            this.pnlQuizList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuizList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTabName;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private Guna.UI2.WinForms.Guna2Button btnAddQue;
        private Guna.UI2.WinForms.Guna2Button btnShowQue;
        private Guna.UI2.WinForms.Guna2Panel pnlShowQuiz;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQuizSet;
        private Guna.UI2.WinForms.Guna2Panel pnlShowQues;
        private Guna.UI2.WinForms.Guna2DataGridView dgvShowQues;
        private Guna.UI2.WinForms.Guna2Panel pnlShowUsers;
        private Guna.UI2.WinForms.Guna2DataGridView dgvShowUsers;
        private Guna.UI2.WinForms.Guna2Panel pnlShowAttempts;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAttempts;
        private Guna.UI2.WinForms.Guna2Panel UserPanel;
        private Guna.UI2.WinForms.Guna2Panel UserSidebar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserTabName;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnViewResults;
        private Guna.UI2.WinForms.Guna2Panel pnlQuizList;
        private Guna.UI2.WinForms.Guna2Button btnUserLogout;
        private Guna.UI2.WinForms.Guna2DataGridView dgvQuizList;
        private Guna.UI2.WinForms.Guna2Panel pnlQuizDash;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTimer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuestion;
        private Guna.UI2.WinForms.Guna2Button btnOptionA;
        private Guna.UI2.WinForms.Guna2Button btnOptionB;
        private Guna.UI2.WinForms.Guna2Button btnOptionC;
        private Guna.UI2.WinForms.Guna2Button btnOptionD;
        private Guna.UI2.WinForms.Guna2Button btnSubmitAttempt;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Panel pnlAddQue;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCorAns;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCorAns;
        private Guna.UI2.WinForms.Guna2TextBox txtOpt4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOpt4;
        private Guna.UI2.WinForms.Guna2TextBox txtOpt3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOpt3;
        private Guna.UI2.WinForms.Guna2TextBox txtOpt2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOpt2;
        private Guna.UI2.WinForms.Guna2TextBox txtOpt1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOpt1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbQuizSet;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuizSet;
        private Guna.UI2.WinForms.Guna2TextBox txtQuestion;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQueName;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Panel pnlUserProfile;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Panel pnlUpdate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUpdateName;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdateEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtUpdateName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUpdateEmail;
        private Guna.UI2.WinForms.Guna2Button btnShowUpdate;
        private Guna.UI2.WinForms.Guna2Panel pnlHistory;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}
