using System.Runtime.InteropServices;

namespace NativeDLLWrappers.Netapi32
{
    /// <summary>
    /// The ServerInfo101 structure contains information
    /// about the specified server, including name, platform,
    /// type of server, and associated software.
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/aa370903(v=vs.85).aspx
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct ServerInfo101
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

        /// <summary>
        /// The major version number and the server type.
        /// </summary>
        public uint VersionMajor;

        /// <summary>
        /// The minor release version number of the operating system.
        /// </summary>
        public uint VersionMinor;

        /// <summary>
        /// The type of software the computer is running.
        /// </summary>
        public ServerType Type;

        /// <summary>
        /// A comment describing the server. The comment can be null.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string Comment;
    }
}
