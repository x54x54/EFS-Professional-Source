namespace EFS_Professional.WinADBHelper
{
    using System;

    public class ADBCommand
    {
        private string _cmd;

        public ADBCommand(string cmd)
        {
            this._cmd = cmd;
        }

        public string Command =>
            this._cmd;
    }
}

