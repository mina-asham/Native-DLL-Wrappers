using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NativeDLLWrappers.User32
{
    /// <summary>
    /// Specifies various aspects of a keystroke.
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms646271(v=vs.85).aspx
    /// </summary>
    public enum KeyboardEventFlag : uint
    {
        /// <summary>
        /// If specified, the scan code was preceded by a prefix byte that has the value 0xE0 (224).
        /// </summary>
        ExtendedKey = 0x0001,

        /// <summary>
        /// If specified, the key is being released. If not specified, the key is being pressed.
        /// </summary>
        KeyUp = 0x0002,

        /// <summary>
        /// If specified, wScan identifies the key and wVk is ignored.
        /// </summary>
        Scancode = 0x0008,

        /// <summary>
        /// If specified, the system synthesizes a VK_PACKET keystroke.
        /// The wVk parameter must be zero. This flag can only be combined
        /// with the KeyUp flag.
        /// </summary>
        Unicode = 0x0004
    }
}
