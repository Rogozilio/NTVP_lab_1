using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    //Класс скидки по процентам
    public class PercentDiscount : IDiscount
    {
        private double _percent { get; set; }//Значение скидки

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

        //Вычесление цены товара с учетом процентной скидки
        public double Discount(Product product)
        {
            return product.Price * (1 - (_percent / 100));
        }
    }
}
