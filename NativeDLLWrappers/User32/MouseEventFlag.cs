using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NativeDLLWrappers.User32
{
    /// <summary>
    /// A set of bit flags that specify various aspects of mouse motion and button clicks.
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms646273(v=vs.85).aspx
    /// </summary>
    public enum MouseEventFlag : uint
    {
        /// <summary>
        /// The dx and dy members contain normalized absolute coordinates.
        /// If the flag is not set, dxand dy contain relative Data 
        /// (the change in position since the last reported position). 
        /// This flag can be set, or not set, regardless of what kind of
        /// mouse or other pointing device, if any, is connected to the system.
        /// </summary>
        Absolute = 0x8000,

        /// <summary>
        /// The wheel was moved horizontally, if the mouse has a wheel.
        /// The amount of movement is specified in mouseData.
        /// Windows XP/2000:  This value is not supported.
        /// </summary>
        HWheel = 0x01000,

        /// <summary>
        /// Movement occurred.
        /// </summary>
        Move = 0x0001,

        /// <summary>
        /// The WM_MOUSEMOVE messages will not be coalesced.
        /// The default behavior is to coalesce WM_MOUSEMOVE messages.
        /// Windows XP/2000:  This value is not supported.
        /// </summary>
        MoveNoCoalesce = 0x2000,

        /// <summary>
        /// The left button was pressed.
        /// </summary>
        LeftDown = 0x0002,

        /// <summary>
        /// The left button was released.
        /// </summary>
        LeftUp = 0x0004,

        /// <summary>
        /// The right button was pressed.
        /// </summary>
        RightDown = 0x0008,

        /// <summary>
        /// The right button was released.
        /// </summary>
        RightUp = 0x0010,

        /// <summary>
        /// The middle button was pressed.
        /// </summary>
        MiddleDown = 0x0020,

        /// <summary>
        /// The middle button was released.
        /// </summary>
        MiddleUp = 0x0040,

        /// <summary>
        /// Maps coordinates to the entire desktop.
        /// Must be used with Absolute.
        /// </summary>
        VirtualDesk = 0x4000,

        /// <summary>
        /// The wheel was moved, if the mouse has a wheel.
        /// The amount of movement is specified in mouseData.
        /// </summary>
        Wheel = 0x0800,

        /// <summary>
        /// An X button was pressed.
        /// </summary>
        XDown = 0x0080,

        /// <summary>
        /// An X button was released.
        /// </summary>
        XUp = 0x0100,
    }
}
