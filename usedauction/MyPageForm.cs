using Models;
using System;
using System.Windows.Forms;

namespace usedauction
{
    public partial class MyPageForm : Form
    {
        ConnectFirebase openfirebase = new ConnectFirebase();
        string ID;

        public MyPageForm(string id)
        {
            ID = id;
            InitializeComponent();
        }

        private async void MyPageForm_Load(object sender, EventArgs e)
        {
            var meminfo = await openfirebase.Select_GetMember(ID);
            var memnoti = await openfirebase.Select_GetAllINoti(ID);
            lbl_Noti.Text = "알림 : " + memnoti.Count + " 개";
            lbl_Name.Text = meminfo.MemberName;
            lbl_Nname.Text = meminfo.MemberNName;
            panel_buy.Visible = false;
            panel_sell.Visible = false;
        }

        private async void btn_sell_Click(object sender, EventArgs e)
        {
            var meminfo = await openfirebase.Select_GetMember(ID);
            var myauc = await openfirebase.Select_GetSeller(ID);
            panel_buy.Visible = false;
            panel_sell.Visible = true;
            lbl_sellcom.Text = "판매완료 : " + meminfo.MemberS_count + " 건";
            lbl_selling.Text = "등록물품 : " + myauc.Count + " 건";

        }

        private void btn_selling_Click(object sender, EventArgs e)
        {
            Myitems myitems = new Myitems(ID, 1);
            myitems.ShowDialog();
        }

        private void btn_sellcom_Click(object sender, EventArgs e)
        {
            Myitems myitems = new Myitems(ID, 2);
            myitems.ShowDialog();
        }

        private void btn_inter_Click(object sender, EventArgs e)
        {
            Myitems myitems = new Myitems(ID, 5);
            myitems.ShowDialog();
        }

        private void btn_buycom_Click(object sender, EventArgs e)
        {
            Myitems myitems = new Myitems(ID, 4);
            myitems.ShowDialog();
        }

        private void btn_buying_Click(object sender, EventArgs e)
        {
            Myitems myitems = new Myitems(ID, 3);
            myitems.ShowDialog();
        }

        private async void btn_buy_Click(object sender, EventArgs e)
        {
            var meminfo = await openfirebase.Select_GetMember(ID);
            var myauc = await openfirebase.Select_GetAlltopbidItems(ID);

            panel_sell.Visible = false;
            panel_buy.Visible = true;

            lbl_buycom.Text = "구매완료 : " + meminfo.MemberB_count + " 건";
            lbl_buying.Text = "참여중인경매 : " + myauc.Count + " 건";
        }

        private async void btn_Noti_Click(object sender, EventArgs e)
        {
            NotiForm notiForm = new NotiForm(ID);
            notiForm.ShowDialog();
            var memnoti = await openfirebase.Select_GetAllINoti(ID);
            lbl_Noti.Text = "알림 : " + memnoti.Count + " 개";
        }
    }
}
