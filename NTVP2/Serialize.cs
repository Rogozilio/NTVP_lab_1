using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;
using Discounts;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NTVP2
{
    /// <summary>
    /// Сериализация
    /// </summary>
    class Serialize
    {
        /// <summary>
        /// Путь для сохранения или згрузки файла
        /// </summary>
        static private string _filePath { get; set; }

        /// <summary>
        /// Содержание файла
        /// </summary>
        static private string _fileSerialize { get; set; }

        /// <summary>
        /// Сохранение файла
        /// </summary>
        static public void SaveData(object DiscountList)
        {
            if (_filePath == null)
            {
                SaveAsData(DiscountList);
            }
            else
            {
                _fileSerialize  = JsonConvert.SerializeObject(DiscountList, new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                });


                File.WriteAllText(_filePath, _fileSerialize);

                MessageBox.Show("Сохранено успешно");
            }
        }

        /// <summary>
        /// Сохранение файла с выбором пути
        /// </summary>
        static public void SaveAsData(object DiscountList)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Сохранение отменено");
                return;
            }

            if(result == DialogResult.OK)
            {
                _filePath = saveFileDialog.FileName;

                _fileSerialize = JsonConvert.SerializeObject(DiscountList, new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                });

                File.WriteAllText(_filePath, _fileSerialize);

                MessageBox.Show("Сохранено успешно");
            }
        }

        /// <summary>
        /// Открытие файла
        /// </summary>
        static public List<IDiscount> OpenData(List<IDiscount> DiscountList)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();

            _filePath = openFileDialog.FileName;
            _fileSerialize = File.ReadAllText(_filePath);

            if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Открытие файла отменено");
                return DiscountList;
            }

            if (result == DialogResult.OK)
            {
                DiscountList = JsonConvert.DeserializeObject<List<IDiscount>>(_fileSerialize, new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Auto
                });
                return DiscountList;
            }
            return DiscountList;
        }
    }
}