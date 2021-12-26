
namespace usedauction
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_MyPage = new System.Windows.Forms.Button();
            this.btn_NewItem = new System.Windows.Forms.Button();
            this.btn_Top10 = new System.Windows.Forms.Button();
            this.btn_AllView = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Cate = new System.Windows.Forms.Label();
            this.cmb_Cate = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.Dgv_items = new System.Windows.Forms.DataGridView();
            this.Data_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.Data_con = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_HighBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_items)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_MyPage);
            this.panel1.Controls.Add(this.btn_NewItem);
            this.panel1.Controls.Add(this.btn_Top10);
            this.panel1.Controls.Add(this.btn_AllView);
            this.panel1.Controls.Add(this.lbl_Name);
            this.panel1.Controls.Add(this.lbl_Cate);
            this.panel1.Controls.Add(this.cmb_Cate);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_MyPage
            // 
            this.btn_MyPage.Location = new System.Drawing.Point(0, 343);
            this.btn_MyPage.Name = "btn_MyPage";
            this.btn_MyPage.Size = new System.Drawing.Size(135, 58);
            this.btn_MyPage.TabIndex = 6;
            this.btn_MyPage.Text = "마이페이지";
            this.btn_MyPage.UseVisualStyleBackColor = true;
            this.btn_MyPage.Click += new System.EventHandler(this.btn_MyPage_Click);
            // 
            // btn_NewItem
            // 
            this.btn_NewItem.Location = new System.Drawing.Point(0, 269);
            this.btn_NewItem.Name = "btn_NewItem";
            this.btn_NewItem.Size = new System.Drawing.Size(135, 58);
            this.btn_NewItem.TabIndex = 5;
            this.btn_NewItem.Text = "상품등록";
            this.btn_NewItem.UseVisualStyleBackColor = true;
            this.btn_NewItem.Click += new System.EventHandler(this.btn_NewItem_Click);
            // 
            // btn_Top10
            // 
            this.btn_Top10.Location = new System.Drawing.Point(1, 196);
            this.btn_Top10.Name = "btn_Top10";
            this.btn_Top10.Size = new System.Drawing.Size(135, 58);
            this.btn_Top10.TabIndex = 4;
            this.btn_Top10.Text = "Top10 상품";
            this.btn_Top10.UseVisualStyleBackColor = true;
            this.btn_Top10.Click += new System.EventHandler(this.btn_Top10_Click);
            // 
            // btn_AllView
            // 
            this.btn_AllView.Location = new System.Drawing.Point(0, 124);
            this.btn_AllView.Name = "btn_AllView";
            this.btn_AllView.Size = new System.Drawing.Size(135, 58);
            this.btn_AllView.TabIndex = 3;
            this.btn_AllView.Text = "전체보기";
            this.btn_AllView.UseVisualStyleBackColor = true;
            this.btn_AllView.Click += new System.EventHandler(this.btn_AllView_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(10, 10);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(72, 28);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "사용자";
            // 
            // lbl_Cate
            // 
            this.lbl_Cate.AutoSize = true;
            this.lbl_Cate.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cate.Location = new System.Drawing.Point(30, 63);
            this.lbl_Cate.Name = "lbl_Cate";
            this.lbl_Cate.Size = new System.Drawing.Size(74, 21);
            this.lbl_Cate.TabIndex = 1;
            this.lbl_Cate.Text = "카테고리";
            // 
            // cmb_Cate
            // 
            this.cmb_Cate.FormattingEnabled = true;
            this.cmb_Cate.Items.AddRange(new object[] {
            "IT",
            "가전제품",
            "헬스",
            "잡화"});
            this.cmb_Cate.Location = new System.Drawing.Point(0, 87);
            this.cmb_Cate.Name = "cmb_Cate";
            this.cmb_Cate.Size = new System.Drawing.Size(135, 23);
            this.cmb_Cate.TabIndex = 0;
            this.cmb_Cate.SelectedIndexChanged += new System.EventHandler(this.cmb_Cate_SelectedIndexChanged);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(140, 34);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(578, 23);
            this.txt_Search.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(724, 33);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            this.Column_ID});
            this.Dgv_items.Location = new System.Drawing.Point(141, 62);
            this.Dgv_items.Name = "Dgv_items";
            this.Dgv_items.ReadOnly = true;
            this.Dgv_items.RowTemplate.Height = 25;
            this.Dgv_items.Size = new System.Drawing.Size(659, 387);
            this.Dgv_items.TabIndex = 4;
            this.Dgv_items.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_items_CellDoubleClick);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_items);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "경매중고";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_MyPage;
        private System.Windows.Forms.Button btn_NewItem;
        private System.Windows.Forms.Button btn_Top10;
        private System.Windows.Forms.Button btn_AllView;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Cate;
        private System.Windows.Forms.ComboBox cmb_Cate;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView Dgv_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_name;
        private System.Windows.Forms.DataGridViewImageColumn Data_Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_con;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_HighBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
    }
}