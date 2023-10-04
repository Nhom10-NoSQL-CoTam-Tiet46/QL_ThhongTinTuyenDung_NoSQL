using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace WinForms_Library
{
    public class Xuly_NoSQL
    {
        public MongoClient client;
        public IMongoDatabase database;


        public Xuly_NoSQL(string databasename)
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase(databasename);

        }

        public Xuly_NoSQL()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("QL_Tuyendung");

        }
               

        public string kiemTraDN(string username, string password)
        {
            var collection = database.GetCollection<BsonDocument>("login");

            // Tạo một BsonDocument để truy vấn dựa trên thông tin đăng nhập
            var filter = Builders<BsonDocument>.Filter.Eq("TaiKhoanQly", username) &
                         Builders<BsonDocument>.Filter.Eq("MatKhauQly", password);

            // Tìm Document phù hợp
            var document = collection.Find(filter).FirstOrDefault();

            // Nếu document khác null, trả về giá trị của thuộc tính "TaiKhoanQly"
            if (document != null)
            {
                return document["TaiKhoanQly"].AsString;
            }

            // Nếu không tìm thấy Document phù hợp, trả về null hoặc một giá trị thích hợp để biểu thị không đăng nhập thành công
            return null;
        }

        public DataTable LoadData(string collectionName)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var documents = collection.Find(new BsonDocument()).ToList();

            DataTable dataTable = new DataTable();
            bool columnsCreated = false;

            foreach (var data in documents)
            {
                if (!columnsCreated)
                {
                    // Tạo các cột trong DataTable dựa trên các trường và các trường con trong document đầu tiên
                    foreach (var element in data.Elements)
                    {
                        CreateColumnsFromElement(dataTable, element, "");
                    }

                    columnsCreated = true;
                }

                // Thêm dữ liệu từ Document vào DataTable
                var rowData = new List<object>();
                foreach (var element in data.Elements)
                {
                    ExtractDataFromElement(rowData, element);
                }

                dataTable.Rows.Add(rowData.ToArray());
            }

            return dataTable;
        }

        public void CreateColumnsFromElement(DataTable dataTable, BsonElement element, string prefix)
        {
            if (element.Value.IsBsonDocument)
            {
                // Nếu trường là một Document con, xử lý các trường con
                var subDocument = element.Value.AsBsonDocument;
                foreach (var subElement in subDocument.Elements)
                {
                    CreateColumnsFromElement(dataTable, subElement, prefix + element.Name + "_");
                }
            }
            else
            {
                // Nếu trường không phải là Document con, tạo cột trong DataTable
                dataTable.Columns.Add(prefix + element.Name, typeof(object));
            }
        }

        public void ExtractDataFromElement(List<object> rowData, BsonElement element)
        {
            if (element.Value.IsBsonDocument)
            {
                // Nếu trường là một Document con, xử lý các trường con
                var subDocument = element.Value.AsBsonDocument;
                foreach (var subElement in subDocument.Elements)
                {
                    ExtractDataFromElement(rowData, subElement);
                }
            }
            else
            {
                // Nếu trường không phải là Document con, thêm giá trị vào rowData
                rowData.Add(element.Value);
            }
        }
        public void ThemDocumentVaoCollection(string collectionName, BsonDocument document)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);

            // Thêm Document vào collection
            collection.InsertOne(document);
        }

        public void SuaDocumentTrongCollection(string collectionName, string documentId, BsonDocument newDocument)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);

            // Tạo một filter để xác định Document cần sửa dựa trên "_id" và giá trị documentId
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(documentId));

            // Sử dụng phương thức ReplaceOne để thay thế Document đầu tiên phù hợp với filter bằng newDocument
            var result = collection.ReplaceOne(filter, newDocument);

            // Kiểm tra xem có Document nào bị sửa không
            if (result.ModifiedCount > 0)
            {
                // Sửa thành công
                MessageBox.Show("Document đã được sửa.");
            }
            else
            {
                // Không tìm thấy Document phù hợp để sửa
                MessageBox.Show("Không tìm thấy Document phù hợp để sửa.");
            }
        }

        public void XoaDocumentTrongCollection(string collectionName, string documentId)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);

            // Tạo một filter để xác định Document cần xóa dựa trên "_id" và giá trị documentId
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(documentId));

            // Sử dụng phương thức DeleteOne để xóa Document đầu tiên phù hợp với filter
            var result = collection.DeleteOne(filter);

            // Kiểm tra xem có Document nào bị xóa không
            if (result.DeletedCount > 0)
            {
                // Xóa thành công
                MessageBox.Show("Document đã được xóa.");
            }
            else
            {
                // Không tìm thấy Document phù hợp để xóa
                MessageBox.Show("Không tìm thấy Document phù hợp để xóa.");
            }
        }

    }
}
