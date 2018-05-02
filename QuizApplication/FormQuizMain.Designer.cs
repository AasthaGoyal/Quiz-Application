namespace QuizApplication
{
    partial class FormQuizMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuizMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btmGo = new System.Windows.Forms.Button();
            this.btmAdmin = new System.Windows.Forms.Button();
            this.btmNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btmGo
            // 
            this.btmGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmGo.Location = new System.Drawing.Point(330, 192);
            this.btmGo.Name = "btmGo";
            this.btmGo.Size = new System.Drawing.Size(98, 58);
            this.btmGo.TabIndex = 2;
            this.btmGo.Text = "GO";
            this.btmGo.UseVisualStyleBackColor = true;
            this.btmGo.Click += new System.EventHandler(this.btmGo_Click);
            // 
            // btmAdmin
            // 
            this.btmAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAdmin.Location = new System.Drawing.Point(31, 262);
            this.btmAdmin.Name = "btmAdmin";
            this.btmAdmin.Size = new System.Drawing.Size(397, 69);
            this.btmAdmin.TabIndex = 3;
            this.btmAdmin.Text = "Access Administrator (Login)";
            this.btmAdmin.UseVisualStyleBackColor = true;
            this.btmAdmin.Click += new System.EventHandler(this.btmAdmin_Click);
            // 
            // btmNew
            // 
            this.btmNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmNew.Location = new System.Drawing.Point(31, 337);
            this.btmNew.Name = "btmNew";
            this.btmNew.Size = new System.Drawing.Size(397, 69);
            this.btmNew.TabIndex = 5;
            this.btmNew.Text = "New Registration";
            this.btmNew.UseVisualStyleBackColor = true;
            this.btmNew.Click += new System.EventHandler(this.btmNew_Click);
            // 
            // FormQuizMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 432);
            this.Controls.Add(this.btmNew);
            this.Controls.Add(this.btmAdmin);
            this.Controls.Add(this.btmGo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormQuizMain";
            this.Text = "FormQuizMain";
            this.Load += new System.EventHandler(this.FormQuizMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btmGo;
        private System.Windows.Forms.Button btmAdmin;
        private System.Windows.Forms.Button btmNew;
    }
}