namespace loging
{
    partial class trangchinhlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trangchinhlogin));
            this.imglogin = new System.Windows.Forms.PictureBox();
            this.imguser = new System.Windows.Forms.PictureBox();
            this.imgpasss = new System.Windows.Forms.PictureBox();
            this.txtbusername = new System.Windows.Forms.TextBox();
            this.txtbpassword = new System.Windows.Forms.TextBox();
            this.chkShowpassword = new System.Windows.Forms.CheckBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.likforgotpass = new System.Windows.Forms.LinkLabel();
            this.txt = new System.Windows.Forms.Label();
            this.lblerroruser = new System.Windows.Forms.Label();
            this.lblerrorpasswword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imglogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgpasss)).BeginInit();
            this.SuspendLayout();
            // 
            // imglogin
            // 
            this.imglogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.imglogin.Image = ((System.Drawing.Image)(resources.GetObject("imglogin.Image")));
            this.imglogin.Location = new System.Drawing.Point(0, 0);
            this.imglogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imglogin.Name = "imglogin";
            this.imglogin.Size = new System.Drawing.Size(472, 167);
            this.imglogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imglogin.TabIndex = 0;
            this.imglogin.TabStop = false;
            // 
            // imguser
            // 
            this.imguser.Image = ((System.Drawing.Image)(resources.GetObject("imguser.Image")));
            this.imguser.Location = new System.Drawing.Point(89, 218);
            this.imguser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imguser.Name = "imguser";
            this.imguser.Size = new System.Drawing.Size(79, 78);
            this.imguser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imguser.TabIndex = 1;
            this.imguser.TabStop = false;
            // 
            // imgpasss
            // 
            this.imgpasss.Image = ((System.Drawing.Image)(resources.GetObject("imgpasss.Image")));
            this.imgpasss.Location = new System.Drawing.Point(89, 326);
            this.imgpasss.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgpasss.Name = "imgpasss";
            this.imgpasss.Size = new System.Drawing.Size(79, 78);
            this.imgpasss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgpasss.TabIndex = 2;
            this.imgpasss.TabStop = false;
            // 
            // txtbusername
            // 
            this.txtbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtbusername.Location = new System.Drawing.Point(177, 248);
            this.txtbusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbusername.Name = "txtbusername";
            this.txtbusername.Size = new System.Drawing.Size(212, 27);
            this.txtbusername.TabIndex = 3;
            this.txtbusername.Text = "Enter your Name";
            this.txtbusername.Enter += new System.EventHandler(this.txtbusername_Enter);
            this.txtbusername.Leave += new System.EventHandler(this.txtbusername_Leave);
            // 
            // txtbpassword
            // 
            this.txtbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbpassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtbpassword.Location = new System.Drawing.Point(177, 353);
            this.txtbpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbpassword.Name = "txtbpassword";
            this.txtbpassword.Size = new System.Drawing.Size(212, 27);
            this.txtbpassword.TabIndex = 4;
            this.txtbpassword.Text = "Enter your password";
            this.txtbpassword.Enter += new System.EventHandler(this.txtbpassword_Enter);
            this.txtbpassword.Leave += new System.EventHandler(this.txtbpassword_Leave);
            // 
            // chkShowpassword
            // 
            this.chkShowpassword.AutoSize = true;
            this.chkShowpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowpassword.Location = new System.Drawing.Point(177, 384);
            this.chkShowpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkShowpassword.Name = "chkShowpassword";
            this.chkShowpassword.Size = new System.Drawing.Size(124, 20);
            this.chkShowpassword.TabIndex = 5;
            this.chkShowpassword.Text = "Show password";
            this.chkShowpassword.UseVisualStyleBackColor = true;
            this.chkShowpassword.Click += new System.EventHandler(this.chkShowpassword_rightclick);
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Location = new System.Drawing.Point(99, 438);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(112, 36);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_rightclick);
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.Location = new System.Drawing.Point(277, 438);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(112, 36);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_rightclick);
            // 
            // likforgotpass
            // 
            this.likforgotpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.likforgotpass.AutoSize = true;
            this.likforgotpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.likforgotpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likforgotpass.LinkColor = System.Drawing.Color.Purple;
            this.likforgotpass.Location = new System.Drawing.Point(95, 476);
            this.likforgotpass.Name = "likforgotpass";
            this.likforgotpass.Size = new System.Drawing.Size(134, 20);
            this.likforgotpass.TabIndex = 8;
            this.likforgotpass.TabStop = true;
            this.likforgotpass.Text = "Forgot password";
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(85, 170);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(264, 20);
            this.txt.TabIndex = 9;
            this.txt.Text = "Enter username and password";
            this.txt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblerroruser
            // 
            this.lblerroruser.AutoSize = true;
            this.lblerroruser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerroruser.Location = new System.Drawing.Point(176, 226);
            this.lblerroruser.Name = "lblerroruser";
            this.lblerroruser.Size = new System.Drawing.Size(0, 20);
            this.lblerroruser.TabIndex = 10;
            this.lblerroruser.Visible = false;
            // 
            // lblerrorpasswword
            // 
            this.lblerrorpasswword.AutoSize = true;
            this.lblerrorpasswword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorpasswword.Location = new System.Drawing.Point(176, 331);
            this.lblerrorpasswword.Name = "lblerrorpasswword";
            this.lblerrorpasswword.Size = new System.Drawing.Size(0, 20);
            this.lblerrorpasswword.TabIndex = 11;
            this.lblerrorpasswword.Visible = false;
            this.lblerrorpasswword.Click += new System.EventHandler(this.label1_Click);
            // 
            // trangchinhlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 545);
            this.Controls.Add(this.lblerrorpasswword);
            this.Controls.Add(this.lblerroruser);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.likforgotpass);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.chkShowpassword);
            this.Controls.Add(this.txtbpassword);
            this.Controls.Add(this.txtbusername);
            this.Controls.Add(this.imgpasss);
            this.Controls.Add(this.imguser);
            this.Controls.Add(this.imglogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "trangchinhlogin";
            this.Tag = "";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.imglogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgpasss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imglogin;
        private System.Windows.Forms.PictureBox imguser;
        private System.Windows.Forms.PictureBox imgpasss;
        private System.Windows.Forms.TextBox txtbusername;
        private System.Windows.Forms.TextBox txtbpassword;
        private System.Windows.Forms.CheckBox chkShowpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.LinkLabel likforgotpass;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label lblerroruser;
        private System.Windows.Forms.Label lblerrorpasswword;
    }
}

