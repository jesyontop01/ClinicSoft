using System;
using System.Collections.Generic;

namespace ClinicSoft.DalLayer.Models
{
    public partial class CoreDistributedCache
    {
        public string Id { get; set; } = null!;
        public byte[] Value { get; set; } = null!;
        public DateTimeOffset ExpiresAtTime { get; set; }
        public long? SlidingExpirationInSeconds { get; set; }
        public DateTimeOffset? AbsoluteExpiration { get; set; }
    }
}
