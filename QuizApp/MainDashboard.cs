using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class MainDashboard : Form
    {
        private void MainDashboard_Load(object sender, EventArgs e)
        {
            CenterToScreen();  // Centers the form on the screen when loaded
        }

        public MainDashboard(int role, string username)
        {
            InitializeComponent();
            AdminPanel.Visible = false;
            //UserPanel.Visible = false;

            if (role == 1)
            {
                AdminPanel.Visible = true;
                //UserPanel.Visible = false;
            }
            else if (role == 2)
            {
                //UserPanel.Visible = true;
                AdminPanel.Visible = false;
            }
        }

        private void btnUserLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
