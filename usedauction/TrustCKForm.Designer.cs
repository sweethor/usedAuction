
namespace usedauction
{
    partial class TrustCKForm
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
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(124, 9);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(66, 28);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "label1";
            // 
            // lbl_Nname
            // 
            this.lbl_Nname.AutoSize = true;
            this.lbl_Nname.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nname.Location = new System.Drawing.Point(130, 68);
            this.lbl_Nname.Name = "lbl_Nname";
            this.lbl_Nname.Size = new System.Drawing.Size(54, 21);
            this.lbl_Nname.TabIndex = 1;
            this.lbl_Nname.Text = "label2";
            this.lbl_Nname.Click += new System.EventHandler(this.lbl_Nname_Click);
            // 
            // lbl_Trust
            // 
            this.lbl_Trust.AutoSize = true;
            this.lbl_Trust.Location = new System.Drawing.Point(12, 121);
            this.lbl_Trust.Name = "lbl_Trust";
            this.lbl_Trust.Size = new System.Drawing.Size(43, 15);
            this.lbl_Trust.TabIndex = 2;
            this.lbl_Trust.Text = "신뢰도";
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Location = new System.Drawing.Point(12, 209);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(43, 15);
            this.lbl_Answer.TabIndex = 3;
            this.lbl_Answer.Text = "응답도";
            // 
            // lbl_Satissfied
            // 
            this.lbl_Satissfied.AutoSize = true;
            this.lbl_Satissfied.Location = new System.Drawing.Point(12, 302);
            this.lbl_Satissfied.Name = "lbl_Satissfied";
            this.lbl_Satissfied.Size = new System.Drawing.Size(43, 15);
            this.lbl_Satissfied.TabIndex = 4;
            this.lbl_Satissfied.Text = "만족도";
            // 
            // pb_Trust
            // 
            this.pb_Trust.Location = new System.Drawing.Point(25, 148);
            this.pb_Trust.Name = "pb_Trust";
            this.pb_Trust.Size = new System.Drawing.Size(249, 37);
            this.pb_Trust.TabIndex = 5;
            // 
            // pb_Answer
            // 
            this.pb_Answer.Location = new System.Drawing.Point(25, 243);
            this.pb_Answer.Name = "pb_Answer";
            this.pb_Answer.Size = new System.Drawing.Size(249, 37);
            this.pb_Answer.TabIndex = 6;
            // 
            // pb_Satissfied
            // 
            this.pb_Satissfied.Location = new System.Drawing.Point(25, 342);
            this.pb_Satissfied.Name = "pb_Satissfied";
            this.pb_Satissfied.Size = new System.Drawing.Size(249, 37);
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
            // TrustCKForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.pb_Satissfied);
            this.Controls.Add(this.pb_Answer);
            this.Controls.Add(this.pb_Trust);
            this.Controls.Add(this.lbl_Satissfied);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.lbl_Trust);
            this.Controls.Add(this.lbl_Nname);
            this.Controls.Add(this.lbl_Name);
            this.Name = "TrustCKForm";
            this.Text = "TrustCKForm";
            this.Load += new System.EventHandler(this.TrustCKForm_Load);
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
    }
}