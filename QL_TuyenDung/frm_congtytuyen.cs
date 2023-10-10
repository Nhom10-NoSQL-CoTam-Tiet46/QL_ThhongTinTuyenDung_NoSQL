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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Imaging;

namespace QL_TuyenDung
{
    public partial class frm_congtytuyen : Form
    {
        Xuly_NoSQL xuly = new Xuly_NoSQL();
        int dachon = 0;
        string tenColection = "congty";
        BsonArray dsCV = new BsonArray();
        BsonArray dsCTY = new BsonArray();
        private object txt_emailUV;

        public frm_congtytuyen()
        {
            InitializeComponent();
            //docdulieu(tenColection);
            hienthi();
            txt_id.ReadOnly = true;
        }


        // ham them

        public void themmotacv()
        {
            var connectionString = "mongodb://localhost:27017/admin";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var db = server.GetDatabase("QL_Tuyendung");
            var collection = db.GetCollection<BsonDocument>("congty");
            BsonDocument cv1 = new BsonDocument();
            //dong moi
            cv1.Add("MaCV", txtmacv.Text);
            cv1.Add("TenCV", txttencv.Text);
            cv1.Add("Luong", txtluong.Text);
            dsCV.Add(cv1);
            foreach (BsonDocument document in collection.FindAll())
            {
                if (document.GetElement("MaCTY").Value.ToString() == txtmacty.Text)
                {
                    document.GetElement("TenCTY").Value.ToString();
                    document["MoTaCV"] = dsCV;
                    collection.Save(document);
                    MessageBox.Show("Them cv thành công");
                    break;
                }
            }

            hienthi();
        }
        public BsonDocument TaoJSON()
        {
            BsonDocument document = new BsonDocument
            {
                { "MaCTY", txtmacty.Text },
                { "TenCTY", txttencty.Text },
                { "DiaChi",(txtdiachi.Text) },
                { "SoDT", (txtsdt.Text) },
            };
            BsonArray Dg = new BsonArray();
            document.Add("MoTaCV", Dg);
            return document;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost:27017/admin";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var db = server.GetDatabase("QL_Tuyendung");
            var collection = db.GetCollection<BsonDocument>("congty");


            BsonDocument document = new BsonDocument();
            document.Add("MaCTY", txtmacty.Text);
            document.Add("TenCTY", txttencty.Text);
            document.Add("DiaChi", txtdiachi.Text);

            document.Add("SoDT", txtsdt.Text);


            BsonArray Dg = new BsonArray();
            document.Add("MoTaCV", Dg);
            //document.Add("MaCV", txtmacv.Text);
            //document.Add("TenCV", txttencv.Text);
            //document.Add("Luong", txtluong.Text);
            //Dg.Add(document);
            collection.Insert(document);
            foreach (BsonDocument document1 in collection.FindAll())
            {
                {
                    document["MoTaCV"] = Dg;
                    collection.Save(document1);
                }
            }
            //themmotacv();
            MessageBox.Show("Thêm thành công");
            hienthi();

        }

