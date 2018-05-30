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
        public AddDiscountForm(BindingSource discountBindingSource)
        {
            InitializeComponent();
            ObjectControl.SetBindingSource(discountBindingSource);
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
