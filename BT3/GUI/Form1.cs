using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;
            panel2.Paint += panel2_Paint;
            panel3.Paint += panel3_Paint;
            panel4.Paint += panel4_Paint;
            panel5.Paint += panel5_Paint;
            panel6.Paint += panel6_Paint;
            panel7.Paint += panel7_Paint;
            panel8.Paint += panel8_Paint;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Bo góc Panel
            int cornerRadius = 20;
            Panel pnl = sender as Panel;

            // Dùng GraphicsPath để bo góc
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            // Thiết lập vùng bo góc cho Panel
            pnl.Region = new Region(path);

            // Vẽ viền với màu và độ dày tùy chỉnh
            using (Pen pen = new Pen(Color.LightBlue, 4)) // Thay đổi màu và độ dày viền
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Bo góc Panel
            int cornerRadius = 20;
            Panel pnl = sender as Panel;

            // Dùng GraphicsPath để bo góc
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            // Thiết lập vùng bo góc cho Panel
            pnl.Region = new Region(path);

            // Vẽ viền với màu và độ dày tùy chỉnh
            using (Pen pen = new Pen(Color.LightBlue, 4)) // Thay đổi màu và độ dày viền
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Bo góc Panel
            int cornerRadius = 20;
            Panel pnl = sender as Panel;

            // Dùng GraphicsPath để bo góc
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            // Thiết lập vùng bo góc cho Panel
            pnl.Region = new Region(path);

            // Vẽ viền với màu và độ dày tùy chỉnh
            using (Pen pen = new Pen(Color.LightBlue, 4)) // Thay đổi màu và độ dày viền
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // Bo góc Panel
            int cornerRadius = 20;
            Panel pnl = sender as Panel;

            // Dùng GraphicsPath để bo góc
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            // Thiết lập vùng bo góc cho Panel
            pnl.Region = new Region(path);

            // Vẽ viền với màu và độ dày tùy chỉnh
            using (Pen pen = new Pen(Color.LightBlue, 4)) // Thay đổi màu và độ dày viền
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // Bo góc Panel
            int cornerRadius = 20;
            Panel pnl = sender as Panel;

            // Dùng GraphicsPath để bo góc
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            // Thiết lập vùng bo góc cho Panel
            pnl.Region = new Region(path);

            // Vẽ viền với màu và độ dày tùy chỉnh
            using (Pen pen = new Pen(Color.LightBlue, 4)) // Thay đổi màu và độ dày viền
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            // Bo góc Panel
            int cornerRadius = 20;
            Panel pnl = sender as Panel;

            // Dùng GraphicsPath để bo góc
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            // Thiết lập vùng bo góc cho Panel
            pnl.Region = new Region(path);

            // Vẽ viền với màu và độ dày tùy chỉnh
            using (Pen pen = new Pen(Color.LightBlue, 4)) // Thay đổi màu và độ dày viền
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            // Bo góc Panel
            int cornerRadius = 20;
            Panel pnl = sender as Panel;

            // Dùng GraphicsPath để bo góc
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            // Thiết lập vùng bo góc cho Panel
            pnl.Region = new Region(path);

            // Vẽ viền với màu và độ dày tùy chỉnh
            using (Pen pen = new Pen(Color.LightBlue, 4)) // Thay đổi màu và độ dày viền
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            // Bo góc Panel
            int cornerRadius = 20;
            Panel pnl = sender as Panel;

            // Dùng GraphicsPath để bo góc
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(pnl.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(pnl.Width - cornerRadius, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, pnl.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            // Thiết lập vùng bo góc cho Panel
            pnl.Region = new Region(path);

            // Vẽ viền với màu và độ dày tùy chỉnh
            using (Pen pen = new Pen(Color.LightBlue, 4)) // Thay đổi màu và độ dày viền
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào trước khi lưu
            int productId;
            if (!int.TryParse(txbProductID.Text, out productId))
            {
                MessageBox.Show("Mã sản phẩm phải là số nguyên.");
                return;
            }

            int quantity;
            if (!int.TryParse(txbQuantity.Text, out quantity))
            {
                MessageBox.Show("Số lượng phải là số nguyên.");
                return;
            }

            decimal price;
            if (!decimal.TryParse(txbPrice.Text, out price))
            {
                MessageBox.Show("Đơn giá phải là số thập phân.");
                return;
            }

            // Nếu không có lỗi, tiếp tục lưu sản phẩm
            SanPhamDTO sp = new SanPhamDTO
            {
                MaSanPham = productId,
                TenSanPham = txbProductName.Text,
                SoLuong = quantity,
                DonGia = price,
                XuatXu = txbOrigin.Text,
                NgayHetHan = dtpExpiryDate.Value
            };

            SanPhamBLL bll = new SanPhamBLL();

            // Kiểm tra mã sản phẩm có tồn tại trong database hay không
            if (bll.KiemTraMaSanPhamTonTai(productId))
            {
                // Hiển thị MessageBox với lựa chọn Yes/No
                DialogResult result = MessageBox.Show("Mã sản phẩm đã tồn tại, bạn có muốn chỉnh sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Người dùng chọn Yes, thực hiện cập nhật sản phẩm
                    bll.SuaSanPham(sp);
                }
                else
                {
                    // Người dùng chọn No, thoát mà không làm gì
                    return;
                }
            }
            else
            {
                // Nếu mã sản phẩm chưa tồn tại, thực hiện thêm mới
                bll.ThemSanPham(sp);
            }

            // Cập nhật DataGridView
            dataGridView2.DataSource = bll.LayDanhSachSanPham();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có dòng nào được chọn
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Lấy mã sản phẩm từ dòng được chọn
                int maSanPham = int.Parse(dataGridView2.SelectedRows[0].Cells["MaSanPham"].Value.ToString());

                // Xác nhận người dùng có muốn xóa sản phẩm hay không
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa sản phẩm
                    SanPhamBLL bll = new SanPhamBLL();
                    bll.XoaSanPham(maSanPham);

                    // Cập nhật lại DataGridView sau khi xóa
                    dataGridView2.DataSource = bll.LayDanhSachSanPham();
                }
            }
            else
            {
                // Thông báo nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
            }
        }


        private void btnHighestPrice_Click(object sender, EventArgs e)
        {
            SanPhamBLL bll = new SanPhamBLL();
            dataGridView1.DataSource = bll.TimSanPhamDonGiaCaoNhat();
        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            SanPhamBLL bll = new SanPhamBLL();
            dataGridView1.DataSource = bll.TimSanPhamXuatXuNhatBan();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập giá bắt đầu hoặc giá kết thúc trống
            if (string.IsNullOrWhiteSpace(StartPrice.Text) || string.IsNullOrWhiteSpace(EndPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập cả giá trị bắt đầu và kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal startPrice;
            decimal endPrice;

            // Kiểm tra nếu giá trị bắt đầu hoặc kết thúc không phải là số hợp lệ
            if (!decimal.TryParse(StartPrice.Text, out startPrice))
            {
                MessageBox.Show("Giá trị bắt đầu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(EndPrice.Text, out endPrice))
            {
                MessageBox.Show("Giá trị kết thúc không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu giá trị bắt đầu lớn hơn giá trị kết thúc
            if (startPrice > endPrice)
            {
                MessageBox.Show("Giá trị bắt đầu không được lớn hơn giá trị kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu không có lỗi, tiếp tục lọc sản phẩm theo khoảng giá
            SanPhamBLL bll = new SanPhamBLL();
            dataGridView1.DataSource = bll.LaySanPhamTrongKhoangGia(startPrice, endPrice);
        }


        private void btnExpiryDate_Click(object sender, EventArgs e)
        {
            SanPhamBLL bll = new SanPhamBLL();
            dataGridView1.DataSource = bll.LaySanPhamQuaHan();
        }

        private void btnDeleteOrigin_Click(object sender, EventArgs e)
        {
            string origin = txbFilterOrigin.Text;

            SanPhamBLL bll = new SanPhamBLL();
            DataTable dt = bll.LayDanhSachSanPham();

            foreach (DataRow row in dt.Rows)
            {
                if (row["XuatXu"].ToString() == origin)
                {
                    bll.XoaSanPham((int)row["MaSanPham"]);
                }
            }

            dataGridView2.DataSource = bll.LayDanhSachSanPham();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            SanPhamBLL bll = new SanPhamBLL();
            DataTable dt = bll.LayDanhSachSanPham();

            foreach (DataRow row in dt.Rows)
            {
                bll.XoaSanPham((int)row["MaSanPham"]);
            }

            dataGridView2.DataSource = bll.LayDanhSachSanPham();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SanPhamBLL bll = new SanPhamBLL();
            DataTable dt = bll.LayDanhSachSanPham();
            dataGridView2.DataSource = bll.LayDanhSachSanPham();

        }

        private void btnCheckDate_Click(object sender, EventArgs e)
        {
            SanPhamBLL bll = new SanPhamBLL();

            // Lấy danh sách sản phẩm quá hạn dưới dạng DataTable
            DataTable sanPhamQuaHan = bll.LaySanPhamQuaHan();

            // Đếm số lượng sản phẩm quá hạn
            int soLuongSanPhamQuaHan = sanPhamQuaHan.Rows.Count;

            // Hiển thị thông báo cho người dùng
            MessageBox.Show($"Có {soLuongSanPhamQuaHan} sản phẩm đã quá hạn.", "Kiểm tra hạn sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteAllDate_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả các sản phẩm quá hạn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                SanPhamBLL bll = new SanPhamBLL();
                bll.XoaSanPhamQuaHan();

                // Cập nhật DataGridView sau khi xóa
                dataGridView2.DataSource = bll.LayDanhSachSanPham();

                // Hiển thị thông báo sau khi xóa thành công
                MessageBox.Show("Tất cả các sản phẩm quá hạn đã được xóa.", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
