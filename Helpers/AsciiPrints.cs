﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StresserWinGUI.Helpers
{
    public static class AsciiPrints
    {
        public static string print1 = @"
$$$$$$\    $$\                                                                 
$$  __$$\   $$ |                                                                
$$ /  \__|$$$$$$\    $$$$$$\   $$$$$$\   $$$$$$$\  $$$$$$$\  $$$$$$\   $$$$$$\  
\$$$$$$\  \_$$  _|  $$  __$$\ $$  __$$\ $$  _____|$$  _____|$$  __$$\ $$  __$$\ 
 \____$$\   $$ |    $$ |  \__|$$$$$$$$ |\$$$$$$\  \$$$$$$\  $$$$$$$$ |$$ |  \__|
$$\   $$ |  $$ |$$\ $$ |      $$   ____| \____$$\  \____$$\ $$   ____|$$ |      
\$$$$$$  |  \$$$$  |$$ |      \$$$$$$$\ $$$$$$$  |$$$$$$$  |\$$$$$$$\ $$ |      
 \______/    \____/ \__|       \_______|\_______/ \_______/  \_______|\__| ";

        public static string print2 = @"
   ██████ ▄▄▄█████▓ ██▀███  ▓█████   ██████   ██████ ▓█████  ██▀███  
▒██    ▒ ▓  ██▒ ▓▒▓██ ▒ ██▒▓█   ▀ ▒██    ▒ ▒██    ▒ ▓█   ▀ ▓██ ▒ ██▒
░ ▓██▄   ▒ ▓██░ ▒░▓██ ░▄█ ▒▒███   ░ ▓██▄   ░ ▓██▄   ▒███   ▓██ ░▄█ ▒
  ▒   ██▒░ ▓██▓ ░ ▒██▀▀█▄  ▒▓█  ▄   ▒   ██▒  ▒   ██▒▒▓█  ▄ ▒██▀▀█▄  
▒██████▒▒  ▒██▒ ░ ░██▓ ▒██▒░▒████▒▒██████▒▒▒██████▒▒░▒████▒░██▓ ▒██▒
▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▓▒ ▒ ░▒ ▒▓▒ ▒ ░░░ ▒░ ░░ ▒▓ ░▒▓░
░ ░▒  ░ ░    ░      ░▒ ░ ▒░ ░ ░  ░░ ░▒  ░ ░░ ░▒  ░ ░ ░ ░  ░  ░▒ ░ ▒░
░  ░  ░    ░        ░░   ░    ░   ░  ░  ░  ░  ░  ░     ░     ░░   ░ 
      ░              ░        ░  ░      ░        ░     ░  ░   ░     ";
        public static void Random()
        {
            Console.Clear();
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 4);

            string selectedPrint = "";

            switch (randomNumber)
            {
                case 1:
                    selectedPrint = print1;
                    break;
                case 2:
                    selectedPrint = print2;
                    break;
                default:
                    selectedPrint = print1;
                    break;
            }

            Console.WriteLine(selectedPrint);
        }
    }
}
