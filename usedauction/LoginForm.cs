using Models;
using System;
using System.Windows.Forms;

namespace usedauction
{
    public partial class LoginForm : Form
    {
        ConnectFirebase openfirebase = new ConnectFirebase();
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            var member = await openfirebase.L_GetMember(txt_ID.Text, txt_PW.Text);
            if (member != null)
            {
                MainForm mainForm = new MainForm(txt_ID.Text);
                this.Hide();
                mainForm.ShowDialog();
                Application.ExitThread();

            }
            else
            {
                MessageBox.Show("로그인에 실패하셨습니다.", "알림", MessageBoxButtons.OK);
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "프로그램 종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
