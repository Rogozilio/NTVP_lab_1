using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;

namespace NTVP2
{
    public partial class ObjectControl : UserControl
    {
        public ObjectControl()
        {
            InitializeComponent();
            ReadOnly = true;
        }

        /// <summary>
        /// Источник данных
        /// </summary>
        static private BindingSource _discountBindingSource;

        /// <summary>
        /// Идентифицирует поля только для чтения
        /// </summary>
        private bool _readOnly { get; set; }

        /// <summary>
        /// Свойство _readOnly
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return _readOnly;
            }

            set
            {
                _readOnly = value;
                if(_readOnly == true)
                {
                    DiscountTextBox.ReadOnly = true;
                    PriceTextBox.ReadOnly = true;
                }
                else
                {
                    DiscountTextBox.ReadOnly = false;
                    PriceTextBox.ReadOnly = false;
                }   
            }
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
                if (DiscountComboBox.Text == "Percent" && Convert.ToDouble(DiscountTextBox.Text) < 1 || Convert.ToDouble(DiscountTextBox.Text) > 90)
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

            if (DiscountComboBox.Text == "Percent")
            {
                product.Price = Convert.ToDouble(PriceTextBox.Text);
                PercentDiscount percent = new PercentDiscount();
                percent.Cost = Convert.ToDouble(DiscountTextBox.Text);
                percent.Discount(product);
                _discountBindingSource.Add(percent);
            }
            else if (DiscountComboBox.Text == "Certificate")
            {
                product.Price = Convert.ToDouble(PriceTextBox.Text);
                CertificateDiscount certificate = new CertificateDiscount();
                certificate.Size = Convert.ToDouble(DiscountTextBox.Text);
                certificate.Discount(product);
                _discountBindingSource.Add(certificate);
            }
        }

        /// <summary>
        /// Установить источник данных
        /// </summary>
        static public void SetBindingSource(BindingSource discountBindingSource)
        {
            _discountBindingSource = discountBindingSource;
        }

        /// <summary>
        /// Настрайвает пользовательский интерфейс в зависимости от выбора элемента
        /// </summary>
        private void DiscountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DiscountComboBox.Text == "Percent")
            {
                DiscountLabel.Text = "Percent";
                ReadOnly = false;
                DiscountTextBox.Clear();
                PriceTextBox.Clear();
            }
            else if (DiscountComboBox.Text == "Certificate")
            {
                DiscountLabel.Text = "Certificate";
                ReadOnly = false;
                DiscountTextBox.Clear();
                PriceTextBox.Clear();
            }
        }
    }
}
