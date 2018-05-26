using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Percent : IDiscount
    {
        private double _percent { get; set; }

        public double Value
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

        public double Discount(Product product)
        {
            return product.Price * (1 - (_percent / 100));
        }
    }
}
