namespace EFS_Professional.WinADBHelper
{
    using System;

    public class FastbootCommand
    {
        private string _cmd;

        public FastbootCommand(string cmd)
        {
            this._cmd = cmd;
        }

        public string Command =>
            this._cmd;
    }
}

