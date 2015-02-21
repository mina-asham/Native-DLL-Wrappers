using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NativeDLLWrappers.User32
{
    /// <summary>
    /// The type of the input event.
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms646270(v=vs.85).aspx
    /// </summary>
    public enum InputType : uint
    {
        /// <summary>
        /// The event is a mouse event.
        /// </summary>
        InputMouse = 0,

        /// <summary>
        /// The event is a keyboard event
        /// </summary>
        InputKeyboard = 1,

        /// <summary>
        /// The event is a hardware event.
        /// </summary>
        InputHardware = 2
    }
}
