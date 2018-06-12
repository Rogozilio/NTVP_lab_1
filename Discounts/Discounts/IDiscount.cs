namespace Discounts
{
        /// <summary>
        /// Скидка
        /// </summary>
        public interface IDiscount
        {
            /// <summary>
            /// Тип скидки
            /// </summary>
            string TypeDiscount { get; }

            /// <summary>
            /// Значение скидки
            /// </summary>
            double ValueDiscount { get; }

            /// <summary>
            /// Цена товара
            /// </summary>
            double Price { get; }

            /// <summary>
            /// Цена товара с учетом скидки
            /// </summary>
            double Result { get; }

            /// <summary>
            /// Вычесление цены товара с учетом скидки
            /// </summary>
            double Discount(Product product);
        }
}
