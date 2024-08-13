using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class UserRole
    {
        public long UserRoleId { get; set; }
        public long? UserId { get; set; }
        public long? RoleId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? CreatedUser { get; set; }
        public virtual User? ModifiedUser { get; set; }
        public virtual Role? Role { get; set; }
        public virtual User? User { get; set; }
    }
}
