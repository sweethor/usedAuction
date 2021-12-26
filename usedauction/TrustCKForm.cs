using Models;
using System;
using System.Windows.Forms;

namespace usedauction
{
    public partial class TrustCKForm : Form
    {
        string seller_id;
        ConnectFirebase openfirebase = new ConnectFirebase();
        public TrustCKForm(string s_id)
        {
            InitializeComponent();
            seller_id = s_id;
        }

        private async void TrustCKForm_Load(object sender, EventArgs e)
        {
            var sellerinfo = await openfirebase.Select_GetMember(seller_id);
            lbl_Name.Text = sellerinfo.MemberName;
            lbl_Nname.Text = sellerinfo.MemberNName;
            pb_Trust.Value = sellerinfo.MemberTrust / sellerinfo.MemberT_count;
            pb_Answer.Value = sellerinfo.MemberAnswer / sellerinfo.MemberT_count;
            pb_Satissfied.Value = sellerinfo.MemberSatissfied / sellerinfo.MemberT_count;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Nname_Click(object sender, EventArgs e)
        {

        }
    }
}
