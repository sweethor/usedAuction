using Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace usedauction
{
    public partial class ItemDetailForm : Form
    {
        string item_no;
        string MyID;
        int sellmode;
        bool ck_inter;
        ConnectFirebase openfirebase = new ConnectFirebase();
        public ItemDetailForm(string no, string myid)
        {
            item_no = no;
            MyID = myid;
            InitializeComponent();
        }

        private async void ItemDetailForm_Load(object sender, EventArgs e)
        {
            await openfirebase.Update_cnt(Int32.Parse(item_no));
            var item = await openfirebase.Select_GetItem(Int32.Parse(item_no));
            sellmode = item.Sell_mode;
            lbl_Name.Text = item.Sell_name;
            lbl_seller.Text = item.Sell_ID;
            lbl_highbid.Text = item.Highest_bid.ToString();
            lbl_con.Text = item.Sell_contents;
            lbl_Buyprice.Text = item.Sell_price.ToString();

            byte[] imageAsBytes = System.Convert.FromBase64String(item.Sell_img.ToString());
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(imageAsBytes);
            Image image = Image.FromStream(memoryStream);

            image = resizeImage(image, 200, 200);
            pb_Img.Image = image;
            if (MyID == item.Sell_ID)
            {
                btn_buy.Visible = false;
                btn_cancle.Visible = false;
                btn_inter.Visible = false;
                btn_c.Visible = true;
                btn_update.Visible = true;
                btn_delete.Visible = true;
            }
            else
            {
                btn_buy.Visible = true;
                btn_cancle.Visible = true;
                btn_inter.Visible = true;
                btn_c.Visible = false;
                btn_update.Visible = false;
                btn_delete.Visible = false;
                if (openfirebase.Select_GetInterItem(MyID, Int32.Parse(item_no)) != null)
                {
                    btn_inter.Text = "즐겨찾기";
                    ck_inter = true;
                }
                else
                {
                    btn_inter.Text = "즐겨찾기 해제";
                    ck_inter = false;
                }
            }


        }
        /// <summary>
        /// 받아온 이미지 크기 제조정 함수
        /// </summary>
        /// <param 이미지="image"></param>
        /// <param 가로="width"></param>
        /// <param 세로="height"></param>
        /// <returns></returns>
        public static Image resizeImage(Image image, int width, int height)
        {
            var destinationRect = new Rectangle(0, 0, width, height);
            var destinationImage = new Bitmap(width, height);

            destinationImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destinationImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destinationRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return (Image)destinationImage;
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_buy_Click(object sender, EventArgs e)
        {
            var item = await openfirebase.Select_GetItem(Int32.Parse(item_no));
            if (sellmode == 1)
            {
                if (Int32.Parse(tb_Bidorbuy.Text) <= item.Highest_bid)
                {
                    MessageBox.Show("입력한 금액이 최고입찰가보다 낮거나 같습니다.", "알림", MessageBoxButtons.OK);
                }
                else
                {
                    if (item.Topbid_ID != "")
                    {
                        await openfirebase.AddNoti(item.Topbid_ID, item.Sell_name, item.Sell_num, item.Sell_ID, MyID, item.Highest_bid, 1);
                    }

                    await openfirebase.Update_bid(item.Sell_num, MyID, Int32.Parse(tb_Bidorbuy.Text));
                    MessageBox.Show("입찰완료.", "알림", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else if (sellmode == 2)
            {
                if (Int32.Parse(tb_Bidorbuy.Text) == item.Sell_price)
                {

                    await openfirebase.AddNoti(MyID, item.Sell_name, item.Sell_num, item.Sell_ID, MyID, item.Highest_bid, 2);
                    await openfirebase.AddNoti(item.Sell_ID, item.Sell_name, item.Sell_num, item.Sell_ID, MyID, item.Highest_bid, 3);
                    await openfirebase.AddbuyItem(MyID, item.Sell_name, item.Sell_contents, item.Sell_img, item.Sell_price, item.Sell_ID, MyID, item.Highest_bid, sellmode);
                    await openfirebase.AddsoldoutItem(item.Sell_ID, item.Sell_name, item.Sell_contents, item.Sell_img, item.Sell_price, item.Sell_ID, MyID, item.Highest_bid, sellmode);
                    await openfirebase.UpdateMember(MyID, 2);
                    await openfirebase.UpdateMember(item.Sell_ID, 1);
                    await openfirebase.Delete_Item(item.Sell_num);

                    await openfirebase.Soldout_Delete_InterItem(item.Sell_num);
                    MessageBox.Show("구매완료.", "알림", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("입력한 금액이 판매가격과 같지 않습니다.", "알림", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (Int32.Parse(tb_Bidorbuy.Text) >= item.Sell_price)
                {

                    if (item.Topbid_ID != "")
                    {
                        await openfirebase.AddNoti(item.Topbid_ID, item.Sell_name, item.Sell_num, item.Sell_ID, MyID, item.Highest_bid, 1);
                    }
                    await openfirebase.AddNoti(item.Sell_ID, item.Sell_name, item.Sell_num, item.Sell_ID, MyID, item.Highest_bid, 3);
                    await openfirebase.AddbuyItem(MyID, item.Sell_name, item.Sell_contents, item.Sell_img, item.Sell_price, item.Sell_ID, MyID, item.Highest_bid, sellmode);
                    await openfirebase.AddsoldoutItem(item.Sell_ID, item.Sell_name, item.Sell_contents, item.Sell_img, item.Sell_price, item.Sell_ID, MyID, item.Highest_bid, sellmode);
                    await openfirebase.UpdateMember(MyID, 2);
                    await openfirebase.UpdateMember(item.Sell_ID, 1);
                    await openfirebase.Delete_Item(item.Sell_num);


                    await openfirebase.Soldout_Delete_InterItem(item.Sell_num);
                    MessageBox.Show("구매완료.", "알림", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    if (Int32.Parse(tb_Bidorbuy.Text) <= item.Highest_bid)
                    {
                        MessageBox.Show("입력한 금액이 최고입찰가보다 낮습니다.", "알림", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (item.Topbid_ID != "")
                        {
                            await openfirebase.AddNoti(item.Topbid_ID, item.Sell_name, item.Sell_num, item.Sell_ID, MyID, item.Highest_bid, 1);
                        }
                        await openfirebase.Update_bid(item.Sell_num, MyID, Int32.Parse(tb_Bidorbuy.Text));
                        MessageBox.Show("입찰완료.", "알림", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
            }
        }

        private async void btn_inter_Click(object sender, EventArgs e)
        {
            if (ck_inter)
            {
                var item = await openfirebase.Select_GetItem(Int32.Parse(item_no));
                await openfirebase.AddInerItem(MyID, Int32.Parse(item_no), item.Sell_name, item.Sell_contents,
                    item.Sell_img, item.Sell_price, item.Sell_ID, item.Topbid_ID, item.Highest_bid, item.Sell_mode);
                btn_inter.Text = "즐겨찾기 해제";
                ck_inter = false;
                MessageBox.Show("즐겨찾기에 추가되었습니다.", "알림", MessageBoxButtons.OK);
            }
            else
            {
                await openfirebase.Delete_InterItem(MyID, Int32.Parse(item_no));
                ck_inter = true;
                btn_inter.Text = "즐겨찾기";
                MessageBox.Show("즐겨찾기에서 삭제되었습니다.", "알림", MessageBoxButtons.OK);

            }
        }

        private async void btn_sellerinfo_Click(object sender, EventArgs e)
        {
            var item = await openfirebase.Select_GetItem(Int32.Parse(item_no));
            TrustCKForm trustCKForm = new TrustCKForm(item.Sell_ID);
            trustCKForm.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateItemForm updateItemForm = new UpdateItemForm(Int32.Parse(item_no));
            updateItemForm.ShowDialog();
            this.Close();
        }



        private void btn_c_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            await openfirebase.Delete_Item(Int32.Parse(item_no));
            MessageBox.Show("삭제되었습니다.", "알림", MessageBoxButtons.OK);
            this.Close();
        }
    }

}
