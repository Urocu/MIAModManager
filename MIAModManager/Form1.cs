using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MIAModManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Start_Game_Click(object sender, EventArgs e)
        {
            string gameDir = GameUtils.GetGameRootDirectory();
            string executablePath = Path.Combine(gameDir, "MadeInAbyss.exe");
            if (File.Exists(executablePath))
                Process.Start(executablePath);

        }
        
    }
}
