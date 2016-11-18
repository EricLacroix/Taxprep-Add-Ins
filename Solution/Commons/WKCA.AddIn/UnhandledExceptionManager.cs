using System;

namespace WKCA
{
    public delegate void UnhandledAddInExceptionEventHandler(object sender, Exception e, out bool handle);

    public static class UnhandledExceptionManager
    {
        public static event UnhandledAddInExceptionEventHandler UnhandledException;

        public static bool HandleException(object sender, Exception e)
        {
            if (UnhandledException != null)
            {
                var result = false;
                UnhandledException(sender, e, out result);
                return result;
            }
            return false;
        }
    }
}