using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; // For hasing password.

namespace FinalProject24
{
    public static class SecurityHelper
    {
        public static string HashPassword(string password)
        {
            // Create a SHA256 hash object.
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Compute the hash of the password.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a string.
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return builder.ToString();
            }
        }
    }

}
