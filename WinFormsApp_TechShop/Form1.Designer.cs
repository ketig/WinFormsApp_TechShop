namespace WinFormsApp_TechShop
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
            label_email = new Label();
            label_password = new Label();
            button_signIn = new Button();
            textBox_email = new TextBox();
            textBox_password = new TextBox();
            label_id = new Label();
            SuspendLayout();
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(347, 148);
            label_email.Name = "label_email";
            label_email.Size = new Size(88, 41);
            label_email.TabIndex = 0;
            label_email.Text = "Email";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(347, 254);
            label_password.Name = "label_password";
            label_password.Size = new Size(143, 41);
            label_password.TabIndex = 1;
            label_password.Text = "Password";
            // 
            // button_signIn
            // 
            button_signIn.Location = new Point(614, 476);
            button_signIn.Name = "button_signIn";
            button_signIn.Size = new Size(250, 65);
            button_signIn.TabIndex = 2;
            button_signIn.Text = "Sign In";
            button_signIn.UseVisualStyleBackColor = true;
            button_signIn.Click += button_signIn_Click;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(614, 148);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(250, 47);
            textBox_email.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(614, 254);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(250, 47);
            textBox_password.TabIndex = 4;
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(680, 657);
            label_id.Name = "label_id";
            label_id.Size = new Size(0, 41);
            label_id.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1681, 1045);
            Controls.Add(label_id);
            Controls.Add(textBox_password);
            Controls.Add(textBox_email);
            Controls.Add(button_signIn);
            Controls.Add(label_password);
            Controls.Add(label_email);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_email;
        private Label label_password;
        private Button button_signIn;
        private TextBox textBox_email;
        private TextBox textBox_password;
        private Label label_id;
    }
}
