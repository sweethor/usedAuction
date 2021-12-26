
namespace usedauction
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackImg = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.txt_KaID = new System.Windows.Forms.TextBox();
            this.txt_EMail = new System.Windows.Forms.TextBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_NName = new System.Windows.Forms.TextBox();
            this.btn_CKNname = new System.Windows.Forms.Button();
            this.txt_PW = new System.Windows.Forms.TextBox();
            this.btn_CKID = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_des = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackImg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BackImg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 564);
            this.panel1.TabIndex = 0;
            // 
            // BackImg
            // 
            this.BackImg.Image = ((System.Drawing.Image)(resources.GetObject("BackImg.Image")));
            this.BackImg.Location = new System.Drawing.Point(0, 0);
            this.BackImg.Name = "BackImg";
            this.BackImg.Size = new System.Drawing.Size(347, 563);
            this.BackImg.TabIndex = 0;
            this.BackImg.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Cancle);
            this.panel2.Controls.Add(this.btn_SignUp);
            this.panel2.Controls.Add(this.txt_KaID);
            this.panel2.Controls.Add(this.txt_EMail);
            this.panel2.Controls.Add(this.txt_PhoneNumber);
            this.panel2.Controls.Add(this.txt_Name);
            this.panel2.Controls.Add(this.txt_NName);
            this.panel2.Controls.Add(this.btn_CKNname);
            this.panel2.Controls.Add(this.txt_PW);
            this.panel2.Controls.Add(this.btn_CKID);
            this.panel2.Controls.Add(this.txt_ID);
            this.panel2.Controls.Add(this.lbl_des);
            this.panel2.Controls.Add(this.lbl_title);
            this.panel2.Location = new System.Drawing.Point(-3, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 565);
            this.panel2.TabIndex = 1;
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancle.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancle.Location = new System.Drawing.Point(169, 506);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(153, 34);
            this.btn_Cancle.TabIndex = 12;
            this.btn_Cancle.Text = "취소";
            this.btn_Cancle.UseVisualStyleBackColor = false;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SignUp.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Location = new System.Drawing.Point(15, 506);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(153, 34);
            this.btn_SignUp.TabIndex = 11;
            this.btn_SignUp.Text = "회원가입";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // txt_KaID
            // 
            this.txt_KaID.Location = new System.Drawing.Point(15, 465);
            this.txt_KaID.Name = "txt_KaID";
            this.txt_KaID.PlaceholderText = "카카오톡ID";
            this.txt_KaID.Size = new System.Drawing.Size(307, 23);
            this.txt_KaID.TabIndex = 10;
            // 
            // txt_EMail
            // 
            this.txt_EMail.Location = new System.Drawing.Point(15, 415);
            this.txt_EMail.Name = "txt_EMail";
            this.txt_EMail.PlaceholderText = "E-Mail";
            this.txt_EMail.Size = new System.Drawing.Size(307, 23);
            this.txt_EMail.TabIndex = 9;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(15, 367);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.PlaceholderText = "전화번호";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(307, 23);
            this.txt_PhoneNumber.TabIndex = 8;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(15, 318);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PlaceholderText = "이름";
            this.txt_Name.Size = new System.Drawing.Size(307, 23);
            this.txt_Name.TabIndex = 7;
            // 
            // txt_NName
            // 
            this.txt_NName.Location = new System.Drawing.Point(15, 269);
            this.txt_NName.Name = "txt_NName";
            this.txt_NName.PlaceholderText = "계정명";
            this.txt_NName.Size = new System.Drawing.Size(184, 23);
            this.txt_NName.TabIndex = 6;
            // 
            // btn_CKNname
            // 
            this.btn_CKNname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CKNname.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_CKNname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CKNname.Location = new System.Drawing.Point(216, 269);
            this.btn_CKNname.Name = "btn_CKNname";
            this.btn_CKNname.Size = new System.Drawing.Size(106, 23);
            this.btn_CKNname.TabIndex = 5;
            this.btn_CKNname.Text = "중복확인";
            this.btn_CKNname.UseVisualStyleBackColor = false;
            this.btn_CKNname.Click += new System.EventHandler(this.btn_CKNname_Click);
            // 
            // txt_PW
            // 
            this.txt_PW.Location = new System.Drawing.Point(15, 227);
            this.txt_PW.Name = "txt_PW";
            this.txt_PW.PlaceholderText = "PassWord";
            this.txt_PW.Size = new System.Drawing.Size(307, 23);
            this.txt_PW.TabIndex = 4;
            // 
            // btn_CKID
            // 
            this.btn_CKID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CKID.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_CKID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CKID.Location = new System.Drawing.Point(216, 187);
            this.btn_CKID.Name = "btn_CKID";
            this.btn_CKID.Size = new System.Drawing.Size(106, 23);
            this.btn_CKID.TabIndex = 3;
            this.btn_CKID.Text = "중복확인";
            this.btn_CKID.UseVisualStyleBackColor = false;
            this.btn_CKID.Click += new System.EventHandler(this.btn_CKID_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(15, 187);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PlaceholderText = "ID";
            this.txt_ID.Size = new System.Drawing.Size(184, 23);
            this.txt_ID.TabIndex = 2;
            // 
            // lbl_des
            // 
            this.lbl_des.AutoSize = true;
            this.lbl_des.ForeColor = System.Drawing.Color.White;
            this.lbl_des.Location = new System.Drawing.Point(69, 147);
            this.lbl_des.Name = "lbl_des";
            this.lbl_des.Size = new System.Drawing.Size(214, 15);
            this.lbl_des.TabIndex = 1;
            this.lbl_des.Text = "Create an account to start doing more";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(116, 100);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(115, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Sign Up";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SignUpForm";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackImg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BackImg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_des;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.TextBox txt_KaID;
        private System.Windows.Forms.TextBox txt_EMail;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_NName;
        private System.Windows.Forms.Button btn_CKNname;
        private System.Windows.Forms.TextBox txt_PW;
        private System.Windows.Forms.Button btn_CKID;
        private System.Windows.Forms.TextBox txt_ID;
    }
}