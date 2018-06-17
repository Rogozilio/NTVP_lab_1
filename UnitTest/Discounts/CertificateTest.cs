using NUnit.Framework;
using Discounts;

namespace UnitTest.model
{
    [TestFixture]
    public class CertificateUnitTest
    {
        [TestCase(0, TestName = "Тестирование Size при присваивании 0")]
        [TestCase(1, TestName = "Тестирование Size при присваивании 1")]
        [TestCase(99999, TestName = "Тестирование Size при присваивании 99999")]
        [TestCase(-1, TestName = "Тестирование Size при присваивании -1")]
        [TestCase(1.5, TestName = "Тестирование Size при присваивании 1,5")]
        public void CertificateTest(double value)
        {
            CertificateDiscount certificate = new CertificateDiscount();
            certificate.Size = value;
        }

        [TestCase(TestName = "Тестирование подсчета скидки по сертификату")]
        public void DiscountCertificateTest()
        {
            Product product = new Product();
            product.Price = 200;
            CertificateDiscount certificate = new CertificateDiscount();
            certificate.Size = 10;
            IDiscount discount = certificate;

            double excepted = discount.Discount(product);
            double actual = 190;
            Assert.AreEqual(excepted, actual);
        }
    }
}
