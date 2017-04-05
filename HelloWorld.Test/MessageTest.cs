
using HelloWorld.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld.Test{
    [TestClass]
    public class MessageTest{
        [TestMethod]
        public void TestExpectedMessage(){
            var message = Message.Get("Travis");
            Assert.AreEqual("Hello, World!", message);
        }
    }
}