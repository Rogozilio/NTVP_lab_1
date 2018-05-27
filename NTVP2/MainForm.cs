using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using model;

namespace NTVP2
{
    public partial class MainForm : Form
    {

        private List<IDiscount> DiscountList;
        public MainForm()
        {
            InitializeComponent();
            DiscountList = new List<IDiscount>();
            iDiscountBindingSource.DataSource = DiscountList;
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
            AddDiscountForm AddDiscountForm = new AddDiscountForm(this);
            AddDiscountForm.Show();
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
                ExeptionForm exceptionForm = new ExeptionForm(ex.Message);
                exceptionForm.Show();
                return;
            }
        }

        /// <summary>
        /// Сериализация данных
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Discount.rog", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, DiscountList);
            }
        }

        /// <summary>
        /// Десериализация данныз
        /// </summary>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Discount.rog", FileMode.OpenOrCreate))
            {
                DiscountList = (List<IDiscount>)formatter.Deserialize(fs);
                iDiscountBindingSource.DataSource = DiscountList;
            }
        }

        /// <summary>
        /// Поиск данных по таблице
        /// </summary>
        private void FindStringButton_Click(object sender, EventArgs e)
        {
            switch (DiscountComboBox.Text)
            {
                case "Percent": FindElement(0); break;
                case "Certificate": FindElement(1); break;
                case "PriceProduct": FindElement(2); break;
                case "Result": FindElement(3); break;
                default: break;
            }
        }

        /// <summary>
        /// Выделение нужной ячейки в таблице 
        /// </summary>
        private void FindElement(int index)
        {
            for(int i = 0; i < DiscountGridView.RowCount; i++)
                {
                if (Convert.ToDouble(DiscountGridView[index, i].Value) == Convert.ToDouble(textBox1.Text))
                {
                    DiscountGridView.Rows[i].Cells[index].Selected = true;
                }
            }
        }
    }
}
