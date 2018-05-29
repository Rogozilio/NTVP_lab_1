using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using model;

namespace UnitTest.model
{
    [TestFixture]
    class ProductUnitTest
    {
        [Test]
        [TestCase(0, TestName = "Тестирование Size при присваивании 0")]
        [TestCase(1, TestName = "Тестирование Size при присваивании 1")]
        [TestCase(99999, TestName = "Тестирование Size при присваивании 99999")]
        [TestCase(-1, TestName = "Тестирование Size при присваивании -1")]
        [TestCase(1.5, TestName = "Тестирование Size при присваивании 1,5")]
        public void ProductTest(double value)
        {
            Product product = new Product();
            product.Price = value;
        }
    }
}
