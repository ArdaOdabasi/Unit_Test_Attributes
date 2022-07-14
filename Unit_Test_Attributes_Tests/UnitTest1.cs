using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unit_Test_Attributes_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Owner("Arda")] //Owner attribute, test methodunun sahibini belirler.
        [TestCategory("Tester")] //Testleri bir kategoriye göre gruplandırmak için kullanılır.
        [Priority(1)] //Testleri öncelik sırasına göre gruplandırmak için kullanılır.
        [TestProperty("Guncelleyen", "Caner")] //Testleri spesifik bir duruma göre gruplandırmak için kullanılır.
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Ersun")]
        [TestCategory("Tester")]
        [Priority(3)]
        [TestProperty("Guncelleyen", "Caner")]
        [TestProperty("Guncelleyen2", "Semih")]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Altay")]
        [TestCategory("Developer")]
        [TestCategory("Tester")]
        [TestCategory("Demo")]
        [Priority(2)]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Vedat")]
        [TestCategory("Developer")]
        [Priority(2)]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Arda")]
        [TestCategory("Developer")]
        [Priority(1)]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod, Ignore] //Ignore attribute, bir testi pas geçmek için kullanılır.
        public void TestMethod6()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod, Timeout(1000)] //Birim teste bir timeout süresi vermek için kullanılır.
        //Milisaniye cinsinden verilir eğer test methodu 1 saniye üzerinde çalışırsa timeout durumu gerçekleşir.
        public void TestMethod7()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod, Timeout(TestTimeout.Infinite)] //Timeout süresi sınırsızdır.
        public void TestMethod8()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod, Description("Testi yapılan gereksinime ait bilgilendirme burada yapılabilir.")] //Description attribute, açıklama girmek istediğimiz durumlarda kullanılır.
        public void TestMethod9()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
