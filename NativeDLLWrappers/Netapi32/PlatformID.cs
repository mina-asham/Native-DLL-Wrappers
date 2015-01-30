namespace NativeDLLWrappers.Netapi32
{
    /// <summary>
    /// The information level to user for platform-specific information.
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/aa370897(v=vs.85).aspx
    /// </summary>
    public enum PlatformID : uint
    {
        /// <summary>
        /// The MS-DOS platform.
        /// </summary>
        DOS = 300,

        /// <summary>
        /// The OS/2 platform.
        /// </summary>
        OS2 = 400,

        /// <summary>
        /// The Windows NT platform.
        /// </summary>
        NT = 500,

        /// <summary>
        /// The OSF platform.
        /// </summary>
        OSF = 600,

        /// <summary>
        /// The VMS platform.
        /// </summary>
        VMS = 700
    }
}
