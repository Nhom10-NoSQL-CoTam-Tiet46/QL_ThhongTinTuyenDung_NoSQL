namespace QL_TuyenDung
{
    partial class frm_main
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
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            nhanvienToolStripMenuItem = new ToolStripMenuItem();
            việcCầnTuyểnToolStripMenuItem = new ToolStripMenuItem();
            ứngViênToolStripMenuItem = new ToolStripMenuItem();
            côngTyTuyểnDụngToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1782, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhanvienToolStripMenuItem, việcCầnTuyểnToolStripMenuItem, ứngViênToolStripMenuItem, côngTyTuyểnDụngToolStripMenuItem });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(73, 24);
            quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // nhanvienToolStripMenuItem
            // 
            nhanvienToolStripMenuItem.Name = "nhanvienToolStripMenuItem";
            nhanvienToolStripMenuItem.Size = new Size(221, 26);
            nhanvienToolStripMenuItem.Text = "Nhân viên";
            nhanvienToolStripMenuItem.Click += nhanvienToolStripMenuItem_Click;
            // 
            // việcCầnTuyểnToolStripMenuItem
            // 
            việcCầnTuyểnToolStripMenuItem.Name = "việcCầnTuyểnToolStripMenuItem";
            việcCầnTuyểnToolStripMenuItem.Size = new Size(221, 26);
            việcCầnTuyểnToolStripMenuItem.Text = "Việc cần tuyển";
            việcCầnTuyểnToolStripMenuItem.Click += việcCầnTuyểnToolStripMenuItem_Click;
            // 
            // ứngViênToolStripMenuItem
            // 
            ứngViênToolStripMenuItem.Name = "ứngViênToolStripMenuItem";
            ứngViênToolStripMenuItem.Size = new Size(221, 26);
            ứngViênToolStripMenuItem.Text = "Ứng viên";
            ứngViênToolStripMenuItem.Click += ứngViênToolStripMenuItem_Click;
            // 
            // côngTyTuyểnDụngToolStripMenuItem
            // 
            côngTyTuyểnDụngToolStripMenuItem.Name = "côngTyTuyểnDụngToolStripMenuItem";
            côngTyTuyểnDụngToolStripMenuItem.Size = new Size(221, 26);
            côngTyTuyểnDụngToolStripMenuItem.Text = "Công ty tuyển dụng";
            côngTyTuyểnDụngToolStripMenuItem.Click += côngTyTuyểnDụngToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 717);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1782, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(69, 20);
            toolStripStatusLabel1.Text = "Xin chào:";
            // 
            // button1
            // 
            button1.Location = new Point(73, 72);
            button1.Name = "button1";
            button1.Size = new Size(220, 61);
            button1.TabIndex = 3;
            button1.Text = "Cong Ty Tuyen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(352, 72);
            button2.Name = "button2";
            button2.Size = new Size(220, 61);
            button2.TabIndex = 4;
            button2.Text = "Nhan Vien";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(624, 72);
            button3.Name = "button3";
            button3.Size = new Size(175, 61);
            button3.TabIndex = 5;
            button3.Text = "Ung Vien";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // frm_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 743);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_main";
            Text = "frm_main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem nhanvienToolStripMenuItem;
        private ToolStripMenuItem việcCầnTuyểnToolStripMenuItem;
        private ToolStripMenuItem ứngViênToolStripMenuItem;
        private ToolStripMenuItem côngTyTuyểnDụngToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}