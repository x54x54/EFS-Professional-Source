namespace EFS_Professional
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    public class AT_Cmd
    {
        private List<AT_Cmd> _atCmds;
        private string _cmdName;
        private string _cmdValue;
        public const string Check_SIM_Lock_Status = "AT^CARDLOCK?";
        public const string List_Available_AT_Commands = "AT+CLAC";
        public const string Read_Battery_Life = "AT+CBC";
        public const string Read_Device_Info = "ATI";
        public const string Read_IMEI = "AT+CGSN";
        public const string Read_IMSI = "AT+CIMI";
        public const string Read_Manufacturer_ID = "AT+CGMI";
        public const string Read_Model_ID = "AT+CGMM";
        public const string Read_Network_Registered_Status = "AT+CGREG";
        public const string Read_Operator_Names = "AT+COPN";
        public const string Read_Revision_ID = "AT+CGMR";
        public const string Read_Signal_Quality = "AT+CSQ";
        public const string Read_SIM_Serial_Number = "AT+CCID";
        public const string Set_Qualcomm_Diag_Monitor = "AT$QCDMG";

        public AT_Cmd()
        {
            this._atCmds = new List<AT_Cmd>();
            foreach (FieldInfo info in this.GetType().GetFields())
            {
                this._atCmds.Add(new AT_Cmd(info.Name.Replace("_", " "), Conversions.ToString(info.GetValue(info))));
            }
        }

        public AT_Cmd(string cmdName, string cmdValue)
        {
            this._atCmds = new List<AT_Cmd>();
            this._cmdName = cmdName;
            this._cmdValue = cmdValue;
        }

        public List<AT_Cmd> GetCommands()
        {
            if (this._atCmds.Count > 0)
            {
                return this._atCmds;
            }
            return null;
        }

        public string CommandName =>
            this._cmdName;

        public string CommandValue =>
            this._cmdValue;
    }
}

