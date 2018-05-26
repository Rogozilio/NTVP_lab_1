using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Certificate : IDiscount
    {
        private double _certificate { get; set; }

        public double Value
        {
            get
            {
                return _certificate;
            }
            set
            {
                _certificate = value;

                if (_certificate < 0)
                {
                    throw new Exception("Аргумент не должен содержать отрицательное значение");
                }
            }
        }
        public double Discount(Product product)
        {
            if (product.Price > Value)
            {
                return product.Price - Value;
            }
            else
            {
                return 0;
            }
        }
    }
}
