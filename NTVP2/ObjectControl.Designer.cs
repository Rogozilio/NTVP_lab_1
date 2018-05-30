namespace NTVP2
{
    partial class ObjectControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DiscountComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DiscountComboBox
            // 
            this.DiscountComboBox.FormattingEnabled = true;
            this.DiscountComboBox.Items.AddRange(new object[] {
            "Percent",
            "Certificate"});
            this.DiscountComboBox.Location = new System.Drawing.Point(3, 13);
            this.DiscountComboBox.Name = "DiscountComboBox";
            this.DiscountComboBox.Size = new System.Drawing.Size(93, 21);
            this.DiscountComboBox.TabIndex = 0;
            this.DiscountComboBox.SelectedIndexChanged += new System.EventHandler(this.DiscountComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Discount type";
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(3, 50);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(93, 20);
            this.DiscountTextBox.TabIndex = 2;
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(102, 53);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(0, 13);
            this.DiscountLabel.TabIndex = 3;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(3, 86);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(93, 20);
            this.PriceTextBox.TabIndex = 4;
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(102, 89);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(70, 13);
            this.ProductPriceLabel.TabIndex = 5;
            this.ProductPriceLabel.Text = "Price product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AcceptAddDiscountButton_Click);
            // 
            // ObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.DiscountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiscountComboBox);
            this.Name = "ObjectControl";
            this.Size = new System.Drawing.Size(186, 157);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DiscountComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.Button button1;
    }
}
