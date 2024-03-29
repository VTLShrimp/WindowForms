namespace Test
{
    partial class ResetForm
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
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.Usernametextbox = new System.Windows.Forms.TextBox();
            this.ConfirmTextBox = new System.Windows.Forms.TextBox();
            this.NewPassTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(58, 344);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(163, 68);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Usernametextbox
            // 
            this.Usernametextbox.Location = new System.Drawing.Point(192, 118);
            this.Usernametextbox.Margin = new System.Windows.Forms.Padding(4);
            this.Usernametextbox.Name = "Usernametextbox";
            this.Usernametextbox.Size = new System.Drawing.Size(233, 26);
            this.Usernametextbox.TabIndex = 1;
            // 
            // ConfirmTextBox
            // 
            this.ConfirmTextBox.Location = new System.Drawing.Point(192, 244);
            this.ConfirmTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.PasswordChar = '*';
            this.ConfirmTextBox.Size = new System.Drawing.Size(233, 26);
            this.ConfirmTextBox.TabIndex = 2;
            // 
            // NewPassTextBox
            // 
            this.NewPassTextBox.Location = new System.Drawing.Point(192, 182);
            this.NewPassTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NewPassTextBox.Name = "NewPassTextBox";
            this.NewPassTextBox.PasswordChar = '*';
            this.NewPassTextBox.Size = new System.Drawing.Size(233, 26);
            this.NewPassTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password :";
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(281, 344);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(163, 68);
            this.cancelbutton.TabIndex = 7;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(115, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reset Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(192, 277);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 429);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPassTextBox);
            this.Controls.Add(this.ConfirmTextBox);
            this.Controls.Add(this.Usernametextbox);
            this.Controls.Add(this.ConfirmButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResetForm";
            this.Text = "ResetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox Usernametextbox;
        private System.Windows.Forms.TextBox ConfirmTextBox;
        private System.Windows.Forms.TextBox NewPassTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}