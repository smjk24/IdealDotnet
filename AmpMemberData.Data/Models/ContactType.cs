using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class ContactType
    {
        public ContactType()
        {
            CommunityContacts = new HashSet<CommunityContact>();
            PartnersContacts = new HashSet<PartnersContact>();
            UserContacts = new HashSet<UserContact>();
            UtilityContacts = new HashSet<UtilityContact>();
        }

        public int ContactTypeId { get; set; }
        public string? ContactTypeName { get; set; }

        public virtual ICollection<CommunityContact> CommunityContacts { get; set; }
        public virtual ICollection<PartnersContact> PartnersContacts { get; set; }
        public virtual ICollection<UserContact> UserContacts { get; set; }
        public virtual ICollection<UtilityContact> UtilityContacts { get; set; }
    }
}
