using Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace usedauction
{
    public partial class SignUpForm : Form
    {
        bool ckid = false;
        bool cknname = false;
        ConnectFirebase openfirebase = new ConnectFirebase();
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            panel2.Parent = BackImg;
            panel2.BackColor = Color.FromArgb(110, Color.Blue);
        }

        private async void btn_CKID_Click(object sender, EventArgs e)
        {
            var member = await openfirebase.ID_CK_GetMember(txt_ID.Text);
            if (member != null)
            {
                MessageBox.Show("이미존재하는 아이디입니다.", "알림", MessageBoxButtons.OK);
                txt_ID.Clear();
            }
            else
            {
                ckid = true;
                MessageBox.Show("사용가능한 아이디입니다.", "알림", MessageBoxButtons.OK);
            }
        }

        private async void btn_CKNname_Click(object sender, EventArgs e)
        {
            var member = await openfirebase.NNAME_CK_GetMember(txt_NName.Text);
            if (member != null)
            {
                MessageBox.Show("이미존재하는 닉네임입니다.", "알림", MessageBoxButtons.OK);
                txt_NName.Clear();
            }
            else
            {
                cknname = true;
                MessageBox.Show("사용가능한 닉네임입니다.", "알림", MessageBoxButtons.OK);
            }
        }

        private async void btn_SignUp_Click(object sender, EventArgs e)
        {
            if (ckid && cknname)
            {
                await openfirebase.AddMember(txt_ID.Text, txt_PW.Text, txt_Name.Text, txt_NName.Text, txt_PhoneNumber.Text, txt_EMail.Text, txt_KaID.Text);
                MessageBox.Show("회원가입 성공.", "알림", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("중복확인 부탁드립니다.", "알림", MessageBoxButtons.OK);
            }
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            ckid = false;
            cknname = false;
            this.Close();
        }
    }
}
