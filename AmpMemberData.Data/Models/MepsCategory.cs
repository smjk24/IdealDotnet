using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class MepsCategory
    {
        public MepsCategory()
        {
            Partners = new HashSet<Partner>();
        }

        public long MepsCategoryId { get; set; }
        public string? MepsName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? CreatedUser { get; set; }
        public virtual User? ModifiedUser { get; set; }
        public virtual ICollection<Partner> Partners { get; set; }
    }
}
