namespace QuanLyQuanCafe
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            panel1 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            txbPassWord = new TextBox();
            btnExit = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txbUserName = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(6, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 305);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(btnExit);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(btnLogin);
            panel4.Location = new Point(317, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 285);
            panel4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(29, 50);
            label1.Name = "label1";
            label1.Size = new Size(278, 33);
            label1.TabIndex = 3;
            label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(txbPassWord);
            panel3.Location = new Point(5, 168);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 50);
            panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // txbPassWord
            // 
            txbPassWord.BackColor = SystemColors.ButtonFace;
            txbPassWord.Location = new Point(86, 18);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.PlaceholderText = "Nhập mật khẩu";
            txbPassWord.Size = new Size(230, 23);
            txbPassWord.TabIndex = 1;
            txbPassWord.Text = "0";
            txbPassWord.UseSystemPasswordChar = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Teal;
            btnExit.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(29, 233);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 39);
            btnExit.TabIndex = 0;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txbUserName);
            panel2.Location = new Point(5, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 49);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // txbUserName
            // 
            txbUserName.BackColor = SystemColors.ButtonFace;
            txbUserName.ForeColor = SystemColors.InfoText;
            txbUserName.Location = new Point(86, 16);
            txbUserName.Name = "txbUserName";
            txbUserName.PlaceholderText = "Nhập tài khoản";
            txbUserName.Size = new Size(230, 23);
            txbUserName.TabIndex = 1;
            txbUserName.Text = "ad_linh";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Teal;
            btnLogin.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(176, 233);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(131, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(669, 320);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐĂNG NHẬP HỆ THỐNG";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txbPassWord;
        private Panel panel2;
        private TextBox txbUserName;
        private Button btnLogin;
        private Button btnExit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label label1;
    }
}