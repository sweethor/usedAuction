using System;
using System.Drawing;
using System.Windows.Forms;
using Models;

namespace usedauction
{
    public partial class NewItemForm : Form
    {
        string str_img;
        string memberID;
        int mode;
        int cate;
        ConnectFirebase openfirebase = new ConnectFirebase();


        public NewItemForm(string id)
        {
            memberID = id;
            InitializeComponent();
        }
        //경매 + 구매 방식
        private void rb_Sellmode3_CheckedChanged(object sender, System.EventArgs e)
        {
            mode = 3;
        }
        // 구매 방식
        private void rb_Sellmode2_CheckedChanged(object sender, System.EventArgs e)
        {
            mode = 2;
        }
        // 경매 방식
        private void rb_Sellmode1_CheckedChanged(object sender, System.EventArgs e)
        {
            mode = 1;
        }
        // 카테고리 : IT
        private void rb_category1_CheckedChanged(object sender, System.EventArgs e)
        {
            cate = 1;
        }
        // 카테고리 : 가전제품
        private void rb_category2_CheckedChanged(object sender, System.EventArgs e)
        {
            cate = 2;
        }
        // 카테고리 : 헬스
        private void rb_category3_CheckedChanged(object sender, System.EventArgs e)
        {
            cate = 3;
        }
        // 카테고리 : 잡화
        private void rb_category4_CheckedChanged(object sender, System.EventArgs e)
        {
            cate = 4;
        }

        private void btn_openimg_Click(object sender, System.EventArgs e)
        {
            string image_file = string.Empty;
            OpenFileDialog openFile = new OpenFileDialog();

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                image_file = openFile.FileName;
            }
            else if(openFile.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            byte[] imgebyte = ImageToByte(Bitmap.FromFile(image_file));
            str_img = System.Convert.ToBase64String(imgebyte);
            pb_img.Image = Bitmap.FromFile(image_file);
            pb_img.SizeMode = PictureBoxSizeMode.StretchImage;


        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private async void btn_ok_Click(object sender, System.EventArgs e)
        {
            await openfirebase.AddItem(txt_name.Text, txt_content.Text, str_img, Int32.Parse(txt_sellprice.Text),
                Int32.Parse(txt_bid.Text), mode, cate, memberID);
            MessageBox.Show("등록완료.", "알림", MessageBoxButtons.OK);
            this.Close();
        }

        private void btn_cancle_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
