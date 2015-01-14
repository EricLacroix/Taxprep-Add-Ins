using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using FILETIME = System.Runtime.InteropServices.ComTypes.FILETIME;

namespace AddinReg
{
    internal static class ConsoleHelper
    {
        public static void InitConsoleHandles()
        {
            SafeFileHandle hStdOut, hStdErr, hStdOutDup, hStdErrDup;
            BY_HANDLE_FILE_INFORMATION bhfi;
            hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
            hStdErr = GetStdHandle(STD_ERROR_HANDLE);
            // Get current process handle
            var hProcess = Process.GetCurrentProcess().Handle;
            // Duplicate Stdout handle to save initial value
            DuplicateHandle(hProcess, hStdOut, hProcess, out hStdOutDup,
                0, true, DUPLICATE_SAME_ACCESS);
            // Duplicate Stderr handle to save initial value
            DuplicateHandle(hProcess, hStdErr, hProcess, out hStdErrDup,
                0, true, DUPLICATE_SAME_ACCESS);
            // Attach to console window – this may modify the standard handles
            AttachConsole(ATTACH_PARENT_PROCESS);
            // Adjust the standard handles
            if (GetFileInformationByHandle(GetStdHandle(STD_OUTPUT_HANDLE), out bhfi))
            {
                SetStdHandle(STD_OUTPUT_HANDLE, hStdOutDup);
            }
            else
            {
                SetStdHandle(STD_OUTPUT_HANDLE, hStdOut);
            }
            if (GetFileInformationByHandle(GetStdHandle(STD_ERROR_HANDLE), out bhfi))
            {
                SetStdHandle(STD_ERROR_HANDLE, hStdErrDup);
            }
            else
            {
                SetStdHandle(STD_ERROR_HANDLE, hStdErr);
            }
        }

        public static void ReleaseConsoleHandles()
        {
            //SendKeys.SendWait("{ENTER}");
            FreeConsole();
        }

        #region WinAPI links

        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        [DllImport("kernel32.dll")]
        private static extern bool AttachConsole(uint dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool GetFileInformationByHandle(SafeFileHandle hFile,
            out BY_HANDLE_FILE_INFORMATION lpFileInformation);

        [DllImport("kernel32.dll")]
        private static extern SafeFileHandle GetStdHandle(uint nStdHandle);

        [DllImport("kernel32.dll")]
        private static extern bool SetStdHandle(uint nStdHandle, SafeFileHandle hHandle);

        [DllImport("kernel32.dll")]
        private static extern bool DuplicateHandle(IntPtr hSourceProcessHandle, SafeFileHandle hSourceHandle,
            IntPtr hTargetProcessHandle,
            out SafeFileHandle lpTargetHandle, uint dwDesiredAccess, bool bInheritHandle, uint dwOptions);

        private const uint ATTACH_PARENT_PROCESS = 0xFFFFFFFF;
        private const uint STD_OUTPUT_HANDLE = 0xFFFFFFF5;
        private const uint STD_ERROR_HANDLE = 0xFFFFFFF4;
        private const uint DUPLICATE_SAME_ACCESS = 2;

        private struct BY_HANDLE_FILE_INFORMATION
        {
            public uint FileAttributes;
            public FILETIME CreationTime;
            public FILETIME LastAccessTime;
            public FILETIME LastWriteTime;
            public uint VolumeSerialNumber;
            public uint FileSizeHigh;
            public uint FileSizeLow;
            public uint NumberOfLinks;
            public uint FileIndexHigh;
            public uint FileIndexLow;
        }

        #endregion
    }
}