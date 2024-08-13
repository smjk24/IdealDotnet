using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class ServiceGroup
    {
        public ServiceGroup()
        {
            CommunityServiceGroups = new HashSet<CommunityServiceGroup>();
        }

        public long ServiceGroupId { get; set; }
        public string? ServiceGroupName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? CreatedUser { get; set; }
        public virtual User? ModifiedUser { get; set; }
        public virtual ICollection<CommunityServiceGroup> CommunityServiceGroups { get; set; }
    }
}
