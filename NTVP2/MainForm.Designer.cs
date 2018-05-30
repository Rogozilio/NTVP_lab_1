namespace NTVP2
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DiscountGridView = new System.Windows.Forms.DataGridView();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDiscountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CreateRandomDataButton = new System.Windows.Forms.Button();
            this.AddDiscountButton = new System.Windows.Forms.Button();
            this.RemoveDiscountButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FindStringButton = new System.Windows.Forms.Button();
            this.DiscountComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDiscountBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoadButton);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.DiscountGridView);
            this.groupBox1.Controls.Add(this.CreateRandomDataButton);
            this.groupBox1.Controls.Add(this.AddDiscountButton);
            this.groupBox1.Controls.Add(this.RemoveDiscountButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discount";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(453, 107);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(108, 23);
            this.LoadButton.TabIndex = 8;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(453, 78);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(108, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DiscountGridView
            // 
            this.DiscountGridView.AllowUserToAddRows = false;
            this.DiscountGridView.AllowUserToDeleteRows = false;
            this.DiscountGridView.AutoGenerateColumns = false;
            this.DiscountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiscountGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.priceDataGridViewTextBoxColumn,
            this.percentDataGridViewTextBoxColumn,
            this.certificateDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.DiscountGridView.DataSource = this.iDiscountBindingSource;
            this.DiscountGridView.Location = new System.Drawing.Point(11, 20);
            this.DiscountGridView.Name = "DiscountGridView";
            this.DiscountGridView.ReadOnly = true;
            this.DiscountGridView.Size = new System.Drawing.Size(436, 148);
            this.DiscountGridView.TabIndex = 6;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percentDataGridViewTextBoxColumn
            // 
            this.percentDataGridViewTextBoxColumn.DataPropertyName = "Percent";
            this.percentDataGridViewTextBoxColumn.HeaderText = "Percent";
            this.percentDataGridViewTextBoxColumn.Name = "percentDataGridViewTextBoxColumn";
            this.percentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // certificateDataGridViewTextBoxColumn
            // 
            this.certificateDataGridViewTextBoxColumn.DataPropertyName = "Certificate";
            this.certificateDataGridViewTextBoxColumn.HeaderText = "Certificate";
            this.certificateDataGridViewTextBoxColumn.Name = "certificateDataGridViewTextBoxColumn";
            this.certificateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.HeaderText = "Result";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDiscountBindingSource
            // 
            this.iDiscountBindingSource.DataSource = typeof(model.IDiscount);
            // 
            // CreateRandomDataButton
            // 
            this.CreateRandomDataButton.Location = new System.Drawing.Point(452, 136);
            this.CreateRandomDataButton.Name = "CreateRandomDataButton";
            this.CreateRandomDataButton.Size = new System.Drawing.Size(109, 23);
            this.CreateRandomDataButton.TabIndex = 4;
            this.CreateRandomDataButton.Text = "Create random data";
            this.CreateRandomDataButton.UseVisualStyleBackColor = true;
            this.CreateRandomDataButton.Click += new System.EventHandler(this.CreateRandomDataButton_Click);
            // 
            // AddDiscountButton
            // 
            this.AddDiscountButton.Location = new System.Drawing.Point(453, 20);
            this.AddDiscountButton.Name = "AddDiscountButton";
            this.AddDiscountButton.Size = new System.Drawing.Size(109, 23);
            this.AddDiscountButton.TabIndex = 1;
            this.AddDiscountButton.Text = "Add discount";
            this.AddDiscountButton.UseVisualStyleBackColor = true;
            this.AddDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // RemoveDiscountButton
            // 
            this.RemoveDiscountButton.Location = new System.Drawing.Point(453, 49);
            this.RemoveDiscountButton.Name = "RemoveDiscountButton";
            this.RemoveDiscountButton.Size = new System.Drawing.Size(109, 23);
            this.RemoveDiscountButton.TabIndex = 2;
            this.RemoveDiscountButton.Text = "Remove discount";
            this.RemoveDiscountButton.UseVisualStyleBackColor = true;
            this.RemoveDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 8;
            // 
            // FindStringButton
            // 
            this.FindStringButton.Location = new System.Drawing.Point(15, 75);
            this.FindStringButton.Name = "FindStringButton";
            this.FindStringButton.Size = new System.Drawing.Size(90, 23);
            this.FindStringButton.TabIndex = 5;
            this.FindStringButton.Text = "Find string";
            this.FindStringButton.UseVisualStyleBackColor = true;
            this.FindStringButton.Click += new System.EventHandler(this.FindStringButton_Click);
            // 
            // DiscountComboBox
            // 
            this.DiscountComboBox.FormattingEnabled = true;
            this.DiscountComboBox.Items.AddRange(new object[] {
            "Percent",
            "Certificate",
            "PriceProduct",
            "Result"});
            this.DiscountComboBox.Location = new System.Drawing.Point(15, 22);
            this.DiscountComboBox.Name = "DiscountComboBox";
            this.DiscountComboBox.Size = new System.Drawing.Size(90, 21);
            this.DiscountComboBox.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FindStringButton);
            this.groupBox2.Controls.Add(this.DiscountComboBox);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(593, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 107);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find element";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 197);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "DiscountForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiscountGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDiscountBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveDiscountButton;
        private System.Windows.Forms.Button AddDiscountButton;
        private System.Windows.Forms.Button CreateRandomDataButton;
        private System.Windows.Forms.Button FindStringButton;
        private System.Windows.Forms.DataGridView DiscountGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox DiscountComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn certificateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource iDiscountBindingSource;
    }
}

