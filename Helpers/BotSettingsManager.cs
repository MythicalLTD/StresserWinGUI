using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace StresserWinGUI.Helpers
{
    public static class BotSettingsManager
    {
        private static readonly string BotsRegistryPath = @"SOFTWARE\MythicalSystems\Stresser\Bots";

        public static void CreateBot(string botName, string domain, string threads, string rspt, string token)
        {
            string botValue = $"Domain={domain};Threads={threads};Rspt={rspt};Token={token}";

            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(BotsRegistryPath))
            {
                if (key != null)
                {
                    key.SetValue(botName, botValue);
                }
            }
        }
        public static Dictionary<string, string> GetAllBots()
        {
            var bots = new Dictionary<string, string>();

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(BotsRegistryPath))
            {
                if (key != null)
                {
                    foreach (string valueName in key.GetValueNames())
                    {
                        string botValue = key.GetValue(valueName) as string;
                        bots[valueName] = botValue;
                    }
                }
            }

            return bots;
        }

        public static int GetNumberOfBots()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(BotsRegistryPath))
            {
                if (key != null)
                {
                    return key.GetValueNames().Length;
                }
                else
                {
                    throw new Exception($"Failed to open registry key '{BotsRegistryPath}'.");
                }
            }
        }

        public static string GetBot(string botName)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(BotsRegistryPath))
            {
                if (key != null)
                {
                    return key.GetValue(botName) as string;
                }
            }
            return null;
        }

        public static void DeleteBot(string botName)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(BotsRegistryPath, writable: true))
            {
                if (key != null && key.GetValue(botName) != null)
                {
                    key.DeleteValue(botName);
                }
            }
        }
    }
}
