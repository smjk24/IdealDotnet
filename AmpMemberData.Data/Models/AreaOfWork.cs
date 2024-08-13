using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class AreaOfWork
    {
        public AreaOfWork()
        {
            UserDetails = new HashSet<UserDetail>();
        }

        public long AreaOfWorkId { get; set; }
        public string? AreaDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? CreatedUser { get; set; }
        public virtual User? ModifiedUser { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}
