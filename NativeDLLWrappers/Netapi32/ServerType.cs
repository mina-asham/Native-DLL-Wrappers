namespace NativeDLLWrappers.Netapi32
{
    /// <summary>
    /// A value that filters the server entries
    /// to return from the enumeration in NetServerEnum.
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/aa370623(v=vs.85).aspx
    /// </summary>
    public enum ServerType : uint
    {
        /// <summary>
        /// All workstations.
        /// </summary>
        Workstation = 0x00000001,

        /// <summary>
        /// All computers that run the Server service.
        /// </summary>
        Server = 0x00000002,

        /// <summary>
        /// Any server that runs an instance of Microsoft SQL Server.
        /// </summary>
        SqlServer = 0x00000004,

        /// <summary>
        /// A server that is primary domain controller.
        /// </summary>
        DomainCtrl = 0x00000008,

        /// <summary>
        /// Any server that is a backup domain controller.
        /// </summary>
        DomainBackCtrl = 0x00000010,

        /// <summary>
        /// Any server that runs the Timesource service.
        /// </summary>
        TimeSource = 0x00000020,

        /// <summary>
        /// Any server that runs the Apple
        /// Filing Protocol (AFP) file service.
        /// </summary>
        AFP = 0x00000040,

        /// <summary>
        /// Any server that is a Novell server.
        /// </summary>
        Novell = 0x00000080,

        /// <summary>
        /// Any computer that is LAN Manager 2.x domain member.
        /// </summary>
        DomainMember = 0x00000100,

        /// <summary>
        /// Any computer that shares a print queue.
        /// </summary>
        PrintQServer = 0x00000200,

        /// <summary>
        /// Any server that runs a dial-in service.
        /// </summary>
        DialinServer = 0x00000400,

        /// <summary>
        /// Any server that is a Xenix server.
        /// </summary>
        XenixServer = 0x00000800,

        /// <summary>
        /// Any server that is a UNIX server.
        /// This is the same as the XenixServer.
        /// </summary>
        ServerUnix = 0x00000800,

        /// <summary>
        /// A workstation or server.
        /// </summary>
        NT = 0x00001000,

        /// <summary>
        /// Any computer that runs Windows for Workgroups.
        /// </summary>
        WFW = 0x00002000,

        /// <summary>
        /// Any server that runs the Microsoft
        /// File and Print for NetWare service.
        /// </summary>
        ServerMFPN = 0x00004000,

        /// <summary>
        /// Any server that is not a domain controller.
        /// </summary>
        ServerNT = 0x00008000,

        /// <summary>
        /// Any computer that can run the browser service.
        /// </summary>
        PotentialBrowser = 0x00010000,

        /// <summary>
        /// A computer that runs a browser service as backup.
        /// </summary>
        BackupBrowser = 0x00020000,

        /// <summary>
        /// A computer that runs the master browser service.
        /// </summary>
        MasterBrowser = 0x00040000,

        /// <summary>
        /// A computer that runs the domain master browser.
        /// </summary>
        DomainMaster = 0x00080000,

        /// <summary>
        /// A computer that runs OSF/1.
        /// </summary>
        ServerOSF = 0x00100000,

        /// <summary>
        /// A computer that runs Open Virtual Memory System (VMS).
        /// </summary>
        ServerVMS = 0x00200000,

        /// <summary>
        /// A computer that runs Windows.
        /// </summary>
        Windows = 0x00400000,

        /// <summary>
        /// A computer that is the root of
        /// Ditributed File System (DFS) tree.
        /// </summary>
        DFS = 0x00800000,

        /// <summary>
        /// Server clusters available in the domain.
        /// </summary>
        ClusterNT = 0x01000000,

        /// <summary>
        /// A server running the Terminal Server service.
        /// </summary>
        TerminalServer = 0x02000000,

        /// <summary>
        /// Cluster virtual servers available in the domain.
        /// Windows 2000: This is not supported.
        /// </summary>
        ClusterVsNT = 0x04000000,

        /// <summary>
        /// A computer that runs IBM Directory and
        /// Sercurity Services (DSS) or equivalent.
        /// </summary>
        DCE = 0x10000000,

        /// <summary>
        /// A computer that over an alternate transport.
        /// </summary>
        AlternateXport = 0x20000000,

        /// <summary>
        /// Any computer maintained in a list by the browser.
        /// </summary>
        LocalListOnly = 0x40000000,

        /// <summary>
        /// The primary domain
        /// </summary>
        DomainEnum = 0x80000000,

        /// <summary>
        /// All servers. This is a convenience
        /// that will return all possible servers.
        /// </summary>
        All = 0xFFFFFFFF
    }
}
