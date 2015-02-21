using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NativeDLLWrappers.User32
{
    /// <summary>
    /// Class responsible for User32 DLL functionality.
    /// </summary>
    public static class User32
    {
        /// <summary>
        /// Synthesizes keystrokes, mouse motions, and button clicks.
        /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms646310%28v=vs.85%29.aspx
        /// </summary>
        /// <param name="nInputs">Number of inputs to send.</param>
        /// <param name="pInputs">Array of input elements.</param>
        /// <param name="cbSize">Size in bytes of an Input structure.</param>
        /// <returns></returns>
        [DllImport("User32.dll", SetLastError = true)]
        public static extern uint SendInput(
            uint nInputs,
            ref Input[] pInputs,
            int cbSize
        );
    }
}
