using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class MutualAid
    {
        public MutualAid()
        {
            CommunityMutualAids = new HashSet<CommunityMutualAid>();
        }

        public long MutualAidId { get; set; }
        public string? MutualAidName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? CreatedUser { get; set; }
        public virtual User? ModifiedUser { get; set; }
        public virtual ICollection<CommunityMutualAid> CommunityMutualAids { get; set; }
    }
}
