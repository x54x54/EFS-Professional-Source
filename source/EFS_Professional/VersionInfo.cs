namespace EFS_Professional
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Reflection;

    public class VersionInfo
    {
        public static string GetAppVersion()
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            return (Conversions.ToString(version.Major) + "." + Conversions.ToString(version.Minor) + "." + Conversions.ToString(version.Build) + " ***BETA***");
        }
    }
}

