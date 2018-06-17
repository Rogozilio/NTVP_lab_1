namespace NTVP2
{
    partial class AddDiscountForm
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
            this.CancelAddDiscountButton = new System.Windows.Forms.Button();
            this.AcceptAddDiscountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelAddDiscountButton
            // 
            this.CancelAddDiscountButton.Location = new System.Drawing.Point(103, 144);
            this.CancelAddDiscountButton.Name = "CancelAddDiscountButton";
            this.CancelAddDiscountButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAddDiscountButton.TabIndex = 3;
            this.CancelAddDiscountButton.Text = "Cancel";
            this.CancelAddDiscountButton.UseVisualStyleBackColor = true;
            this.CancelAddDiscountButton.Click += new System.EventHandler(this.CancelAddDiscountButton_Click);
            // 
            // AcceptAddDiscountButton
            // 
            this.AcceptAddDiscountButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AcceptAddDiscountButton.Location = new System.Drawing.Point(5, 145);
            this.AcceptAddDiscountButton.Name = "AcceptAddDiscountButton";
            this.AcceptAddDiscountButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptAddDiscountButton.TabIndex = 5;
            this.AcceptAddDiscountButton.Text = "Add";
            this.AcceptAddDiscountButton.UseVisualStyleBackColor = true;
            this.AcceptAddDiscountButton.Click += new System.EventHandler(this.AcceptAddDiscountButton_Click);
            // 
            // AddDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 177);
            this.Controls.Add(this.AcceptAddDiscountButton);
            this.Controls.Add(this.CancelAddDiscountButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddDiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDiscountForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CancelAddDiscountButton;
        private System.Windows.Forms.Button AcceptAddDiscountButton;
    }
}