namespace Bt6_doitien
{
    partial class frmdoitien
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
            this.btnvn_us = new System.Windows.Forms.Button();
            this.btnvn_eu = new System.Windows.Forms.Button();
            this.btnus_vn = new System.Windows.Forms.Button();
            this.btneu_vn = new System.Windows.Forms.Button();
            this.txtsodoi = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền muốn đổi";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết Quả";
            // 
            // btnvn_us
            // 
            this.btnvn_us.Enabled = false;
            this.btnvn_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvn_us.Location = new System.Drawing.Point(36, 118);
            this.btnvn_us.Name = "btnvn_us";
            this.btnvn_us.Size = new System.Drawing.Size(162, 58);
            this.btnvn_us.TabIndex = 1;
            this.btnvn_us.Text = "VND -> USD";
            this.btnvn_us.UseVisualStyleBackColor = true;
            this.btnvn_us.Click += new System.EventHandler(this.btnvn_us_Click);
            // 
            // btnvn_eu
            // 
            this.btnvn_eu.Enabled = false;
            this.btnvn_eu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvn_eu.Location = new System.Drawing.Point(204, 118);
            this.btnvn_eu.Name = "btnvn_eu";
            this.btnvn_eu.Size = new System.Drawing.Size(162, 58);
            this.btnvn_eu.TabIndex = 2;
            this.btnvn_eu.Text = "VND -> EUR";
            this.btnvn_eu.UseVisualStyleBackColor = true;
            this.btnvn_eu.Click += new System.EventHandler(this.btnvn_eu_Click);
            // 
            // btnus_vn
            // 
            this.btnus_vn.Enabled = false;
            this.btnus_vn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnus_vn.Location = new System.Drawing.Point(372, 118);
            this.btnus_vn.Name = "btnus_vn";
            this.btnus_vn.Size = new System.Drawing.Size(162, 58);
            this.btnus_vn.TabIndex = 3;
            this.btnus_vn.Text = "USD -> VND";
            this.btnus_vn.UseVisualStyleBackColor = true;
            this.btnus_vn.Click += new System.EventHandler(this.btnus_vn_Click);
            // 
            // btneu_vn
            // 
            this.btneu_vn.Enabled = false;
            this.btneu_vn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneu_vn.Location = new System.Drawing.Point(540, 118);
            this.btneu_vn.Name = "btneu_vn";
            this.btneu_vn.Size = new System.Drawing.Size(162, 58);
            this.btneu_vn.TabIndex = 4;
            this.btneu_vn.Text = "EUR -> VND";
            this.btneu_vn.UseVisualStyleBackColor = true;
            this.btneu_vn.Click += new System.EventHandler(this.btneu_vn_Click);
            // 
            // txtsodoi
            // 
            this.txtsodoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsodoi.Location = new System.Drawing.Point(320, 34);
            this.txtsodoi.Name = "txtsodoi";
            this.txtsodoi.Size = new System.Drawing.Size(279, 28);
            this.txtsodoi.TabIndex = 6;
            this.txtsodoi.TextChanged += new System.EventHandler(this.txtsodoi_TextChanged);
            this.txtsodoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsodoi_KeyPress);
            // 
            // txtketqua
            // 
            this.txtketqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtketqua.Enabled = false;
            this.txtketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtketqua.Location = new System.Drawing.Point(320, 68);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(279, 28);
            this.txtketqua.TabIndex = 7;
            // 
            // frmdoitien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 250);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtsodoi);
            this.Controls.Add(this.btneu_vn);
            this.Controls.Add(this.btnus_vn);
            this.Controls.Add(this.btnvn_eu);
            this.Controls.Add(this.btnvn_us);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmdoitien";
            this.Text = "Đổi Tiền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnvn_us;
        private System.Windows.Forms.Button btnvn_eu;
        private System.Windows.Forms.Button btnus_vn;
        private System.Windows.Forms.Button btneu_vn;
        private System.Windows.Forms.TextBox txtsodoi;
        private System.Windows.Forms.TextBox txtketqua;
    }
}

