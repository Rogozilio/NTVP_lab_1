using System;
using Discount;

namespace NTVP
{
    class Program
    {
        static void Main(string[] args)
        {
            double percent;
            double certificate;
            double priceProduct;
            IDiscount discount;

            Console.WriteLine("Расчет скидки по процентам");
            Console.Write("Введите скидку: ");
            percent = Convert.ToDouble(System.Console.ReadLine());
            Console.Write("Введите цену товара: ");
            priceProduct = Convert.ToDouble(System.Console.ReadLine());
            Console.Write("Цена товара с учетом скидки: ");
            discount = new Percent();
            Console.WriteLine(discount.Discount(percent, priceProduct));
            Console.WriteLine();

            Console.WriteLine("Расчет скидки по сертификату");
            Console.Write("Введите скидку сертификата: ");
            certificate = Convert.ToDouble(System.Console.ReadLine());
            Console.Write("Введите цену товара: ");
            priceProduct = Convert.ToDouble(System.Console.ReadLine());
            Console.Write("Цена товара с учетом скидки: ");
            discount = new Certificate();
            Console.WriteLine(discount.Discount(certificate, priceProduct));
            Console.Read();
        }
    }
}
