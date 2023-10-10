namespace QL_TuyenDung
{
    partial class frm_nhanvienn1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label9 = new Label();
            txt_idUV = new TextBox();
            txtphongban = new TextBox();
            txtemail = new TextBox();
            txtsdt = new TextBox();
            txtchucvu = new TextBox();
            txttuoi = new TextBox();
            txttennv = new TextBox();
            txtmanv = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txtsua = new Button();
            txtxoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(934, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txt_idUV);
            groupBox1.Controls.Add(txtphongban);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(txtsdt);
            groupBox1.Controls.Add(txtchucvu);
            groupBox1.Controls.Add(txttuoi);
            groupBox1.Controls.Add(txttennv);
            groupBox1.Controls.Add(txtmanv);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 382);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 26);
            label9.Name = "label9";
            label9.Size = new Size(31, 20);
            label9.TabIndex = 14;
            label9.Text = "ID :";
            // 
            // txt_idUV
            // 
            txt_idUV.Location = new Point(105, 23);
            txt_idUV.Name = "txt_idUV";
            txt_idUV.Size = new Size(286, 27);
            txt_idUV.TabIndex = 8;
            // 
            // txtphongban
            // 
            txtphongban.Location = new Point(105, 332);
            txtphongban.Name = "txtphongban";
            txtphongban.Size = new Size(286, 27);
            txtphongban.TabIndex = 13;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(105, 287);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(286, 27);
            txtemail.TabIndex = 12;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(105, 239);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(286, 27);
            txtsdt.TabIndex = 11;
            // 
            // txtchucvu
            // 
            txtchucvu.Location = new Point(105, 196);
            txtchucvu.Name = "txtchucvu";
            txtchucvu.Size = new Size(286, 27);
            txtchucvu.TabIndex = 10;
            // 
            // txttuoi
            // 
            txttuoi.Location = new Point(105, 156);
            txttuoi.Name = "txttuoi";
            txttuoi.Size = new Size(286, 27);
            txttuoi.TabIndex = 9;
            // 
            // txttennv
            // 
            txttennv.Location = new Point(105, 112);
            txttennv.Name = "txttennv";
            txttennv.Size = new Size(286, 27);
            txttennv.TabIndex = 8;
            // 
            // txtmanv
            // 
            txtmanv.Location = new Point(105, 64);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new Size(286, 27);
            txtmanv.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 290);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 6;
            label8.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 242);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 5;
            label7.Text = "SĐT:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 199);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 4;
            label6.Text = "Chức vụ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 335);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 3;
            label5.Text = "Phòng ban:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 159);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 2;
            label4.Text = "Tuổi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 115);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 1;
            label3.Text = "Tên NV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 0;
            label2.Text = "MaNV:";
            // 
            // button1
            // 
            button1.Location = new Point(15, 37);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(573, 4);
            label1.Name = "label1";
            label1.Size = new Size(212, 46);
            label1.TabIndex = 5;
            label1.Text = "NHÂN VIÊN";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(415, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(948, 482);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtsua);
            groupBox3.Controls.Add(txtxoa);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(12, 441);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(391, 94);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // txtsua
            // 
            txtsua.Location = new Point(269, 37);
            txtsua.Name = "txtsua";
            txtsua.Size = new Size(94, 29);
            txtsua.TabIndex = 6;
            txtsua.Text = "Sửa";
            txtsua.UseVisualStyleBackColor = true;
            txtsua.Click += txtsua_Click;
            // 
            // txtxoa
            // 
            txtxoa.Location = new Point(138, 37);
            txtxoa.Name = "txtxoa";
            txtxoa.Size = new Size(94, 29);
            txtxoa.TabIndex = 5;
            txtxoa.Text = "Xóa";
            txtxoa.UseVisualStyleBackColor = true;
            txtxoa.Click += txtxoa_Click;
            // 
            // frm_nhanvienn1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1367, 556);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frm_nhanvienn1";
            Text = "frm_nhanvienn1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox txt_idUV;
        private TextBox txtphongban;
        private TextBox txtemail;
        private TextBox txtsdt;
        private TextBox txtchucvu;
        private TextBox txttuoi;
        private TextBox txttennv;
        private TextBox txtmanv;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button txtsua;
        private Button txtxoa;
    }
}