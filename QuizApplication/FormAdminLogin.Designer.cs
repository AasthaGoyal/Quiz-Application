namespace QuizApplication
{
    partial class FormAdminLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btmLogin = new System.Windows.Forms.Button();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.dbQuizAppDataSet = new QuizApplication.dbQuizAppDataSet();
            this.tblQuizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblQuizTableAdapter = new QuizApplication.dbQuizAppDataSetTableAdapters.tblQuizTableAdapter();
            this.tableAdapterManager = new QuizApplication.dbQuizAppDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQuizAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(227, 66);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(227, 109);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // btmLogin
            // 
            this.btmLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmLogin.Location = new System.Drawing.Point(459, 152);
            this.btmLogin.Name = "btmLogin";
            this.btmLogin.Size = new System.Drawing.Size(97, 39);
            this.btmLogin.TabIndex = 3;
            this.btmLogin.Text = "Login";
            this.btmLogin.UseVisualStyleBackColor = true;
            this.btmLogin.Click += new System.EventHandler(this.btmLogin_Click);
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.Location = new System.Drawing.Point(348, 65);
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(208, 20);
            this.txtUserLogin.TabIndex = 4;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(348, 109);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(208, 20);
            this.txtPasswordLogin.TabIndex = 5;
            // 
            // dbQuizAppDataSet
            // 
            this.dbQuizAppDataSet.DataSetName = "dbQuizAppDataSet";
            this.dbQuizAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblQuizBindingSource
            // 
            this.tblQuizBindingSource.DataMember = "tblQuiz";
            this.tblQuizBindingSource.DataSource = this.dbQuizAppDataSet;
            // 
            // tblQuizTableAdapter
            // 
            this.tblQuizTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminLoginTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblQuizTableAdapter = this.tblQuizTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuizApplication.dbQuizAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 203);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.btmLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAdminLogin";
            this.Text = "FormAdminLogin";
            this.Load += new System.EventHandler(this.FormAdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbQuizAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuizBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btmLogin;
        private System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private dbQuizAppDataSet dbQuizAppDataSet;
        private System.Windows.Forms.BindingSource tblQuizBindingSource;
        private dbQuizAppDataSetTableAdapters.tblQuizTableAdapter tblQuizTableAdapter;
        private dbQuizAppDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}