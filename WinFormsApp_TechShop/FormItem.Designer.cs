namespace WinFormsApp_TechShop
{
    partial class FormItem
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
            label_id = new Label();
            SuspendLayout();
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Location = new Point(572, 716);
            label_id.Name = "label_id";
            label_id.Size = new Size(0, 41);
            label_id.TabIndex = 8;
            // 
            // FormItem
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 930);
            Controls.Add(label_id);
            Name = "FormItem";
            Text = "FormItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_id;
    }
}