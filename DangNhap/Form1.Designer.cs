namespace DangNhap
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
            ID = new Label();
            Pass = new Label();
            IDBox = new TextBox();
            PasswordBox = new TextBox();
            PhoneNumberBox = new TextBox();
            PhoneNumber = new Label();
            AddressBox = new TextBox();
            Address = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            RegisterButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(202, 94);
            ID.Name = "ID";
            ID.Size = new Size(28, 20);
            ID.TabIndex = 0;
            ID.Text = "ID ";
            ID.Click += ID_Click;
            // 
            // Pass
            // 
            Pass.AutoSize = true;
            Pass.Location = new Point(202, 127);
            Pass.Name = "Pass";
            Pass.Size = new Size(70, 20);
            Pass.TabIndex = 1;
            Pass.Text = "Mật khẩu";
            Pass.Click += Pass_Click;
            // 
            // IDBox
            // 
            IDBox.Location = new Point(350, 87);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(214, 27);
            IDBox.TabIndex = 2;
            // 
            // PasswordBox
            // 
            PasswordBox.Cursor = Cursors.IBeam;
            PasswordBox.Location = new Point(351, 120);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(213, 27);
            PasswordBox.TabIndex = 3;
            PasswordBox.KeyPress += PasswordBox_KeyPress;
            // 
            // PhoneNumberBox
            // 
            PhoneNumberBox.Location = new Point(351, 153);
            PhoneNumberBox.Name = "PhoneNumberBox";
            PhoneNumberBox.Size = new Size(214, 27);
            PhoneNumberBox.TabIndex = 5;
            PhoneNumberBox.KeyPress += PhoneNumberBox_KeyPress;
            // 
            // PhoneNumber
            // 
            PhoneNumber.AutoSize = true;
            PhoneNumber.Location = new Point(202, 160);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(97, 20);
            PhoneNumber.TabIndex = 4;
            PhoneNumber.Text = "Số điện thoại";
            PhoneNumber.Click += PhoneNumber_Click;
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(351, 193);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(214, 27);
            AddressBox.TabIndex = 7;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(202, 200);
            Address.Name = "Address";
            Address.Size = new Size(55, 20);
            Address.TabIndex = 6;
            Address.Text = "Địa chỉ";
            Address.Click += Address_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 94);
            label1.Name = "label1";
            label1.Size = new Size(12, 20);
            label1.TabIndex = 8;
            label1.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 127);
            label2.Name = "label2";
            label2.Size = new Size(12, 20);
            label2.TabIndex = 9;
            label2.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 160);
            label5.Name = "label5";
            label5.Size = new Size(12, 20);
            label5.TabIndex = 10;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(333, 196);
            label6.Name = "label6";
            label6.Size = new Size(12, 20);
            label6.TabIndex = 11;
            label6.Text = ":";
            // 
            // RegisterButton
            // 
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.Location = new Point(137, 274);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(218, 40);
            RegisterButton.TabIndex = 12;
            RegisterButton.Text = "Đăng Ký";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.Location = new Point(410, 274);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(218, 40);
            CancelButton.TabIndex = 13;
            CancelButton.Text = "Xóa Thông Tin";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelButton);
            Controls.Add(RegisterButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddressBox);
            Controls.Add(Address);
            Controls.Add(PhoneNumberBox);
            Controls.Add(PhoneNumber);
            Controls.Add(PasswordBox);
            Controls.Add(IDBox);
            Controls.Add(Pass);
            Controls.Add(ID);
            Cursor = Cursors.IBeam;
            Name = "Form1";
            Text = "Đăng ký";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private Label Pass;
        private TextBox IDBox;
        private TextBox PasswordBox;
        private TextBox PhoneNumberBox;
        private Label PhoneNumber;
        private TextBox AddressBox;
        private Label Address;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Button RegisterButton;
        private Button CancelButton;
    }
}
