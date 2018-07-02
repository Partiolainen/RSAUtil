using System;
using System.Security.Cryptography;
using System.Text;

namespace XC.RSAUtil.Test
{
    class Program
    {
        static void Main(string[] args)
        {
	        var keyList = RsaKeyGenerator.Pkcs1Key(2048, true);

			Console.WriteLine($"Public key:\n{keyList.PublicKey}\n\nPrivate key:\n{keyList.PrivateKey}");

	        Console.Write("String for encrypt: ");
	        var test_string = Console.ReadLine();
	        var rsa_encryptor = new RsaPkcs1Util(Encoding.UTF8, keyList.PublicKey);
	        var encrypted_string = rsa_encryptor.Encrypt(test_string, RSAEncryptionPadding.Pkcs1);
			Console.WriteLine($"\nEncrypted string:\n{encrypted_string}\n");

			var rsa_decryptor = new RsaPkcs1Util(Encoding.UTF8, keyList.PublicKey, keyList.PrivateKey);
	        var decrypted_string = rsa_decryptor.Decrypt(encrypted_string, RSAEncryptionPadding.Pkcs1);
	        Console.WriteLine($"\nDecrypted string:\n{decrypted_string}\n");

			Console.WriteLine("\nPress any key to exit");
			Console.ReadKey();
        }
    }
}
