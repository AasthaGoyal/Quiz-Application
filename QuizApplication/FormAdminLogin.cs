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
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void tblQuizBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblQuizBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbQuizAppDataSet);

        }

        private void FormAdminLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbQuizAppDataSet.tblQuiz' table. You can move, or remove it, as needed.
            this.tblQuizTableAdapter.Fill(this.dbQuizAppDataSet.tblQuiz);

        }

        private void btmLogin_Click(object sender, EventArgs e)
        {
            string userName = tblQuizTableAdapter.CheckUser(txtUserLogin.Text, txtPasswordLogin.Text);
            if (userName == "")
                MessageBox.Show("Invalid Username and Password combination");
            else
                MessageBox.Show("Welcome " + userName);
        }
    }
}
