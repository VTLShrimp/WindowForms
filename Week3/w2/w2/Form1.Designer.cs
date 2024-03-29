namespace w2
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
            txtName = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            lblResult = new TextBox();
            btnTinh = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(73, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(331, 27);
            txtName.TabIndex = 0;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(73, 125);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(190, 27);
            txtHeight.TabIndex = 1;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(73, 188);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(190, 27);
            txtWeight.TabIndex = 2;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(44, 372);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(405, 27);
            lblResult.TabIndex = 3;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(61, 45);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(130, 30);
            btnTinh.TabIndex = 4;
            btnTinh.Text = "tinh";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(61, 98);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 30);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(61, 147);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 30);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "thoat";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(73, 287);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(59, 24);
            rdoMale.TabIndex = 9;
            rdoMale.TabStop = true;
            rdoMale.Text = "nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(218, 287);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(46, 24);
            rdoFemale.TabIndex = 10;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "nu";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(266, 20);
            label1.TabIndex = 11;
            label1.Text = "CÔNG THỨC TÍNH CÂN NĂNG CHUẢN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 46);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 12;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 132);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 13;
            label3.Text = "Chiều cao";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 287);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 14;
            label4.Text = "Giới tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 349);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 15;
            label5.Text = "Kết quả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 195);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 16;
            label6.Text = "Cân nặng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnTinh);
            groupBox1.Location = new Point(395, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 197);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năg";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(lblResult);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private TextBox lblResult;
        private Button btnTinh;
        private Button btnXoa;
        private Button btnThoat;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
    }
}
