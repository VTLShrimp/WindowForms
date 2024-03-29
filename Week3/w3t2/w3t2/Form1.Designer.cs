namespace w3t2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txta = new TextBox();
            txtb = new TextBox();
            txtc = new TextBox();
            txtkq = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // txta
            // 
            txta.Location = new Point(25, 77);
            txta.Name = "txta";
            txta.Size = new Size(88, 27);
            txta.TabIndex = 0;
            // 
            // txtb
            // 
            txtb.Location = new Point(213, 77);
            txtb.Name = "txtb";
            txtb.Size = new Size(88, 27);
            txtb.TabIndex = 1;
            // 
            // txtc
            // 
            txtc.Location = new Point(409, 77);
            txtc.Name = "txtc";
            txtc.Size = new Size(88, 27);
            txtc.TabIndex = 2;
            // 
            // txtkq
            // 
            txtkq.Location = new Point(25, 168);
            txtkq.Name = "txtkq";
            txtkq.Size = new Size(265, 117);
            txtkq.TabIndex = 3;
            txtkq.Text = "";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(380, 352);
            button1.Name = "button1";
            button1.Size = new Size(106, 48);
            button1.TabIndex = 4;
            button1.Text = "Tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(492, 352);
            button2.Name = "button2";
            button2.Size = new Size(101, 48);
            button2.TabIndex = 5;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 84);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 6;
            label1.Text = "X^2+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 84);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 7;
            label2.Text = "X+";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 84);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 8;
            label3.Text = "=0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 145);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 9;
            label4.Text = "Kết quả";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtkq);
            Controls.Add(txtc);
            Controls.Add(txtb);
            Controls.Add(txta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txta;
        private TextBox txtb;
        private TextBox txtc;
        private RichTextBox txtkq;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ImageList imageList1;
    }
}
