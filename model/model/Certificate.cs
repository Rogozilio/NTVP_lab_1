using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    //Класс скидки по сертификату
    public class CertificateDiscount : IDiscount
    {
        private double _certificate { get; set; }//Значение сертификата

        public double Size
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

        //Вычесление цены товара с учетом сертификата
        public double Discount(Product product)
        {
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
