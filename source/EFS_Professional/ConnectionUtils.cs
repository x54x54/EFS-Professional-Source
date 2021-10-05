namespace EFS_Professional
{
    using System;

    public class ConnectionUtils
    {
        public static void SetConnectionMode(ConnectionMode connMode, CommandQueue queue)
        {
            Command command;
            if (connMode == ConnectionMode.OfflineAnalog)
            {
                command = new Command(Qcdm.Cmd.DIAG_CONTROL_F, new byte[] { 0, 0 }, "DIAG_CONTROL_F - Change mode: Offline Analog Mode");
                queue.Add(ref command);
            }
            else if (connMode == ConnectionMode.OfflineDigital)
            {
                command = new Command(Qcdm.Cmd.DIAG_CONTROL_F, new byte[] { 1, 0 }, "DIAG_CONTROL_F - Change mode: Offline Digital Mode");
                queue.Add(ref command);
            }
            else if (connMode == ConnectionMode.Reset)
            {
                command = new Command(Qcdm.Cmd.DIAG_CONTROL_F, new byte[] { 2, 0 }, "DIAG_CONTROL_F - Change mode: Reset");
                queue.Add(ref command);
            }
            else if (connMode == ConnectionMode.FactoryTestMode)
            {
                command = new Command(Qcdm.Cmd.DIAG_CONTROL_F, new byte[] { 3, 0 }, "DIAG_CONTROL_F - Change mode: Offline Factory Test Mode");
                queue.Add(ref command);
            }
            else if (connMode == ConnectionMode.Online)
            {
                command = new Command(Qcdm.Cmd.DIAG_CONTROL_F, new byte[] { 4, 0 }, "DIAG_CONTROL_F - Change mode: Online Mode");
                queue.Add(ref command);
            }
            else if (connMode == ConnectionMode.LowPower)
            {
                command = new Command(Qcdm.Cmd.DIAG_CONTROL_F, new byte[] { 5, 0 }, "DIAG_CONTROL_F - Change mode: Low Power Mode");
                queue.Add(ref command);
            }
            else if (connMode == ConnectionMode.Power)
            {
                command = new Command(Qcdm.Cmd.DIAG_CONTROL_F, new byte[] { 6, 0 }, "DIAG_CONTROL_F - Change mode: Power Off Mode");
                queue.Add(ref command);
            }
        }

        public enum ConnectionMode
        {
            OfflineAnalog,
            OfflineDigital,
            Reset,
            FactoryTestMode,
            Online,
            LowPower,
            Power
        }
    }
}

