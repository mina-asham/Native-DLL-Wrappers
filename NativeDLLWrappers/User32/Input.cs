using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NativeDLLWrappers.User32
{
    /// <summary>
    /// Input event structure.
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms646270(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Input
    {
        /// <summary>
        /// The type of the input event.
        /// </summary>
        public InputType Type;

        /// <summary>
        /// The information about a simulated event.
        /// </summary>
        public MouseKeyboardHardwareInput Data;
    }
}
