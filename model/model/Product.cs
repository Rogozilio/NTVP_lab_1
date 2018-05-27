using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    //Продукт
    public class Product
    {
        private double _price { get; set; }//Цена продукта

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
