using System.Windows.Forms;

namespace CongTruNhanChia
{
    partial class frmCongTruNhanChia
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
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSohang1 = new System.Windows.Forms.TextBox();
            this.txtSohang2 = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCong
            // 
            this.btnCong.Enabled = false;
            this.btnCong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCong.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCong.Location = new System.Drawing.Point(74, 160);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(76, 53);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_click);
            // 
            // btnTru
            // 
            this.btnTru.Enabled = false;
            this.btnTru.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTru.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTru.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTru.Location = new System.Drawing.Point(156, 160);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(76, 53);
            this.btnTru.TabIndex = 1;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_click);
            // 
            // btnNhan
            // 
            this.btnNhan.Enabled = false;
            this.btnNhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNhan.Location = new System.Drawing.Point(238, 160);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(76, 53);
            this.btnNhan.TabIndex = 2;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_click);
            // 
            // btnChia
            // 
            this.btnChia.Enabled = false;
            this.btnChia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChia.Location = new System.Drawing.Point(320, 160);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(76, 53);
            this.btnChia.TabIndex = 3;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số thứ 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số thứ 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ket qua";
            // 
            // txtSohang1
            // 
            this.txtSohang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSohang1.Location = new System.Drawing.Point(151, 57);
            this.txtSohang1.Name = "txtSohang1";
            this.txtSohang1.Size = new System.Drawing.Size(252, 28);
            this.txtSohang1.TabIndex = 7;
            this.txtSohang1.TextChanged += new System.EventHandler(this.txtSohang1_changed);
            // 
            // txtSohang2
            // 
            this.txtSohang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSohang2.Location = new System.Drawing.Point(151, 110);
            this.txtSohang2.Name = "txtSohang2";
            this.txtSohang2.Size = new System.Drawing.Size(252, 28);
            this.txtSohang2.TabIndex = 8;
            this.txtSohang2.TextChanged += new System.EventHandler(this.txtSohang2_changed);
            // 
            // txtTong
            // 
            this.txtTong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTong.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTong.Enabled = false;
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(151, 236);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(252, 28);
            this.txtTong.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 10;
            this.label4.Visible = false;
            // 
            // frmCongTruNhanChia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 378);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtSohang2);
            this.Controls.Add(this.txtSohang1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Name = "frmCongTruNhanChia";
            this.Text = "CongTruNhanChia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSohang1;
        private System.Windows.Forms.TextBox txtSohang2;
        private System.Windows.Forms.TextBox txtTong;
        private ErrorProvider ErrorProvider = new ErrorProvider();
        private Label label4;
    }
}

