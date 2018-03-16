using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleApplication.Models; 
namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Contact_FullName_Has_No_Name()
        {
            var c = new Contact();
            Assert.AreEqual("[No Name]", c.GetFullName()); 

        }
        [TestMethod]
        public void Contact_FullName_Is_Name_And_LastName()
        {
            var c = new Contact()
            {
                Name = "Han",
                LastName = "Solo"
            };

            Assert.AreEqual("Han Solo", c.GetFullName()); 
        }
    }
}
