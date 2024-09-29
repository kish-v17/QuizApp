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

        public MainDashboard(int role, string username)
        {
            InitializeComponent();
            AdminPanel.Visible = false;
            UserPanel.Visible = false;

            if (role == 1)
            {
                AdminPanel.Visible = true;
                UserPanel.Visible = false;
                lblUserTabName.Text = "Welcome " + username;
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
        private void ConfigureQuizSetGrid()
        {
            // Configure other columns before adding the button column

            // Add the Start Button column as the last column
            DataGridViewButtonColumn startButtonColumn = new DataGridViewButtonColumn();
            startButtonColumn.Name = "StartButton";
            startButtonColumn.HeaderText = "";  // No header text for the button column
            startButtonColumn.Text = "Start";   // The text to display on the button
            startButtonColumn.UseColumnTextForButtonValue = true;  // Show text on the button

            // Prevent the button from resizing according to text
            startButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            startButtonColumn.Width = 80; // Set a fixed width for the button column

            dgvQuizList.Columns.Add(startButtonColumn);  // Add the button as the last column

            // Add the event handler for button clicks
            dgvQuizList.CellClick += new DataGridViewCellEventHandler(dgvQuizSets_CellClick);
        }

        private void dgvQuizSets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvQuizList.Columns["StartButton"].Index && e.RowIndex >= 0)
            {
                // Get the QuizSet_Id from the corresponding row
                int selectedQuizSetId = Convert.ToInt32(dgvQuizList.Rows[e.RowIndex].Cells["Sr. No."].Value);

                // Call the method to start the quiz
                StartQuiz(selectedQuizSetId);
            }
        }

        private void StartQuiz(int quizSetId)
        {
            // Logic to start the quiz for the selected QuizSet_Id
            MessageBox.Show("Starting quiz for QuizSet_Id: " + quizSetId);
        }


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

        private bool ValidateQueForm()
        {
            bool isValid = true;
            errorProvider2.Clear();
            if (cmbQuizSet.SelectedIndex == 0)
            {
                errorProvider2.SetError(cmbQuizSet, "Please select a valid quiz set.");
                isValid = false;
            }

            List<Guna.UI2.WinForms.Guna2TextBox> gunaTextFields = new List<Guna.UI2.WinForms.Guna2TextBox>{txtQuestion,txtOpt1,txtOpt2,txtOpt3,txtOpt4,txtCorAns};

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

            List<Guna.UI2.WinForms.Guna2TextBox> gunaTextFields = new List<Guna.UI2.WinForms.Guna2TextBox> { txtQuizName,txtQuizDescription };

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
                cmd = new SqlCommand("Insert into QuizSet_tbl (QuizSet_Title,QuizSet_Desc) values (@title,@desc)", con);
                cmd.Parameters.AddWithValue("@title", txtQuizName.Text);
                cmd.Parameters.AddWithValue("@desc", txtQuizDescription.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Quiz set inserted successfully!");

                pnlAddQuiz.Visible = false;
                pnlAddQue.Visible = false;
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
                cmd = new SqlCommand("Insert into Question_tbl (Que_Set_Id, Que_Text, Option1, Option2, Option3, Option4, Correct ) values (@qid, @qText, @op1, @op2, @op3, @op4, @cor)", con);
                cmd.Parameters.AddWithValue("@qid", cmbQuizSet.SelectedValue);
                cmd.Parameters.AddWithValue("@qText", txtQuestion.Text);
                cmd.Parameters.AddWithValue("@op1", txtOpt1.Text);
                cmd.Parameters.AddWithValue("@op2", txtOpt2.Text);
                cmd.Parameters.AddWithValue("@op3", txtOpt3.Text);
                cmd.Parameters.AddWithValue("@op4", txtOpt4.Text);
                cmd.Parameters.AddWithValue("@cor", txtCorAns.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Question inserted successfully!");

                pnlAddQue.Visible = false;
                pnlAddQuiz.Visible = false;
                pnlShowQuiz.Visible = true;

            }
        }
        private void LoadQuizData()
        {
            try
            {
                getCon();
                string query = "SELECT ROW_NUMBER() OVER(ORDER BY QuizSet_ID) AS [Sr. No.], QuizSet_Title AS [Quiz Category], QuizSet_Desc AS [Quiz Description] FROM QuizSet_tbl";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvQuizSet.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading quiz data: " + ex.Message);
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

        private void LoadQuesData()
        {
            try
            {
                getCon();
                string query = @"SELECT Q.Que_Id, Q.Que_Text, Q.Option1, Q.Option2, Q.Option3, Q.Option4, Q.Correct, QS.QuizSet_Title FROM Question_tbl Q INNER JOIN QuizSet_tbl QS ON  Q.Que_Set_Id = QS.QuizSet_Id";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvShowQues.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading quiz data: " + ex.Message);
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


        private void btnShowQue_Click(object sender, EventArgs e)
        {
            pnlAddQue.Visible = false;
            pnlAddQuiz.Visible = false;
            pnlShowQuiz.Visible = false;
            pnlShowAttempts.Visible = false;
            pnlShowUsers.Visible = false;
            pnlShowQues.Visible = true;
            lblTabName.Text = "Questions";
            LoadQuesData();
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
    }

}
