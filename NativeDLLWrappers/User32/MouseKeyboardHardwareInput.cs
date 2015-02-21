using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NativeDLLWrappers.User32
{
    /// <summary>
    /// The information about a simulated event.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct MouseKeyboardHardwareInput
    {
        /// <summary>
        /// The information about a simulated mouse event.
        /// </summary>
        [FieldOffset(0)]
        public MouseInput MouseInput;

        /// <summary>
        /// The information about a simulated keyboard event.
        /// </summary>
        [FieldOffset(0)]
        public KeyboardInput KeyboardInput;

        /// <summary>
        /// The information about a simulated hardware event.
        /// </summary>
        [FieldOffset(0)]
        public HardwareInput HardwareInput;
    }
}
