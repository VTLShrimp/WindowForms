namespace TinhTongDonGian
{
    partial class frmTinhTong
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
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.frmThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSohang1 = new System.Windows.Forms.TextBox();
            this.txtSohang2 = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Enabled = false;
            this.btnTinhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTong.Location = new System.Drawing.Point(121, 213);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(122, 31);
            this.btnTinhTong.TabIndex = 0;
            this.btnTinhTong.Text = "Tính Tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_click);
            // 
            // frmThoat
            // 
            this.frmThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmThoat.Location = new System.Drawing.Point(327, 213);
            this.frmThoat.Name = "frmThoat";
            this.frmThoat.Size = new System.Drawing.Size(89, 31);
            this.frmThoat.TabIndex = 1;
            this.frmThoat.Text = "Thoát";
            this.frmThoat.UseVisualStyleBackColor = true;
            this.frmThoat.Click += new System.EventHandler(this.btnThoat_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số hạng thứ nhất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số hạng thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng";
            // 
            // txtSohang1
            // 
            this.txtSohang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSohang1.Location = new System.Drawing.Point(327, 58);
            this.txtSohang1.Name = "txtSohang1";
            this.txtSohang1.Size = new System.Drawing.Size(155, 27);
            this.txtSohang1.TabIndex = 5;
            this.txtSohang1.TextChanged += new System.EventHandler(this.txtSohang1_TextChanged);
            // 
            // txtSohang2
            // 
            this.txtSohang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSohang2.Location = new System.Drawing.Point(327, 110);
            this.txtSohang2.Name = "txtSohang2";
            this.txtSohang2.Size = new System.Drawing.Size(155, 27);
            this.txtSohang2.TabIndex = 6;
            this.txtSohang2.TextChanged += new System.EventHandler(this.txtSohang2_TextChanged);
            // 
            // txtTong
            // 
            this.txtTong.Enabled = false;
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(327, 162);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(155, 27);
            this.txtTong.TabIndex = 7;
            // 
            // frmTinhTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 284);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtSohang2);
            this.Controls.Add(this.txtSohang1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmThoat);
            this.Controls.Add(this.btnTinhTong);
            this.Name = "frmTinhTong";
            this.Text = "frmTinhTong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Button frmThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSohang1;
        private System.Windows.Forms.TextBox txtSohang2;
        private System.Windows.Forms.TextBox txtTong;
    }
}

