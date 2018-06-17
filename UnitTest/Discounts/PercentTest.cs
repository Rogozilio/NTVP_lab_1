using NUnit.Framework;
using Discounts;

namespace UnitTest.model
{
    [TestFixture]
    class PercentUnitTest
    {
        [TestCase(0, TestName = "Тестирование Size при присваивании 0")]
        [TestCase(1, TestName = "Тестирование Size при присваивании 1")]
        [TestCase(90, TestName = "Тестирование Size при присваивании 90")]
        [TestCase(91, TestName = "Тестирование Size при присваивании 91")]
        [TestCase(1.5, TestName = "Тестирование Size при присваивании 1,5")]
        public void PercentTest(double value)
        {
            PercentDiscount percent = new PercentDiscount();
            percent.Cost = value;
        }

        [TestCase(TestName = "Тестирование подсчета скидки по процентам")]
        public void DiscountPercenttest()
        {
            Product product = new Product();
            product.Price = 200;
            PercentDiscount certificate = new PercentDiscount();
            certificate.Cost = 10;
            IDiscount discount = certificate;

            double excepted = discount.Discount(product);
            double actual = 180;
            Assert.AreEqual(excepted, actual);
        }
    }
}
