using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Discounts;

namespace NTVP2
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список скидок
        /// </summary>
        private List<IDiscount> DiscountList;

        /// <summary>
        /// Конструктор главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            DiscountList = new List<IDiscount>();
            iDiscountBindingSource.DataSource = DiscountList;
            string[] typeDiscount = { "Percent", "Certificate" };
            TypeDiscountComboBox.Items.AddRange(typeDiscount);
            string[] find = { "ValueDiscount", "Price", "Result" };
            FindComboBox.Items.AddRange(find);
            #if !DEBUG
            CreateRandomDataButton.Visible = false;
            #endif
        }

        /// <summary>
        /// Заполнение таблицы случаными данными
        /// </summary>
        private void CreateRandomDataButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Product product = new Product();

            product.Price = random.Next(100, 1000);
            PercentDiscount percent = new PercentDiscount();
            percent.Cost = random.Next(1, 90);
            percent.Discount(product);
            iDiscountBindingSource.Add(percent);

            product.Price = random.Next(500, 1000);
            CertificateDiscount certificate = new CertificateDiscount();
            certificate.Size = random.Next(100, 500);
            certificate.Discount(product);
            iDiscountBindingSource.Add(certificate);
        }

        /// <summary>
        /// Создание формы для добавление данных в таблицу
        /// </summary>
        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            AddDiscountForm AddDiscountForm = new AddDiscountForm();
            AddDiscountForm.ShowDialog();
            if(AddDiscountForm.DiscountControl.DiscountComboBox.Text != "")
            {
                iDiscountBindingSource.Add(AddDiscountForm.AddLine);
            }
  
        }

        /// <summary>
        /// Создание формы для изменения данных в таблице
        /// </summary>
        private void ModifyDiscountButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddDiscountForm AddDiscountForm = new AddDiscountForm();
                AddDiscountForm.AcceptAddDiscountButton.Text = "Modify";
                AddDiscountForm.DiscountControl.DiscountComboBox.Text =
                    Convert.ToString(DiscountGridView[0, DiscountGridView.CurrentRow.Index].Value);
                AddDiscountForm.DiscountControl.DiscountTextBox.Text =
                    Convert.ToString(DiscountGridView[1, DiscountGridView.CurrentRow.Index].Value);
                AddDiscountForm.DiscountControl.PriceTextBox.Text =
                    Convert.ToString(DiscountGridView[2, DiscountGridView.CurrentRow.Index].Value);
                AddDiscountForm.ShowDialog();
                if (AddDiscountForm.DiscountControl.DiscountComboBox.Text != "")
                {
                    iDiscountBindingSource.Insert(DiscountGridView.CurrentRow.Index, AddDiscountForm.AddLine);
                    iDiscountBindingSource.RemoveAt(DiscountGridView.CurrentRow.Index);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Удаление данных из таблицы
        /// </summary>
        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            try
            {
                iDiscountBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Сериализация данных
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(SaveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, DiscountList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Десериализация данныз
        /// </summary>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                OpenFileDialog.ShowDialog();
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(OpenFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    DiscountList = (List<IDiscount>)formatter.Deserialize(fs);
                    iDiscountBindingSource.DataSource = DiscountList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Поиск данных по таблице
        /// </summary>
        private void FindStringButton_Click(object sender, EventArgs e)
        {
            switch (FindComboBox.Text)
            {
                case "ValueDiscount": FindElement(1); break;
                case "Price": FindElement(2); break;
                case "Result": FindElement(3); break;
                default: DiscountGridView.ClearSelection(); break;
            }
        }

        /// <summary>
        /// Выделение нужной ячейки в таблице 
        /// </summary>
        private void FindElement(int index)
        {
            try
            {
                DiscountGridView.ClearSelection();
                for (int i = 0; i < DiscountGridView.RowCount; i++)
                {
                    if (Convert.ToDouble(DiscountGridView[index, i].Value) == Convert.ToDouble(ValueTextBox.Text)
                        && Convert.ToString(DiscountGridView[0, i].Value) == TypeDiscountComboBox.Text)
                    {
                        DiscountGridView.Rows[i].Cells[index].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void TypeDiscountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TypeDiscountComboBox.Text != "")
            {
                FindLabel.Visible = true;
                FindComboBox.Visible = true;
            }
        }
    }
}
