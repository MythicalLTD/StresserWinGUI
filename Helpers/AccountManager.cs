using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StresserWinGUI.Helpers
{
    public static class AccountManager
    {

        public static void Create(string accountName, string accountPassword)
        {

        }

        public static void Verify(string accountName, string accountPassword)
        {

        }


        public static string Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Decode(string base64EncodedText)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedText);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }
}
