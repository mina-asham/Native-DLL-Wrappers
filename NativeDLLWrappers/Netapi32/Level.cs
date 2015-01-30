namespace NativeDLLWrappers.Netapi32
{
    /// <summary>
    /// The information level of the data requested in NetServerEnum.
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/aa370623(v=vs.85).aspx
    /// </summary>
    public enum Level : uint
    {
        /// <summary>
        /// Returns server names and platform information.
        /// The bufPrt parameter points to an array of
        /// ServerInfo100 structures.
        /// </summary>
        ServerInfo100 = 100,

        /// <summary>
        /// Returns server names, types, and associated data.
        /// The bufPrt parameter points to an array of
        /// ServerInfo101 structures.
        /// </summary>
        ServerInfo101 = 101
    }
}
