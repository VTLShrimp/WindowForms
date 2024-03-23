namespace BT2
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
            this.listsonguyen = new System.Windows.Forms.ListBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.changebutton = new System.Windows.Forms.Button();
            this.result_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numberbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.result_box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listsonguyen
            // 
            this.listsonguyen.FormattingEnabled = true;
            this.listsonguyen.ItemHeight = 20;
            this.listsonguyen.Location = new System.Drawing.Point(21, 26);
            this.listsonguyen.Margin = new System.Windows.Forms.Padding(4);
            this.listsonguyen.Name = "listsonguyen";
            this.listsonguyen.Size = new System.Drawing.Size(434, 144);
            this.listsonguyen.TabIndex = 0;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(127, 365);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(103, 39);
            this.Addbutton.TabIndex = 3;
            this.Addbutton.Text = "Thêm";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(277, 365);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(103, 39);
            this.deletebutton.TabIndex = 4;
            this.deletebutton.Text = "Xóa";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // changebutton
            // 
            this.changebutton.Location = new System.Drawing.Point(434, 365);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(103, 39);
            this.changebutton.TabIndex = 5;
            this.changebutton.Text = "Sửa";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // result_button
            // 
            this.result_button.Location = new System.Drawing.Point(277, 432);
            this.result_button.Name = "result_button";
            this.result_button.Size = new System.Drawing.Size(103, 39);
            this.result_button.TabIndex = 6;
            this.result_button.Text = "Tính";
            this.result_button.UseVisualStyleBackColor = true;
            this.result_button.Click += new System.EventHandler(this.result_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giá trị";
            // 
            // numberbox
            // 
            this.numberbox.Location = new System.Drawing.Point(201, 307);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(289, 26);
            this.numberbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 506);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kết quả";
            // 
            // result_box
            // 
            this.result_box.Location = new System.Drawing.Point(214, 503);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(289, 26);
            this.result_box.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listsonguyen);
            this.groupBox1.Location = new System.Drawing.Point(90, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 206);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách số nguyên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.result_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result_button);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.Addbutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listsonguyen;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button changebutton;
        private System.Windows.Forms.Button result_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result_box;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

