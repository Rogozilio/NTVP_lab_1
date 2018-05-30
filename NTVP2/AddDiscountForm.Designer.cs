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
            this.CancelAddDiscountButton = new System.Windows.Forms.Button();
            this.DiscountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objectControl1 = new NTVP2.ObjectControl();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelAddDiscountButton
            // 
            this.CancelAddDiscountButton.Location = new System.Drawing.Point(58, 175);
            this.CancelAddDiscountButton.Name = "CancelAddDiscountButton";
            this.CancelAddDiscountButton.Size = new System.Drawing.Size(75, 23);
            this.CancelAddDiscountButton.TabIndex = 3;
            this.CancelAddDiscountButton.Text = "Cancel";
            this.CancelAddDiscountButton.UseVisualStyleBackColor = true;
            this.CancelAddDiscountButton.Click += new System.EventHandler(this.CancelAddDiscountButton_Click);
            // 
            // objectControl1
            // 
            this.objectControl1.Location = new System.Drawing.Point(5, 12);
            this.objectControl1.Name = "objectControl1";
            this.objectControl1.ReadOnly = true;
            this.objectControl1.Size = new System.Drawing.Size(186, 157);
            this.objectControl1.TabIndex = 4;
            // 
            // AddDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 211);
            this.Controls.Add(this.objectControl1);
            this.Controls.Add(this.CancelAddDiscountButton);
            this.Name = "AddDiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDiscountForm";
            ((System.ComponentModel.ISupportInitialize)(this.DiscountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CancelAddDiscountButton;
        public System.Windows.Forms.BindingSource DiscountBindingSource;
        private ObjectControl objectControl1;
    }
}