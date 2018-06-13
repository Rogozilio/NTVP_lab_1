using System;
using System.Runtime.Serialization;

namespace Discounts
{
    /// <summary>
    /// Класс скидки по процентам
    /// </summary>

    [Serializable]
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Тип скидки
        /// </summary>
        public string TypeDiscount => "Percent";

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
        public double ValueDiscount => _percent;

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
