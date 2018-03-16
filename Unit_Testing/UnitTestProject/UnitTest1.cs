using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            var p = new Unit_Testing.Program();

            Assert.AreEqual(680131659347, p.Hash_function("leepadg"));

        }
        [TestMethod]
        public void Test2()
        {
            var p = new Unit_Testing.Program();

            Assert.AreNotEqual(123, p.Hash_function("leepadg")); 

        }
        
        [TestMethod]
        public void Test3()
        {
            var p = new Unit_Testing.Program();

            Assert.ThrowsException<System.NullReferenceException>(()=>p.Hash_function(null)); 

        }
        [TestMethod]
        public void Test4()
        {
            var p = new Unit_Testing.Program();

            Assert.AreEqual("hola-como-estas", p.slugify("Hola como estas"));

        }
        [TestMethod]
        public void Test5()
        {
            var p = new Unit_Testing.Program();

            Assert.AreNotEqual("Hola como-estas", p.slugify("Hola como te va"));

        }

        [TestMethod]
        public void Test6()
        {
            var p = new Unit_Testing.Program();

            Assert.ThrowsException<System.NullReferenceException>(() => p.slugify(null));

        }


    }
}
