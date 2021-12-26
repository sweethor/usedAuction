using Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace usedauction
{
    public partial class MainForm : Form
    {
        ConnectFirebase openfirebase = new ConnectFirebase();
        string myid;
        public MainForm(string mem_id)
        {
            myid = mem_id;
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            lbl_Name.Text = myid;
            var items = await openfirebase.Select_GetAllItem();
            foreach (SellingItem item in items)
            {
                byte[] imageAsBytes = System.Convert.FromBase64String(item.Sell_img.ToString());
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(imageAsBytes);
                Image image = Image.FromStream(memoryStream);
                image = resizeImage(image, 50, 50);
                Dgv_items.Rows.Add(item.Sell_name.ToString(), image, item.Sell_contents.ToString(), item.Sell_price.ToString(), item.Highest_bid.ToString(), item.Sell_num.ToString());
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
        // 아이템 전체리스트 받아오기
        private async void btn_AllView_Click(object sender, EventArgs e)
        {
            Dgv_items.Rows.Clear();
            var items = await openfirebase.Select_GetAllItem();
            foreach (SellingItem item in items)
            {
                byte[] imageAsBytes = System.Convert.FromBase64String(item.Sell_img.ToString());
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(imageAsBytes);
                Image image = Image.FromStream(memoryStream);
                image = resizeImage(image, 50, 50);
                Dgv_items.Rows.Add(item.Sell_name.ToString(), image, item.Sell_contents.ToString(), item.Sell_price.ToString(), item.Highest_bid.ToString(), item.Sell_num.ToString());
            }
        }

        private async void btn_Top10_Click(object sender, EventArgs e)
        {
            Dgv_items.Rows.Clear();
            var items = await openfirebase.Select_GetTop10();
            foreach (SellingItem item in items)
            {
                byte[] imageAsBytes = System.Convert.FromBase64String(item.Sell_img.ToString());
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(imageAsBytes);
                Image image = Image.FromStream(memoryStream);
                image = resizeImage(image, 50, 50);
                Dgv_items.Rows.Add(item.Sell_name.ToString(), image, item.Sell_contents.ToString(), item.Sell_price.ToString(), item.Highest_bid.ToString(), item.Sell_num.ToString());
            }
        }

        private async void cmb_Cate_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_Cate.Text)
            {
                case "IT":
                    {
                        Dgv_items.Rows.Clear();
                        var items = await openfirebase.Select_GetCategory(1);
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
                case "가전제품":
                    {
                        Dgv_items.Rows.Clear();
                        var items = await openfirebase.Select_GetCategory(2);
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
                case "헬스":
                    {
                        Dgv_items.Rows.Clear();
                        var items = await openfirebase.Select_GetCategory(3);
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
                case "잡화":
                    {
                        Dgv_items.Rows.Clear();
                        var items = await openfirebase.Select_GetCategory(4);
                        foreach (SellingItem item in items)
                        {
                            byte[] imageAsBytes = System.Convert.FromBase64String(item.Sell_img.ToString());
                            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(imageAsBytes);
                            Image image = Image.FromStream(memoryStream);
                            image = resizeImage(image, 50, 50);
                            Dgv_items.Rows.Add(item.Sell_name.ToString(), image, item.Sell_contents.ToString(), item.Sell_price.ToString(), item.Highest_bid.ToString(), item.Sell_num.ToString()

                                );
                        }
                        break;
                    }

            }
        }

        private void Dgv_items_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = sender as DataGridView;
            int curR = e.RowIndex;
            ItemDetailForm detailForm = new ItemDetailForm(grid.Rows[curR].Cells[5].Value.ToString(), myid);
            detailForm.ShowDialog();

        }

        private async void btn_Search_Click(object sender, EventArgs e)
        {
            Dgv_items.Rows.Clear();
            var items = await openfirebase.Select_GetName(txt_Search.Text);
            foreach (SellingItem item in items)
            {
                byte[] imageAsBytes = System.Convert.FromBase64String(item.Sell_img.ToString());
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(imageAsBytes);
                Image image = Image.FromStream(memoryStream);
                image = resizeImage(image, 50, 50);
                Dgv_items.Rows.Add(item.Sell_name.ToString(), image, item.Sell_contents.ToString(), item.Sell_price.ToString(), item.Highest_bid.ToString(), item.Sell_num

                    );
            }
        }

        private void btn_MyPage_Click(object sender, EventArgs e)
        {
            MyPageForm myPageForm = new MyPageForm(myid);
            myPageForm.ShowDialog();
        }

        private void btn_NewItem_Click(object sender, EventArgs e)
        {
            NewItemForm newItemForm = new NewItemForm(myid);
            newItemForm.ShowDialog();
        }
    }
}
