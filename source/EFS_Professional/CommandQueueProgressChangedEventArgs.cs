namespace EFS_Professional
{
    using System;
    using System.ComponentModel;

    public class CommandQueueProgressChangedEventArgs : ProgressChangedEventArgs
    {
        private string _consoleOutput;
        private string _consoleRX;
        private string _consoleRXASCII;
        private string _consoleTX;
        private int _currentNVItem;
        private int _nvItemNumber;
        private int _totalNVItems;

        public CommandQueueProgressChangedEventArgs(string consoleOutput, string consoleTX, string consoleRX, string consoleRXASCII, int nvItemNumber, int currentNVItem, int totalNVItems, int progressPercentage, object UserState) : base(progressPercentage, RuntimeHelpers.GetObjectValue(UserState))
        {
            this._consoleOutput = string.Empty;
            this._consoleTX = string.Empty;
            this._consoleRX = string.Empty;
            this._consoleRXASCII = string.Empty;
            this._nvItemNumber = 0;
            this._currentNVItem = 0;
            this._totalNVItems = 0;
            this._consoleOutput = consoleOutput;
            this._consoleTX = consoleTX;
            this._consoleRX = consoleRX;
            this._consoleRXASCII = consoleRXASCII;
            this._nvItemNumber = nvItemNumber;
            this._currentNVItem = currentNVItem;
            this._totalNVItems = totalNVItems;
        }

        public string ConsoleOutput =>
            this._consoleOutput;

        public string ConsoleRXASCIIOutput =>
            this._consoleRXASCII;

        public string ConsoleRXOutput =>
            this._consoleRX;

        public string ConsoleTXOutput =>
            this._consoleTX;

        public int CurrentNVItem =>
            this._currentNVItem;

        public int NVItemNumber =>
            this._nvItemNumber;

        public int TotalNVItems =>
            this._totalNVItems;
    }
}

