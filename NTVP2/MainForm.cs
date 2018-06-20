using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Discounts;
using StripMenu;

namespace NTVP2
{
    /// <summary>
    /// Главная форма
    /// </summary>
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
        /// Возвращает случайное число в диапазоне
        /// </summary>
        public int Random(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }

        /// <summary>
        /// Заполнение таблицы случаными данными
        /// </summary>
        private void CreateRandomDataButton_Click(object sender, EventArgs e)
        {
            //TODO: генерация в отдельной сущности - говорили же об этом
            //Исправлено
            Product product = new Product();

            product.Price = Random(100, 1000);
            PercentDiscount percent = new PercentDiscount();
            percent.Cost = Random(1, 90);
            percent.Discount(product);
            iDiscountBindingSource.Add(percent);

            product.Price = Random(500, 1000);
            CertificateDiscount certificate = new CertificateDiscount();
            certificate.Size = Random(100, 500);
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
            if (AddDiscountForm.AddDiscount != null)
            {
               iDiscountBindingSource.Add(AddDiscountForm.AddDiscount);
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
                AddDiscountForm.ModifyDiscount = (IDiscount)iDiscountBindingSource.Current;
                AddDiscountForm.ShowDialog();
                if (AddDiscountForm.AddDiscount != null)
                {
                    iDiscountBindingSource.Insert(DiscountGridView.CurrentRow.Index, AddDiscountForm.AddDiscount);
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
            //TODO: Похоже на какой-то костыль с флагом. Заменить на проверку без флага через DiscountGridView.SelectedRows != null или типа того
            //исправлено
            if (DiscountGridView.SelectedRows.Count != 0)
            {
                for (int i = DiscountGridView.Rows.Count - 1; i >= 0; i--)
                {
                    if (DiscountGridView.Rows[i].Selected)
                    {
                        iDiscountBindingSource.RemoveAt(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Для удаления нужно выделить строку");
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
            DiscountGridView.ClearSelection();
            for (int i = 0; i < DiscountGridView.RowCount; i++)
            {
                //TODO: такие длинные условия плохо читаемы.
                // Вынести каждое парсируемое значение в отдельную локальную переменную.
                // Под условием использовать локальные переменные.
                // А вместо try-catch и Convert.ToDouble() использовать Double.TryParse() (почитай про метод - полезный)
                // Исправлено
                string tableValue = DiscountGridView[index, i].Value.ToString();
                string textBoxValue = ValueTextBox.Text;
                string typeDiscount = DiscountGridView[0, i].Value.ToString();
                double digitalTableValue;
                double digitalTextBoxValue;
                if (double.TryParse(tableValue, out digitalTableValue)
                    && double.TryParse(textBoxValue, out digitalTextBoxValue)
                    && digitalTableValue == digitalTextBoxValue
                    && typeDiscount == TypeDiscountComboBox.Text)
                {
                    DiscountGridView.Rows[i].Cells[index].Selected = true;
                }
            }
        }

        /// <summary>
        /// Событие при пустом TypeDiscountComboBox
        /// </summary>
        private void TypeDiscountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TypeDiscountComboBox.Text != "")
            {
                FindLabel.Visible = true;
                FindComboBox.Visible = true;
            }
        }

        /// <summary>
        /// Свойство хранящее путь к файлу
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Открытие файла
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = OpenFileDialog.FileName;
                    DiscountList = Data.OpenToFile(FilePath);
                    iDiscountBindingSource.DataSource = DiscountList;
                }
                else
                {
                    MessageBox.Show("Открытие файла отменено");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Сохранение файла
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (FilePath != null)
                {
                        Data.SaveToFile(DiscountList, FilePath);
                        MessageBox.Show("Сохранено успешно");
                }
                else
                {
                    if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FilePath = SaveFileDialog.FileName;
                        Data.SaveToFile(DiscountList, FilePath);
                        MessageBox.Show("Сохранено успешно");
                    }
                    else
                    {
                        MessageBox.Show("Сохранение отменено");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Сохранение файла с выбором пути файла
        /// </summary>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = SaveFileDialog.FileName;
                    Data.SaveToFile(DiscountList, FilePath);
                    MessageBox.Show("Сохранено успешно");
                }
                else
                {
                    MessageBox.Show("Сохранение отменено");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
