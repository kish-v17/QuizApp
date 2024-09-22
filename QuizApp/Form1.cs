using System;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        string conStr;
        SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        void getCon()
        {
            conStr = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            con = new SqlConnection(conStr);
            con.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!(pnlLogin.Visible))
            {
                pnlLogin.Visible = true;
                pnlRegister.Visible = false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!(pnlRegister.Visible))
            {
                pnlLogin.Visible = false;
                pnlRegister.Visible = true;
            }
        }

        private void subRegister_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateForm(regEml, regPwd, regUsr, regCpwd);

            if (isValid)
            {
                insertUser(regUsr.Text,regEml.Text,regCpwd.Text);
            }
        }
        private void subLogin_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateForm(logEml ,logPwd);

            if (isValid)
            {
                if (checkLogin(logEml.Text, logPwd.Text)) 
                {
                    MessageBox.Show("Login Successfull!");
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password!");
                }
            }
        }

        private void insertUser(string username,string email,string password)
        {
            getCon();
            cmd = new SqlCommand("insert into Users_tbl(Username,Email,Password) values (@user,@eml,@pwd)", con);
            cmd.Parameters.AddWithValue("@user",username);
            cmd.Parameters.AddWithValue("@eml", email.ToLower());
            cmd.Parameters.AddWithValue("@pwd", password);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registration Successful!");
        }

        private bool checkLogin(string email,string password)
        {
            getCon();
            cmd = new SqlCommand("select count(*) from Users_tbl where Email= @email and Password=@pwd",con);
            cmd.Parameters.AddWithValue("@email", email.ToLower()) ;
            cmd.Parameters.AddWithValue("@pwd", password);
            int res = Convert.ToInt32(cmd.ExecuteScalar());
            return res > 0;
        }

        private bool isRegistered(string email)
        {
            getCon();
            cmd = new SqlCommand("select count(*) from Users_tbl where Email= @email", con);
            cmd.Parameters.AddWithValue("@email", email.ToLower());
            int res = Convert.ToInt32(cmd.ExecuteScalar());
            return res > 0;
        }

        private bool ValidateForm(Control email, Control password, Control username = null,Control confirmPassword = null)
        {
            bool isValid = true;
            errorProvider1.Clear();
            if (username != null && string.IsNullOrWhiteSpace(username.Text))
            {
                errorProvider1.SetError(username, "Username is required.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(email.Text) || !IsValidEmail(email.Text))
            {
                errorProvider1.SetError(email, "Enter a valid email.");
                isValid = false;
            }
            if (isRegistered(email.Text))
            {
                errorProvider1.SetError(email, "This email is already registered.");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                errorProvider1.SetError(password, "Password is required.");
                isValid = false;
            }
            if (confirmPassword != null && password.Text != confirmPassword.Text)
            {
                errorProvider1.SetError(confirmPassword, "Passwords do not match.");
                isValid = false;
            }

            return isValid;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return emailRegex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }
    }
}
