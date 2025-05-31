using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Buisness
{
    public class PasswordHelper
    {
        public static (string hash, string salt) HashPassword(string password)
        {
            // Генерация соли
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            // Хеширование пароля с солью
            using (var hasher = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] hash = hasher.GetBytes(32);
                // Соля хранится в виде Base64 строки для удобства
                return (Convert.ToBase64String(hash), Convert.ToBase64String(salt));
            }
        }

        public static bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            // Декодирование соли из Base64
            byte[] salt = Convert.FromBase64String(storedSalt);

            // Хеширование введенного пароля с той же солью
            using (var hasher = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] hash = hasher.GetBytes(32);
                // Сравнение хеша
                return Convert.ToBase64String(hash) == storedHash;
            }
        }
    }
}
