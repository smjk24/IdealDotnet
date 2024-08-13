using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class Community
    {
        public Community()
        {
            CommunityContacts = new HashSet<CommunityContact>();
            CommunityMutualAids = new HashSet<CommunityMutualAid>();
            CommunityProjectParticipations = new HashSet<CommunityProjectParticipation>();
            CommunityServiceGroups = new HashSet<CommunityServiceGroup>();
            CommunityUsers = new HashSet<CommunityUser>();
            Utilities = new HashSet<Utility>();
        }

        public long CommunityId { get; set; }
        public string? CommunityName { get; set; }
        public string? CommunityAddress { get; set; }
        public string? UtilityName { get; set; }
        public string? UtilityAddress { get; set; }
        public string? Website { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? CreatedUser { get; set; }
        public virtual User? ModifiedUser { get; set; }
        public virtual ICollection<CommunityContact> CommunityContacts { get; set; }
        public virtual ICollection<CommunityMutualAid> CommunityMutualAids { get; set; }
        public virtual ICollection<CommunityProjectParticipation> CommunityProjectParticipations { get; set; }
        public virtual ICollection<CommunityServiceGroup> CommunityServiceGroups { get; set; }
        public virtual ICollection<CommunityUser> CommunityUsers { get; set; }
        public virtual ICollection<Utility> Utilities { get; set; }
    }
}
