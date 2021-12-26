using Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace usedauction
{
    public partial class Myitems : Form
    {
        string memID;
        int Mode;
        ConnectFirebase openfirebase = new ConnectFirebase();

        /// <summary>
        /// 마이페이지에서 받아와서 리스트 출력
        /// </summary>
        /// <param name="name"></param>
        /// <param name="itemno"></param>
        /// <param 모드="mode"></param> 1. 판매중, 2. 판매완료, 3. 입찰중, 4. 구매완료, 5. 즐겨찾기
        public Myitems(string id, int mode)
        {
            InitializeComponent();
            memID = id;
            Mode = mode;
        }

        private async void Myitems_Load(object sender, EventArgs e)
        {

            switch (Mode)
            {
                case 1:
                    {
                        this.Text = "판매중인 제품";
                        var items = await openfirebase.Select_GetSeller(memID);
                        foreach (SellingItem item in items)
                        {
                            byte[] imageAsBytes = System.Convert.FromBase64String(item.Sell_img.ToString());
                            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(imageAsBytes);
                            Image image = Image.FromStream(memoryStream);
                            image = resizeImage(image, 50, 50);
                            Dgv_items.Rows.Add(item.Sell_name.ToString(), image, item.Sell_contents.ToString(), item.Sell_price.ToString(), item.Highest_bid.ToString(), item.Sell_num.ToString());
                        }
                        break;
                    }
                case 2:
                    {
                        this.Text = "판매완료된 제품";
                        var items = await openfirebase.Select_GetAllSoldOutItem(memID);
                        foreach (SoldOutItem item in items)
                        {
                            byte[] imageAsBytes = System.Convert.FromBase64String(item.Sell_img.ToString());
                            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(imageAsBytes);
                            Image image = Image.FromStream(memoryStream);
                            image = resizeImage(image, 50, 50);
                            Dgv_items.Rows.Add(item.Sell_name.ToString(), image, item.Sell_contents.ToString(), item.Sell_price.ToString(), item.Highest_bid.ToString(), item.Sell_num.ToString(),item.Sell_ID,item.Topbid_ID);
                        }
                        break;
                    }
                case 3:
                    {
                        this.Text = "입찰중인 제품";
                        var items = await openfirebase.Select_GetAlltopbidItems(memID);
                        foreach (SellingItem item in items)
                        {
                            byte[] imageAsBytes = System.Convert.FromBase64String(item.Sell_img.ToString());
                            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(imageAsBytes);
                            Image image = Image.FromStream(memoryStream);
                            image = resizeImage(image, 50, 50);
                            Dgv_items.Rows.Add(item.Sell_name.ToString(), image, item.Sell_contents.ToString(), item.Sell_price.ToString(), item.Highest_bid.ToString(), item.Sell_num.ToString());
                        }
                        break;
                    }
                case 4:
                    {
                        this.Text = "구매완료 제품";
                        var items = await openfirebase.Select_GetAllBuyItem(memID);
                        foreach (BuyComplete item in items)
                        {
                            byte[] imageAsBytes = System.Convert.FromBase64String(item.Sell_img.ToString());
                            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(imageAsBytes);
                            Image image = Image.FromStream(memoryStream);
                            image = resizeImage(image, 50, 50);
                            Dgv_items.Rows.Add(item.Sell_name.ToString(), image, item.Sell_contents.ToString(), item.Sell_price.ToString(), item.Highest_bid.ToString(), item.Sell_num.ToString(), item.Sell_ID, item.Topbid_ID);
                        }
                        break;
                    }
                case 5:
                    {
                        this.Text = "즐겨찾기 제품";
                        var items = await openfirebase.Select_GetAllInterItem(memID);
                        foreach (Inter_item item in items)
                        {
                            byte[] imageAsBytes = System.Convert.FromBase64String(item.Sell_img.ToString());
                            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(imageAsBytes);
                            Image image = Image.FromStream(memoryStream);
                            image = resizeImage(image, 50, 50);
                            Dgv_items.Rows.Add(item.Sell_name.ToString(), image, item.Sell_contents.ToString(), item.Sell_price.ToString(), item.Highest_bid.ToString(), item.Sell_num.ToString());
                        }
                        break;
                    }

            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Dgv_items_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            int curR = e.RowIndex;
            switch (Mode)
            {
                case 1:
                    {
                        ItemDetailForm detailForm = new ItemDetailForm(grid.Rows[curR].Cells[5].Value.ToString(), memID);
                        detailForm.ShowDialog();
                        break;
                    }
                case 2:
                    {
                        MemberInfoForm memberInfoForm = new MemberInfoForm(grid.Rows[curR].Cells[7].Value.ToString());
                        memberInfoForm.ShowDialog();
                        break;
                    }
                case 3:
                    {
                        ItemDetailForm detailForm = new ItemDetailForm(grid.Rows[curR].Cells[5].Value.ToString(), memID);
                        detailForm.ShowDialog();
                        break;
                    }
                case 4:
                    {
                        MemberInfoForm memberInfoForm = new MemberInfoForm(grid.Rows[curR].Cells[6].Value.ToString());
                        memberInfoForm.ShowDialog();
                        break;
                    }
                case 5:
                    {
                        ItemDetailForm detailForm = new ItemDetailForm(grid.Rows[curR].Cells[5].Value.ToString(), memID);
                        detailForm.ShowDialog();
                        break;
                    }
            }
        }


    }
}
