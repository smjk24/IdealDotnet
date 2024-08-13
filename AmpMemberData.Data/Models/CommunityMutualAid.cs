using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class CommunityMutualAid
    {
        public long CommunityMutualAidId { get; set; }
        public long? CommunityId { get; set; }
        public long? MutualAidId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Community? Community { get; set; }
        public virtual User? CreatedUser { get; set; }
        public virtual User? ModifiedUser { get; set; }
        public virtual MutualAid? MutualAid { get; set; }
    }
}
