using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WKCA
{
    public delegate void UnhandledAddInExceptionEventHandler(object sender, Exception e, out bool handle);

    public static class UnhandledExceptionManager
    {

        public static event UnhandledAddInExceptionEventHandler UnhandledException;

        public static bool HandleException(object sender,  Exception e)
        {
            if (UnhandledException != null)
            {
                bool result = false;
                UnhandledException(sender, e, out result);
                return result;
            }
            else
            {
                return false;
            }
        }

    }
}
