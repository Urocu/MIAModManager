using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIAModManager
{
    internal class GameUtils
    {
        public static string GetGameRootDirectory()
        {
            try
            {
                string miAAppID = "1324340";
                string steamPath = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Valve\\Steam", "InstallPath", "");
                if (steamPath == "")
                    throw new Exception("No Steam Installation Path Found.");
                string steamGamePaths = steamPath + "\\steamapps\\libraryfolders.vdf";
                using (StreamReader reader = new StreamReader(steamGamePaths))
                {
                    string fileContents = reader.ReadToEnd();
                    int appIDIndex = fileContents.IndexOf(miAAppID);
                    if (appIDIndex == -1)
                        throw new Exception("Game is not installed properly or is pirated.");
                    Match match = Regex.Match(fileContents.Substring(0, appIDIndex), "\"path\"\\s+\"(.*?)\"", RegexOptions.RightToLeft);
                    if (!match.Success)
                        throw new Exception("Steam files are corrupted.");
                    string gamePath = match.Groups[1].Value.Replace("\\\\", "\\") + "\\steamapps\\common\\MadeInAbyss-BSFD";
                    return gamePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
    }
    
}
