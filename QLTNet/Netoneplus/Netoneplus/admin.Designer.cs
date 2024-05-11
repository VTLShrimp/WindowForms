namespace Netoneplus
{
    partial class frmadmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGíupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpnangcap = new System.Windows.Forms.TabPage();
            this.tpmenu = new System.Windows.Forms.TabPage();
            this.tpbaocao = new System.Windows.Forms.TabPage();
            this.tpthanhvien = new System.Windows.Forms.TabPage();
            this.lvtaikhoan = new System.Windows.Forms.ListView();
            this.lvnaptien = new System.Windows.Forms.ListView();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.cbbtuychinh = new System.Windows.Forms.ComboBox();
            this.lvchinhthanhvien = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txttong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.tpdieukhien = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tpthanhvien.SuspendLayout();
            this.tpdieukhien.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.tùyChìnhToolStripMenuItem,
            this.càiĐặtToolStripMenuItem,
            this.trợGíupToolStripMenuItem,
            this.chatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Nhập";
            // 
            // tùyChìnhToolStripMenuItem
            // 
            this.tùyChìnhToolStripMenuItem.Name = "tùyChìnhToolStripMenuItem";
            this.tùyChìnhToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.tùyChìnhToolStripMenuItem.Text = "Tùy Chình";
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.càiĐặtToolStripMenuItem.Text = "Cài Đặt";
            // 
            // trợGíupToolStripMenuItem
            // 
            this.trợGíupToolStripMenuItem.Name = "trợGíupToolStripMenuItem";
            this.trợGíupToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.trợGíupToolStripMenuItem.Text = "Trợ Gíup";
            // 
            // tpnangcap
            // 
            this.tpnangcap.Location = new System.Drawing.Point(4, 27);
            this.tpnangcap.Name = "tpnangcap";
            this.tpnangcap.Padding = new System.Windows.Forms.Padding(3);
            this.tpnangcap.Size = new System.Drawing.Size(1023, 551);
            this.tpnangcap.TabIndex = 5;
            this.tpnangcap.Text = "Nâng Cấp";
            this.tpnangcap.UseVisualStyleBackColor = true;
            // 
            // tpmenu
            // 
            this.tpmenu.Location = new System.Drawing.Point(4, 27);
            this.tpmenu.Name = "tpmenu";
            this.tpmenu.Padding = new System.Windows.Forms.Padding(3);
            this.tpmenu.Size = new System.Drawing.Size(1023, 551);
            this.tpmenu.TabIndex = 4;
            this.tpmenu.Text = "Menu";
            this.tpmenu.UseVisualStyleBackColor = true;
            // 
            // tpbaocao
            // 
            this.tpbaocao.Location = new System.Drawing.Point(4, 27);
            this.tpbaocao.Name = "tpbaocao";
            this.tpbaocao.Padding = new System.Windows.Forms.Padding(3);
            this.tpbaocao.Size = new System.Drawing.Size(1023, 551);
            this.tpbaocao.TabIndex = 2;
            this.tpbaocao.Text = " Báo Cáo";
            this.tpbaocao.UseVisualStyleBackColor = true;
            // 
            // tpthanhvien
            // 
            this.tpthanhvien.Controls.Add(this.btnsua);
            this.tpthanhvien.Controls.Add(this.btnxoa);
            this.tpthanhvien.Controls.Add(this.btnthem);
            this.tpthanhvien.Controls.Add(this.label2);
            this.tpthanhvien.Controls.Add(this.txttong);
            this.tpthanhvien.Controls.Add(this.txttimkiem);
            this.tpthanhvien.Controls.Add(this.label1);
            this.tpthanhvien.Controls.Add(this.lvchinhthanhvien);
            this.tpthanhvien.Controls.Add(this.cbbtuychinh);
            this.tpthanhvien.Controls.Add(this.btntimkiem);
            this.tpthanhvien.Controls.Add(this.lvnaptien);
            this.tpthanhvien.Controls.Add(this.lvtaikhoan);
            this.tpthanhvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpthanhvien.Location = new System.Drawing.Point(4, 27);
            this.tpthanhvien.Name = "tpthanhvien";
            this.tpthanhvien.Padding = new System.Windows.Forms.Padding(3);
            this.tpthanhvien.Size = new System.Drawing.Size(1023, 551);
            this.tpthanhvien.TabIndex = 1;
            this.tpthanhvien.Text = "Thành Viên";
            this.tpthanhvien.UseVisualStyleBackColor = true;
            // 
            // lvtaikhoan
            // 
            this.lvtaikhoan.HideSelection = false;
            this.lvtaikhoan.Location = new System.Drawing.Point(6, 49);
            this.lvtaikhoan.Name = "lvtaikhoan";
            this.lvtaikhoan.Size = new System.Drawing.Size(601, 293);
            this.lvtaikhoan.TabIndex = 0;
            this.lvtaikhoan.UseCompatibleStateImageBehavior = false;
            // 
            // lvnaptien
            // 
            this.lvnaptien.HideSelection = false;
            this.lvnaptien.Location = new System.Drawing.Point(617, 49);
            this.lvnaptien.Name = "lvnaptien";
            this.lvnaptien.Size = new System.Drawing.Size(400, 293);
            this.lvnaptien.TabIndex = 1;
            this.lvnaptien.UseCompatibleStateImageBehavior = false;
            // 
            // txttimkiem
            // 
            this.txttimkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttimkiem.Location = new System.Drawing.Point(309, 13);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(5);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(184, 24);
            this.txttimkiem.TabIndex = 2;
            // 
            // btntimkiem
            // 
            this.btntimkiem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(501, 8);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(106, 35);
            this.btntimkiem.TabIndex = 3;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // cbbtuychinh
            // 
            this.cbbtuychinh.FormattingEnabled = true;
            this.cbbtuychinh.Location = new System.Drawing.Point(9, 14);
            this.cbbtuychinh.Name = "cbbtuychinh";
            this.cbbtuychinh.Size = new System.Drawing.Size(121, 26);
            this.cbbtuychinh.TabIndex = 4;
            this.cbbtuychinh.Text = "Tùy Chỉnh";
            // 
            // lvchinhthanhvien
            // 
            this.lvchinhthanhvien.HideSelection = false;
            this.lvchinhthanhvien.Location = new System.Drawing.Point(6, 393);
            this.lvchinhthanhvien.Name = "lvchinhthanhvien";
            this.lvchinhthanhvien.Size = new System.Drawing.Size(1009, 152);
            this.lvchinhthanhvien.TabIndex = 5;
            this.lvchinhthanhvien.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng số tài khoản: ";
            // 
            // txttong
            // 
            this.txttong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttong.Enabled = false;
            this.txttong.Location = new System.Drawing.Point(149, 354);
            this.txttong.Margin = new System.Windows.Forms.Padding(5);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(29, 24);
            this.txttong.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lịch sữ nạp:";
            // 
            // btnthem
            // 
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(617, 348);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(84, 34);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(707, 348);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(84, 34);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(797, 348);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(84, 34);
            this.btnsua.TabIndex = 11;
            this.btnsua.Text = "Sữa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // tpdieukhien
            // 
            this.tpdieukhien.Controls.Add(this.label3);
            this.tpdieukhien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpdieukhien.Location = new System.Drawing.Point(4, 27);
            this.tpdieukhien.Name = "tpdieukhien";
            this.tpdieukhien.Padding = new System.Windows.Forms.Padding(3);
            this.tpdieukhien.Size = new System.Drawing.Size(1023, 551);
            this.tpdieukhien.TabIndex = 0;
            this.tpdieukhien.Text = "Điều Khiển";
            this.tpdieukhien.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Danh sách máy:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpdieukhien);
            this.tabControl.Controls.Add(this.tpthanhvien);
            this.tabControl.Controls.Add(this.tpbaocao);
            this.tabControl.Controls.Add(this.tpmenu);
            this.tabControl.Controls.Add(this.tpnangcap);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1031, 582);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.chatToolStripMenuItem.Text = "Chat";
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 610);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmadmin";
            this.Text = "OnePlus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tpthanhvien.ResumeLayout(false);
            this.tpthanhvien.PerformLayout();
            this.tpdieukhien.ResumeLayout(false);
            this.tpdieukhien.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tùyChìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGíupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.TabPage tpnangcap;
        private System.Windows.Forms.TabPage tpmenu;
        private System.Windows.Forms.TabPage tpbaocao;
        private System.Windows.Forms.TabPage tpthanhvien;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvchinhthanhvien;
        private System.Windows.Forms.ComboBox cbbtuychinh;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.ListView lvnaptien;
        private System.Windows.Forms.ListView lvtaikhoan;
        private System.Windows.Forms.TabPage tpdieukhien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl;
    }
}

