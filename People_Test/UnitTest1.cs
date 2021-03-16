using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectTestExample;

namespace People_Test
{
    [TestClass]
    public class UnitTest1
    {
        People people = new People("Lagoust", "123456", "csgo299@yandex.ru", 79992647826);

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual("Lagoust", people.Login);
            
        }
        [TestMethod]
        public void GetEmailTest()
        {
            Assert.AreEqual("csgo299@yandex.ru", people.Email);
            //sdfsdfxcsadfsaassdfaf
        }

        [TestMethod]
        public void GetPhoneTest()
        {
            Assert.AreEqual(79992647826, people.Phone);

        }
        [TestMethod]
        public void GetPassTest()
        {
            Assert.AreEqual("123456", people.Pass);

        }
    }
}
