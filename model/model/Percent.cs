using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    /// <summary>
    /// Класс скидки по процентам
    /// </summary>
    [Serializable]
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        ///  Вернуть значение сертификата = 0 т.к. в данном классе учитывется только процентная скидка
        /// </summary>
        public double Certificate => 0;

        /// <summary>
        /// Значение скидки
        /// </summary>
        private double _percent { get; set; }

        public double Cost
        {
            get
            {
                return _percent;
            }
            set
            {
                _percent = value;

                if (_percent < 1 || _percent > 90)
                {
                    throw new Exception("Размер скидки должен быть в диапазоне от 1% до 90%");
                }
            }
        }

        /// <summary>
        /// Вернуть проценты
        /// </summary>
        public double Percent => _percent;

        /// <summary>
        /// Цена товара
        /// </summary>
        private double _price;

        /// <summary>
        /// Цена товара с учетом скидки
        /// </summary>
        private double _result;

        /// <summary>
        /// Вычесление цены товара с учетом процентной скидки
        /// </summary>
        public double Discount(Product product)
        {
            _price = product.Price;
            _result = product.Price * (1 - (_percent / 100));
            return _result;
        }

        /// <summary>
        /// Вернуть цену товара
        /// </summary>
        public double Price => _price;   

        /// <summary>
        /// Вернуть цену товара с учетом скидки
        /// </summary>
        public double Result => _result;
    }
}
