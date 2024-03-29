using System.Windows.Forms;

namespace uocchungboichung
{
    partial class frmuocch_boich
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.txtucln = new System.Windows.Forms.TextBox();
            this.txtbcnn = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.btntiep = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ước chung lớn nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bội chung nhỏ nhất";
            // 
            // txtso1
            // 
            this.txtso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso1.Location = new System.Drawing.Point(274, 133);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(215, 28);
            this.txtso1.TabIndex = 5;
            this.txtso1.TextChanged += new System.EventHandler(this.txtso1_TextChanged);
            this.txtso1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtso1_KeyPress);
            // 
            // txtso2
            // 
            this.txtso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtso2.Location = new System.Drawing.Point(274, 184);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(215, 28);
            this.txtso2.TabIndex = 6;
            this.txtso2.TextChanged += new System.EventHandler(this.txtso2_TextChanged);
            this.txtso2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtso2_KeyPress);
            // 
            // txtucln
            // 
            this.txtucln.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtucln.Enabled = false;
            this.txtucln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtucln.Location = new System.Drawing.Point(339, 229);
            this.txtucln.Name = "txtucln";
            this.txtucln.Size = new System.Drawing.Size(150, 28);
            this.txtucln.TabIndex = 7;
            // 
            // txtbcnn
            // 
            this.txtbcnn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbcnn.Enabled = false;
            this.txtbcnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbcnn.Location = new System.Drawing.Point(339, 276);
            this.txtbcnn.Name = "txtbcnn";
            this.txtbcnn.Size = new System.Drawing.Size(150, 28);
            this.txtbcnn.TabIndex = 8;
            // 
            // txthoten
            // 
            this.txthoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoten.Location = new System.Drawing.Point(178, 87);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(279, 28);
            this.txthoten.TabIndex = 9;
            this.txthoten.TextChanged += new System.EventHandler(this.txthoten_TextChanged);
            // 
            // btntim
            // 
            this.btntim.Enabled = false;
            this.btntim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.Location = new System.Drawing.Point(145, 326);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(84, 49);
            this.btntim.TabIndex = 10;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntiep
            // 
            this.btntiep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntiep.Location = new System.Drawing.Point(259, 326);
            this.btntiep.Name = "btntiep";
            this.btntiep.Size = new System.Drawing.Size(117, 49);
            this.btntiep.TabIndex = 11;
            this.btntiep.Text = "Tiếp tục";
            this.btntiep.UseVisualStyleBackColor = true;
            this.btntiep.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(405, 326);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(84, 49);
            this.btnthoat.TabIndex = 12;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmuocch_boich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntiep);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtbcnn);
            this.Controls.Add(this.txtucln);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmuocch_boich";
            this.Text = "Ước chung lớn nhất _ Bội chung nhỏ nhất";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox txtucln;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btntiep;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtbcnn;
        private ErrorProvider ErrorProvider = new ErrorProvider();

    }
}

