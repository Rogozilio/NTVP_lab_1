using System;
using System.Windows.Forms;
using Discounts;

namespace NTVP2
{
    /// <summary>
    /// форма для добавления скидки
    /// </summary>
    public partial class AddDiscountForm : Form
    {
        DiscountControl discountControl = new DiscountControl();

        /// <summary>
        /// Конструктор формы для добавления
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();
            discountControl.Location = new System.Drawing.Point(5, 12);
            Controls.Add(discountControl);
            discountControl.Show();
        }
        /// <summary>
        /// Свойство для заполнения таблицы главной формы
        /// </summary>
        public IDiscount AddDiscount { get; set; }

        /// <summary>
        /// Свойство изменения скидки
        /// </summary>
        public IDiscount ModifyDiscount
        {
            set
            {
                AcceptAddDiscountButton.Text = "Modify";
                discountControl.ModifyDiscount = value;
                discountControl.Location = new System.Drawing.Point(5, 12);
                Controls.Add(discountControl);
                discountControl.Show();
            }    
         }

        /// <summary>
        /// Добавляет значение в таблицу главной формы
        /// </summary>
        private void AcceptAddDiscountButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddDiscount = discountControl.AddDiscount;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
