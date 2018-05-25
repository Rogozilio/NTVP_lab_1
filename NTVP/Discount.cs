using System;

namespace Discount
{
    public interface IDiscount
    {
        double Discount(double percent, double priceProduct);
    }
    public class Product
    {
        public double Price { get; set; }
    }
    public class Percent : IDiscount
    {
        private double _percent;
        Product product = new Product();
        public double Discount(double percent, double priceProduct)
        {
            _percent = percent;
            product.Price = priceProduct;
            try
            {
                if (product.Price < 0)
                {
                    throw new Exception("Аргумент не должен содержать отрицательное значение");
                }
                else if(_percent < 1 || _percent > 90)
                {
                    throw new Exception("Размер скидки должен быть в диапазоне от 1% до 90%");
                }
                else
                {
                    return product.Price * (1 - (_percent / 100));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
    public class Certificate : IDiscount
    { 
        private double _certificate;
        Product product = new Product();
        public double Discount(double certificate, double priceProduct)
        {
            _certificate = certificate;
            product.Price = priceProduct;

            try
            {
                if (_certificate < 0 || product.Price < 0)
                {
                    throw new Exception("Аргумент не должен содержать отрицательное значение");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
                return -1;
            }

            if (product.Price > _certificate)
            {
                return product.Price - _certificate;
            }
            else
            {
                return 0;
            }
        }
    }
}
