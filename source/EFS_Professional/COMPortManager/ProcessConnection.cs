namespace EFS_Professional.COMPortManager
{
    using System;
    using System.Management;

    internal class ProcessConnection
    {
        public static ManagementScope ConnectionScope(string machineName, ConnectionOptions options, string path)
        {
            ManagementScope scope2 = new ManagementScope {
                Path = new ManagementPath(@"\\" + machineName + path),
                Options = options
            };
            scope2.Connect();
            return scope2;
        }

        public static ConnectionOptions ProcessConnectionOptions() => 
            new ConnectionOptions { 
                Impersonation = ImpersonationLevel.Impersonate,
                Authentication = AuthenticationLevel.Default,
                EnablePrivileges = true
            };
    }
}

