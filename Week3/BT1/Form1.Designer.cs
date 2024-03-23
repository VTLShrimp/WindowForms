namespace BT1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.newnum = new System.Windows.Forms.TextBox();
            this.bT1week3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseFakeDataSet1 = new BT1.DataBaseFakeDataSet1();
            this.oldnum = new System.Windows.Forms.TextBox();
            this.kwOL = new System.Windows.Forms.TextBox();
            this.kwconsume = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CalButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataBaseFakeDataSet = new BT1.DataBaseFakeDataSet();
            this.bT1week3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bT1week3TableAdapter = new BT1.DataBaseFakeDataSetTableAdapters.BT1week3TableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bT1week3TableAdapter1 = new BT1.DataBaseFakeDataSet1TableAdapters.BT1week3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bT1week3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseFakeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseFakeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bT1week3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên khách hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chỉ số cũ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chỉ số mới :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Kw tiêu thụ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số Kw trong định mức : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số Kw vượt định mức :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trong định mức là 500đ/1Kw";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Định mức là 50Kw";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Vượt định mức là 1000đ/1Kw";
            // 
            // newnum
            // 
            this.newnum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bT1week3BindingSource1, "New_number", true));
            this.newnum.Location = new System.Drawing.Point(191, 184);
            this.newnum.Name = "newnum";
            this.newnum.Size = new System.Drawing.Size(100, 26);
            this.newnum.TabIndex = 11;
            // 
            // bT1week3BindingSource1
            // 
            this.bT1week3BindingSource1.DataMember = "BT1week3";
            this.bT1week3BindingSource1.DataSource = this.dataBaseFakeDataSet1;
            // 
            // dataBaseFakeDataSet1
            // 
            this.dataBaseFakeDataSet1.DataSetName = "DataBaseFakeDataSet1";
            this.dataBaseFakeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oldnum
            // 
            this.oldnum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bT1week3BindingSource1, "Old_number", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.oldnum.Location = new System.Drawing.Point(191, 139);
            this.oldnum.Name = "oldnum";
            this.oldnum.Size = new System.Drawing.Size(100, 26);
            this.oldnum.TabIndex = 12;
            // 
            // kwOL
            // 
            this.kwOL.Enabled = false;
            this.kwOL.Location = new System.Drawing.Point(508, 184);
            this.kwOL.Name = "kwOL";
            this.kwOL.Size = new System.Drawing.Size(70, 26);
            this.kwOL.TabIndex = 13;
            // 
            // kwconsume
            // 
            this.kwconsume.Enabled = false;
            this.kwconsume.Location = new System.Drawing.Point(191, 225);
            this.kwconsume.Name = "kwconsume";
            this.kwconsume.Size = new System.Drawing.Size(100, 26);
            this.kwconsume.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(508, 139);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(70, 26);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "50";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(62, 318);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(205, 26);
            this.textBox7.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tổng tiền phải trả : ";
            // 
            // CalButton
            // 
            this.CalButton.Location = new System.Drawing.Point(62, 350);
            this.CalButton.Name = "CalButton";
            this.CalButton.Size = new System.Drawing.Size(100, 42);
            this.CalButton.TabIndex = 18;
            this.CalButton.Text = "Tính";
            this.CalButton.UseVisualStyleBackColor = true;
            this.CalButton.Click += new System.EventHandler(this.CalButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Enabled = false;
            this.PrintButton.Location = new System.Drawing.Point(167, 350);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(100, 42);
            this.PrintButton.TabIndex = 19;
            this.PrintButton.Text = "In";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(108, 398);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(100, 42);
            this.exitbutton.TabIndex = 20;
            this.exitbutton.Text = "Thoát";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(151, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(384, 39);
            this.label11.TabIndex = 21;
            this.label11.Text = "BẢNG TÍNH TIỀN ĐIỆN";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bT1week3BindingSource1;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(231, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "Name";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataBaseFakeDataSet
            // 
            this.dataBaseFakeDataSet.DataSetName = "DataBaseFakeDataSet";
            this.dataBaseFakeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bT1week3BindingSource
            // 
            this.bT1week3BindingSource.DataMember = "BT1week3";
            this.bT1week3BindingSource.DataSource = this.dataBaseFakeDataSet;
            // 
            // bT1week3TableAdapter
            // 
            this.bT1week3TableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(318, 318);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 124);
            this.listBox1.TabIndex = 23;
            // 
            // bT1week3TableAdapter1
            // 
            this.bT1week3TableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 562);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CalButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.kwconsume);
            this.Controls.Add(this.kwOL);
            this.Controls.Add(this.oldnum);
            this.Controls.Add(this.newnum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bT1week3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseFakeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseFakeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bT1week3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newnum;
        private System.Windows.Forms.TextBox oldnum;
        private System.Windows.Forms.TextBox kwOL;
        private System.Windows.Forms.TextBox kwconsume;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CalButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataBaseFakeDataSet dataBaseFakeDataSet;
        private System.Windows.Forms.BindingSource bT1week3BindingSource;
        private DataBaseFakeDataSetTableAdapters.BT1week3TableAdapter bT1week3TableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private DataBaseFakeDataSet1 dataBaseFakeDataSet1;
        private System.Windows.Forms.BindingSource bT1week3BindingSource1;
        private DataBaseFakeDataSet1TableAdapters.BT1week3TableAdapter bT1week3TableAdapter1;
    }
}

