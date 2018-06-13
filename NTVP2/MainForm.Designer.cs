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
            this.ModifyDiscountButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CreateRandomDataButton = new System.Windows.Forms.Button();
            this.AddDiscountButton = new System.Windows.Forms.Button();
            this.RemoveDiscountButton = new System.Windows.Forms.Button();
            this.DiscountGridView = new System.Windows.Forms.DataGridView();
            this.typeDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDiscountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.FindStringButton = new System.Windows.Forms.Button();
            this.TypeDiscountComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.FindLabel = new System.Windows.Forms.Label();
            this.TypeDiscountLabel = new System.Windows.Forms.Label();
            this.FindComboBox = new System.Windows.Forms.ComboBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDiscountBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModifyDiscountButton);
            this.groupBox1.Controls.Add(this.LoadButton);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.CreateRandomDataButton);
            this.groupBox1.Controls.Add(this.AddDiscountButton);
            this.groupBox1.Controls.Add(this.RemoveDiscountButton);
            this.groupBox1.Controls.Add(this.DiscountGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discount";
            // 
            // ModifyDiscountButton
            // 
            this.ModifyDiscountButton.Location = new System.Drawing.Point(103, 210);
            this.ModifyDiscountButton.Name = "ModifyDiscountButton";
            this.ModifyDiscountButton.Size = new System.Drawing.Size(90, 23);
            this.ModifyDiscountButton.TabIndex = 9;
            this.ModifyDiscountButton.Text = "Modify discount";
            this.ModifyDiscountButton.UseVisualStyleBackColor = true;
            this.ModifyDiscountButton.Click += new System.EventHandler(this.ModifyDiscountButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(126, 19);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(108, 23);
            this.LoadButton.TabIndex = 8;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 19);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(108, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CreateRandomDataButton
            // 
            this.CreateRandomDataButton.Location = new System.Drawing.Point(308, 210);
            this.CreateRandomDataButton.Name = "CreateRandomDataButton";
            this.CreateRandomDataButton.Size = new System.Drawing.Size(109, 23);
            this.CreateRandomDataButton.TabIndex = 4;
            this.CreateRandomDataButton.Text = "Create random data";
            this.CreateRandomDataButton.UseVisualStyleBackColor = true;
            this.CreateRandomDataButton.Click += new System.EventHandler(this.CreateRandomDataButton_Click);
            // 
            // AddDiscountButton
            // 
            this.AddDiscountButton.Location = new System.Drawing.Point(11, 210);
            this.AddDiscountButton.Name = "AddDiscountButton";
            this.AddDiscountButton.Size = new System.Drawing.Size(86, 23);
            this.AddDiscountButton.TabIndex = 1;
            this.AddDiscountButton.Text = "Add discount";
            this.AddDiscountButton.UseVisualStyleBackColor = true;
            this.AddDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // RemoveDiscountButton
            // 
            this.RemoveDiscountButton.Location = new System.Drawing.Point(199, 210);
            this.RemoveDiscountButton.Name = "RemoveDiscountButton";
            this.RemoveDiscountButton.Size = new System.Drawing.Size(103, 23);
            this.RemoveDiscountButton.TabIndex = 2;
            this.RemoveDiscountButton.Text = "Remove discount";
            this.RemoveDiscountButton.UseVisualStyleBackColor = true;
            this.RemoveDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // DiscountGridView
            // 
            this.DiscountGridView.AllowUserToAddRows = false;
            this.DiscountGridView.AllowUserToDeleteRows = false;
            this.DiscountGridView.AutoGenerateColumns = false;
            this.DiscountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiscountGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDiscountDataGridViewTextBoxColumn,
            this.valueDiscountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn});
            this.DiscountGridView.DataSource = this.iDiscountBindingSource;
            this.DiscountGridView.Location = new System.Drawing.Point(11, 49);
            this.DiscountGridView.Name = "DiscountGridView";
            this.DiscountGridView.ReadOnly = true;
            this.DiscountGridView.Size = new System.Drawing.Size(436, 155);
            this.DiscountGridView.TabIndex = 6;
            // 
            // typeDiscountDataGridViewTextBoxColumn
            // 
            this.typeDiscountDataGridViewTextBoxColumn.DataPropertyName = "TypeDiscount";
            this.typeDiscountDataGridViewTextBoxColumn.HeaderText = "TypeDiscount";
            this.typeDiscountDataGridViewTextBoxColumn.Name = "typeDiscountDataGridViewTextBoxColumn";
            this.typeDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDiscountDataGridViewTextBoxColumn
            // 
            this.valueDiscountDataGridViewTextBoxColumn.DataPropertyName = "ValueDiscount";
            this.valueDiscountDataGridViewTextBoxColumn.HeaderText = "ValueDiscount";
            this.valueDiscountDataGridViewTextBoxColumn.Name = "valueDiscountDataGridViewTextBoxColumn";
            this.valueDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.iDiscountBindingSource.DataSource = typeof(Discounts.IDiscount);
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(89, 76);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(90, 20);
            this.ValueTextBox.TabIndex = 8;
            // 
            // FindStringButton
            // 
            this.FindStringButton.Location = new System.Drawing.Point(89, 102);
            this.FindStringButton.Name = "FindStringButton";
            this.FindStringButton.Size = new System.Drawing.Size(90, 23);
            this.FindStringButton.TabIndex = 5;
            this.FindStringButton.Text = "Find cell";
            this.FindStringButton.UseVisualStyleBackColor = true;
            this.FindStringButton.Click += new System.EventHandler(this.FindStringButton_Click);
            // 
            // TypeDiscountComboBox
            // 
            this.TypeDiscountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeDiscountComboBox.FormattingEnabled = true;
            this.TypeDiscountComboBox.Location = new System.Drawing.Point(89, 21);
            this.TypeDiscountComboBox.Name = "TypeDiscountComboBox";
            this.TypeDiscountComboBox.Size = new System.Drawing.Size(90, 21);
            this.TypeDiscountComboBox.TabIndex = 9;
            this.TypeDiscountComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeDiscountComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ValueLabel);
            this.groupBox2.Controls.Add(this.FindLabel);
            this.groupBox2.Controls.Add(this.TypeDiscountLabel);
            this.groupBox2.Controls.Add(this.FindComboBox);
            this.groupBox2.Controls.Add(this.FindStringButton);
            this.groupBox2.Controls.Add(this.TypeDiscountComboBox);
            this.groupBox2.Controls.Add(this.ValueTextBox);
            this.groupBox2.Location = new System.Drawing.Point(472, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 136);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find element";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(49, 79);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(34, 13);
            this.ValueLabel.TabIndex = 13;
            this.ValueLabel.Text = "Value";
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(56, 52);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(27, 13);
            this.FindLabel.TabIndex = 12;
            this.FindLabel.Text = "Find";
            this.FindLabel.Visible = false;
            // 
            // TypeDiscountLabel
            // 
            this.TypeDiscountLabel.AutoSize = true;
            this.TypeDiscountLabel.Location = new System.Drawing.Point(9, 24);
            this.TypeDiscountLabel.Name = "TypeDiscountLabel";
            this.TypeDiscountLabel.Size = new System.Drawing.Size(74, 13);
            this.TypeDiscountLabel.TabIndex = 11;
            this.TypeDiscountLabel.Text = "Type discount";
            // 
            // FindComboBox
            // 
            this.FindComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FindComboBox.FormattingEnabled = true;
            this.FindComboBox.Location = new System.Drawing.Point(89, 49);
            this.FindComboBox.Name = "FindComboBox";
            this.FindComboBox.Size = new System.Drawing.Size(90, 21);
            this.FindComboBox.TabIndex = 10;
            this.FindComboBox.Visible = false;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "SerializeFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 258);
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
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.ComboBox TypeDiscountComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource iDiscountBindingSource;
        private System.Windows.Forms.Button ModifyDiscountButton;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.Label TypeDiscountLabel;
        private System.Windows.Forms.ComboBox FindComboBox;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

