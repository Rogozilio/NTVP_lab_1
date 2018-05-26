using System;
using model;

namespace NTVP
{
    class main
    {
        static void Main(string[] args)
        {
            try
            {
                IDiscount discount;
                Product product = new Product();
                Percent percent = new Percent();
                Certificate certificate = new Certificate();

                Console.WriteLine("Расчет скидки по процентам");
                Console.Write("Введите скидку: ");
                percent.Value = Convert.ToDouble(System.Console.ReadLine());
                Console.Write("Введите цену товара: ");
                product.Price = Convert.ToDouble(System.Console.ReadLine());
                Console.Write("Цена товара с учетом скидки: ");
                discount = percent;
                Console.WriteLine(discount.Discount(product));
                Console.WriteLine();

                Console.WriteLine("Расчет скидки по сертификату");
                Console.Write("Введите скидку сертификата: ");
                certificate.Value = Convert.ToDouble(System.Console.ReadLine());
                Console.Write("Введите цену товара: ");
                product.Price = Convert.ToDouble(System.Console.ReadLine());
                Console.Write("Цена товара с учетом скидки: ");
                discount = certificate;
                Console.WriteLine(discount.Discount(product));
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }
    }
}
