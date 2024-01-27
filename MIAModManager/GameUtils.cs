using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace MIAModManager
{
    internal class GameUtils
    {
        public static string MIA_STEAM_ID = "1324340"; //Steam app id for Made In Abyss.
        public static string GetGameRootDirectory()
        {
            try
            {
                string steamInstallDir = (string) Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Valve\\Steam", "InstallPath", "");
                if (steamInstallDir == "")
                    throw new Exception("No Steam Installation Path Found.");
                string steamGamePaths = Path.Combine(steamInstallDir, "steamapps", "libraryfolders.vdf");
                using (StreamReader reader = new(steamGamePaths))
                {
                    string line;
                    string dir = "";
                    while((line = reader.ReadLine()) != null) {
                        if (line.Contains("\\\\"))
                            dir = line.Split('"')[3].Replace("\\\\", "\\");
                        else if (line.Contains(MIA_STEAM_ID) && dir != "")
                            break;
                    }
                    return dir;
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
