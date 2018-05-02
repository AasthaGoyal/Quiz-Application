using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class RegisterNewUser : Form
    {
        public RegisterNewUser()
        {
            InitializeComponent();
        }

        private void btmRegister_Click(object sender, EventArgs e)
        {
            adminLoginTableAdapter.AddNewUser(txtFullName.Text, txtUsername.Text, txtPassword.Text);
            MessageBox.Show("The user has been succesfully added");
        }

        private void adminLoginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adminLoginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbQuizAppDataSet);

        }

        private void RegisterNewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbQuizAppDataSet.AdminLogin' table. You can move, or remove it, as needed.
            this.adminLoginTableAdapter.Fill(this.dbQuizAppDataSet.AdminLogin);

        }

        private void adminLoginBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btmLogin2_Click(object sender, EventArgs e)
        {
            new FormAdminLogin().Show();
        }
    }
}
