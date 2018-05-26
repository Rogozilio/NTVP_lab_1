using System;

namespace model
{

    public interface IDiscount
    {
        double Discount(Product product);
    }
}
