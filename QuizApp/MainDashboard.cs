using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace QuizApp
{
    public partial class MainDashboard : Form
    {
        string conStr;
        SqlConnection con;
        SqlCommand cmd;
        private int currentQuestionIndex = 0;
        private List<Question> questions;
        private System.Windows.Forms.Timer quizTimer;
        private int timeRemaining, timetaken = 0, uid, qid, score = 0, up_quizid, up_queid;
        void getCon()
        {
            conStr = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            con = new SqlConnection(conStr);
            con.Open();
        }
        private void MainDashboard_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        public MainDashboard(int user, int role, string username)
        {
            InitializeComponent();
            AdminPanel.Visible = false;
            UserPanel.Visible = false;
            uid = user;

            if (role == 1)
            {
                AdminPanel.Visible = true;
                UserPanel.Visible = false;
                lblTabName.Text = "Welcome " + username;
                pnlAddQue.Visible = false;
                pnlAddQuiz.Visible = false;
                pnlShowAttempts.Visible = false;
                pnlShowUsers.Visible = false;
                pnlShowQues.Visible = false;
                pnlShowQuiz.Visible = true;
                lblTabName.Text = "Quizes";
                LoadQuizData();

            }
            else if (role == 2)
            {
                UserPanel.Visible = true;
                AdminPanel.Visible = false;
                lblUserTabName.Text = "Welcome " + username;
                LoadQuizSets();
                ConfigureQuizSetGrid();
            }
        }

        private bool ValidateQueForm()
        {
            bool isValid = true;
            errorProvider2.Clear();
            if (cmbQuizSet.SelectedIndex == 0)
            {
                errorProvider2.SetError(cmbQuizSet, "Please select a valid quiz set.");
                isValid = false;
            }
            if (cmbCorAns.SelectedIndex == 0)
            {
                errorProvider2.SetError(cmbQuizSet, "Please select a valid correct option.");
                isValid = false;
            }

            List<Guna.UI2.WinForms.Guna2TextBox> gunaTextFields = new List<Guna.UI2.WinForms.Guna2TextBox> { txtQuestion, txtOpt1, txtOpt2, txtOpt3, txtOpt4 };

            foreach (var textField in gunaTextFields)
            {
                if (string.IsNullOrWhiteSpace(textField.Text))
                {
                    errorProvider2.SetError(textField, "This field cannot be empty.");
                    isValid = false;
                }
                else
                {
                    errorProvider2.SetError(textField, string.Empty);
                }
            }

            return isValid;
        }


        private bool ValidateQuizForm()
        {
            bool isValid = true;
            errorProvider2.Clear();

            List<Guna.UI2.WinForms.Guna2TextBox> gunaTextFields = new List<Guna.UI2.WinForms.Guna2TextBox> { txtQuizName, txtQuizDescription };

            foreach (var textField in gunaTextFields)
            {
                if (string.IsNullOrWhiteSpace(textField.Text))
                {
                    errorProvider2.SetError(textField, "This field cannot be empty.");
                    isValid = false;
                }
                else
                {
                    errorProvider2.SetError(textField, string.Empty);
                }
            }
            return isValid;
        }
        private void btnSubmitQuiz_Click(object sender, EventArgs e)
        {
            getCon();
            if (ValidateQuizForm())
            {
                if (btnSubmitQuiz.Text == "Update")
                {
                    cmd = new SqlCommand("update QuizSet_tbl set QuizSet_Title=@title,QuizSet_Desc=@desc where QuizSet_Id=@quizset", con);
                    cmd.Parameters.AddWithValue("@title", txtQuizName.Text);
                    cmd.Parameters.AddWithValue("@desc", txtQuizDescription.Text);
                    cmd.Parameters.AddWithValue("@quizset", up_quizid);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Quiz set updated successfully!");
                }
                else
                {
                    cmd = new SqlCommand("Insert into QuizSet_tbl (QuizSet_Title,QuizSet_Desc) values (@title,@desc)", con);
                    cmd.Parameters.AddWithValue("@title", txtQuizName.Text);
                    cmd.Parameters.AddWithValue("@desc", txtQuizDescription.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Quiz set inserted successfully!");
                }
                clear();
                pnlAddQue.Visible = false;
                pnlAddQuiz.Visible = false;
                pnlShowAttempts.Visible = false;
                pnlShowUsers.Visible = false;
                pnlShowQues.Visible = false;
                pnlShowQuiz.Visible = true;
                LoadQuizData();
            }
        }

        private void btnAddQuiz_Click(object sender, EventArgs e)
        {
            pnlShowQuiz.Visible = false;
            pnlAddQue.Visible = false;
            pnlShowAttempts.Visible = false;
            pnlShowQues.Visible = false;
            pnlShowUsers.Visible = false;
            pnlAddQuiz.Visible = true;
            lblTabName.Text = "Add QuizSet";
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out successfully.");
            Form1 lf = new Form1();
            lf.Show();
            this.Close();
        }
        private void fillCombo()
        {
            try
            {
                getCon();
                string query = "SELECT QuizSet_ID, QuizSet_Title FROM QuizSet_tbl";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow newRow = dt.NewRow();
                newRow["QuizSet_ID"] = 0;
                newRow["QuizSet_Title"] = "---Category---";
                dt.Rows.InsertAt(newRow, 0);

                cmbQuizSet.DisplayMember = "QuizSet_Title";
                cmbQuizSet.ValueMember = "QuizSet_ID";
                cmbQuizSet.DataSource = dt;

                cmbQuizSet.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAddQue_Click(object sender, EventArgs e)
        {
            pnlAddQuiz.Visible = false;
            pnlShowQuiz.Visible = false;
            pnlShowQues.Visible = false;
            pnlShowUsers.Visible = false;
            pnlShowAttempts.Visible = false;
            pnlAddQue.Visible = true;
            lblTabName.Text = "Add Questions";
            fillCombo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getCon();
            if (ValidateQueForm())
            {
                if (btnAdd.Text == "Update")
                {
                    cmd = new SqlCommand("update Question_tbl set Que_Set_Id=@qid, Que_Text=@qText, Option1=@op1, Option2=@op2, Option3=@op3, Option4=@op4, Correct=@cor where Que_Id=@que", con);
                    cmd.Parameters.AddWithValue("@qid", cmbQuizSet.SelectedValue);
                    cmd.Parameters.AddWithValue("@qText", txtQuestion.Text);
                    cmd.Parameters.AddWithValue("@op1", txtOpt1.Text);
                    cmd.Parameters.AddWithValue("@op2", txtOpt2.Text);
                    cmd.Parameters.AddWithValue("@op3", txtOpt3.Text);
                    cmd.Parameters.AddWithValue("@op4", txtOpt4.Text);
                    cmd.Parameters.AddWithValue("@cor", cmbCorAns.SelectedItem);
                    cmd.Parameters.AddWithValue("@que", up_queid);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question updated successfully!");
                }
                else
                {
                    cmd = new SqlCommand("Insert into Question_tbl (Que_Set_Id, Que_Text, Option1, Option2, Option3, Option4, Correct ) values (@qid, @qText, @op1, @op2, @op3, @op4, @cor)", con);
                    cmd.Parameters.AddWithValue("@qid", cmbQuizSet.SelectedValue);
                    cmd.Parameters.AddWithValue("@qText", txtQuestion.Text);
                    cmd.Parameters.AddWithValue("@op1", txtOpt1.Text);
                    cmd.Parameters.AddWithValue("@op2", txtOpt2.Text);
                    cmd.Parameters.AddWithValue("@op3", txtOpt3.Text);
                    cmd.Parameters.AddWithValue("@op4", txtOpt4.Text);
                    cmd.Parameters.AddWithValue("@cor", cmbCorAns.SelectedItem);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question inserted successfully!");
                }
                clear();
                pnlAddQue.Visible = false;
                pnlAddQuiz.Visible = false;
                pnlShowAttempts.Visible = false;
                pnlShowQuiz.Visible = true;
                pnlShowUsers.Visible = false;
                pnlShowQues.Visible = false;
                LoadQuizData();

            }
        }
        private void LoadQuizData()
        {
            try
            {
                getCon();
                string query = "SELECT QuizSet_Id AS [Sr. No.], QuizSet_Title AS [Quiz Category], QuizSet_Desc AS [Quiz Description] FROM QuizSet_tbl";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvQuizSet.DataSource = dt;

                if (dgvQuizSet.Columns["View"] == null)
                {
                    DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
                    viewButtonColumn.Name = "View";
                    viewButtonColumn.Text = "View Questions";
                    viewButtonColumn.UseColumnTextForButtonValue = true;
                    dgvQuizSet.Columns.Add(viewButtonColumn);
                }

                if (dgvQuizSet.Columns["Edit"] == null)
                {
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                    editButtonColumn.Name = "Edit";
                    editButtonColumn.Text = "Edit";
                    editButtonColumn.UseColumnTextForButtonValue = true;
                    dgvQuizSet.Columns.Add(editButtonColumn);
                }

                if (dgvQuizSet.Columns["Delete"] == null)
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                    deleteButtonColumn.Name = "Delete";
                    deleteButtonColumn.Text = "Delete";
                    deleteButtonColumn.UseColumnTextForButtonValue = true;
                    dgvQuizSet.Columns.Add(deleteButtonColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading quiz data: " + ex.Message);
            }
        }
        private void dgvQuizSet_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            PaintButtonInCell(dgvQuizSet, e, "View", "View Questions");
            PaintButtonInCell(dgvQuizSet, e, "Edit", "Edit");
            PaintButtonInCell(dgvQuizSet, e, "Delete", "Delete");
        }

        private void dgvQuizSet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            qid = Convert.ToInt32(dgvQuizSet.Rows[e.RowIndex].Cells["Sr. No."].Value);
            if (e.RowIndex >= 0)
            {
                if (dgvQuizSet.Columns[e.ColumnIndex].Name == "View")
                {
                    string quizCategory = dgvQuizSet.Rows[e.RowIndex].Cells["Quiz Category"].Value.ToString();
                    MessageBox.Show("View questions for: " + quizCategory);
                    LoadQuesData(qid);
                    pnlAddQuiz.Visible = false;
                    pnlAddQue.Visible = false;
                    pnlShowAttempts.Visible = false;
                    pnlShowUsers.Visible = false;
                    pnlShowQues.Visible = true;
                    pnlShowQuiz.Visible = false;
                }
                else if (dgvQuizSet.Columns[e.ColumnIndex].Name == "Edit")
                {
                    string quizCategory = dgvQuizSet.Rows[e.RowIndex].Cells["Quiz Category"].Value.ToString();
                    MessageBox.Show("Edit quiz set: " + quizCategory);
                    fillAddQuiz(qid);
                    pnlAddQuiz.Visible = true;
                    pnlAddQue.Visible = false;
                    pnlShowAttempts.Visible = false;
                    pnlShowUsers.Visible = false;
                    pnlShowQues.Visible = false;
                    pnlShowQuiz.Visible = false;
                }
                else if (dgvQuizSet.Columns[e.ColumnIndex].Name == "Delete")
                {
                    string quizCategory = dgvQuizSet.Rows[e.RowIndex].Cells["Quiz Category"].Value.ToString();
                    var confirmResult = MessageBox.Show("Are you sure to delete this quiz set: " + quizCategory,
                                                        "Confirm Delete",
                                                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("delete from QuizSet_tbl where QuizSet_Id=@quiz", con);
                        cmd.Parameters.AddWithValue("@quiz", qid);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Quiz set deleted: " + quizCategory);
                        LoadQuizData();
                    }
                }
            }
        }
        void fillAddQuiz(int qid)
        {
            try
            {
                getCon();
                string query = "SELECT QuizSet_Title, QuizSet_Desc FROM QuizSet_tbl WHERE QuizSet_ID = @QuizSet_ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@QuizSet_ID", qid);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtQuizName.Text = reader["QuizSet_Title"].ToString();
                    txtQuizDescription.Text = reader["QuizSet_Desc"].ToString();
                    up_quizid = qid;
                    btnSubmitQuiz.Text = "Update";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving quiz details: " + ex.Message);
            }

        }


        private void btnShowQuiz_Click(object sender, EventArgs e)
        {
            pnlAddQue.Visible = false;
            pnlAddQuiz.Visible = false;
            pnlShowAttempts.Visible = false;
            pnlShowUsers.Visible = false;
            pnlShowQues.Visible = false;
            pnlShowQuiz.Visible = true;
            lblTabName.Text = "Quizes";
            LoadQuizData();
        }

        private void LoadQuesData(int queid)
        {
            try
            {
                getCon();
                string query = @"SELECT Q.Que_Id, Q.Que_Text, Q.Option1, Q.Option2, Q.Option3, Q.Option4, Q.Correct, QS.QuizSet_Title FROM Question_tbl Q INNER JOIN QuizSet_tbl QS ON  Q.Que_Set_Id = QS.QuizSet_Id where Q.Que_Set_Id=@quesid";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@quesid", queid);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvShowQues.DataSource = dt;

                if (dgvShowQues.Columns["Edit"] == null)
                {
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                    editButtonColumn.Name = "Edit";
                    editButtonColumn.Text = "Edit";
                    editButtonColumn.UseColumnTextForButtonValue = true;
                    dgvShowQues.Columns.Add(editButtonColumn);
                }

                if (dgvShowQues.Columns["Delete"] == null)
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                    deleteButtonColumn.Name = "Delete";
                    deleteButtonColumn.Text = "Delete";
                    deleteButtonColumn.UseColumnTextForButtonValue = true;
                    dgvShowQues.Columns.Add(deleteButtonColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading quiz data: " + ex.Message);
            }
        }
        private void dgvShowQues_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            PaintButtonInCell(dgvShowQues, e, "Edit", "Edit");
            PaintButtonInCell(dgvShowQues, e, "Delete", "Delete");
        }
        private void dgvShowQues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            qid = Convert.ToInt32(dgvShowQues.Rows[e.RowIndex].Cells["Que_ID"].Value);
            if (e.RowIndex >= 0)
            {
                if (dgvShowQues.Columns[e.ColumnIndex].Name == "Edit")
                {
                    fillCombo();
                    fillAddQues(qid);
                    pnlAddQuiz.Visible = false;
                    pnlAddQue.Visible = true;
                    pnlShowAttempts.Visible = false;
                    pnlShowUsers.Visible = false;
                    pnlShowQues.Visible = false;
                    pnlShowQuiz.Visible = false;
                }
                else if (dgvShowQues.Columns[e.ColumnIndex].Name == "Delete")
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this question: ",
                                                        "Confirm Delete",
                                                        MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("delete from Question_tbl where Que_Id=@que", con);
                        cmd.Parameters.AddWithValue("@que", qid);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Question deleted!");
                        LoadQuesData(qid);
                    }
                }
            }
        }

        void fillAddQues(int qid)
        {
            try
            {
                getCon();
                string query = "SELECT * FROM Question_tbl WHERE Que_Id = @que";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@que", qid);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cmbQuizSet.SelectedValue = reader["Que_Set_Id"];
                    txtQuestion.Text = reader["Que_Text"].ToString();
                    txtOpt1.Text = reader["Option1"].ToString();
                    txtOpt2.Text = reader["Option2"].ToString();
                    txtOpt3.Text = reader["Option3"].ToString();
                    txtOpt4.Text = reader["Option4"].ToString();
                    cmbCorAns.SelectedItem = reader["Correct"];
                    up_queid = qid;
                    btnAdd.Text = "Update";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving quiz details: " + ex.Message);
            }

        }

        private void LoadUserData()
        {
            try
            {
                getCon();
                string query = "Select UserId AS [Sr. no.],Username AS [User], Email from Users_tbl where Roll!=1";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvShowUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading quiz data: " + ex.Message);
            }
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            pnlAddQue.Visible = false;
            pnlAddQuiz.Visible = false;
            pnlShowQuiz.Visible = false;
            pnlShowQues.Visible = false;
            pnlShowAttempts.Visible = false;
            pnlShowUsers.Visible = true;
            lblTabName.Text = "Users";
            LoadUserData();
        }
        private void btnAdminDash_Click(object sender, EventArgs e)
        {
            pnlAddQue.Visible = false;
            pnlAddQuiz.Visible = false;
            pnlShowQuiz.Visible = true;
            pnlShowAttempts.Visible = false;
            pnlShowUsers.Visible = false;
            pnlShowQues.Visible = false;
            lblTabName.Text = "Quizes";
        }
        private void btnRecentAttempts_Click(object sender, EventArgs e)
        {
            pnlAddQue.Visible = false;
            pnlAddQuiz.Visible = false;
            pnlShowQuiz.Visible = false;
            pnlShowQues.Visible = false;
            pnlShowUsers.Visible = false;
            pnlShowAttempts.Visible = true;
            lblTabName.Text = "Recents Attempts";
            LoadAttemptData();
        }
        private void LoadAttemptData()
        {
            try
            {
                getCon();
                string query = "SELECT A_Id AS[Sr No.], Username AS[Username],QuizSet_Title AS[Quiz set], Score AS [Score], Total_Que AS [Total Questions], TimeTaken AS [Time Taken], A_Date AS [Attempt Date], CASE WHEN Completion_Status = 1 THEN 'Complete' ELSE 'Incomplete' END AS[Status] FROM Attempts_tbl Join Users_tbl on A_U_Id=UserId Join QuizSet_tbl on A_Q_Id=Quizset_Id";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAttempts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading quiz data: " + ex.Message);
            }
        }
        private void clear()
        {
            cmbCorAns.SelectedIndex = 0;
            txtOpt1.Text = "";
            txtOpt2.Text = "";
            txtOpt3.Text = "";
            txtOpt4.Text = "";
            txtQuestion.Text = "";
            txtQuizDescription.Text = "";
            txtQuizName.Text = "";
            cmbQuizSet.SelectedIndex = 0;
        }


        //UserControl side
        private void LoadQuizSets()
        {
            try
            {
                getCon();
                string query = "SELECT ROW_NUMBER() OVER(ORDER BY QuizSet_ID) AS [Sr. No.], QuizSet_Title AS [Quiz Category], QuizSet_Desc AS [Quiz Description] FROM QuizSet_tbl";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvQuizList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading quiz sets: " + ex.Message);
            }
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlQuizDash.Visible = false;
            pnlUserProfile.Visible = true;
            pnlHistory.Visible = false;
            lblTabName.Text = "Profile";
            fillProfile(uid);
        }
        void fillProfile(int userid)
        {
            getCon();
            SqlDataAdapter da = new SqlDataAdapter("select * from Users_tbl where UserId='" + userid + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            lblName.Text = ds.Tables[0].Rows[0][1].ToString();
            lblEmail.Text = ds.Tables[0].Rows[0][2].ToString();
            txtUpdateName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtUpdateEmail.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void btnShowUpdate_Click(object sender, EventArgs e)
        {
            if (pnlUpdate.Visible)
            {
                pnlUpdate.Visible = false;
            }
            else
            {
                pnlUpdate.Visible = true;
            }
        }

        private void btnUserLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out successfully.");
            Form1 lf = new Form1();
            lf.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getCon();
            cmd = new SqlCommand("Update Users_tbl set Username=@user, Email=@eml where UserId=@userid", con);
            cmd.Parameters.AddWithValue("@user", txtUpdateName.Text);
            cmd.Parameters.AddWithValue("@eml", txtUpdateEmail.Text);
            cmd.Parameters.AddWithValue("@userid", uid);
            cmd.ExecuteNonQuery();
            clear();
            pnlUpdate.Visible = false;
            MessageBox.Show("Profile Updated");
            fillProfile(uid);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlQuizList.Visible = true;
            pnlUserProfile.Visible = false;
            pnlHistory.Visible = false;
            pnlQuizDash.Visible = false;
            lblUserTabName.Text = "Home";
        }

        private void ConfigureQuizSetGrid()
        {
            DataGridViewTextBoxColumn startLabelColumn = new DataGridViewTextBoxColumn();
            startLabelColumn.Name = "Start";
            startLabelColumn.HeaderText = "";
            startLabelColumn.ReadOnly = true;
            startLabelColumn.Width = 50;

            dgvQuizList.Columns.Add(startLabelColumn);
            dgvQuizList.CellClick += new DataGridViewCellEventHandler(dgvQuizList_CellClick);
            dgvQuizList.CellPainting += new DataGridViewCellPaintingEventHandler(dgvQuizList_CellPainting);
        }

        private void dgvQuizList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            PaintButtonInCell(dgvQuizList, e, "Start", "Start");
        }


        private void dgvQuizList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvQuizList.Columns["Start"].Index && e.RowIndex >= 0)
            {
                int selectedQuizSetId = Convert.ToInt32(dgvQuizList.Rows[e.RowIndex].Cells["Sr. No."].Value);

                StartQuiz(selectedQuizSetId);
            }
        }

        private void StartQuiz(int quizSetId)
        {
            MessageBox.Show("Starting quiz for QuizSet_Id: " + quizSetId);
            pnlQuizList.Visible = false;
            pnlHistory.Visible = false;
            pnlUserProfile.Visible = false;
            pnlQuizDash.Visible = true;
            qid = quizSetId;
            questions = GetQuestionsByQuizId(quizSetId);

            if (questions.Count > 0)
            {
                currentQuestionIndex = 0;
                DisplayQuestion(questions[currentQuestionIndex], currentQuestionIndex + 1);
                if (quizSetId != 1)
                {
                    timeRemaining = 60;
                    lblTimer.Text = "Time left : 01:00";
                }
                else
                {
                    timeRemaining = 300;
                    lblTimer.Text = "Time left : 05:00";
                }
                lblTimer.ForeColor = Color.SeaGreen;
                quizTimer = new System.Windows.Forms.Timer();
                quizTimer.Interval = 1000;
                quizTimer.Tick += new EventHandler(OnTimerTick);
                quizTimer.Start();
            }
            else
            {
                MessageBox.Show("No questions found for this quiz.");
            }
        }
        private void OnTimerTick(object sender, EventArgs e)
        {
            timeRemaining--;
            timetaken++;

            lblTimer.Text = "Time left : " + string.Format("{0:D2}:{1:D2}", timeRemaining / 60, timeRemaining % 60);
            if (timeRemaining <= 60)
            {
                lblTimer.ForeColor = Color.Red;
            }
            if (timeRemaining <= 0)
            {
                quizTimer.Stop();
                MessageBox.Show("Time's up!");
                ShowScore();
                InsertAttempt(0);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveSelectedOption(questions[currentQuestionIndex].SelectedOption);

            currentQuestionIndex++;

            if (currentQuestionIndex < questions.Count)
            {
                DisplayQuestion(questions[currentQuestionIndex], currentQuestionIndex + 1);
            }
            else
            {
                quizTimer.Stop();
                ShowScore();
                InsertAttempt(1);
            }

            if (currentQuestionIndex == questions.Count - 1)
            {
                btnNext.Text = "Show Score";
            }
        }

        private void btnOptionA_Click(object sender, EventArgs e)
        {
            btnOptionB.FillColor = Color.White;
            btnOptionC.FillColor = Color.White;
            btnOptionD.FillColor = Color.White;
            btnOptionA.FillColor = Color.SeaGreen;

            btnOptionB.ForeColor = Color.SeaGreen;
            btnOptionC.ForeColor = Color.SeaGreen;
            btnOptionD.ForeColor = Color.SeaGreen;
            btnOptionA.ForeColor = Color.White;
            SaveSelectedOption("A");
        }

        private void btnOptionB_Click(object sender, EventArgs e)
        {
            btnOptionA.FillColor = Color.White;
            btnOptionC.FillColor = Color.White;
            btnOptionD.FillColor = Color.White;
            btnOptionB.FillColor = Color.SeaGreen;

            btnOptionA.ForeColor = Color.SeaGreen;
            btnOptionC.ForeColor = Color.SeaGreen;
            btnOptionD.ForeColor = Color.SeaGreen;
            btnOptionB.ForeColor = Color.White;
            SaveSelectedOption("B");
        }

        private void btnOptionC_Click(object sender, EventArgs e)
        {
            btnOptionA.FillColor = Color.White;
            btnOptionB.FillColor = Color.White;
            btnOptionD.FillColor = Color.White;
            btnOptionC.FillColor = Color.SeaGreen;

            btnOptionA.ForeColor = Color.SeaGreen;
            btnOptionB.ForeColor = Color.SeaGreen;
            btnOptionD.ForeColor = Color.SeaGreen;
            btnOptionC.ForeColor = Color.White;
            SaveSelectedOption("C");
        }

        private void btnOptionD_Click(object sender, EventArgs e)
        {
            btnOptionA.FillColor = Color.White;
            btnOptionB.FillColor = Color.White;
            btnOptionC.FillColor = Color.White;
            btnOptionD.FillColor = Color.SeaGreen;

            btnOptionB.ForeColor = Color.SeaGreen;
            btnOptionC.ForeColor = Color.SeaGreen;
            btnOptionA.ForeColor = Color.SeaGreen;
            btnOptionD.ForeColor = Color.White;
            SaveSelectedOption("D");
        }

        private void SaveSelectedOption(string selectedOption)
        {
            questions[currentQuestionIndex].SelectedOption = selectedOption;
        }

        private void ShowScore()
        {


            foreach (var question in questions)
            {
                if (question.SelectedOption == question.CorrectOption)
                {
                    score++;
                }
            }

            MessageBox.Show($"Your score: {score}/{questions.Count}");
            pnlQuizDash.Visible = false;
            pnlQuizList.Visible = true;
        }



        private void DisplayQuestion(Question question, int cur)
        {
            lblQuestion.Text = cur + ". " + question.QuestionText;
            btnOptionA.Text = "A. " + question.OptionA;
            btnOptionB.Text = "B. " + question.OptionB;
            btnOptionC.Text = "C. " + question.OptionC;
            btnOptionD.Text = "D. " + question.OptionD;

            btnOptionA.FillColor = Color.White;
            btnOptionB.FillColor = Color.White;
            btnOptionC.FillColor = Color.White;
            btnOptionD.FillColor = Color.White;

            btnOptionB.ForeColor = Color.SeaGreen;
            btnOptionC.ForeColor = Color.SeaGreen;
            btnOptionA.ForeColor = Color.SeaGreen;
            btnOptionD.ForeColor = Color.SeaGreen;

            question.SelectedOption = null;
        }


        private List<Question> GetQuestionsByQuizId(int quizSetId)
        {
            List<Question> questions = new List<Question>();

            try
            {
                getCon();
                string query = "SELECT Que_Text, Option1, Option2, Option3, Option4, Correct FROM Question_tbl WHERE Que_Set_Id = @quizSetId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@quizSetId", quizSetId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    questions.Add(new Question
                    {
                        QuestionText = reader["Que_Text"].ToString(),
                        OptionA = reader["Option1"].ToString(),
                        OptionB = reader["Option2"].ToString(),
                        OptionC = reader["Option3"].ToString(),
                        OptionD = reader["Option4"].ToString(),
                        CorrectOption = reader["Correct"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching questions: " + ex.Message);
            }

            return questions;
        }
        void InsertAttempt(int isComplete)
        {
            string tt = string.Format("{0:D2}:{1:D2}", timetaken / 60, timetaken % 60);
            getCon();
            cmd = new SqlCommand("Insert into Attempts_tbl (A_U_Id, A_Q_Id, Score, Total_Que, TimeTaken, A_Date, Completion_Status) values (@uid,@qsid,@score,@tq,@time,@date,@status)", con);
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@qsid", qid);
            cmd.Parameters.AddWithValue("@score", score);
            cmd.Parameters.AddWithValue("@tq", questions.Count);
            cmd.Parameters.AddWithValue("@time", tt);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@status", isComplete);
            cmd.ExecuteNonQuery();
        }
        private void btnViewResults_Click(object sender, EventArgs e)
        {
            pnlQuizDash.Visible = false;
            pnlUserProfile.Visible = false;
            pnlQuizList.Visible = false;
            pnlHistory.Visible = true;
            lblUserTabName.Text = "History";
            showHistory(uid);
        }

        void showHistory(int uid)
        {
            try
            {
                getCon();
                string query = @"SELECT 
                            ROW_NUMBER() OVER(ORDER BY A_Date DESC) AS [Sr.no.],  
                            QuizSet_Title AS [Quiz], 
                            Score, 
                            TimeTaken, 
                            A_Date AS [Date], 
                            CASE 
                                WHEN Completion_Status = 1 THEN 'Complete' 
                                ELSE 'Incomplete' 
                            END AS [Status]
                         FROM Attempts_tbl 
                         JOIN QuizSet_tbl ON A_Q_Id = QuizSet_Id 
                         JOIN Users_tbl ON UserId = A_U_Id 
                         WHERE A_U_Id = @UserId 
                         ORDER BY A_Date DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@UserId", uid);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvHistory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading quiz data: " + ex.Message);
            }
        }

        private void PaintButtonInCell(DataGridView dgv, DataGridViewCellPaintingEventArgs e, string columnName, string buttonText)
        {
            if (e.ColumnIndex == dgv.Columns[columnName].Index && e.RowIndex >= 0)
            {
                // Let the DataGridView paint the default cell background (including row selection color)
                e.PaintBackground(e.ClipBounds, true);

                // Measure the size of the button text
                Size textSize = TextRenderer.MeasureText(buttonText, e.CellStyle.Font);

                // Calculate the position to center the button within the cell
                int x = e.CellBounds.X + (e.CellBounds.Width - textSize.Width) / 2;
                int y = e.CellBounds.Y + (e.CellBounds.Height - textSize.Height) / 2;

                // Define the rectangle for the button with additional padding
                Rectangle textBackgroundRect = new Rectangle(x - 12, y - 6, textSize.Width + 24, textSize.Height + 12);

                // Set colors for the button's normal and selected states
                bool isRowSelected = dgv.Rows[e.RowIndex].Selected;
                Color buttonBackgroundColor = Color.SeaGreen;
                Color borderColor = isRowSelected ? Color.Green : Color.DarkSeaGreen;
                Color textColor = Color.White;

                // Draw the button background
                using (Brush buttonBrush = new SolidBrush(buttonBackgroundColor))
                {
                    e.Graphics.FillRectangle(buttonBrush, textBackgroundRect);
                }
                int textX = textBackgroundRect.X + (textBackgroundRect.Width - textSize.Width) / 2;
                int textY = textBackgroundRect.Y + (textBackgroundRect.Height - textSize.Height) / 2;

                // Draw the button border
                using (Pen borderPen = new Pen(borderColor))
                {
                    e.Graphics.DrawRectangle(borderPen, textBackgroundRect);
                }

                // Draw the button text in bold
                using (Font boldFont = new Font(e.CellStyle.Font, FontStyle.Bold))
                {
                    TextRenderer.DrawText(e.Graphics, buttonText, boldFont, new Point(x, y), textColor);
                }

                // Prevent default cell content painting (since we're custom painting)
                e.Handled = true;
            }
        }


    }
}