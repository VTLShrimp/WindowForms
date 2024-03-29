namespace w1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            KhungCSCu = new TextBox();
            KhungCSMoi = new TextBox();
            SoKWTieeuThu = new TextBox();
            SoTRongDinhMuc = new TextBox();
            SoVuotDinhMuc = new TextBox();
            KhungTongTien = new TextBox();
            cbTenKhachHang = new ComboBox();
            btTinh = new Button();
            btIn = new Button();
            btThoat = new Button();
            rtbXuatKetQua = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // KhungCSCu
            // 
            KhungCSCu.Location = new Point(91, 103);
            KhungCSCu.Name = "KhungCSCu";
            KhungCSCu.Size = new Size(66, 27);
            KhungCSCu.TabIndex = 0;
            // 
            // KhungCSMoi
            // 
            KhungCSMoi.Location = new Point(91, 157);
            KhungCSMoi.Name = "KhungCSMoi";
            KhungCSMoi.Size = new Size(66, 27);
            KhungCSMoi.TabIndex = 1;
            // 
            // SoKWTieeuThu
            // 
            SoKWTieeuThu.Location = new Point(91, 219);
            SoKWTieeuThu.Name = "SoKWTieeuThu";
            SoKWTieeuThu.Size = new Size(66, 27);
            SoKWTieeuThu.TabIndex = 2;
            // 
            // SoTRongDinhMuc
            // 
            SoTRongDinhMuc.Location = new Point(436, 103);
            SoTRongDinhMuc.Name = "SoTRongDinhMuc";
            SoTRongDinhMuc.Size = new Size(66, 27);
            SoTRongDinhMuc.TabIndex = 3;
            // 
            // SoVuotDinhMuc
            // 
            SoVuotDinhMuc.Location = new Point(436, 157);
            SoVuotDinhMuc.Name = "SoVuotDinhMuc";
            SoVuotDinhMuc.Size = new Size(66, 27);
            SoVuotDinhMuc.TabIndex = 4;
            // 
            // KhungTongTien
            // 
            KhungTongTien.Location = new Point(31, 285);
            KhungTongTien.Name = "KhungTongTien";
            KhungTongTien.Size = new Size(175, 27);
            KhungTongTien.TabIndex = 5;
            KhungTongTien.TextChanged += textBox6_TextChanged;
            // 
            // cbTenKhachHang
            // 
            cbTenKhachHang.FormattingEnabled = true;
            cbTenKhachHang.Location = new Point(157, 52);
            cbTenKhachHang.Name = "cbTenKhachHang";
            cbTenKhachHang.Size = new Size(155, 28);
            cbTenKhachHang.TabIndex = 6;
            // 
            // btTinh
            // 
            btTinh.Location = new Point(31, 318);
            btTinh.Name = "btTinh";
            btTinh.Size = new Size(72, 36);
            btTinh.TabIndex = 8;
            btTinh.Text = "Tinh";
            btTinh.UseVisualStyleBackColor = true;
            btTinh.Click += btTinh_Click;
            // 
            // btIn
            // 
            btIn.Location = new Point(134, 318);
            btIn.Name = "btIn";
            btIn.Size = new Size(72, 36);
            btIn.TabIndex = 9;
            btIn.Text = "in";
            btIn.UseVisualStyleBackColor = true;
            btIn.Click += btIn_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(85, 360);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(72, 36);
            btThoat.TabIndex = 10;
            btThoat.Text = "Thoat";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // rtbXuatKetQua
            // 
            rtbXuatKetQua.Location = new Point(316, 302);
            rtbXuatKetQua.Name = "rtbXuatKetQua";
            rtbXuatKetQua.Size = new Size(222, 27);
            rtbXuatKetQua.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 20);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 12;
            label1.Text = "Bang Tinh Tien Dien";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 13;
            label2.Text = "Chir So Cu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 110);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 14;
            label3.Text = "So KW trong dinh muc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 60);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 14;
            label4.Text = "Ho va Ten";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 164);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 15;
            label5.Text = "Chi So Moi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 219);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 16;
            label6.Text = "So KW Tieu Thu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(262, 201);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 17;
            label7.Text = "Dinh muc la 50KW";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(252, 157);
            label8.Name = "label8";
            label8.Size = new Size(151, 20);
            label8.TabIndex = 17;
            label8.Text = "So KW vuot dinh muc";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(262, 226);
            label9.Name = "label9";
            label9.Size = new Size(207, 20);
            label9.TabIndex = 18;
            label9.Text = "TRong dinh muc laf 500d/1kw";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(262, 246);
            label10.Name = "label10";
            label10.Size = new Size(195, 20);
            label10.TabIndex = 19;
            label10.Text = "Vuot dinh muc laf 100d/1kw";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 428);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbXuatKetQua);
            Controls.Add(btThoat);
            Controls.Add(btIn);
            Controls.Add(btTinh);
            Controls.Add(cbTenKhachHang);
            Controls.Add(KhungTongTien);
            Controls.Add(SoVuotDinhMuc);
            Controls.Add(SoTRongDinhMuc);
            Controls.Add(SoKWTieeuThu);
            Controls.Add(KhungCSMoi);
            Controls.Add(KhungCSCu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox KhungCSCu;
        private TextBox KhungCSMoi;
        private TextBox SoKWTieeuThu;
        private TextBox SoTRongDinhMuc;
        private TextBox SoVuotDinhMuc;
        private TextBox KhungTongTien;
        private ComboBox cbTenKhachHang;
        private Button btTinh;
        private Button btIn;
        private Button btThoat;
        private TextBox rtbXuatKetQua;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
