using System.Runtime.InteropServices;


namespace NoSleepMonitor
{
    public class NoSleepWay2
    {
        [DllImport("user32", EntryPoint = "SystemParametersInfo", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private const int SPI_SETSCREENSAVEACTIVE = 0x0011;

        public static void  NoSleep()
        {
            SystemParametersInfo(SPI_SETSCREENSAVEACTIVE, 0, "0", 0); 
        }
        public static void Sleep()
        {
            SystemParametersInfo(SPI_SETSCREENSAVEACTIVE, 1, "0", 0); 
        }
    }
}