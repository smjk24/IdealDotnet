using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class Partner
    {
        public long PartnerId { get; set; }
        public long? MepsCategoryId { get; set; }
        public string? PartnerName { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? Website { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? LogoUrl { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? CreatedUser { get; set; }
        public virtual MepsCategory? MepsCategory { get; set; }
        public virtual User? ModifiedUser { get; set; }
    }
}
