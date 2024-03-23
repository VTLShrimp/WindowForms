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
            this.label1 = new System.Windows.Forms.Label();
            this.numbersBox = new System.Windows.Forms.TextBox();
            this.result_box = new System.Windows.Forms.TextBox();
            this.ResultText = new System.Windows.Forms.Label();
            this.buttonTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dãy số";
            // 
            // numbersBox
            // 
            this.numbersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersBox.Location = new System.Drawing.Point(143, 86);
            this.numbersBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numbersBox.Name = "numbersBox";
            this.numbersBox.Size = new System.Drawing.Size(255, 30);
            this.numbersBox.TabIndex = 1;
            // 
            // result_box
            // 
            this.result_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.result_box.Location = new System.Drawing.Point(192, 289);
            this.result_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(155, 30);
            this.result_box.TabIndex = 3;
            // 
            // ResultText
            // 
            this.ResultText.AutoSize = true;
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultText.Location = new System.Drawing.Point(64, 294);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(80, 25);
            this.ResultText.TabIndex = 2;
            this.ResultText.Text = "Kết quả";
            // 
            // buttonTinh
            // 
            this.buttonTinh.Location = new System.Drawing.Point(121, 186);
            this.buttonTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTinh.Name = "buttonTinh";
            this.buttonTinh.Size = new System.Drawing.Size(241, 34);
            this.buttonTinh.TabIndex = 4;
            this.buttonTinh.Text = "Tính";
            this.buttonTinh.UseVisualStyleBackColor = true;
            this.buttonTinh.Click += new System.EventHandler(this.buttonTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.buttonTinh);
            this.Controls.Add(this.result_box);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.numbersBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "trung binh cong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numbersBox;
        private System.Windows.Forms.TextBox result_box;
        private System.Windows.Forms.Label ResultText;
        private System.Windows.Forms.Button buttonTinh;
    }
}

