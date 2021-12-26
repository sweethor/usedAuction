
namespace usedauction
{
    partial class MemberInfoForm
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Nname = new System.Windows.Forms.Label();
            this.lbl_Trust = new System.Windows.Forms.Label();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.lbl_Satissfied = new System.Windows.Forms.Label();
            this.pb_Trust = new System.Windows.Forms.ProgressBar();
            this.pb_Answer = new System.Windows.Forms.ProgressBar();
            this.pb_Satissfied = new System.Windows.Forms.ProgressBar();
            this.btn_ok = new System.Windows.Forms.Button();
            this.num_Trust = new System.Windows.Forms.NumericUpDown();
            this.num_Satissfied = new System.Windows.Forms.NumericUpDown();
            this.num_Answer = new System.Windows.Forms.NumericUpDown();
            this.lbl_Labelphone = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_LabelEmail = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_LabelKAID = new System.Windows.Forms.Label();
            this.lbl_KAID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_Trust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Satissfied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Answer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(124, 9);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(52, 28);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "이름";
            // 
            // lbl_Nname
            // 
            this.lbl_Nname.AutoSize = true;
            this.lbl_Nname.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nname.Location = new System.Drawing.Point(130, 68);
            this.lbl_Nname.Name = "lbl_Nname";
            this.lbl_Nname.Size = new System.Drawing.Size(58, 21);
            this.lbl_Nname.TabIndex = 1;
            this.lbl_Nname.Text = "닉네임";
            // 
            // lbl_Trust
            // 
            this.lbl_Trust.AutoSize = true;
            this.lbl_Trust.Location = new System.Drawing.Point(12, 264);
            this.lbl_Trust.Name = "lbl_Trust";
            this.lbl_Trust.Size = new System.Drawing.Size(43, 15);
            this.lbl_Trust.TabIndex = 2;
            this.lbl_Trust.Text = "신뢰도";
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Location = new System.Drawing.Point(12, 311);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(43, 15);
            this.lbl_Answer.TabIndex = 3;
            this.lbl_Answer.Text = "응답도";
            // 
            // lbl_Satissfied
            // 
            this.lbl_Satissfied.AutoSize = true;
            this.lbl_Satissfied.Location = new System.Drawing.Point(12, 355);
            this.lbl_Satissfied.Name = "lbl_Satissfied";
            this.lbl_Satissfied.Size = new System.Drawing.Size(43, 15);
            this.lbl_Satissfied.TabIndex = 4;
            this.lbl_Satissfied.Text = "만족도";
            // 
            // pb_Trust
            // 
            this.pb_Trust.Location = new System.Drawing.Point(25, 285);
            this.pb_Trust.Name = "pb_Trust";
            this.pb_Trust.Size = new System.Drawing.Size(186, 23);
            this.pb_Trust.TabIndex = 5;
            // 
            // pb_Answer
            // 
            this.pb_Answer.Location = new System.Drawing.Point(25, 329);
            this.pb_Answer.Name = "pb_Answer";
            this.pb_Answer.Size = new System.Drawing.Size(186, 23);
            this.pb_Answer.TabIndex = 6;
            // 
            // pb_Satissfied
            // 
            this.pb_Satissfied.Location = new System.Drawing.Point(25, 373);
            this.pb_Satissfied.Name = "pb_Satissfied";
            this.pb_Satissfied.Size = new System.Drawing.Size(186, 23);
            this.pb_Satissfied.TabIndex = 7;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(46, 402);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(216, 36);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "확인";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // num_Trust
            // 
            this.num_Trust.Location = new System.Drawing.Point(217, 285);
            this.num_Trust.Name = "num_Trust";
            this.num_Trust.Size = new System.Drawing.Size(65, 23);
            this.num_Trust.TabIndex = 9;
            // 
            // num_Satissfied
            // 
            this.num_Satissfied.Location = new System.Drawing.Point(217, 373);
            this.num_Satissfied.Name = "num_Satissfied";
            this.num_Satissfied.Size = new System.Drawing.Size(65, 23);
            this.num_Satissfied.TabIndex = 10;
            // 
            // num_Answer
            // 
            this.num_Answer.Location = new System.Drawing.Point(217, 329);
            this.num_Answer.Name = "num_Answer";
            this.num_Answer.Size = new System.Drawing.Size(65, 23);
            this.num_Answer.TabIndex = 11;
            // 
            // lbl_Labelphone
            // 
            this.lbl_Labelphone.AutoSize = true;
            this.lbl_Labelphone.Location = new System.Drawing.Point(12, 108);
            this.lbl_Labelphone.Name = "lbl_Labelphone";
            this.lbl_Labelphone.Size = new System.Drawing.Size(55, 15);
            this.lbl_Labelphone.TabIndex = 12;
            this.lbl_Labelphone.Text = "전화번호";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Phone.Location = new System.Drawing.Point(25, 123);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(54, 21);
            this.lbl_Phone.TabIndex = 13;
            this.lbl_Phone.Text = "label2";
            // 
            // lbl_LabelEmail
            // 
            this.lbl_LabelEmail.AutoSize = true;
            this.lbl_LabelEmail.Location = new System.Drawing.Point(12, 156);
            this.lbl_LabelEmail.Name = "lbl_LabelEmail";
            this.lbl_LabelEmail.Size = new System.Drawing.Size(43, 15);
            this.lbl_LabelEmail.TabIndex = 14;
            this.lbl_LabelEmail.Text = "이메일";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.Location = new System.Drawing.Point(25, 171);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(54, 21);
            this.lbl_Email.TabIndex = 15;
            this.lbl_Email.Text = "label2";
            // 
            // lbl_LabelKAID
            // 
            this.lbl_LabelKAID.AutoSize = true;
            this.lbl_LabelKAID.Location = new System.Drawing.Point(12, 203);
            this.lbl_LabelKAID.Name = "lbl_LabelKAID";
            this.lbl_LabelKAID.Size = new System.Drawing.Size(67, 15);
            this.lbl_LabelKAID.TabIndex = 16;
            this.lbl_LabelKAID.Text = "카카오톡ID";
            // 
            // lbl_KAID
            // 
            this.lbl_KAID.AutoSize = true;
            this.lbl_KAID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_KAID.Location = new System.Drawing.Point(25, 218);
            this.lbl_KAID.Name = "lbl_KAID";
            this.lbl_KAID.Size = new System.Drawing.Size(54, 21);
            this.lbl_KAID.TabIndex = 17;
            this.lbl_KAID.Text = "label2";
            // 
            // MemberInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.lbl_KAID);
            this.Controls.Add(this.lbl_LabelKAID);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_LabelEmail);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_Labelphone);
            this.Controls.Add(this.num_Answer);
            this.Controls.Add(this.num_Satissfied);
            this.Controls.Add(this.num_Trust);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.pb_Satissfied);
            this.Controls.Add(this.pb_Answer);
            this.Controls.Add(this.pb_Trust);
            this.Controls.Add(this.lbl_Satissfied);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.lbl_Trust);
            this.Controls.Add(this.lbl_Nname);
            this.Controls.Add(this.lbl_Name);
            this.Name = "MemberInfoForm";
            this.Text = "TrustCKForm";
            this.Load += new System.EventHandler(this.TrustCKForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Trust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Satissfied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Answer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Nname;
        private System.Windows.Forms.Label lbl_Trust;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.Label lbl_Satissfied;
        private System.Windows.Forms.ProgressBar pb_Trust;
        private System.Windows.Forms.ProgressBar pb_Answer;
        private System.Windows.Forms.ProgressBar pb_Satissfied;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.NumericUpDown num_Trust;
        private System.Windows.Forms.NumericUpDown num_Satissfied;
        private System.Windows.Forms.NumericUpDown num_Answer;
        private System.Windows.Forms.Label lbl_Labelphone;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_LabelEmail;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_LabelKAID;
        private System.Windows.Forms.Label lbl_KAID;
    }
}