using System;

namespace model
{
    public interface IDiscount
    {
        //Вычесление цены товара с учетом скидки
        double Discount(Product product);
    }
}
