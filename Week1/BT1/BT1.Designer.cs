namespace Week1
{
    partial class BT1
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
            this.Sohang1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NutTinh = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Sohang2 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.Tong2so = new System.Windows.Forms.Label();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sohang1
            // 
            this.Sohang1.AutoSize = true;
            this.Sohang1.Location = new System.Drawing.Point(90, 102);
            this.Sohang1.Name = "Sohang1";
            this.Sohang1.Size = new System.Drawing.Size(105, 16);
            this.Sohang1.TabIndex = 0;
            this.Sohang1.Text = "Số hạng thứ nhất";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NutTinh
            // 
            this.NutTinh.Enabled = false;
            this.NutTinh.Location = new System.Drawing.Point(120, 272);
            this.NutTinh.Name = "NutTinh";
            this.NutTinh.Size = new System.Drawing.Size(130, 52);
            this.NutTinh.TabIndex = 2;
            this.NutTinh.Text = "Tính";
            this.NutTinh.UseVisualStyleBackColor = true;
            this.NutTinh.Click += new System.EventHandler(this.NutTinh_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Sohang2
            // 
            this.Sohang2.AutoSize = true;
            this.Sohang2.Location = new System.Drawing.Point(90, 139);
            this.Sohang2.Name = "Sohang2";
            this.Sohang2.Size = new System.Drawing.Size(98, 16);
            this.Sohang2.TabIndex = 3;
            this.Sohang2.Text = "Số hạng thứ hai";
            // 
            // txtTong
            // 
            this.txtTong.Enabled = false;
            this.txtTong.Location = new System.Drawing.Point(220, 174);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(274, 22);
            this.txtTong.TabIndex = 6;
            // 
            // Tong2so
            // 
            this.Tong2so.AutoSize = true;
            this.Tong2so.Location = new System.Drawing.Point(90, 180);
            this.Tong2so.Name = "Tong2so";
            this.Tong2so.Size = new System.Drawing.Size(39, 16);
            this.Tong2so.TabIndex = 5;
            this.Tong2so.Text = "Tổng";
           // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(328, 272);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(130, 52);
            this.Exitbutton.TabIndex = 7;
            this.Exitbutton.Text = "Thoát";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // BT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.Tong2so);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Sohang2);
            this.Controls.Add(this.NutTinh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sohang1);
            this.Name = "BT1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sohang1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NutTinh;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Sohang2;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label Tong2so;
        private System.Windows.Forms.Button Exitbutton;
    }
}

