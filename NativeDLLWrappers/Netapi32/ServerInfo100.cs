using System.Runtime.InteropServices;

namespace NativeDLLWrappers.Netapi32
{
    /// <summary>
    /// The ServerInfo100 structure contains information about
    /// the specified server, including the name and platform.
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/aa370897(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ServerInfo100
    {
        /// <summary>
        /// The platform type of the server.
        /// </summary>
        public PlatformID PlatformId;

        /// <summary>
        /// The name of the server.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string Name;
    }
}
