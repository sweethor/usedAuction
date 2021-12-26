
namespace usedauction
{
    partial class NotiForm
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
            this.dgv_noti = new System.Windows.Forms.DataGridView();
            this.Noti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Noti_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_noti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_noti
            // 
            this.dgv_noti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_noti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Noti,
            this.Noti_num});
            this.dgv_noti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_noti.Location = new System.Drawing.Point(0, 0);
            this.dgv_noti.Name = "dgv_noti";
            this.dgv_noti.RowTemplate.Height = 25;
            this.dgv_noti.Size = new System.Drawing.Size(586, 72);
            this.dgv_noti.TabIndex = 0;
            this.dgv_noti.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_noti_CellContentDoubleClick);
            // 
            // Noti
            // 
            this.Noti.HeaderText = "알림내용";
            this.Noti.MinimumWidth = 543;
            this.Noti.Name = "Noti";
            this.Noti.ReadOnly = true;
            this.Noti.Width = 543;
            // 
            // Noti_num
            // 
            this.Noti_num.HeaderText = "알림번호";
            this.Noti_num.Name = "Noti_num";
            this.Noti_num.ReadOnly = true;
            this.Noti_num.Visible = false;
            // 
            // NotiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 72);
            this.Controls.Add(this.dgv_noti);
            this.Name = "NotiForm";
            this.Text = "NotiForm";
            this.Load += new System.EventHandler(this.NotiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_noti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_noti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noti_num;
    }
}