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
            this.components = new System.ComponentModel.Container();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.AcceptAddDiscountButton = new System.Windows.Forms.Button();
            this.CancelAddDiscountButton = new System.Windows.Forms.Button();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.PercentRadioButton = new System.Windows.Forms.RadioButton();
            this.CertificateRadioButton = new System.Windows.Forms.RadioButton();
            this.DiscountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DiscountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(116, 27);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(65, 20);
            this.DiscountTextBox.TabIndex = 0;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(116, 64);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(65, 20);
            this.PriceTextBox.TabIndex = 1;
            // 
            // AcceptAddDiscountButton
            // 
            this.AcceptAddDiscountButton.Location = new System.Drawing.Point(19, 134);
            this.AcceptAddDiscountButton.Name = "AcceptAddDiscountButton";
            this.AcceptAddDiscountButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptAddDiscountButton.TabIndex = 2;
            this.AcceptAddDiscountButton.Text = "Ok";
            this.AcceptAddDiscountButton.UseVisualStyleBackColor = true;
            this.AcceptAddDiscountButton.Click += new System.EventHandler(this.AcceptAddDiscountButton_Click);
            // 
            // CancelAddDiscountButton
            // 
            this.CancelAddDiscountButton.Location = new System.Drawing.Point(116, 134);
            this.CancelAddDiscountButton.Name = "CancelAddDiscountButton";
            this.CancelAddDiscountButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAddDiscountButton.TabIndex = 3;
            this.CancelAddDiscountButton.Text = "Cancel";
            this.CancelAddDiscountButton.UseVisualStyleBackColor = true;
            this.CancelAddDiscountButton.Click += new System.EventHandler(this.CancelAddDiscountButton_Click);
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(24, 30);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(44, 13);
            this.DiscountLabel.TabIndex = 4;
            this.DiscountLabel.Text = "Percent";
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(24, 67);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(70, 13);
            this.ProductPriceLabel.TabIndex = 5;
            this.ProductPriceLabel.Text = "Product price";
            // 
            // PercentRadioButton
            // 
            this.PercentRadioButton.AutoSize = true;
            this.PercentRadioButton.Checked = true;
            this.PercentRadioButton.Location = new System.Drawing.Point(27, 102);
            this.PercentRadioButton.Name = "PercentRadioButton";
            this.PercentRadioButton.Size = new System.Drawing.Size(62, 17);
            this.PercentRadioButton.TabIndex = 6;
            this.PercentRadioButton.TabStop = true;
            this.PercentRadioButton.Text = "Percent";
            this.PercentRadioButton.UseVisualStyleBackColor = true;
            this.PercentRadioButton.CheckedChanged += new System.EventHandler(this.PercentRadioButton_CheckedChanged);
            // 
            // CertificateRadioButton
            // 
            this.CertificateRadioButton.AutoSize = true;
            this.CertificateRadioButton.Location = new System.Drawing.Point(116, 102);
            this.CertificateRadioButton.Name = "CertificateRadioButton";
            this.CertificateRadioButton.Size = new System.Drawing.Size(66, 17);
            this.CertificateRadioButton.TabIndex = 7;
            this.CertificateRadioButton.Text = "Certificat";
            this.CertificateRadioButton.UseVisualStyleBackColor = true;
            this.CertificateRadioButton.CheckedChanged += new System.EventHandler(this.CertificateRadioButton_CheckedChanged);
            // 
            // AddDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 172);
            this.Controls.Add(this.CertificateRadioButton);
            this.Controls.Add(this.PercentRadioButton);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.CancelAddDiscountButton);
            this.Controls.Add(this.AcceptAddDiscountButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.DiscountTextBox);
            this.Name = "AddDiscountForm";
            this.Text = "AddDiscountForm";
            ((System.ComponentModel.ISupportInitialize)(this.DiscountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button AcceptAddDiscountButton;
        private System.Windows.Forms.Button CancelAddDiscountButton;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label ProductPriceLabel;
        public System.Windows.Forms.BindingSource DiscountBindingSource;
        private System.Windows.Forms.RadioButton PercentRadioButton;
        private System.Windows.Forms.RadioButton CertificateRadioButton;
    }
}