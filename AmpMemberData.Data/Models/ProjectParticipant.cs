using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class ProjectParticipant
    {
        public ProjectParticipant()
        {
            CommunityProjectParticipations = new HashSet<CommunityProjectParticipation>();
        }

        public long ProjectParticipantId { get; set; }
        public string? ProjectName { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? CreatedUser { get; set; }
        public virtual User? ModifiedUser { get; set; }
        public virtual ICollection<CommunityProjectParticipation> CommunityProjectParticipations { get; set; }
    }
}
