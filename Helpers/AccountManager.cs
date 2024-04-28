using System;
using Microsoft.Win32;

namespace StresserWinGUI.Helpers
{
    public static class AccountManager
    {
        private static readonly string RegistryPath = @"SOFTWARE\MythicalSystems\Stresser\Users";

        public static void Create(string accountName, string accountPassword)
        {
            string newPassword = Encode(accountPassword);
            SaveToRegistry(accountName, newPassword);
        }

        public static bool Exists(string accountName)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                if (key != null)
                {
                    return key.GetValueNames().Contains(accountName);
                }
            }

            return false; 
        }
        public static bool Verify(string accountName, string accountPassword)
        {
            string storedPassword = ReadFromRegistry(accountName);
            if (storedPassword == null)
            {
                return false;
            }

            string encodedPassword = Encode(accountPassword);
            return storedPassword.Equals(encodedPassword);
        }

        private static void SaveToRegistry(string accountName, string encodedPassword)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
            {
                if (key != null)
                {
                    key.SetValue(accountName, encodedPassword);
                }
            }
        }

        private static string ReadFromRegistry(string accountName)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                if (key != null)
                {
                    return key.GetValue(accountName) as string;
                }
            }
            return null;
        }

        public static string Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Decode(string base64EncodedText)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedText);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}