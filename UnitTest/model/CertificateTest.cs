using NUnit.Framework;
using model;
using System;

namespace UnitTest.model
{
    [TestFixture]
    public class CertificateUnitTest
    {
        [Test]
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

        [Test]
        [TestCase(TestName = "Тестирование подсчета скидки по сертификату")]
        public void DiscountCertificateTest()
        {
            Product product = new Product();
            product.Price = 200;
            CertificateDiscount certificate = new CertificateDiscount();
            certificate.Size = 10;
            IDiscount discount = certificate;

            Assert.AreEqual(discount.Discount(product), 190);
        }
    }
}
