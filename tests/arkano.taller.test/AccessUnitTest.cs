namespace arkano.taller.test
{
    using arkano.taller.core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AccessUnitTest : Access
    {
        [TestMethod]
        [DataRow("1", "1234", "abcd", "ffd275c5130566a2916217b101f26150")]
        public void TestAuthenticationValueGeneration(string ts, string publicKey, string privateKey, string expected)
        {
            Assert.AreEqual(this.GetAuthorizationValueFromValues(privateKey, publicKey, ts), expected);
        }
    }
}
