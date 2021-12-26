
namespace usedauction
{
    partial class Myitems
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
            this.Dgv_items = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            this.Data_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.Data_con = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_HighBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_items)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_items
            // 
            this.Dgv_items.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data_name,
            this.Data_Img,
            this.Data_con,
            this.Data_SellPrice,
            this.Data_HighBid,
            this.Column_ID,
            this.SellerID,
            this.BuyerID});
            this.Dgv_items.Location = new System.Drawing.Point(0, 1);
            this.Dgv_items.Name = "Dgv_items";
            this.Dgv_items.ReadOnly = true;
            this.Dgv_items.RowTemplate.Height = 25;
            this.Dgv_items.Size = new System.Drawing.Size(664, 387);
            this.Dgv_items.TabIndex = 5;
            this.Dgv_items.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_items_CellContentDoubleClick);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(0, 388);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(663, 88);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "확인";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Data_name
            // 
            this.Data_name.HeaderText = "제목";
            this.Data_name.Name = "Data_name";
            this.Data_name.ReadOnly = true;
            this.Data_name.Width = 130;
            // 
            // Data_Img
            // 
            this.Data_Img.HeaderText = "사진";
            this.Data_Img.Name = "Data_Img";
            this.Data_Img.ReadOnly = true;
            this.Data_Img.Width = 150;
            // 
            // Data_con
            // 
            this.Data_con.HeaderText = "내용";
            this.Data_con.Name = "Data_con";
            this.Data_con.ReadOnly = true;
            this.Data_con.Width = 140;
            // 
            // Data_SellPrice
            // 
            this.Data_SellPrice.HeaderText = "판매가격";
            this.Data_SellPrice.Name = "Data_SellPrice";
            this.Data_SellPrice.ReadOnly = true;
            // 
            // Data_HighBid
            // 
            this.Data_HighBid.HeaderText = "최고입찰가";
            this.Data_HighBid.Name = "Data_HighBid";
            this.Data_HighBid.ReadOnly = true;
            // 
            // Column_ID
            // 
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            this.Column_ID.Visible = false;
            // 
            // SellerID
            // 
            this.SellerID.HeaderText = "판매자ID";
            this.SellerID.Name = "SellerID";
            this.SellerID.ReadOnly = true;
            this.SellerID.Visible = false;
            // 
            // BuyerID
            // 
            this.BuyerID.HeaderText = " 최종구매자ID";
            this.BuyerID.Name = "BuyerID";
            this.BuyerID.ReadOnly = true;
            this.BuyerID.Visible = false;
            // 
            // Myitems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 477);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.Dgv_items);
            this.Name = "Myitems";
            this.Text = "Myitems";
            this.Load += new System.EventHandler(this.Myitems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_items;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_name;
        private System.Windows.Forms.DataGridViewImageColumn Data_Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_con;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_HighBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyerID;
    }
}