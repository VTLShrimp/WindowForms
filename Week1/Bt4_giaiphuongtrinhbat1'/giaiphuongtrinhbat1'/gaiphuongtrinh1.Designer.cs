using System.Windows.Forms;

namespace giaiphuongtrinhbat1_
{
    partial class frmgaiphuongtrinh1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtnghiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Hạng 2";
            // 
            // txtso2
            // 
            this.txtso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso2.Location = new System.Drawing.Point(158, 96);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(190, 27);
            this.txtso2.TabIndex = 3;
            this.txtso2.TextChanged += new System.EventHandler(this.txtso2_TextChanged);
            this.txtso2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtso2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hạng 1";
            // 
            // txtso1
            // 
            this.txtso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso1.Location = new System.Drawing.Point(158, 49);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(190, 27);
            this.txtso1.TabIndex = 2;
            this.txtso1.TextChanged += new System.EventHandler(this.txtso1_TextChanged);
            this.txtso1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtso1_KeyPress);
            // 
            // txtnghiem
            // 
            this.txtnghiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnghiem.Enabled = false;
            this.txtnghiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnghiem.Location = new System.Drawing.Point(158, 204);
            this.txtnghiem.Name = "txtnghiem";
            this.txtnghiem.Size = new System.Drawing.Size(190, 27);
            this.txtnghiem.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nghiệm";
            // 
            // btntinh
            // 
            this.btntinh.Enabled = false;
            this.btntinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.Location = new System.Drawing.Point(101, 148);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(188, 28);
            this.btntinh.TabIndex = 6;
            this.btntinh.Text = "Tính Nghệm";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // frmgaiphuongtrinh1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 284);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtnghiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmgaiphuongtrinh1";
            this.Text = "Giai phuong trinh 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtnghiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntinh;
        private ErrorProvider ErrorProvider = new ErrorProvider();

    }
}

