using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTVP2
{
    /// </summary>
    /// Форма для вывода исключений на экран
    /// </summary>
    public partial class ExeptionForm : Form
    {
        public ExeptionForm(string value)
        {
            InitializeComponent();
            ExeptionLabel.Text = value;
            this.Size = new Size(ExeptionLabel.Size.Width + 40, 135);
            CloseExeptionButton.Location = new Point((ExeptionLabel.Size.Width / 2) - 30, 61);
        }

        /// <summary>
        /// Закрытие данной формы
        /// </summary>
        private void CloseExeptionButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
