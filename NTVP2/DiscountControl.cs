using System;
using System.Windows.Forms;
using Discounts;

namespace NTVP2
{
    /// <summary>
    /// Окно для заполнения данных
    /// </summary>
    public partial class DiscountControl : UserControl
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public DiscountControl()
        {
            InitializeComponent();
            string[] discountComboBoxValue = { "Percent", "Certificate" };
            DiscountComboBox.Items.AddRange(discountComboBoxValue);
            ReadOnly = true;
        }

        /// <summary>
        /// Свойство добавления скидки
        /// </summary>
        public IDiscount AddDiscount
        {
            get
            {
                Product product = new Product();

                if (DiscountComboBox.Text == "Percent")
                {
                    product.Price = Convert.ToDouble(PriceTextBox.Text);
                    PercentDiscount percent = new PercentDiscount();
                    percent.Cost = Convert.ToDouble(DiscountTextBox.Text);
                    percent.Discount(product);
                    return percent;
                }
                else if (DiscountComboBox.Text == "Certificate")
                {
                    product.Price = Convert.ToDouble(PriceTextBox.Text);
                    CertificateDiscount certificate = new CertificateDiscount();
                    certificate.Size = Convert.ToDouble(DiscountTextBox.Text);
                    certificate.Discount(product);
                    return certificate;
                }
                else
                {
                    throw new Exception("Заполните пустые значения");
                }
            }
        }

        /// <summary>
        /// Свойство изменение скидки
        /// </summary>
        public IDiscount ModifyDiscount
        {
            set
            {
                if (value is PercentDiscount)
                {
                    var percent = value as PercentDiscount;
                    DiscountComboBox.SelectedIndex = 0;
                    DiscountTextBox.Text = percent.Cost.ToString();
                    PriceTextBox.Text = percent.Price.ToString();
                }
                if(value is CertificateDiscount)
                {
                    var certificate = value as CertificateDiscount;
                    DiscountComboBox.SelectedIndex = 1;
                    DiscountTextBox.Text = certificate.Size.ToString();
                    PriceTextBox.Text = certificate.Price.ToString();
                }
            }
        }

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
        /// Настрайвает пользовательский интерфейс в зависимости от выбора элемента
        /// </summary>
        public void DiscountComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
