
namespace usedauction
{
    partial class MyPageForm
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
            this.lbl_Noti = new System.Windows.Forms.Label();
            this.btn_Noti = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.btn_inter = new System.Windows.Forms.Button();
            this.panel_sell = new System.Windows.Forms.Panel();
            this.btn_sellcom = new System.Windows.Forms.Button();
            this.lbl_selling = new System.Windows.Forms.Label();
            this.lbl_sellcom = new System.Windows.Forms.Label();
            this.btn_selling = new System.Windows.Forms.Button();
            this.panel_buy = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buying = new System.Windows.Forms.Button();
            this.lbl_buycom = new System.Windows.Forms.Label();
            this.lbl_buying = new System.Windows.Forms.Label();
            this.btn_buycom = new System.Windows.Forms.Button();
            this.panel_sell.SuspendLayout();
            this.panel_buy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(29, 21);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(71, 37);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "이름";
            // 
            // lbl_Nname
            // 
            this.lbl_Nname.AutoSize = true;
            this.lbl_Nname.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nname.Location = new System.Drawing.Point(47, 64);
            this.lbl_Nname.Name = "lbl_Nname";
            this.lbl_Nname.Size = new System.Drawing.Size(72, 28);
            this.lbl_Nname.TabIndex = 1;
            this.lbl_Nname.Text = "닉네임";
            // 
            // lbl_Noti
            // 
            this.lbl_Noti.AutoSize = true;
            this.lbl_Noti.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Noti.Location = new System.Drawing.Point(326, 33);
            this.lbl_Noti.Name = "lbl_Noti";
            this.lbl_Noti.Size = new System.Drawing.Size(48, 25);
            this.lbl_Noti.TabIndex = 2;
            this.lbl_Noti.Text = "알림";
            // 
            // btn_Noti
            // 
            this.btn_Noti.Location = new System.Drawing.Point(326, 61);
            this.btn_Noti.Name = "btn_Noti";
            this.btn_Noti.Size = new System.Drawing.Size(73, 31);
            this.btn_Noti.TabIndex = 3;
            this.btn_Noti.Text = "자세히";
            this.btn_Noti.UseVisualStyleBackColor = true;
            this.btn_Noti.Click += new System.EventHandler(this.btn_Noti_Click);
            // 
            // btn_sell
            // 
            this.btn_sell.Location = new System.Drawing.Point(12, 134);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(128, 42);
            this.btn_sell.TabIndex = 4;
            this.btn_sell.Text = "판매정보";
            this.btn_sell.UseVisualStyleBackColor = true;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(155, 134);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(128, 42);
            this.btn_buy.TabIndex = 5;
            this.btn_buy.Text = "구매정보";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // btn_inter
            // 
            this.btn_inter.Location = new System.Drawing.Point(292, 134);
            this.btn_inter.Name = "btn_inter";
            this.btn_inter.Size = new System.Drawing.Size(128, 42);
            this.btn_inter.TabIndex = 6;
            this.btn_inter.Text = "즐겨찾기";
            this.btn_inter.UseVisualStyleBackColor = true;
            this.btn_inter.Click += new System.EventHandler(this.btn_inter_Click);
            // 
            // panel_sell
            // 
            this.panel_sell.Controls.Add(this.btn_sellcom);
            this.panel_sell.Controls.Add(this.lbl_selling);
            this.panel_sell.Controls.Add(this.lbl_sellcom);
            this.panel_sell.Controls.Add(this.btn_selling);
            this.panel_sell.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_sell.Location = new System.Drawing.Point(0, 225);
            this.panel_sell.Name = "panel_sell";
            this.panel_sell.Size = new System.Drawing.Size(434, 298);
            this.panel_sell.TabIndex = 7;
            this.panel_sell.Visible = false;
            // 
            // btn_sellcom
            // 
            this.btn_sellcom.Location = new System.Drawing.Point(235, 193);
            this.btn_sellcom.Name = "btn_sellcom";
            this.btn_sellcom.Size = new System.Drawing.Size(119, 41);
            this.btn_sellcom.TabIndex = 3;
            this.btn_sellcom.Text = "자세히";
            this.btn_sellcom.UseVisualStyleBackColor = true;
            this.btn_sellcom.Click += new System.EventHandler(this.btn_sellcom_Click);
            // 
            // lbl_selling
            // 
            this.lbl_selling.AutoSize = true;
            this.lbl_selling.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_selling.Location = new System.Drawing.Point(30, 65);
            this.lbl_selling.Name = "lbl_selling";
            this.lbl_selling.Size = new System.Drawing.Size(125, 37);
            this.lbl_selling.TabIndex = 0;
            this.lbl_selling.Text = "등록물품";
            // 
            // lbl_sellcom
            // 
            this.lbl_sellcom.AutoSize = true;
            this.lbl_sellcom.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sellcom.Location = new System.Drawing.Point(30, 193);
            this.lbl_sellcom.Name = "lbl_sellcom";
            this.lbl_sellcom.Size = new System.Drawing.Size(125, 37);
            this.lbl_sellcom.TabIndex = 2;
            this.lbl_sellcom.Text = "판매완료";
            // 
            // btn_selling
            // 
            this.btn_selling.Location = new System.Drawing.Point(235, 65);
            this.btn_selling.Name = "btn_selling";
            this.btn_selling.Size = new System.Drawing.Size(119, 42);
            this.btn_selling.TabIndex = 1;
            this.btn_selling.Text = "자세히";
            this.btn_selling.UseVisualStyleBackColor = true;
            this.btn_selling.Click += new System.EventHandler(this.btn_selling_Click);
            // 
            // panel_buy
            // 
            this.panel_buy.Controls.Add(this.label1);
            this.panel_buy.Controls.Add(this.btn_buying);
            this.panel_buy.Controls.Add(this.lbl_buycom);
            this.panel_buy.Controls.Add(this.lbl_buying);
            this.panel_buy.Controls.Add(this.btn_buycom);
            this.panel_buy.Location = new System.Drawing.Point(0, 223);
            this.panel_buy.Name = "panel_buy";
            this.panel_buy.Size = new System.Drawing.Size(432, 296);
            this.panel_buy.TabIndex = 4;
            this.panel_buy.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "최고입찰가만해당";
            // 
            // btn_buying
            // 
            this.btn_buying.Location = new System.Drawing.Point(280, 194);
            this.btn_buying.Name = "btn_buying";
            this.btn_buying.Size = new System.Drawing.Size(119, 42);
            this.btn_buying.TabIndex = 6;
            this.btn_buying.Text = "자세히";
            this.btn_buying.UseVisualStyleBackColor = true;
            this.btn_buying.Click += new System.EventHandler(this.btn_buying_Click);
            // 
            // lbl_buycom
            // 
            this.lbl_buycom.AutoSize = true;
            this.lbl_buycom.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_buycom.Location = new System.Drawing.Point(6, 68);
            this.lbl_buycom.Name = "lbl_buycom";
            this.lbl_buycom.Size = new System.Drawing.Size(125, 37);
            this.lbl_buycom.TabIndex = 5;
            this.lbl_buycom.Text = "구매물품";
            // 
            // lbl_buying
            // 
            this.lbl_buying.AutoSize = true;
            this.lbl_buying.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_buying.Location = new System.Drawing.Point(6, 194);
            this.lbl_buying.Name = "lbl_buying";
            this.lbl_buying.Size = new System.Drawing.Size(179, 37);
            this.lbl_buying.TabIndex = 4;
            this.lbl_buying.Text = "참여중인경매";
            // 
            // btn_buycom
            // 
            this.btn_buycom.Location = new System.Drawing.Point(280, 63);
            this.btn_buycom.Name = "btn_buycom";
            this.btn_buycom.Size = new System.Drawing.Size(119, 42);
            this.btn_buycom.TabIndex = 4;
            this.btn_buycom.Text = "자세히";
            this.btn_buycom.UseVisualStyleBackColor = true;
            this.btn_buycom.Click += new System.EventHandler(this.btn_buycom_Click);
            // 
            // MyPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 523);
            this.Controls.Add(this.panel_buy);
            this.Controls.Add(this.panel_sell);
            this.Controls.Add(this.btn_inter);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.btn_Noti);
            this.Controls.Add(this.lbl_Noti);
            this.Controls.Add(this.lbl_Nname);
            this.Controls.Add(this.lbl_Name);
            this.Name = "MyPageForm";
            this.Text = "MyPageForm";
            this.Load += new System.EventHandler(this.MyPageForm_Load);
            this.panel_sell.ResumeLayout(false);
            this.panel_sell.PerformLayout();
            this.panel_buy.ResumeLayout(false);
            this.panel_buy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Nname;
        private System.Windows.Forms.Label lbl_Noti;
        private System.Windows.Forms.Button btn_Noti;
        private System.Windows.Forms.Button btn_sell;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Button btn_inter;
        private System.Windows.Forms.Panel panel_sell;
        private System.Windows.Forms.Button btn_sellcom;
        private System.Windows.Forms.Label lbl_sellcom;
        private System.Windows.Forms.Button btn_selling;
        private System.Windows.Forms.Label lbl_selling;
        private System.Windows.Forms.Panel panel_buy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buying;
        private System.Windows.Forms.Label lbl_buycom;
        private System.Windows.Forms.Label lbl_buying;
        private System.Windows.Forms.Button btn_buycom;
    }
}