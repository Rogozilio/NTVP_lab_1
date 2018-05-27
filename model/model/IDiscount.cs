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

        double Price { get; }

        double Percent { get; }

        double Certificate { get; }

        double Result { get; }
    }
}
