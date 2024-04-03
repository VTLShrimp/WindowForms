namespace Lab01
{
    partial class frmbaiI
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tapbaiII = new System.Windows.Forms.TabPage();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtchia = new System.Windows.Forms.TextBox();
            this.txtnhan = new System.Windows.Forms.TextBox();
            this.txthieu = new System.Windows.Forms.TextBox();
            this.txtcong = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tapbaiII.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào Mừng Đến Với C#";
            // 
            // btnthoat
            // 
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(347, 609);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(103, 50);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tapbaiII);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 458);
            this.tabControl1.TabIndex = 3;
            // 
            // tapbaiII
            // 
            this.tapbaiII.Controls.Add(this.btnlamlai);
            this.tapbaiII.Controls.Add(this.btntinh);
            this.tapbaiII.Controls.Add(this.txtchia);
            this.tapbaiII.Controls.Add(this.txtnhan);
            this.tapbaiII.Controls.Add(this.txthieu);
            this.tapbaiII.Controls.Add(this.txtcong);
            this.tapbaiII.Controls.Add(this.txtso2);
            this.tapbaiII.Controls.Add(this.txtso1);
            this.tapbaiII.Controls.Add(this.label7);
            this.tapbaiII.Controls.Add(this.label6);
            this.tapbaiII.Controls.Add(this.label5);
            this.tapbaiII.Controls.Add(this.label4);
            this.tapbaiII.Controls.Add(this.label3);
            this.tapbaiII.Controls.Add(this.label2);
            this.tapbaiII.Location = new System.Drawing.Point(4, 25);
            this.tapbaiII.Name = "tapbaiII";
            this.tapbaiII.Padding = new System.Windows.Forms.Padding(3);
            this.tapbaiII.Size = new System.Drawing.Size(799, 429);
            this.tapbaiII.TabIndex = 0;
            this.tapbaiII.Text = "BaiII";
            this.tapbaiII.UseVisualStyleBackColor = true;
            // 
            // btnlamlai
            // 
            this.btnlamlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlamlai.Location = new System.Drawing.Point(425, 145);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(103, 43);
            this.btnlamlai.TabIndex = 13;
            this.btnlamlai.Text = "Làm Lại";
            this.btnlamlai.UseVisualStyleBackColor = true;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // btntinh
            // 
            this.btntinh.Enabled = false;
            this.btntinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.Location = new System.Drawing.Point(425, 252);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(103, 43);
            this.btntinh.TabIndex = 12;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtchia
            // 
            this.txtchia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtchia.Enabled = false;
            this.txtchia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchia.Location = new System.Drawing.Point(173, 309);
            this.txtchia.Name = "txtchia";
            this.txtchia.Size = new System.Drawing.Size(162, 30);
            this.txtchia.TabIndex = 11;
            // 
            // txtnhan
            // 
            this.txtnhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnhan.Enabled = false;
            this.txtnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhan.Location = new System.Drawing.Point(173, 252);
            this.txtnhan.Name = "txtnhan";
            this.txtnhan.Size = new System.Drawing.Size(162, 30);
            this.txtnhan.TabIndex = 10;
            // 
            // txthieu
            // 
            this.txthieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthieu.Enabled = false;
            this.txthieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthieu.Location = new System.Drawing.Point(173, 201);
            this.txthieu.Name = "txthieu";
            this.txthieu.Size = new System.Drawing.Size(162, 30);
            this.txthieu.TabIndex = 9;
            // 
            // txtcong
            // 
            this.txtcong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcong.Enabled = false;
            this.txtcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcong.Location = new System.Drawing.Point(173, 152);
            this.txtcong.Name = "txtcong";
            this.txtcong.Size = new System.Drawing.Size(162, 30);
            this.txtcong.TabIndex = 8;
            // 
            // txtso2
            // 
            this.txtso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso2.Location = new System.Drawing.Point(173, 98);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(162, 30);
            this.txtso2.TabIndex = 7;
            this.txtso2.TextChanged += new System.EventHandler(this.txtso2_TextChanged);
            // 
            // txtso1
            // 
            this.txtso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso1.Location = new System.Drawing.Point(173, 46);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(162, 30);
            this.txtso1.TabIndex = 6;
            this.txtso1.TextChanged += new System.EventHandler(this.txtso1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 314);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nhân:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Hiệu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Thứ 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Thứ 1:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(674, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmbaiI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 687);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label1);
            this.Name = "frmbaiI";
            this.Text = "Bai 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmbaiI_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tapbaiII.ResumeLayout(false);
            this.tapbaiII.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tapbaiII;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtchia;
        private System.Windows.Forms.TextBox txtnhan;
        private System.Windows.Forms.TextBox txthieu;
        private System.Windows.Forms.TextBox txtcong;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.Button btnlamlai;
        private System.Windows.Forms.Button btntinh;
    }
}

