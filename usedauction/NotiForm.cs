using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace usedauction
{
    public partial class NotiForm : Form
    {
        string Member_ID;
        ConnectFirebase openfirebase = new ConnectFirebase();

        public NotiForm(string memid)
        {
            Member_ID = memid;
            InitializeComponent();
        }

        private async void NotiForm_Load(object sender, EventArgs e)
        {
            var items = await openfirebase.Select_GetAllINoti(Member_ID);
            foreach(Noti noti in items)
            {
                dgv_noti.Rows.Add(noti.noti, noti.noti_num);
            }
        }

        private async void dgv_noti_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            int curR = e.RowIndex;
            if (MessageBox.Show("알림을 지우고 나가시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await openfirebase.Delete_Noti(Member_ID, Int32.Parse(grid.Rows[curR].Cells[1].Value.ToString()));
                this.Close();
            }
            
        }
    }
}
