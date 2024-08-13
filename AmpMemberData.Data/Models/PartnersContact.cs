using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class PartnersContact
    {
        public long PartnersContactId { get; set; }
        public int? ContactTypeId { get; set; }
        public string? ContactNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ContactType? ContactType { get; set; }
        public virtual User? CreatedUser { get; set; }
        public virtual User? ModifiedUser { get; set; }
    }
}
