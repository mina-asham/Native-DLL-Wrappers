namespace NativeDLLWrappers.Netapi32
{
    /// <summary>
    /// NetServerEnum function return value.
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/aa370623(v=vs.85).aspx
    /// </summary>
    public enum NetApiStatus : uint
    {
        /// <summary>
        /// Function succeeds.
        /// </summary>
        NerrSuccess = 0,

        /// <summary>
        /// Access was denied.
        /// </summary>
        ErrorAccessDenied = 5,

        /// <summary>
        /// The parameter is incorrect.
        /// </summary>
        ErrorInvalidParameter = 87,

        /// <summary>
        /// More entries are available. Specify a large
        /// enough buffer to receive all entries.
        /// </summary>
        ErrorMoreData = 234,

        /// <summary>
        /// No browser servers found.
        /// </summary>
        ErrorNoBrowserServersFound = 6118,

        /// <summary>
        /// The request is not supported.
        /// </summary>
        ErrorNotSupported = 50,

        /// <summary>
        /// A remote error occurred with
        /// no data returned by the server.
        /// </summary>
        NerrRemoteErr = 2127,

        /// <summary>
        /// The server service is not started.
        /// </summary>
        NerrServerNotStarted = 2114,

        /// <summary>
        /// The service has not been started
        /// </summary>
        NerrServiceNotInstalled = 2184,

        /// <summary>
        /// The Workstation service has not been started.
        /// The local workstation service is used to
        /// communicate with a downlevel remote server.
        /// </summary>
        NerrWkstaNotStarted = 2138
    }
}
