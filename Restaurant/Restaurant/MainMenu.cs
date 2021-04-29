using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(String user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                btnAdd.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
            }
            else if (user == "Admin")
            {
                btnAdd.Show();
                btnUpdate.Show();
                btnRemove.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginform = new LoginForm();
            this.Hide();
            loginform.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uCAdd1.Visible = true;
            uCAdd1.BringToFront();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            uCAdd1.Visible = false;
        }
    }
}
