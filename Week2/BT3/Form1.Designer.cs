namespace BT3
{
    partial class Form1
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
            this.CustomBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatebirthSelect = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboGoFrom = new System.Windows.Forms.Label();
            this.ComboGoto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DateGo = new System.Windows.Forms.DateTimePicker();
            this.DateCome = new System.Windows.Forms.DateTimePicker();
            this.TotalDayBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ComboTo = new System.Windows.Forms.ComboBox();
            this.ComboGo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InfoList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // CustomBox
            // 
            this.CustomBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomBox.Location = new System.Drawing.Point(189, 110);
            this.CustomBox.Name = "CustomBox";
            this.CustomBox.Size = new System.Drawing.Size(225, 24);
            this.CustomBox.TabIndex = 9;
            // 
            // AddressBox
            // 
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBox.Location = new System.Drawing.Point(189, 200);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(225, 24);
            this.AddressBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày sinh ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Địa chỉ";
            // 
            // DatebirthSelect
            // 
            this.DatebirthSelect.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatebirthSelect.Location = new System.Drawing.Point(189, 153);
            this.DatebirthSelect.Name = "DatebirthSelect";
            this.DatebirthSelect.Size = new System.Drawing.Size(224, 24);
            this.DatebirthSelect.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(306, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 39);
            this.label4.TabIndex = 16;
            this.label4.Text = "CÔNG TY DU LỊCH";
            // 
            // ComboGoFrom
            // 
            this.ComboGoFrom.AutoSize = true;
            this.ComboGoFrom.Location = new System.Drawing.Point(96, 277);
            this.ComboGoFrom.Name = "ComboGoFrom";
            this.ComboGoFrom.Size = new System.Drawing.Size(81, 18);
            this.ComboGoFrom.TabIndex = 19;
            this.ComboGoFrom.Text = "Địa điểm đi";
            // 
            // ComboGoto
            // 
            this.ComboGoto.AutoSize = true;
            this.ComboGoto.Location = new System.Drawing.Point(296, 278);
            this.ComboGoto.Name = "ComboGoto";
            this.ComboGoto.Size = new System.Drawing.Size(94, 18);
            this.ComboGoto.TabIndex = 20;
            this.ComboGoto.Text = "Địa điểm đến";
            this.ComboGoto.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ngày đến";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ngày đi";
            // 
            // DateGo
            // 
            this.DateGo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateGo.Location = new System.Drawing.Point(97, 388);
            this.DateGo.Name = "DateGo";
            this.DateGo.Size = new System.Drawing.Size(136, 24);
            this.DateGo.TabIndex = 23;
            // 
            // DateCome
            // 
            this.DateCome.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateCome.Location = new System.Drawing.Point(299, 388);
            this.DateCome.Name = "DateCome";
            this.DateCome.Size = new System.Drawing.Size(136, 24);
            this.DateCome.TabIndex = 24;
            // 
            // TotalDayBox
            // 
            this.TotalDayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalDayBox.Enabled = false;
            this.TotalDayBox.Location = new System.Drawing.Point(623, 321);
            this.TotalDayBox.Name = "TotalDayBox";
            this.TotalDayBox.Size = new System.Drawing.Size(166, 24);
            this.TotalDayBox.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tổng số ngày";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 91);
            this.button1.TabIndex = 27;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(592, 358);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(101, 91);
            this.ResetButton.TabIndex = 28;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(700, 358);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 91);
            this.ExitButton.TabIndex = 29;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // ComboTo
            // 
            this.ComboTo.FormattingEnabled = true;
            this.ComboTo.Items.AddRange(new object[] {
            "Hàn Quốc",
            "Thái Lan",
            "Úc"});
            this.ComboTo.Location = new System.Drawing.Point(299, 299);
            this.ComboTo.Name = "ComboTo";
            this.ComboTo.Size = new System.Drawing.Size(136, 26);
            this.ComboTo.TabIndex = 18;
            // 
            // ComboGo
            // 
            this.ComboGo.FormattingEnabled = true;
            this.ComboGo.Items.AddRange(new object[] {
            "TP.HCM",
            "Hà Nội",
            "Vũng Tàu"});
            this.ComboGo.Location = new System.Drawing.Point(97, 299);
            this.ComboGo.Name = "ComboGo";
            this.ComboGo.Size = new System.Drawing.Size(136, 26);
            this.ComboGo.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InfoList);
            this.groupBox1.Location = new System.Drawing.Point(461, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 201);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // InfoList
            // 
            this.InfoList.BackColor = System.Drawing.SystemColors.Info;
            this.InfoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.InfoList.FormattingEnabled = true;
            this.InfoList.ItemHeight = 22;
            this.InfoList.Location = new System.Drawing.Point(16, 23);
            this.InfoList.Name = "InfoList";
            this.InfoList.Size = new System.Drawing.Size(306, 158);
            this.InfoList.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TotalDayBox);
            this.Controls.Add(this.DateCome);
            this.Controls.Add(this.DateGo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboGoto);
            this.Controls.Add(this.ComboGoFrom);
            this.Controls.Add(this.ComboTo);
            this.Controls.Add(this.ComboGo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DatebirthSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.CustomBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DatebirthSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ComboGoFrom;
        private System.Windows.Forms.Label ComboGoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateGo;
        private System.Windows.Forms.DateTimePicker DateCome;
        private System.Windows.Forms.TextBox TotalDayBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ComboBox ComboTo;
        private System.Windows.Forms.ComboBox ComboGo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox InfoList;
    }
}

