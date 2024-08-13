using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        public long RoleId { get; set; }
        public string? RoleName { get; set; }
        public bool? ViewInContact { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? CreatedUser { get; set; }
        public virtual User? ModifiedUser { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
