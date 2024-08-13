using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class UserDetail
    {
        public long UserDetailId { get; set; }
        public long? UserId { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public string? Address { get; set; }
        public string? Website { get; set; }
        public long? AreaOfWorkId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AreaOfWork? AreaOfWork { get; set; }
        public virtual User? CreatedUser { get; set; }
        public virtual User? ModifiedUser { get; set; }
        public virtual User? User { get; set; }
    }
}
