namespace EFS_Professional
{
    using System;
    using System.Collections.Generic;

    public class NVItemSkipClass
    {
        private string _deviceName;
        private List<string> _nvItems = new List<string>();

        public NVItemSkipClass(string deviceName, List<string> nvItems)
        {
            this._nvItems.Clear();
            this._deviceName = deviceName;
            this._nvItems.AddRange(nvItems);
        }

        public string DeviceName =>
            this._deviceName;

        public List<string> NVItems =>
            this._nvItems;
    }
}

