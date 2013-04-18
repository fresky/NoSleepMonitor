using System;
using System.Runtime.InteropServices;

namespace NoSleepMonitor
{
    static internal class NoSleepWay1
    {
        [Flags()]
        public enum EXECUTION_STATE : uint //Determine Monitor State
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
            // Legacy flag, should not be used.
            // ES_USER_PRESENT = 0x00000004
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        public static void Sleep()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS); 
        }

        public static void NoSleep()
        {
            SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED | EXECUTION_STATE.ES_CONTINUOUS); 
        }
    }
}