using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Caesar_Cipher.UnitTests
{
    [TestClass]
    public class EncryptTests
    {
        [TestMethod]
        public void EncryptingTesterMethod()
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //Arrange
            Program enc = new Program();

            //Act           
            int key = 3;
            string message = "cat";
            string check = enc.Encrypting(alphabet, key, message);

            //Assert
            Assert.AreEqual("fdw", check);
        }
    }
}
