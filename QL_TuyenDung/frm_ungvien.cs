using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Library;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace QL_TuyenDung
{
    public partial class frm_ungvien : Form
    {
        Xuly_NoSQL xuly = new Xuly_NoSQL();
        int dachon = 0;
        string tenColection = "ungvien";
        public frm_ungvien()
        {
            InitializeComponent();
            docdulieu(tenColection);
            txt_idUV.ReadOnly = true;
            AddDataToComboBox();
        }

        public void docdulieu(string colectionName)
        {
            DataTable dataTable;

            // Gọi hàm LoadData và lưu trữ dữ liệu vào biến dataTable
            Xuly_NoSQL xulyNoSQL = new Xuly_NoSQL();
            dataTable = xulyNoSQL.LoadData(colectionName); // Thay "TenCollection" bằng tên của bảng MongoDB của bạn

            // Đặt DataSource của DataGridView
            dgv_ungvien.DataSource = dataTable;
            //dgv_ungvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dgv_ungvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đặt kích thước của DataGridView để tự động điều chỉnh kích thước cột dựa trên nội dung
            //dgv_ungvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Đặt kích thước của DataGridView để tự động điều chỉnh kích thước hàng dựa trên nội dung

        }

        // Hàm để thêm dữ liệu vào ComboBox
        private void AddDataToComboBox()
        {
            // Xóa tất cả các mục hiện có trong ComboBox (nếu cần)
            cbb_trangthaiUV.Items.Clear();

            cbb_trangthaiUV.Items.Add("Chưa xem xét");
            cbb_trangthaiUV.Items.Add("Đang xem xét");
            cbb_trangthaiUV.Items.Add("Đã phỏng vấn");
            cbb_trangthaiUV.Items.Add("Đã từ chối");
            cbb_trangthaiUV.Items.Add("Đạt");

            cbb_kqPV_UV.Items.Clear();
            cbb_kqPV_UV.Items.Add("Đạt");
            cbb_kqPV_UV.Items.Add("Không đạt");
            cbb_kqPV_UV.Items.Add("Chưa đạt");
            cbb_kqPV_UV.Items.Add("Chưa xem");
            cbb_kqPV_UV.Items.Add("Đang xem xét");

        }

        public BsonDocument TaoJSON(string trangThaiUngTuyenUV)
        {
            BsonDocument document = new BsonDocument
            {
                { "MaUV", txt_maUV.Text },
                { "HoTen", txt_hoTenUV.Text },
                { "Tuoi", Convert.ToInt32(txt_tuoiUV.Text) },
            };

            BsonDocument ThongTinLH = new BsonDocument
            {
                { "SoDT", txt_sdtUV.Text },
                { "Email", txt_emailUV.Text },
            };

            document.Add("ThongTinLH", ThongTinLH);

            // Thêm các trường mới vào document sau ThongTinLH
            document.Add("KinhNghiem", txt_kinhnghiemUV.Text);
            document.Add("HocVan", txt_hocVanUV.Text);
            document.Add("KyNang", txt_kyNangUV.Text);
            document.Add("BangCapKhac", txt_bangcapKhacUV.Text);

            BsonDocument donXinUngTuyen = new BsonDocument
            {
                { "MaCV", txt_maCV_UV.Text },
                { "NgayNopDon", BsonDateTime.Create(dtb_ngaynopdon_UV.Value) },
                { "TrangThai", trangThaiUngTuyenUV }
            };

            if (trangThaiUngTuyenUV == "Đạt" || trangThaiUngTuyenUV == "Đang xem xét" || trangThaiUngTuyenUV == "Đã phỏng vấn")
            {
                donXinUngTuyen.Add("CuocPhongVan", new BsonDocument
                {
                    { "NgayPV", BsonDateTime.Create(dtb_ngayPV_UV.Value) },
                    { "KetQuaPV", cbb_kqPV_UV.Text },
                    { "ThongTinKhac", txt_thongTinKhacUV.Text }
                });
            }
            else
            {
                donXinUngTuyen.Add("CuocPhongVan", BsonNull.Value);
            }

            document.Add("DonXinUngTuyen", donXinUngTuyen);

            return document;
        }











        public void dgv_ungvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowDangChon = dgv_ungvien.Rows[e.RowIndex];
                txt_idUV.Text = rowDangChon.Cells[0].Value.ToString();
                txt_maUV.Text = rowDangChon.Cells[1].Value.ToString();
                txt_hoTenUV.Text = rowDangChon.Cells[2].Value.ToString();

                txt_tuoiUV.Text = rowDangChon.Cells[3].Value.ToString();
                txt_sdtUV.Text = rowDangChon.Cells[4].Value.ToString();
                txt_emailUV.Text = rowDangChon.Cells[5].Value.ToString();

                txt_kinhnghiemUV.Text = rowDangChon.Cells[6].Value.ToString();
                txt_hocVanUV.Text = rowDangChon.Cells[7].Value.ToString();

                txt_kyNangUV.Text = rowDangChon.Cells[8].Value.ToString();
                txt_bangcapKhacUV.Text = rowDangChon.Cells[9].Value.ToString();

                txt_maCV_UV.Text = rowDangChon.Cells[10].Value.ToString();

                // Lấy ngày tháng từ cột Index 11 (dtb_ngaynopdon_UV)
                string ngayNopDon = rowDangChon.Cells[11].Value.ToString();
                // Chuyển đổi ngày tháng từ chuỗi sang DateTime
                DateTime ngayNopDonDateTime = DateTime.Parse(ngayNopDon);
                // Gán giá trị DateTime vào DateTimePicker
                dtb_ngaynopdon_UV.Value = ngayNopDonDateTime;

                // Lấy giá trị từ cột Index 12 (cbb_trangthaiUV)
                string trangThaiUV = rowDangChon.Cells[12].Value.ToString();
                // Gán giá trị vào ComboBox cbb_trangthaiUV
                cbb_trangthaiUV.Text = trangThaiUV;




                // Lấy ngày tháng từ cột Index 13 (dtb_ngayPV_UV)
                string ngayPV = rowDangChon.Cells[13].Value.ToString();
                if (ngayPV != "BsonNull")
                {
                    // Chuyển đổi ngày tháng từ chuỗi sang DateTime
                    DateTime ngayPVDateTime = DateTime.Parse(ngayPV);
                    // Gán giá trị DateTime vào DateTimePicker
                    dtb_ngayPV_UV.Value = ngayPVDateTime;


                    // Lấy giá trị từ cột Index 14 (cbb_kqPV_UV)
                    string kqPVUV = rowDangChon.Cells[14].Value.ToString();
                    // Gán giá trị vào ComboBox cbb_kqPV_UV
                    cbb_kqPV_UV.Text = kqPVUV;


                    txt_thongTinKhacUV.Text = rowDangChon.Cells[15].Value.ToString();
                }
                else
                {
                    txt_thongTinKhacUV.Text = "";
                    dtb_ngayPV_UV.Value = DateTime.Now;
                }

            }
        }

        private void btn_dat_Click(object sender, EventArgs e)
        {

            try
            {
                string trangThaiUngTuyenUV = "Đạt";
                BsonDocument bsonDocument = TaoJSON(trangThaiUngTuyenUV);
                xuly.ThemDocumentVaoCollection(tenColection, bsonDocument);
                docdulieu(tenColection);
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin ứng viên");
            }

        }

        private void btn_daphongvan_Click(object sender, EventArgs e)
        {

            try
            {
                string trangThaiUngTuyenUV = "Đã phỏng vấn";
                BsonDocument bsonDocument = TaoJSON(trangThaiUngTuyenUV);
                xuly.ThemDocumentVaoCollection(tenColection, bsonDocument);
                docdulieu(tenColection);
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin ứng viên");
            }

        }

        private void btn_dangxemxet_Click(object sender, EventArgs e)
        {

            try
            {
                string trangThaiUngTuyenUV = "Đang xem xét";
                BsonDocument bsonDocument = TaoJSON(trangThaiUngTuyenUV);
                xuly.ThemDocumentVaoCollection(tenColection, bsonDocument);
                docdulieu(tenColection);
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin ứng viên");
            }

        }

        private void btn_chuaxemxet_Click(object sender, EventArgs e)
        {

            try
            {
                string trangThaiUngTuyenUV = "Chưa xem xét";
                BsonDocument bsonDocument = TaoJSON(trangThaiUngTuyenUV);
                xuly.ThemDocumentVaoCollection(tenColection, bsonDocument);
                docdulieu(tenColection);
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin ứng viên");
            }

        }

        private void btn_datuchoi_Click(object sender, EventArgs e)
        {

            try
            {
                string trangThaiUngTuyenUV = "Đã từ chối";
                BsonDocument bsonDocument = TaoJSON(trangThaiUngTuyenUV);
                xuly.ThemDocumentVaoCollection(tenColection, bsonDocument);
                docdulieu(tenColection);
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin ứng viên");
            }

        }

        private void btn_dat_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string trangThaiUngTuyenUV = "Đạt";
                BsonDocument bsonDocument = TaoJSON(trangThaiUngTuyenUV);
                xuly.SuaDocumentTrongCollection(tenColection, txt_idUV.Text, bsonDocument);
                docdulieu(tenColection);
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin ứng viên");
            }
        }

        private void btn_daPV_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string trangThaiUngTuyenUV = "Đã phỏng vấn";
                BsonDocument bsonDocument = TaoJSON(trangThaiUngTuyenUV);
                xuly.SuaDocumentTrongCollection(tenColection, txt_idUV.Text, bsonDocument);
                docdulieu(tenColection);
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin ứng viên");
            }
        }

        private void btn_dangXem_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string trangThaiUngTuyenUV = "Đang xem xét";
                BsonDocument bsonDocument = TaoJSON(trangThaiUngTuyenUV);
                xuly.SuaDocumentTrongCollection(tenColection, txt_idUV.Text, bsonDocument);
                docdulieu(tenColection);
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin ứng viên");
            }
        }

        private void btn_chuaxem_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string trangThaiUngTuyenUV = "Chưa xem xét";
                BsonDocument bsonDocument = TaoJSON(trangThaiUngTuyenUV);
                xuly.SuaDocumentTrongCollection(tenColection, txt_idUV.Text, bsonDocument);
                docdulieu(tenColection);
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin ứng viên");
            }
        }

        private void btn_tuchoi_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string trangThaiUngTuyenUV = "Đã từ chối";
                BsonDocument bsonDocument = TaoJSON(trangThaiUngTuyenUV);
                xuly.SuaDocumentTrongCollection(tenColection, txt_idUV.Text, bsonDocument);
                docdulieu(tenColection);
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin ứng viên");
            }
        }

        private void btn_xoaUV_Click(object sender, EventArgs e)
        {
            try
            {
               
                xuly.XoaDocumentTrongCollection(tenColection, txt_idUV.Text);
                docdulieu(tenColection);
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn ứng viên để xóa");
            }
        }
    }
}
