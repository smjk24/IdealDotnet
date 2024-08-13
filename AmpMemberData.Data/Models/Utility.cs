using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class Utility
    {
        public Utility()
        {
            UtilityContacts = new HashSet<UtilityContact>();
        }

        public long UtilityId { get; set; }
        public string? UtilityName { get; set; }
        public string? UtilityAddress { get; set; }
        public long? CommunityId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Community? Community { get; set; }
        public virtual User? CreatedUser { get; set; }
        public virtual User? ModifiedUser { get; set; }
        public virtual ICollection<UtilityContact> UtilityContacts { get; set; }
    }
}
