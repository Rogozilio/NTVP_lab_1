using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    /// <summary>
    /// Класс скидки по сертификату
    /// </summary>
    [Serializable]
    public class CertificateDiscount : IDiscount
    {
        /// <summary>
        /// Вернуть значение процентной скидки = 0 т.к. в данном классе учитывется только сертификат
        /// </summary>
        public double Percent => 0;

        /// <summary>
        /// Значение сертификата
        /// </summary>
        private double _certificate { get; set; }

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

        /// <summary>
        /// Вернуть сертификат
        /// </summary>
        public double Certificate => _certificate;

        /// <summary>
        /// Цена товара
        /// </summary>
        private double _price;

        /// <summary>
        /// Цена товара с учетом скидки
        /// </summary>
        private double _result;

        /// <summary>
        /// Вычесление цены товара с учетом сертификата
        /// </summary>
        public double Discount(Product product)
        {
            _price = product.Price;
            if (product.Price > _certificate)
            {
                _result = product.Price - _certificate;
                return _result;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Вернуть цену товара
        /// </summary>
        public double Price => _price;

        /// <summary>
        /// Вернуть цену товара с учетом скидки
        /// </summary>
        public double Result => _result;
    }
}
