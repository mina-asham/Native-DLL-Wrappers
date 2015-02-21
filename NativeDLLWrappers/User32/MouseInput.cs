using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NativeDLLWrappers.User32
{
    /// <summary>
    /// Contains information about a simulated mouse event.
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms646273(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct MouseInput
    {
        /// <summary>
        /// The absolute position of the mouse, or the amount of motion since the last
        /// mouse event was generated, depending on the value of the dwFlags member.
        /// Absolute Data is specified as the x coordinate of the mouse;
        /// relative Data is specified as the number of pixels moved.
        /// </summary>
        public int Dx;

        /// <summary>
        /// The absolute position of the mouse, or the amount of motion since the last
        /// mouse event was generated, depending on the value of the dwFlags member.
        /// Absolute Data is specified as the y coordinate of the mouse; 
        /// relative Data is specified as the number of pixels moved.
        /// </summary>
        public int Dy;

        /// <summary>
        /// If dwFlags does not contain Wheel, XDown, or XUp,
        /// then mouseData should be zero.
        /// </summary>
        public uint mouseData;

        /// <summary>
        /// A set of bit flags that specify various aspects of mouse motion and button clicks.
        /// </summary>
        public MouseEventFlag dwFlags;

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