        void hienthi()
        {
            var connectionString = "mongodb://localhost:27017/admin";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var db = server.GetDatabase("QL_Tuyendung");
            var collection = db.GetCollection<BsonDocument>("congty");
            listView1.Items.Clear();
            foreach (BsonDocument document in collection.FindAll())
            {
                ListViewItem lvi = listView1.Items.Add(document.GetElement("MaCTY").Value.ToString());
                lvi.SubItems.Add(document.GetElement("TenCTY").Value.ToString());
                lvi.SubItems.Add(document.GetElement("DiaChi").Value.ToString());
                lvi.SubItems.Add(document.GetElement("SoDT").Value.ToString());

            }
        }
        private void frm_congtytuyen_Load(object sender, EventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string id = "";
            var connectionString = "mongodb://localhost:27017/admin";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var db = server.GetDatabase("QL_Tuyendung");
            var collection = db.GetCollection<BsonDocument>("congty");
            foreach (BsonDocument document in collection.FindAll())
            {
                //MessageBox.Show("" + document.GetElement("_id").Value.ToString());
                if (document.GetElement("MaCTY").Value.ToString() == txtmacty.Text)
                {
                    id = document.GetElement("_id").Value.ToString();
                    xuly.XoaDocumentTrongCollection(tenColection, id);
                    break;
                }

            }
            hienthi();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            string id = "";
            var connectionString = "mongodb://localhost:27017/admin";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var db = server.GetDatabase("QL_Tuyendung");
            var collection = db.GetCollection<BsonDocument>("congty");
            foreach (BsonDocument document in collection.FindAll())
            {
                //MessageBox.Show("" + document.GetElement("_id").Value.ToString());
                if (document.GetElement("MaCTY").Value.ToString() == txtmacty.Text)
                {
                    id = document.GetElement("_id").Value.ToString();

                    break;
                }

            }
            try
            {

                BsonDocument bsonDocument = TaoJSON();
                xuly.SuaDocumentTrongCollection(tenColection, id, bsonDocument);
                hienthi();
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin ứng viên");
            }

            BsonDocument capnhat = new BsonDocument();
            capnhat.Add("MaCV", txtmacv.Text);
            capnhat.Add("TenCV", txttencv.Text);
            capnhat.Add("Luong", txtluong.Text);
            foreach (BsonDocument document in collection.FindAll())
            {
                if (document.GetElement("MaCTY").Value.ToString() == txtmacty.Text)
                {
                    foreach (BsonDocument sp in dsCV)
                    {
                        if (sp.GetElement("MaCV").Value.ToString() == txtmacv.Text)
                        {

                            dsCV.Remove(sp);
                            dsCV.Add(capnhat);
                            document["MoTaCV"] = dsCV;
                            collection.Save(document);
                            break;
                        }
                    }
                }
            }
            hienthi();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                var connectionString = "mongodb://localhost:27017/admin";
                var client = new MongoClient(connectionString);
                var server = client.GetServer();
                var db = server.GetDatabase("QL_Tuyendung");
                var collection = db.GetCollection<BsonDocument>("congty");
                dsCV.Clear();
                foreach (BsonDocument document in collection.FindAll())
                {
                    if (document.GetElement("MaCTY").Value.ToString() == listView1.SelectedItems[0].SubItems[0].Text)
                    {
                        txtmacty.Text = document.GetElement("MaCTY").Value.ToString();
                        txttencty.Text = document.GetElement("TenCTY").Value.ToString();
                        txtdiachi.Text = document.GetElement("DiaChi").Value.ToString();
                        txtsdt.Text = document.GetElement("SoDT").Value.ToString();
                        listView2.Items.Clear();
                        foreach (BsonDocument cv in document["MoTaCV"].AsBsonArray)
                        {
                            ListViewItem lvi = listView2.Items.Add(cv.GetElement("MaCV").Value.ToString());
                            lvi.SubItems.Add(cv.GetElement("TenCV").Value.ToString());
                            lvi.SubItems.Add(cv.GetElement("Luong").Value.ToString());

                            dsCV.Add(cv);

                        }
                    }
                }
                hienthi();
            }


        }

        private void btthemcv_Click(object sender, EventArgs e)
        {
            themmotacv();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                txtmacv.Text = listView2.SelectedItems[0].SubItems[0].Text;
                txttencv.Text = listView2.SelectedItems[0].SubItems[1].Text;
                txtluong.Text = listView2.SelectedItems[0].SubItems[2].Text;
            }




            // hienthi();
        }

        private void btsua_cv_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost:27017/admin";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var db = server.GetDatabase("QL_Tuyendung");
            var collection = db.GetCollection<BsonDocument>("congty");
            BsonDocument capnhat = new BsonDocument();
            capnhat.Add("MaCV", txtmacv.Text);
            capnhat.Add("TenCV", txttencv.Text);
            capnhat.Add("Luong", txtluong.Text);
            foreach (BsonDocument document in collection.FindAll())
            {
                if (document.GetElement("MaCTY").Value.ToString() == txtmacty.Text)
                {
                    foreach (BsonDocument sp in dsCV)
                    {

                        if (sp.GetElement("MaCV").Value.ToString() == txtmacv.Text)
                        {

                            dsCV.Remove(sp);
                            dsCV.Add(capnhat);
                            document["MoTaCV"] = dsCV;
                            collection.Save(document);
                            break;
                        }
                    }
                }
            }
            //collection.Save(document);
            hienthi();
        }
    }
}
