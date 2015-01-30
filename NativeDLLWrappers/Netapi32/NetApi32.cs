using System;
using System.Runtime.InteropServices;

namespace NativeDLLWrappers.Netapi32
{
    public static class NetApi32
    {
        /// <summary>
        /// The maximum value for a uint.
        /// https://msdn.microsoft.com/en-us/library/cc247107.aspx
        /// </summary>
        public const uint MaxPreferredLength = 0xFFFFFFFF;

        /// <summary>
        /// The NetServerEnum function lists all servers of
        /// the specifiedtype that are visible in a domain.
        /// https://msdn.microsoft.com/en-us/library/windows/desktop/aa370623(v=vs.85).aspx
        /// </summary>
        /// <param name="serverName">
        ///     Reserved; must be NULL.
        /// </param>
        /// <param name="level">
        ///     The information level of the data requested.
        /// </param>
        /// <param name="bufferPtr">
        ///     A pointer to the buffer that receives the data.
        ///     The format of this data depends on the 
        ///     value of the level parameter.
        ///     This buffer is allocated by the system and must
        ///     be freed using the NetApiBufferFree function.
        ///     Note that you must free the buffer even if
        ///     the function fails with ErrorMoreData.
        /// </param>
        /// <param name="maximumPreferredLength">
        ///     The preferred maximum length of returned data, in bytes.
        ///     If you specify MaxPreferredLength, the function allocates
        ///     the amount of memory required for the data. If you 
        ///     specify another value in this parameter, it can
        ///     restrict the number of bytes that the function returns.
        ///     If the buffer size is insufficient to hold all entries,
        ///     the function returns ErrorMoreData.
        /// </param>
        /// <param name="entriesRead">
        ///     The count of elements actually enumerated.
        /// </param>
        /// <param name="totalEntries">
        ///     The total number of visible servers
        ///     and workstations on the network.
        ///     Note that applications should consider
        ///     this value only a hint.
        /// </param>
        /// <param name="serverType">
        ///     A value that filters the server entries
        ///     to return from the enumeration.
        /// </param>
        /// <param name="domain">
        ///     The name of the domain for which a list of servers
        ///     is to be returned. The domain name must be a NetBIOS
        ///     domain name (for example, microsoft). The NetServerEnum
        ///     function does not support DNS-style names
        ///     (for example, microsoft.com).
        ///     If this parameter is NULL, the primary domain is implied.
        /// </param>
        /// <param name="resumeHandle">
        ///     Reserved; must be set to zero.
        /// </param>
        /// <returns>NetApiStatus code</returns>
        [DllImport("Netapi32.dll")]
        public static extern NetApiStatus NetServerEnum(
            String serverName,
            Level level,
            out IntPtr bufferPtr,
            uint maximumPreferredLength,
            out uint entriesRead,
            out uint totalEntries,
            ServerType serverType,
            string domain,
            ref uint resumeHandle
        );

        /// <summary>
        /// The NetApiBufferFree function frees the memory that the
        /// NetApiBufferAllocate function allocates. Applications should
        /// also call NetApiBufferFree to free the memory that other
        /// network management functions use internally to return information.
        /// https://msdn.microsoft.com/en-us/library/windows/desktop/aa370304(v=vs.85).aspx
        /// </summary>
        /// <param name="bufferPtr">
        ///     A pointer to a buffer returned previously by another
        ///     network management function or memory allocated by
        ///     calling the NetApiBufferAllocate function.
        /// </param>
        /// <returns>NetApiStatus code</returns>
        [DllImport("Netapi32.dll")]
        public static extern NetApiStatus NetApiBufferFree(IntPtr bufferPtr);
    }
}
