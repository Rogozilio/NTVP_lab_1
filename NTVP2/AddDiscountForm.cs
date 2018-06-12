using System;
using System.Windows.Forms;
using Discounts;

namespace NTVP2
{
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Свойство для заполнения таблицы главной формы
        /// </summary>
        public IDiscount AddLine { get; set; }

        /// <summary>
        /// Конструктор формы для добавления
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();
            string[] discountComboBoxValue = { "Percent", "Certificate" };
            DiscountControl.DiscountComboBox.Items.AddRange(discountComboBoxValue);
        }

        /// <summary>
        /// Добавляет значение в таблицу главной формы
        /// </summary>
        private void AcceptAddDiscountButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            try
            {
                if (DiscountControl.DiscountComboBox.Text == "Percent")
                {
                    product.Price = Convert.ToDouble(DiscountControl.PriceTextBox.Text);
                    PercentDiscount percent = new PercentDiscount();
                    percent.Cost = Convert.ToDouble(DiscountControl.DiscountTextBox.Text);
                    percent.Discount(product);
                    AddLine = percent;
                }
                else if (DiscountControl.DiscountComboBox.Text == "Certificate")
                {
                    product.Price = Convert.ToDouble(DiscountControl.PriceTextBox.Text);
                    CertificateDiscount certificate = new CertificateDiscount();
                    certificate.Size = Convert.ToDouble(DiscountControl.DiscountTextBox.Text);
                    certificate.Discount(product);
                    AddLine = certificate;
                }
                else
                {
                    throw new Exception("Заполните пустые значения");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Close();
        }

        /// <summary>
        /// Закрытие данной формы
        /// </summary>
        private void CancelAddDiscountButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
