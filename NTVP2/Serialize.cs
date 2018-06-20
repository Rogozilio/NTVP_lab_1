using System.IO;
using Discounts;
using System.Collections.Generic;
using Newtonsoft.Json;

//TODO: неудачное имя для пространства имён. В итоге, по названию непонятно, какие классы он содержит
//Исправлено
namespace StripMenu
{
    //TODO: название класса должно быть от существительного, а не от глагола
    //Исправлено
    /// <summary>
    /// Сериализация
    /// </summary>
    class Data
    {
        //TODO: по RSDN сначала модификатор доступа, потом static и другие модификаторы
        //TODO: Название Save не говорит, каким образом будет сохранена БД - в файл, а может в удаленную БД. Название SaveToFile() более понятное для разработчика, который будет использовать этот класс.
        //TODO: Почему на вход приходит object? Сериализуешь любые объекты, а десериализуешь только списки скидок - неправильно.
        // Вместо object должен быть List<IDiscount> - так ты делаешь класс типобезопасным, и защищаешь от неправильного использования.
        // Исправлено
        /// <summary>
        /// Сохранение файла
        /// </summary>
        public static void SaveToFile(List<IDiscount> DiscountList, string filePath)
        {
                string _fileSerialize  = JsonConvert.SerializeObject(DiscountList, new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                });
                File.WriteAllText(filePath, _fileSerialize);
        }

        //TODO: название - аналогично замечанию по SaveData
        //TODO: Зачем этому методу на вход отдается список скидок?
        //TODO: По логике самого метода - метод должен САМ создавать и возвращать список, но ничего не принимать - кроме имени файла из которого надо считать данные
        //Исправлено
        /// <summary>
        /// Открытие файла
        /// </summary>
        public static List<IDiscount> OpenToFile(string filePath)
        {
            string fileSerialize = File.ReadAllText(filePath);

            List<IDiscount> DiscountList = JsonConvert.DeserializeObject<List<IDiscount>>(fileSerialize, new JsonSerializerSettings
            {
                //TODO: при сериализации и десериализации должны быть одинаковые настройки
                //Исправлено
                TypeNameHandling = TypeNameHandling.All
            });
            return DiscountList;
        }
    }
}