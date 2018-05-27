using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;

namespace NTVP2
{
    public partial class AddDiscountForm : Form
    {
        public AddDiscountForm(MainForm main)
        {
            InitializeComponent();
            this.DiscountBindingSource = main.iDiscountBindingSource;
        }

        /// <summary>
        /// Добавляет значение в таблицу главной формы
        /// </summary>
        private void AcceptAddDiscountButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            try
            {
                if (Convert.ToDouble(PriceTextBox.Text) < 0)
                {
                    throw new Exception("Аргумент не должен содержать отрицательное значение");
                }
                if (PercentRadioButton.Checked == true && Convert.ToDouble(DiscountTextBox.Text) < 1 || Convert.ToDouble(DiscountTextBox.Text) > 90)
                {
                    throw new Exception("Скидка должна быть в диапазоне от 1% до 90%");
                }
            }
            catch (Exception ex)
            {
                ExeptionForm exceptionForm = new ExeptionForm(ex.Message);
                exceptionForm.Show();
                return;
            }
            if (PercentRadioButton.Checked == true)
            {
                product.Price = Convert.ToDouble(PriceTextBox.Text);
                PercentDiscount percent = new PercentDiscount();
                percent.Cost = Convert.ToDouble(DiscountTextBox.Text);
                percent.Discount(product);
                DiscountBindingSource.Add(percent);

                
            }
            else
            {
                product.Price = Convert.ToDouble(PriceTextBox.Text);
                CertificateDiscount certificate = new CertificateDiscount();
                certificate.Size = Convert.ToDouble(DiscountTextBox.Text);
                certificate.Discount(product);
                DiscountBindingSource.Add(certificate);
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

        /// <summary>
        /// Выбор скидки по процентам
        /// </summary>
        private void PercentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PercentRadioButton.Checked == true)
            {
                DiscountLabel.Text = "Percent";
                CertificateRadioButton.Checked = false;
            }
        }

        /// <summary>
        /// Выбор скидки по сертификату
        /// </summary>
        private void CertificateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CertificateRadioButton.Checked == true)
            {
                DiscountLabel.Text = "Certificate";
                PercentRadioButton.Checked = false;
            }
        }
    }
}
