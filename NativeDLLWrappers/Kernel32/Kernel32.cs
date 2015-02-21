using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NativeDLLWrappers.Kernel32
{
    /// <summary>
    /// Class responsible for Kernel32 DLL functionality.
    /// </summary>
    public static class Kernel32
    {
        /// <summary>
        /// Retrieves the calling thread's last-error code value. The last-error code is maintained
        /// on a per-thread basis. Multiple threads do not overwrite each other's last-error code.
        /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms679360%28v=vs.85%29.aspx
        /// Error codes: https://msdn.microsoft.com/en-us/library/windows/desktop/ms681382(v=vs.85).aspx
        /// </summary>
        /// <returns></returns>
        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern uint GetLastError();
    }
}
