using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using StresserWinGUI.Forms;
using System.Windows.Forms;
using YamlDotNet.Serialization;

namespace StresserWinGUI.Helpers
{
    public class UIStyler
    {
        private static string stylepath = Program.appWorkDir + @"\styles.yaml";
        private static Dictionary<string, Dictionary<string, string>> styles;

        private static void ReadYaml()
        {
            try
            {
                styles = new Dictionary<string, Dictionary<string, string>>();

                if (File.Exists(stylepath))
                {
                    using (StreamReader reader = new StreamReader(stylepath))
                    {
                        var dsl = new DeserializerBuilder().Build();
                        styles = dsl.Deserialize<Dictionary<string, Dictionary<string, string>>>(reader);
                    }
                }
                else
                {
                    string yamlContent = @"
lblappname:
  Text: Stresser WIN GUI
";

                    File.AppendAllText(stylepath, yamlContent);

                    Program.hLogger.Log(LogType.Warning, "[THEME] Style file does not exist!");
                    Program.Restart();
                }
            }
            catch (Exception ex)
            {
                Program.hLogger.Log(LogType.Warning, "[THEME] Failed to read yml file: " + ex.ToString());
            }
        }

        public static void ApplyStyles(Control form, bool debug)
        {
            ReadYaml();
            try
            {

                string controlName = form.Name;
                if (styles.ContainsKey(controlName))
                {
                    Dictionary<string, string> controlStyles = styles[controlName];

                    foreach (KeyValuePair<string, string> style in controlStyles)
                    {
                        ApplyStyle(form, style.Key, style.Value, debug);
                    }
                }
                foreach (Control childControl in form.Controls)
                {
                    ApplyStyles(childControl, debug);
                }
            }
            catch (Exception ex)
            {
                Program.Crash($"[THEME] Failed to apply styles for '" + form.Name + "'!\nPlease check the logs\n" + ex.ToString());
            }
        }
        private static void ApplyStyle(Control control, string property, string value, bool debug)
        {
            PropertyInfo prop = control.GetType().GetProperty(property);
            if (prop != null)
            {
                if (prop.PropertyType == typeof(Color))
                {
                    string[] rgbParts = value.Split(',');
                    if (rgbParts.Length == 3 && int.TryParse(rgbParts[0], out int r) && int.TryParse(rgbParts[1], out int g) && int.TryParse(rgbParts[2], out int b))
                    {
                        Color color = Color.FromArgb(r, g, b);
                        prop.SetValue(control, color);
                        if (debug)
                        {
                            Program.hLogger.Log(LogType.Info, $"[THEME] Applied RGB Color '{color}' to '{property}' of '{control.Name}'.");
                        }
                    }
                    else
                    {
                        Color color = Color.FromName(value);
                        prop.SetValue(control, color);
                        if (debug)
                        {
                            Program.hLogger.Log(LogType.Info, $"[THEME] Applied Color '{color}' to '{property}' of '{control.Name}'.");
                        }
                    }
                }
                else if (prop.PropertyType == typeof(Size))
                {
                    string[] sizeParts = value.Split(',');
                    if (sizeParts.Length == 2 && int.TryParse(sizeParts[0], out int width) && int.TryParse(sizeParts[1], out int height))
                    {
                        Size size = new Size(width, height);
                        prop.SetValue(control, size);
                        if (debug == true)
                        {
                            Program.hLogger.Log(LogType.Info, $"[THEME] Applied Size '{size}' to '{property}' of '{control.Name}'.");
                        }
                    }
                }
                else if (prop.PropertyType == typeof(Point))
                {
                    string[] pointParts = value.Split(',');
                    if (pointParts.Length == 2 && int.TryParse(pointParts[0], out int x) && int.TryParse(pointParts[1], out int y))
                    {
                        Point point = new Point(x, y);
                        prop.SetValue(control, point);
                        if (debug == true)
                        {
                            Program.hLogger.Log(LogType.Info, $"[THEME] Applied Point '{point}' to '{property}' of '{control.Name}'.");
                        }
                    }
                }
                else if (prop.PropertyType == typeof(DockStyle))
                {
                    DockStyle dockStyle;
                    if (Enum.TryParse(value, out dockStyle))
                    {
                        prop.SetValue(control, dockStyle);
                        if (debug == true)
                        {
                            Program.hLogger.Log(LogType.Info, $"[THEME] Applied DockStyle '{dockStyle}' to '{property}' of '{control.Name}'.");
                        }
                    }
                }
                else if (prop.PropertyType == typeof(bool))
                {
                    bool boolValue;
                    if (bool.TryParse(value, out boolValue))
                    {
                        prop.SetValue(control, boolValue);
                        Program.hLogger.Log(LogType.Info, $"[THEME] Applied Boolean '{boolValue}' to '{property}' of '{control.Name}'.");
                    }
                }
                else if (prop.PropertyType == typeof(FormStartPosition))
                {
                    FormStartPosition startPosition;
                    if (Enum.TryParse(value, out startPosition))
                    {
                        prop.SetValue(control, startPosition);
                        if (debug)
                        {
                            Program.hLogger.Log(LogType.Info, $"[THEME] Applied StartPosition '{startPosition}' to '{property}' of '{control.Name}'.");
                        }
                    }
                    else
                    {
                        Program.hLogger.Log(LogType.Warning, $"[THEME] Invalid StartPosition value '{value}' for '{property}' of '{control.Name}'.");
                    }
                }
                else if (prop.PropertyType == typeof(FormBorderStyle))
                {
                    FormBorderStyle borderStyle;
                    if (Enum.TryParse(value, out borderStyle))
                    {
                        prop.SetValue(control, borderStyle);
                        if (debug)
                        {
                            Program.hLogger.Log(LogType.Info, $"[THEME] Applied FormBorderStyle '{borderStyle}' to '{property}' of '{control.Name}'.");
                        }
                    }
                    else
                    {
                        Program.hLogger.Log(LogType.Warning, $"[THEME] Invalid FormBorderStyle value '{value}' for '{property}' of '{control.Name}'.");
                    }
                }
                else
                {
                    prop.SetValue(control, Convert.ChangeType(value, prop.PropertyType));
                    Program.hLogger.Log(LogType.Info, $"[THEME] Applied Value '{value}' to '{property}' of '{control.Name}'.");
                }
            }
            else
            {
                Program.hLogger.Log(LogType.Warning, $"[THEME] Property '{property}' not found on '{control.Name}'.");
            }
        }

    }
}
