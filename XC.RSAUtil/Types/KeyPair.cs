namespace XC.RSAUtil.Types
{
    public class KeyPair
    {
		public KeyPair() { }
	    public KeyPair(string publickey, string privatekey="")
	    {
		    PublicKey = publickey;
		    PrivateKey = PrivateKey;
	    }
		public string PublicKey { get; set; }
		public string PrivateKey { get; set; }
    }
}
