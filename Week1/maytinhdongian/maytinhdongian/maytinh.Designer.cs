using System.Windows.Forms;

namespace maytinhdongian
{
    partial class frmmaytinh
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txttong = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntinh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtchia = new System.Windows.Forms.RadioButton();
            this.rbtnhan = new System.Windows.Forms.RadioButton();
            this.rbttru = new System.Windows.Forms.RadioButton();
            this.rbtcong = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // txtso1
            // 
            this.txtso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso1.Location = new System.Drawing.Point(179, 64);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(135, 27);
            this.txtso1.TabIndex = 3;
            this.txtso1.TextChanged += new System.EventHandler(this.txtso1_TextChanged);
            this.txtso1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtso1_KeyPress);
            // 
            // txttong
            // 
            this.txttong.Enabled = false;
            this.txttong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttong.Location = new System.Drawing.Point(179, 138);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(135, 27);
            this.txttong.TabIndex = 4;
            // 
            // txtso2
            // 
            this.txtso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso2.Location = new System.Drawing.Point(179, 101);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(135, 27);
            this.txtso2.TabIndex = 5;
            this.txtso2.TextChanged += new System.EventHandler(this.txtso2_TextChanged);
            this.txtso2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtso2_KeyPress);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(63, 190);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(88, 41);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntinh
            // 
            this.btntinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.Location = new System.Drawing.Point(226, 190);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(88, 41);
            this.btntinh.TabIndex = 7;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtchia);
            this.groupBox1.Controls.Add(this.rbtnhan);
            this.groupBox1.Controls.Add(this.rbttru);
            this.groupBox1.Controls.Add(this.rbtcong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(347, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 162);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép Tính";
            // 
            // rbtchia
            // 
            this.rbtchia.AutoSize = true;
            this.rbtchia.Enabled = false;
            this.rbtchia.Location = new System.Drawing.Point(21, 121);
            this.rbtchia.Name = "rbtchia";
            this.rbtchia.Size = new System.Drawing.Size(64, 24);
            this.rbtchia.TabIndex = 12;
            this.rbtchia.TabStop = true;
            this.rbtchia.Text = "Chia";
            this.rbtchia.UseVisualStyleBackColor = true;
            this.rbtchia.CheckedChanged += new System.EventHandler(this.rbtchia_CheckedChanged);
            // 
            // rbtnhan
            // 
            this.rbtnhan.AutoSize = true;
            this.rbtnhan.Enabled = false;
            this.rbtnhan.Location = new System.Drawing.Point(21, 89);
            this.rbtnhan.Name = "rbtnhan";
            this.rbtnhan.Size = new System.Drawing.Size(69, 24);
            this.rbtnhan.TabIndex = 11;
            this.rbtnhan.TabStop = true;
            this.rbtnhan.Text = "Nhân";
            this.rbtnhan.UseVisualStyleBackColor = true;
            this.rbtnhan.CheckedChanged += new System.EventHandler(this.rbtnhan_CheckedChanged);
            // 
            // rbttru
            // 
            this.rbttru.AutoSize = true;
            this.rbttru.Enabled = false;
            this.rbttru.Location = new System.Drawing.Point(21, 58);
            this.rbttru.Name = "rbttru";
            this.rbttru.Size = new System.Drawing.Size(55, 24);
            this.rbttru.TabIndex = 10;
            this.rbttru.TabStop = true;
            this.rbttru.Text = "Trừ";
            this.rbttru.UseVisualStyleBackColor = true;
            this.rbttru.CheckedChanged += new System.EventHandler(this.rbttru_CheckedChanged);
            // 
            // rbtcong
            // 
            this.rbtcong.AutoSize = true;
            this.rbtcong.Enabled = false;
            this.rbtcong.Location = new System.Drawing.Point(21, 27);
            this.rbtcong.Name = "rbtcong";
            this.rbtcong.Size = new System.Drawing.Size(69, 24);
            this.rbtcong.TabIndex = 9;
            this.rbtcong.TabStop = true;
            this.rbtcong.Text = "Cộng";
            this.rbtcong.UseVisualStyleBackColor = true;
            this.rbtcong.CheckedChanged += new System.EventHandler(this.rbtcong_CheckedChanged);
            // 
            // frmmaytinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 297);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txttong);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmmaytinh";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtcong;
        private System.Windows.Forms.RadioButton rbtchia;
        private System.Windows.Forms.RadioButton rbtnhan;
        private System.Windows.Forms.RadioButton rbttru;
        private ErrorProvider ErrorProvider = new ErrorProvider();
    }
}

