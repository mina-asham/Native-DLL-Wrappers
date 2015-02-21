using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NativeDLLWrappers.User32
{
    /// <summary>
    /// Contains information about a simulated keyboard event.
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms646271(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct KeyboardInput
    {
        /// <summary>
        /// A virtual-key code. The code must be a value in the range 1 to 254.
        /// If the dwFlags member specifies KEYEVENTF_UNICODE, wVk must be EventFUnicode.
        /// </summary>
        public VirtualKey wVk;

        /// <summary>
        /// A hardware scan code for the key. If dwFlags specifies
        /// KEYEVENTF_UNICODE, wScan specifies a Unicode character
        /// which is to be sent to the foreground application.
        /// </summary>
        public ushort wScan;

        /// <summary>
        /// Specifies various aspects of a keystroke.
        /// </summary>
        public KeyboardEventFlag dwFlags;

        /// <summary>
        /// The time stamp for the event, in milliseconds. 
        /// If this parameter is 0, the system will provide its own time stamp.
        /// </summary>
        public uint time;

        /// <summary>
        /// An additional value associated with the mouse event.
        /// An application calls GetMessageExtraInfo to obtain this extra information.
        /// </summary>
        public UIntPtr dwExtraInfo;
    }
}
