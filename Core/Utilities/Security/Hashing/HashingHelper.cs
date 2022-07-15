using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //Verdiğimiz passwordun hashini oluşturmya yarar
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key; //Her kullanıcı için bir keyde oluşşur
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }

        }

        //Sonradan sisteme girmek isteyen kişinin verdiği passwordun bizim verdiğimiz dbdeki hashle ilgili salta göre eşleşmediğini kontrol eder
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt) //Password hashini doğrula
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++) //karşılaştırcaz
                {
                    if (computedHash[i] != passwordHash[i]) //gönderilen hesaplanan eşit değilse false döner değer eşleşmiyor demek
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
