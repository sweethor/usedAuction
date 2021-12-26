
namespace usedauction
{
    partial class UpdateItemForm
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
            this.btn_openimg = new System.Windows.Forms.Button();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.rb_Sellmode1 = new System.Windows.Forms.RadioButton();
            this.panel_sellmode = new System.Windows.Forms.Panel();
            this.rb_Sellmode3 = new System.Windows.Forms.RadioButton();
            this.rb_Sellmode2 = new System.Windows.Forms.RadioButton();
            this.panel_cate = new System.Windows.Forms.Panel();
            this.rb_category4 = new System.Windows.Forms.RadioButton();
            this.rb_category3 = new System.Windows.Forms.RadioButton();
            this.rb_category2 = new System.Windows.Forms.RadioButton();
            this.rb_category1 = new System.Windows.Forms.RadioButton();
            this.txt_bid = new System.Windows.Forms.TextBox();
            this.txt_sellprice = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_content = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.panel_sellmode.SuspendLayout();
            this.panel_cate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_openimg
            // 
            this.btn_openimg.Location = new System.Drawing.Point(310, 62);
            this.btn_openimg.Name = "btn_openimg";
            this.btn_openimg.Size = new System.Drawing.Size(108, 32);
            this.btn_openimg.TabIndex = 0;
            this.btn_openimg.Text = "이미지열기";
            this.btn_openimg.UseVisualStyleBackColor = true;
            this.btn_openimg.Click += new System.EventHandler(this.btn_openimg_Click);
            // 
            // pb_img
            // 
            this.pb_img.Location = new System.Drawing.Point(12, 104);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(405, 158);
            this.pb_img.TabIndex = 1;
            this.pb_img.TabStop = false;
            // 
            // rb_Sellmode1
            // 
            this.rb_Sellmode1.AutoSize = true;
            this.rb_Sellmode1.Location = new System.Drawing.Point(18, 20);
            this.rb_Sellmode1.Name = "rb_Sellmode1";
            this.rb_Sellmode1.Size = new System.Drawing.Size(49, 19);
            this.rb_Sellmode1.TabIndex = 2;
            this.rb_Sellmode1.TabStop = true;
            this.rb_Sellmode1.Text = "경매";
            this.rb_Sellmode1.UseVisualStyleBackColor = true;
            this.rb_Sellmode1.CheckedChanged += new System.EventHandler(this.rb_Sellmode1_CheckedChanged);
            // 
            // panel_sellmode
            // 
            this.panel_sellmode.Controls.Add(this.rb_Sellmode3);
            this.panel_sellmode.Controls.Add(this.rb_Sellmode2);
            this.panel_sellmode.Controls.Add(this.rb_Sellmode1);
            this.panel_sellmode.Location = new System.Drawing.Point(11, 322);
            this.panel_sellmode.Name = "panel_sellmode";
            this.panel_sellmode.Size = new System.Drawing.Size(405, 58);
            this.panel_sellmode.TabIndex = 3;
            // 
            // rb_Sellmode3
            // 
            this.rb_Sellmode3.AutoSize = true;
            this.rb_Sellmode3.Location = new System.Drawing.Point(307, 20);
            this.rb_Sellmode3.Name = "rb_Sellmode3";
            this.rb_Sellmode3.Size = new System.Drawing.Size(89, 19);
            this.rb_Sellmode3.TabIndex = 4;
            this.rb_Sellmode3.TabStop = true;
            this.rb_Sellmode3.Text = "경매 + 구매";
            this.rb_Sellmode3.UseVisualStyleBackColor = true;
            this.rb_Sellmode3.CheckedChanged += new System.EventHandler(this.rb_Sellmode3_CheckedChanged);
            // 
            // rb_Sellmode2
            // 
            this.rb_Sellmode2.AutoSize = true;
            this.rb_Sellmode2.Location = new System.Drawing.Point(170, 20);
            this.rb_Sellmode2.Name = "rb_Sellmode2";
            this.rb_Sellmode2.Size = new System.Drawing.Size(49, 19);
            this.rb_Sellmode2.TabIndex = 3;
            this.rb_Sellmode2.TabStop = true;
            this.rb_Sellmode2.Text = "구매";
            this.rb_Sellmode2.UseVisualStyleBackColor = true;
            this.rb_Sellmode2.CheckedChanged += new System.EventHandler(this.rb_Sellmode2_CheckedChanged);
            // 
            // panel_cate
            // 
            this.panel_cate.Controls.Add(this.rb_category4);
            this.panel_cate.Controls.Add(this.rb_category3);
            this.panel_cate.Controls.Add(this.rb_category2);
            this.panel_cate.Controls.Add(this.rb_category1);
            this.panel_cate.Location = new System.Drawing.Point(11, 386);
            this.panel_cate.Name = "panel_cate";
            this.panel_cate.Size = new System.Drawing.Size(405, 55);
            this.panel_cate.TabIndex = 4;
            // 
            // rb_category4
            // 
            this.rb_category4.AutoSize = true;
            this.rb_category4.Location = new System.Drawing.Point(323, 19);
            this.rb_category4.Name = "rb_category4";
            this.rb_category4.Size = new System.Drawing.Size(49, 19);
            this.rb_category4.TabIndex = 8;
            this.rb_category4.TabStop = true;
            this.rb_category4.Text = "잡화";
            this.rb_category4.UseVisualStyleBackColor = true;
            this.rb_category4.CheckedChanged += new System.EventHandler(this.rb_category4_CheckedChanged);
            // 
            // rb_category3
            // 
            this.rb_category3.AutoSize = true;
            this.rb_category3.Location = new System.Drawing.Point(221, 19);
            this.rb_category3.Name = "rb_category3";
            this.rb_category3.Size = new System.Drawing.Size(49, 19);
            this.rb_category3.TabIndex = 7;
            this.rb_category3.TabStop = true;
            this.rb_category3.Text = "헬스";
            this.rb_category3.UseVisualStyleBackColor = true;
            this.rb_category3.CheckedChanged += new System.EventHandler(this.rb_category3_CheckedChanged);
            // 
            // rb_category2
            // 
            this.rb_category2.AutoSize = true;
            this.rb_category2.Location = new System.Drawing.Point(101, 19);
            this.rb_category2.Name = "rb_category2";
            this.rb_category2.Size = new System.Drawing.Size(73, 19);
            this.rb_category2.TabIndex = 6;
            this.rb_category2.TabStop = true;
            this.rb_category2.Text = "가전제품";
            this.rb_category2.UseVisualStyleBackColor = true;
            this.rb_category2.CheckedChanged += new System.EventHandler(this.rb_category2_CheckedChanged);
            // 
            // rb_category1
            // 
            this.rb_category1.AutoSize = true;
            this.rb_category1.Location = new System.Drawing.Point(18, 19);
            this.rb_category1.Name = "rb_category1";
            this.rb_category1.Size = new System.Drawing.Size(34, 19);
            this.rb_category1.TabIndex = 5;
            this.rb_category1.TabStop = true;
            this.rb_category1.Text = "IT";
            this.rb_category1.UseVisualStyleBackColor = true;
            this.rb_category1.CheckedChanged += new System.EventHandler(this.rb_category1_CheckedChanged);
            // 
            // txt_bid
            // 
            this.txt_bid.Location = new System.Drawing.Point(11, 451);
            this.txt_bid.Name = "txt_bid";
            this.txt_bid.Size = new System.Drawing.Size(405, 23);
            this.txt_bid.TabIndex = 5;
            // 
            // txt_sellprice
            // 
            this.txt_sellprice.Location = new System.Drawing.Point(11, 489);
            this.txt_sellprice.Name = "txt_sellprice";
            this.txt_sellprice.Size = new System.Drawing.Size(405, 23);
            this.txt_sellprice.TabIndex = 6;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(11, 535);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(163, 53);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "수정";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(253, 535);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(163, 53);
            this.btn_cancle.TabIndex = 8;
            this.btn_cancle.Text = "취소";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 33);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(407, 23);
            this.txt_name.TabIndex = 9;
            // 
            // txt_content
            // 
            this.txt_content.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_content.Location = new System.Drawing.Point(12, 278);
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(407, 23);
            this.txt_content.TabIndex = 10;
            // 
            // UpdateItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 624);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_sellprice);
            this.Controls.Add(this.txt_bid);
            this.Controls.Add(this.panel_cate);
            this.Controls.Add(this.panel_sellmode);
            this.Controls.Add(this.pb_img);
            this.Controls.Add(this.btn_openimg);
            this.Name = "UpdateItemForm";
            this.Text = "UpdateItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.panel_sellmode.ResumeLayout(false);
            this.panel_sellmode.PerformLayout();
            this.panel_cate.ResumeLayout(false);
            this.panel_cate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_openimg;
        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.RadioButton sellmode1;
        private System.Windows.Forms.Panel panel_sellmode;
        private System.Windows.Forms.RadioButton rb_Sellmode3;
        private System.Windows.Forms.RadioButton rb_Sellmode2;
        private System.Windows.Forms.RadioButton rb_Sellmode1;
        private System.Windows.Forms.Panel panel_cate;
        private System.Windows.Forms.RadioButton rb_category1;
        private System.Windows.Forms.RadioButton rb_category4;
        private System.Windows.Forms.RadioButton rb_category3;
        private System.Windows.Forms.RadioButton rb_category2;
        private System.Windows.Forms.TextBox txt_bid;
        private System.Windows.Forms.TextBox txt_sellprice;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_content;
    }
}