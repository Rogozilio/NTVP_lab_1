using System;

namespace model
{
    /// <summary>
    /// Скидка
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Вычесление цены товара с учетом скидки
        /// </summary>
        double Discount(Product product);

        /// <summary>
        /// Цена товара
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Процентная скидка
        /// </summary>
        double Percent { get; }

        /// <summary>
        /// Скидка по сертификату
        /// </summary>
        double Certificate { get; }

        /// <summary>
        /// Цена товара с учетом скидки
        /// </summary>
        double Result { get; }
    }
}
