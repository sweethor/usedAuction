using Models;
using System;
using System.Windows.Forms;

namespace usedauction
{
    public partial class MemberInfoForm : Form
    {
        string member_id;
        ConnectFirebase openfirebase = new ConnectFirebase();
        public MemberInfoForm(string id)
        {
            InitializeComponent();
            member_id = id;
        }

        private async void TrustCKForm_Load(object sender, EventArgs e)
        {
            var sellerinfo = await openfirebase.Select_GetMember(member_id);
            lbl_Name.Text = sellerinfo.MemberName;
            lbl_Nname.Text = sellerinfo.MemberNName;
            lbl_Email.Text = sellerinfo.MemberEMail;
            lbl_KAID.Text = sellerinfo.MemberKAID;
            lbl_Phone.Text = sellerinfo.MemberPhone;
            pb_Trust.Value = sellerinfo.MemberTrust / sellerinfo.MemberT_count;
            pb_Answer.Value = sellerinfo.MemberAnswer / sellerinfo.MemberT_count;
            pb_Satissfied.Value = sellerinfo.MemberSatissfied / sellerinfo.MemberT_count;
        }

        private async void btn_ok_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("신뢰도 : " + num_Trust.Value + " 응답도 : " + num_Answer.Value + " 만족도 : " + num_Satissfied.Value + 
                " 이 확실합니까", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await openfirebase.UpdateMember(member_id, Int32.Parse(num_Trust.Value.ToString()), Int32.Parse(num_Answer.Value.ToString()), Int32.Parse(num_Satissfied.Value.ToString()));
                MessageBox.Show("상대방의 신뢰도가 기입되었습니다.", "알림", MessageBoxButtons.OK);
                this.Close();
            }
        }

    }
}
