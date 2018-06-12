using System;
using System.Windows.Forms;
using Discounts;

namespace NTVP2
{
    public partial class DiscountControl : UserControl
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public DiscountControl()
        {
            InitializeComponent();
            ReadOnly = true;
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
