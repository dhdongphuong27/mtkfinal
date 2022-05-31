using QuanLyCuaHangTienLoi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTienLoi
{
    public partial class frmHD : Form
    {
        Subject subject = new Subject();
        public frmHD()
        {
            InitializeComponent();
        }
        public static string isMainButton = "";

        //Hiển thị giao diện dữ liệu tương ứng với sự kiện click ở giao diện chính (frmMain)
        private void frmHD_Load(object sender, EventArgs e)
        {
            loaiGiamGiaComboBox.SelectedIndex = 0;
            dotGiamGiaComboBox.SelectedIndex = 0;
            if (isMainButton == "themhd")
            {
                try
                {
                    btnUpdateHD.Visible = false;
                    HoaDonDAO.Instance.InsertHD(DateTime.Now);
                    txtNgayHD.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    txtSoHD.Text = DataProvider.Instance.ExcuteScalar("SELECT Max(SoHD) FROM hoadon");
                    txtSoHD.Enabled = false;
                    txtNgayHD.Enabled = false;
                    txtMaHH.Focus();
                }
                catch (Exception) { }
            }
            if (isMainButton == "suahd")
            {
                try
                {
                    btnThanhToan.Visible = false;
                    txtSoHD.Text = frmMain.SoHD;
                    dgvDonHang.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHH, TenHH, DonGia, SL, ThanhTien FROM donhang WHERE SoHD = " + frmMain.SoHD);
                    DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT NgayLap, TongTien FROM hoadon WHERE SoHD = " + int.Parse(frmMain.SoHD));
                    foreach (DataRow dr in dt.Rows)
                    {
                        txtNgayHD.Text = dr["NgayLap"].ToString();
                        tvTongTien.Text = dr["TongTien"].ToString();
                    }
                    txtSoHD.Enabled = false;
                    txtNgayHD.Enabled = false;
                }
                catch (Exception) { }
            }
            if (isMainButton == "xemhd")
            {
                pnEditHD.Visible = false;
                btnThanhToan.Visible = false;
                btnTinhTien.Visible = false;
                try
                {
                    DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM hoadon WHERE SoHD = " + frmMain.SoHD);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            txtSoHD.Text = dr["SoHD"].ToString();
                            txtNgayHD.Text = dr["NgayLap"].ToString();
                            tvTongTien.Text = dr["TongTien"].ToString() + " vnđ";
                            tvSauGiam.Text = dr["SauGiam"].ToString() + " vnđ";
                        }
                    }
                    txtSoHD.Enabled = false;
                    txtNgayHD.Enabled = false;
                    dgvDonHang.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHH, TenHH, DonGia, SL, ThanhTien FROM donhang WHERE SoHD = " + int.Parse(frmMain.SoHD));
                }
                catch (Exception) { }
            }
        }

        //Thêm hàng hóa cho hóa đơn
        private void btnThemHH_Click(object sender, EventArgs e)
        {
            if (txtMaHH.Text == "" || txtSL.Text == "")
            {
                MessageBox.Show("Nhập thông tin cho sản phẩm!");
            }
            else
            {
                try
                {
                    int sohd = int.Parse(txtSoHD.Text);
                    string mahh = txtMaHH.Text;
                    string tenhh = tvTenHH.Text;
                    float gia = float.Parse(tvDonGia.Text);
                    int sl = int.Parse(txtSL.Text);
                    float thanhtien = gia * sl;

                    DonHangDAO.Instance.InsertDH(sohd, mahh, tenhh, gia, sl, thanhtien);
                    DetailPaymentChange dpc = new DetailPaymentChange(mahh, sl);
                    Observer observerHH = new ObserverHangHoa(dpc);
                    subject.Attach(observerHH);
                    //subject.Attach(new Observer(new DetailPaymentChange(mahh, sl));
                    //string query = "UPDATE hanghoa SET SL = SL -" + sl + " WHERE MaHH = '" + mahh + "'";
                    //DataProvider.Instance.ExcuteNonQuery(query);

                    dgvDonHang.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHH, TenHH, DonGia, SL, ThanhTien FROM donhang WHERE SoHD = " + txtSoHD.Text);
                    
                }
                catch (Exception ex){
                    MessageBox.Show(ex.ToString());
                }               
            }
        }

        //Xóa hàng hóa khỏi hóa đơn
        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            if (MaHH == "")
            {
                MessageBox.Show("Hàng hóa không tồn tại!");
            }
            else
            {
                try
                {
                    string id = MaHH;
                    
                    DonHangDAO.Instance.DeleteDH(id);
                    subject.Detach(id);
                    dgvDonHang.DataSource = DataProvider.Instance.ExcuteQuery("SELECT MaHH,TenHH,DonGia,SL,ThanhTien FROM hanghoa WHERE SoHD = " + int.Parse(txtSoHD.Text));
                }
                catch (Exception) { }            
            }
        }

        private void txtMaHH_Leave(object sender, EventArgs e)
        {
            string mahh = txtMaHH.Text;
            DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM hanghoa WHERE MaHH = '" + mahh + "'");
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    tvTenHH.Text = dr["TenHH"].ToString();
                    tvDonGia.Text = dr["GiaBan"].ToString();
                }
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            float gia = float.Parse(tvDonGia.Text);
            int sl = 0;
            if (txtSL.Text != "")
            {
                sl = int.Parse(txtSL.Text);
            }
            float thanhtien = gia * sl;
            tvThanhTien.Text = thanhtien.ToString();
        }

        //Thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                subject.Excute();
                DataProvider.Instance.ExcuteNonQuery("UPDATE hoadon SET TongTien = " + tvTongTien.Text + ", SauGiam = "+ tvSauGiam.Text + " WHERE SoHD = " + txtSoHD.Text);
                this.Hide();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        //Cập nhật hóa đơn
        private void btnUpdateHD_Click(object sender, EventArgs e)
        {
            try
            {
                int sohd = int.Parse(txtSoHD.Text);
                string tongtien = DataProvider.Instance.ExcuteScalar("SELECT SUM(ThanhTien) FROM donhang WHERE SoHD = " + sohd);
                DataProvider.Instance.ExcuteNonQuery("UPDATE hoadon SET TongTien = " + tongtien + " WHERE SoHD = " + sohd);
                tvTongTien.Text = tongtien + " vnđ";
                MessageBox.Show("Đã cập nhật!");
            }
            catch (Exception) 
            {
                int sohd = int.Parse(txtSoHD.Text);
                tvTongTien.Text = "";
                MessageBox.Show("Đã cập nhật!");
                DataProvider.Instance.ExcuteNonQuery("UPDATE hoadon SET TongTien = NULL WHERE SoHD = " + sohd);
            }
            this.Hide();
        }

        public string MaHH = "";
        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MaHH = dgvDonHang.Rows[e.RowIndex].Cells["clMaHH"].FormattedValue.ToString();
            }
            catch (Exception) { }
        }

        private void txtSoHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sohd = int.Parse(txtSoHD.Text);

            string tongtien = DataProvider.Instance.ExcuteScalar("SELECT SUM(ThanhTien) FROM donhang WHERE SoHD = " + sohd);

            MaGiamGia maGiamGia = new MaGiamGia(float.Parse(tongtien), float.Parse(txtMucGiam.Text));
   

            int index = loaiGiamGiaComboBox.SelectedIndex;

            switch (index)
            {
                case 0:
                    maGiamGia.SetCongThucTinhTien(new KhongGiam());
                    break;
                case 1:
                    maGiamGia.SetCongThucTinhTien(new GiamPhanTram());
                    break;
                case 2:
                    maGiamGia.SetCongThucTinhTien(new GiamTrucTiep());
                    break;
            }
            float saugiam = maGiamGia.TinhTien();
            tvTongTien.Text = tongtien;
            tvSauGiam.Text = saugiam.ToString() ;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void loaiGiamGiaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index1 = dotGiamGiaComboBox.SelectedIndex;
            AbstractFactory promotion;
            Discount d = new Weekend().Discount();// gán tạm
            bool flag = false;
            switch (index1)
            {
                case 0:
                    loaiGiamGiaComboBox.SelectedIndex = 0;
                    txtMucGiam.Text = 0.ToString();
                    break;
                case 1:
                    promotion = new Weekend();
                    d = promotion.Discount();
                    flag = true;
                    break;
                case 2:
                    promotion = new Yearend();
                    d = promotion.Discount();
                    flag = true;
                    break;
            }
            if (flag == true)
            {
                loaiGiamGiaComboBox.SelectedIndex = d.LoaiGiamGia();
                txtMucGiam.Text = d.MucGiamGia().ToString();
            }
        }
    }
}
