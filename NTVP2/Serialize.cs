using System.Runtime.Serialization.Formatters.Binary; //TODO: неиспользуемы юзинги надо удалять. В решарпере даже есть специальная функция для этого
using System.IO;
using System.Windows.Forms;
using Discounts;
using System.Collections.Generic;
using Newtonsoft.Json;

//TODO: неудачное имя для пространства имён. В итоге, по названию непонятно, какие классы он содержит
namespace NTVP2
{
    //TODO: название класса должно быть от существительного, а не от глагола
    /// <summary>
    /// Сериализация
    /// </summary>
    class Serialize
    {
        //TODO: путь файла существует только внутри контекста конкретного вызова метода - значит, это должна быть локальная переменная, а не поле
        /// <summary>
        /// Путь для сохранения или згрузки файла
        /// </summary>
        static private string _filePath { get; set; }

        //TODO: имя файла существует только внутри контекста конкретного вызова метода - значит, это должна быть локальная переменная, а не поле
        /// <summary>
        /// Содержание файла
        /// </summary>
        static private string _fileSerialize { get; set; }

        //TODO: по RSDN сначала модификатор доступа, потом static и другие модификаторы
        //TODO: Название Save не говорит, каким образом будет сохранена БД - в файл, а может в удаленную БД. Название SaveToFile() более понятное для разработчика, который будет использовать этот класс.
        //TODO: Почему на вход приходит object? Сериализуешь любые объекты, а десериализуешь только списки скидок - неправильно.
        // Вместо object должен быть List<IDiscount> - так ты делаешь класс типобезопасным, и защищаешь от неправильного использования.
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
                //TODO: никаких месседжбоксов в бизнес-логике. Месседж-бокс показывать только в формах (даже контролам нежелательно показывать месседжбоксы).
                MessageBox.Show("Сохранено успешно");
            }
        }

        /// <summary>
        /// Сохранение файла с выбором пути
        /// </summary>
        static public void SaveAsData(object DiscountList)
        {
            //TODO: смешал бизнес-логику и интерфейс. Сериализация не должна использовать формы
            // в противном случае ты просто не можешь написать юнит-тесты на сериализацию - только ручное тестирование
            // Или не можешь сериализовать данные без пользователя
            // - пусть на вход метода сразу приходит имя файла, куда надо сохранить. А все SaveFileDialog останутся в mainForm
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
                //TODO: дублирование логики с SaveData - с теми же самыми замечаниями
                _fileSerialize = JsonConvert.SerializeObject(DiscountList, new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                });

                File.WriteAllText(_filePath, _fileSerialize);

                MessageBox.Show("Сохранено успешно");
            }
        }

        //TODO: название - аналогично замечанию по SaveData
        //TODO: Зачем этому методу на вход отдается список скидок?
        //TODO: По логике самого метода - метод должен САМ создавать и возвращать список, но ничего не принимать - кроме имени файла из которого надо считать данные
        /// <summary>
        /// Открытие файла
        /// </summary>
        static public List<IDiscount> OpenData(List<IDiscount> DiscountList)
        {
            //TODO: см. замечания выше - никаких форм внутри бизнес-логики
            OpenFileDialog openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();

            _filePath = openFileDialog.FileName;
            _fileSerialize = File.ReadAllText(_filePath);

            if (result == DialogResult.Cancel)
            {
                //TODO: см. выше
                MessageBox.Show("Открытие файла отменено");
                return DiscountList;
            }

            if (result == DialogResult.OK)
            {
                DiscountList = JsonConvert.DeserializeObject<List<IDiscount>>(_fileSerialize, new JsonSerializerSettings
                {
                    //TODO: при сериализации и десериализации должны быть одинаковые настройки
                    TypeNameHandling = TypeNameHandling.Auto
                });
                return DiscountList;
            }
            return DiscountList;
        }
    }
}