namespace w7
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
            btnTongUocSo = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            txtInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbNumbers = new ComboBox();
            lstFactors = new ListBox();
            SuspendLayout();
            // 
            // btnTongUocSo
            // 
            btnTongUocSo.Location = new Point(523, 260);
            btnTongUocSo.Name = "btnTongUocSo";
            btnTongUocSo.Size = new Size(241, 53);
            btnTongUocSo.TabIndex = 0;
            btnTongUocSo.Text = "Tổng các ước số";
            btnTongUocSo.UseVisualStyleBackColor = true;
            btnTongUocSo.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(523, 319);
            button2.Name = "button2";
            button2.Size = new Size(241, 53);
            button2.TabIndex = 1;
            button2.Text = "Số lượng các ước số chẵn";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(523, 378);
            button3.Name = "button3";
            button3.Size = new Size(241, 53);
            button3.TabIndex = 2;
            button3.Text = "Số lượng các ước số nguyên tố";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(408, 388);
            button4.Name = "button4";
            button4.Size = new Size(97, 43);
            button4.TabIndex = 3;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(209, 41);
            button5.Name = "button5";
            button5.Size = new Size(97, 43);
            button5.TabIndex = 4;
            button5.Text = "Cập nhật";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(-1, 57);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(193, 27);
            txtInput.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Nhập số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 20);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 7;
            label2.Text = "Danh sách các ước ";
            // 
            // cmbNumbers
            // 
            cmbNumbers.FormattingEnabled = true;
            cmbNumbers.Location = new Point(-1, 129);
            cmbNumbers.Name = "cmbNumbers";
            cmbNumbers.Size = new Size(193, 28);
            cmbNumbers.TabIndex = 8;
            cmbNumbers.SelectedIndexChanged += cmbNumbers_SelectedIndexChanged;
            // 
            // lstFactors
            // 
            lstFactors.FormattingEnabled = true;
            lstFactors.Location = new Point(531, 49);
            lstFactors.Name = "lstFactors";
            lstFactors.Size = new Size(248, 124);
            lstFactors.TabIndex = 9;
            lstFactors.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstFactors);
            Controls.Add(cmbNumbers);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnTongUocSo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTongUocSo;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox txtInput;
        private Label label1;
        private Label label2;
        private ComboBox cmbNumbers;
        private ListBox lstFactors;
    }
}
