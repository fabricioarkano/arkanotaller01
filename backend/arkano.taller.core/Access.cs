namespace arkano.taller.core
{
    using System;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    public class Access
    {
        public const string PrivateKey = "e970a9224c1e6a1e35a6d6ba06a18e3a84441654";

        public const string PublicKey = "94f7bb23cf5a39db5786add5cd466827";

        public Access()
        {
        }

        public string GetAuthorizationValue()
        {
            string ts = DateTime.Now.Ticks.ToString();
            var mdd5Output = this.GetAuthorizationValueFromValues(PrivateKey, PublicKey, ts);
            return $"ts={ts}&apiKey={PublicKey}&hash={mdd5Output}";
        }

        protected string GetAuthorizationValueFromValues(string privateKey, string publicKey, string timeStamp)
        {
            var input = $"{timeStamp}{privateKey}{publicKey}";
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                var dataAsHexa = data.Select(x => x.ToString("x2"));
                string mdd5Output = string.Join(string.Empty, dataAsHexa);
                return mdd5Output;
            }
        }
    }
}
