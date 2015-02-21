﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NativeDLLWrappers.User32
{
    /// <summary>
    /// Contains information about a simulated message generated by an input device other than a keyboard or mouse.
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms646269(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct HardwareInput
    {
        /// <summary>
        /// The message generated by the input hardware.
        /// </summary>
        public uint uMsg;

        /// <summary>
        /// The low-order word of the lParam parameter for uMsg.
        /// </summary>
        public ushort wParamL;

        /// <summary>
        /// The high-order word of the lParam parameter for uMsg.
        /// </summary>
        public ushort wParamH;
    }
}