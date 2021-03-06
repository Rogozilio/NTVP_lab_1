﻿using System;
using System.Runtime.Serialization;

namespace Discounts
{
    /// <summary>
    /// Класс скидки по сертификату
    /// </summary>
    public class CertificateDiscount : IDiscount
    { 
        /// <summary>
        /// Тип скидки
        /// </summary>
        public string TypeDiscount => "Certificate";

        /// <summary>
        /// Значение сертификата
        /// </summary>
        private double _certificate { get; set; }

        /// <summary>
        /// Свойство значения сертификата
        /// </summary>
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
        public double ValueDiscount => _certificate;

        /// <summary>
        /// Цена товара
        /// </summary>
        private double _price { get; set; }

        /// <summary>
        /// Свойство цены товара
        /// </summary>
        public double PriceProduct
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        /// <summary>
        /// Цена товара с учетом скидки
        /// </summary>
        private double _result { get; set; }

        /// <summary>
        /// Свойство цены товара с учетом скидки
        /// </summary>
        public double ResultPrice
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
            }
        }

        /// <summary>
        /// Вычесление цены товара с учетом сертификата
        /// </summary>
        public double Discount(Product product)
        {
            PriceProduct = product.Price;
            if (PriceProduct > _certificate)
            {
                ResultPrice = PriceProduct - _certificate;
                return ResultPrice;
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
