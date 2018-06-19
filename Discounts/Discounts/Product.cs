using System;
using System.Runtime.Serialization;

namespace Discounts
{
    /// <summary>
    /// Продукт
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Цена продукта
        /// </summary>
        private double _price { get; set; }

        /// <summary>
        /// Свойство цены продукта
        /// </summary>
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;

                if (_price < 0)
                {
                    throw new Exception("Аргумент не должен содержать отрицательное значение");
                }
            }
        }
    }
}
