
namespace usedauction
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Login_Img = new System.Windows.Forms.PictureBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_PW = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Login_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_Img
            // 
            this.Login_Img.Image = ((System.Drawing.Image)(resources.GetObject("Login_Img.Image")));
            this.Login_Img.Location = new System.Drawing.Point(0, -1);
            this.Login_Img.Name = "Login_Img";
            this.Login_Img.Size = new System.Drawing.Size(253, 164);
            this.Login_Img.TabIndex = 0;
            this.Login_Img.TabStop = false;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(25, 176);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PlaceholderText = "ID";
            this.txt_ID.Size = new System.Drawing.Size(195, 23);
            this.txt_ID.TabIndex = 1;
            // 
            // txt_PW
            // 
            this.txt_PW.Location = new System.Drawing.Point(25, 208);
            this.txt_PW.Name = "txt_PW";
            this.txt_PW.PasswordChar = '*';
            this.txt_PW.PlaceholderText = "Password";
            this.txt_PW.Size = new System.Drawing.Size(195, 23);
            this.txt_PW.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(25, 237);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(195, 23);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "로그인";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(25, 266);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(195, 23);
            this.btn_signup.TabIndex = 4;
            this.btn_signup.Text = "회원가입";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(113)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(254, 311);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_PW);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.Login_Img);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Login_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Login_Img;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_PW;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signup;
    }
}

