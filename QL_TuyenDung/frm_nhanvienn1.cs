using MongoDB.Bson;
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
using WinForms_Library;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
namespace QL_TuyenDung
{
    public partial class frm_nhanvienn1 : Form
    {
        Xuly_NoSQL xuly = new Xuly_NoSQL();
        int dachon = 0;
        string tenColection = "nhanvien";
        public frm_nhanvienn1()
        {
            InitializeComponent();
            docdulieu(tenColection);
            // txt_idUV.ReadOnly = true;
        }
        public void docdulieu(string colectionName)
        {
            DataTable dataTable;

            // Gọi hàm LoadData và lưu trữ dữ liệu vào biến dataTable
            Xuly_NoSQL xulyNoSQL = new Xuly_NoSQL();
            dataTable = xulyNoSQL.LoadData(tenColection); // Thay "TenCollection" bằng tên của bảng MongoDB của bạn

            // Đặt DataSource của DataGridView
            dataGridView1.DataSource = dataTable;
            //dgv_ungvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dgv_ungvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Đặt kích thước của DataGridView để tự động điều chỉnh kích thước cột dựa trên nội dung
            //dgv_ungvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Đặt kích thước của DataGridView để tự động điều chỉnh kích thước hàng dựa trên nội dung

        }
        public BsonDocument TaoJSON()
        {
            BsonDocument document = new BsonDocument
            {
                { "MaNV", txtmanv.Text },
                { "TenNV", txttennv.Text },
                { "Tuoi", Convert.ToInt32(txttuoi.Text) },
                { "PhongBan", txtphongban.Text },
                { "ChucVu", txtchucvu.Text },
            };

            BsonDocument ThongTinLH = new BsonDocument
            {
                { "SoDT", txtsdt.Text },
                { "Email", txtemail.Text },
            };

            document.Add("ThongTinLH", ThongTinLH);

            // Thêm các trường mới vào document sau ThongTinLH



            return document;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                BsonDocument bsonDocument = TaoJSON();
                xuly.ThemDocumentVaoCollection(tenColection, bsonDocument);
                docdulieu(tenColection);
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin ứng viên");
            }
        }

        private void txtxoa_Click(object sender, EventArgs e)
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

        private void txtsua_Click(object sender, EventArgs e)
        {
            try
            {

                BsonDocument bsonDocument = TaoJSON();
                xuly.SuaDocumentTrongCollection(tenColection, txt_idUV.Text, bsonDocument);
                docdulieu(tenColection);
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin ứng viên");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rowDangChon = dataGridView1.Rows[e.RowIndex];
                txt_idUV.Text = rowDangChon.Cells[0].Value.ToString();
                txtmanv.Text = rowDangChon.Cells[1].Value.ToString();
                txttennv.Text = rowDangChon.Cells[2].Value.ToString();

                txttuoi.Text = rowDangChon.Cells[3].Value.ToString();
                txtphongban.Text = rowDangChon.Cells[4].Value.ToString();
                txtchucvu.Text = rowDangChon.Cells[5].Value.ToString();

                txtsdt.Text = rowDangChon.Cells[6].Value.ToString();
                txtemail.Text = rowDangChon.Cells[7].Value.ToString();
            }
        }
    }
}
