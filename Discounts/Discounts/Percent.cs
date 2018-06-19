using System;

namespace Discounts
{
    /// <summary>
    /// Класс скидки по процентам
    /// </summary>
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

        /// <summary>
        /// Свойство значения скидки
        /// </summary>
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
        private double _price { get; set; }

        /// <summary>
        /// Свойство цены товара
        /// </summary>
        public double PriceProduct
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        /// <summary>
        /// Цена товара с учетом скидки
        /// </summary>
        private double _result { get; set; }

        /// <summary>
        /// Свойство цены товара с учетом скидки
        /// </summary>
        public double ResultPrice
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
            }
        }
        /// <summary>
        /// Вычесление цены товара с учетом процентной скидки
        /// </summary>
        public double Discount(Product product)
        {
            PriceProduct = product.Price;
            ResultPrice = product.Price * (1 - (_percent / 100));
            return ResultPrice;
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
