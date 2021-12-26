
namespace usedauction
{
    partial class ItemDetailForm
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
            this.pb_Img = new System.Windows.Forms.PictureBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_con = new System.Windows.Forms.Label();
            this.tb_Bidorbuy = new System.Windows.Forms.TextBox();
            this.lbl_highbid = new System.Windows.Forms.Label();
            this.lbl_Buyprice = new System.Windows.Forms.Label();
            this.lbl_seller = new System.Windows.Forms.Label();
            this.btn_sellerinfo = new System.Windows.Forms.Button();
            this.btn_inter = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Img
            // 
            this.pb_Img.Location = new System.Drawing.Point(44, 70);
            this.pb_Img.Name = "pb_Img";
            this.pb_Img.Size = new System.Drawing.Size(400, 213);
            this.pb_Img.TabIndex = 0;
            this.pb_Img.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(197, 9);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(71, 37);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "제목";
            // 
            // lbl_con
            // 
            this.lbl_con.AutoSize = true;
            this.lbl_con.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_con.Location = new System.Drawing.Point(44, 285);
            this.lbl_con.Name = "lbl_con";
            this.lbl_con.Size = new System.Drawing.Size(42, 21);
            this.lbl_con.TabIndex = 2;
            this.lbl_con.Text = "내용";
            // 
            // tb_Bidorbuy
            // 
            this.tb_Bidorbuy.Location = new System.Drawing.Point(47, 366);
            this.tb_Bidorbuy.Name = "tb_Bidorbuy";
            this.tb_Bidorbuy.Size = new System.Drawing.Size(331, 23);
            this.tb_Bidorbuy.TabIndex = 3;
            // 
            // lbl_highbid
            // 
            this.lbl_highbid.AutoSize = true;
            this.lbl_highbid.Location = new System.Drawing.Point(47, 314);
            this.lbl_highbid.Name = "lbl_highbid";
            this.lbl_highbid.Size = new System.Drawing.Size(43, 15);
            this.lbl_highbid.TabIndex = 4;
            this.lbl_highbid.Text = "판매가";
            // 
            // lbl_Buyprice
            // 
            this.lbl_Buyprice.AutoSize = true;
            this.lbl_Buyprice.Location = new System.Drawing.Point(47, 342);
            this.lbl_Buyprice.Name = "lbl_Buyprice";
            this.lbl_Buyprice.Size = new System.Drawing.Size(67, 15);
            this.lbl_Buyprice.TabIndex = 5;
            this.lbl_Buyprice.Text = "최고입찰가";
            // 
            // lbl_seller
            // 
            this.lbl_seller.AutoSize = true;
            this.lbl_seller.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_seller.Location = new System.Drawing.Point(288, 43);
            this.lbl_seller.Name = "lbl_seller";
            this.lbl_seller.Size = new System.Drawing.Size(51, 19);
            this.lbl_seller.TabIndex = 8;
            this.lbl_seller.Text = "판매자";
            // 
            // btn_sellerinfo
            // 
            this.btn_sellerinfo.Location = new System.Drawing.Point(358, 42);
            this.btn_sellerinfo.Name = "btn_sellerinfo";
            this.btn_sellerinfo.Size = new System.Drawing.Size(85, 22);
            this.btn_sellerinfo.TabIndex = 9;
            this.btn_sellerinfo.Text = "판매자정보";
            this.btn_sellerinfo.UseVisualStyleBackColor = true;
            this.btn_sellerinfo.Click += new System.EventHandler(this.btn_sellerinfo_Click);
            // 
            // btn_inter
            // 
            this.btn_inter.Location = new System.Drawing.Point(31, 10);
            this.btn_inter.Name = "btn_inter";
            this.btn_inter.Size = new System.Drawing.Size(117, 50);
            this.btn_inter.TabIndex = 6;
            this.btn_inter.Text = "즐겨찾기";
            this.btn_inter.UseVisualStyleBackColor = true;
            this.btn_inter.Click += new System.EventHandler(this.btn_inter_Click);
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(184, 10);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(117, 50);
            this.btn_buy.TabIndex = 7;
            this.btn_buy.Text = "구매 및 입찰";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(332, 10);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(117, 50);
            this.btn_cancle.TabIndex = 10;
            this.btn_cancle.Text = "취소";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(21, 10);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(142, 70);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "변경";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(169, 10);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(138, 70);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(313, 10);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(138, 70);
            this.btn_c.TabIndex = 13;
            this.btn_c.Text = "취소";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_c);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_cancle);
            this.panel1.Controls.Add(this.btn_buy);
            this.panel1.Controls.Add(this.btn_inter);
            this.panel1.Location = new System.Drawing.Point(12, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 102);
            this.panel1.TabIndex = 11;
            // 
            // ItemDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sellerinfo);
            this.Controls.Add(this.lbl_seller);
            this.Controls.Add(this.lbl_Buyprice);
            this.Controls.Add(this.lbl_highbid);
            this.Controls.Add(this.tb_Bidorbuy);
            this.Controls.Add(this.lbl_con);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.pb_Img);
            this.Name = "ItemDetailForm";
            this.Text = "ItemDetailForm";
            this.Load += new System.EventHandler(this.ItemDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Img;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_con;
        private System.Windows.Forms.TextBox tb_Bidorbuy;
        private System.Windows.Forms.Label lbl_highbid;
        private System.Windows.Forms.Label lbl_Buyprice;
        private System.Windows.Forms.Label lbl_seller;
        private System.Windows.Forms.Button btn_sellerinfo;
        private System.Windows.Forms.Button btn_inter;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Panel panel1;
    }
}