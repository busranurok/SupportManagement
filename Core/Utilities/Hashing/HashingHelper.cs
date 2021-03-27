using System;
using System.Text;

namespace Core.Utilities.Hashing
{
    public class HashingHelper
    {
        public HashingHelper()
        {
        }

        //static yazmadaki amaç class ın adı ile ulaşmak. Bir nesne üretilmesine gerek kalmasın.
        //out : parametre olarak gönderdiğim değeri içerisini doldurup bize verir. return yazmamıza gerek kalmaz.
        public static void CreatePasswordHash(string password, out byte[] passwordHash,out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                //tuzlama işlemi
                passwordSalt = hmac.Key;
                //UTF8: Türkçe karakter
                //password ü hashleyip password hassh değişkenine atıyoruz
                passwordHash = hmac.ComputeHash(buffer: Encoding.UTF8.GetBytes(password));
            }
        }

        //hassi doğrulama işlemi
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(buffer: Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
