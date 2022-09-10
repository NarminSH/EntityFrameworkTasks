using System;
using System.Collections.Generic;

namespace CrudApp1.Models
{
    public partial class CaptureDdlevent
    {
        public DateTime EventDate { get; set; }
        public string? EventType { get; set; }
        public string? EventDdl { get; set; }
        public string? EventXml { get; set; }
        public string? DatabaseName { get; set; }
        public string? SchemaName { get; set; }
        public string? ObjectName { get; set; }
        public string? HostName { get; set; }
        public string? Ipaddress { get; set; }
        public string? ProgramName { get; set; }
        public string? LoginName { get; set; }
    }
}
