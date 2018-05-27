namespace NTVP2
{
    partial class ExeptionForm
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
            this.ExeptionLabel = new System.Windows.Forms.Label();
            this.CloseExeptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExeptionLabel
            // 
            this.ExeptionLabel.AutoSize = true;
            this.ExeptionLabel.Location = new System.Drawing.Point(12, 29);
            this.ExeptionLabel.Name = "ExeptionLabel";
            this.ExeptionLabel.Size = new System.Drawing.Size(35, 13);
            this.ExeptionLabel.TabIndex = 0;
            this.ExeptionLabel.Text = "label1";
            // 
            // CloseExeptionButton
            // 
            this.CloseExeptionButton.Location = new System.Drawing.Point(82, 61);
            this.CloseExeptionButton.Name = "CloseExeptionButton";
            this.CloseExeptionButton.Size = new System.Drawing.Size(75, 23);
            this.CloseExeptionButton.TabIndex = 1;
            this.CloseExeptionButton.Text = "Close";
            this.CloseExeptionButton.UseVisualStyleBackColor = true;
            this.CloseExeptionButton.Click += new System.EventHandler(this.CloseExeptionButton_Click);
            // 
            // ExeptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 96);
            this.Controls.Add(this.CloseExeptionButton);
            this.Controls.Add(this.ExeptionLabel);
            this.Name = "ExeptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExceptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExeptionLabel;
        private System.Windows.Forms.Button CloseExeptionButton;
    }
}