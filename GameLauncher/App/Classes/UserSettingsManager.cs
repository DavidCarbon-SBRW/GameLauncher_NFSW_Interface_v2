using System;
using System.Diagnostics;
using System.IO;

namespace GameLauncher.App.Classes
{
    public class UserSettingsManager
    {
        public static string GetUserSettingsPath()
        {
            string appdata = "";
            appdata = Environment.GetEnvironmentVariable("AppData");
            return appdata + "/Need for Speed World/Settings/UserSettings.xml";
        }
    }
}
