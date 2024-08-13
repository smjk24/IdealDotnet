using System;
using System.Collections.Generic;

namespace AmpMemberData.Data.Models
{
    public partial class User
    {
        public User()
        {
            AreaOfWorkCreatedUsers = new HashSet<AreaOfWork>();
            AreaOfWorkModifiedUsers = new HashSet<AreaOfWork>();
            CommunityContactCreatedUsers = new HashSet<CommunityContact>();
            CommunityContactModifiedUsers = new HashSet<CommunityContact>();
            CommunityCreatedUsers = new HashSet<Community>();
            CommunityModifiedUsers = new HashSet<Community>();
            CommunityMutualAidCreatedUsers = new HashSet<CommunityMutualAid>();
            CommunityMutualAidModifiedUsers = new HashSet<CommunityMutualAid>();
            CommunityProjectParticipationCreatedUsers = new HashSet<CommunityProjectParticipation>();
            CommunityProjectParticipationModifiedUsers = new HashSet<CommunityProjectParticipation>();
            CommunityServiceGroupCreatedUsers = new HashSet<CommunityServiceGroup>();
            CommunityServiceGroupModifiedUsers = new HashSet<CommunityServiceGroup>();
            CommunityUserCreatedUsers = new HashSet<CommunityUser>();
            CommunityUserModifiedUsers = new HashSet<CommunityUser>();
            CommunityUserUsers = new HashSet<CommunityUser>();
            InverseCreatedUser = new HashSet<User>();
            InverseModifiedUser = new HashSet<User>();
            MepsCategoryCreatedUsers = new HashSet<MepsCategory>();
            MepsCategoryModifiedUsers = new HashSet<MepsCategory>();
            MutualAidCreatedUsers = new HashSet<MutualAid>();
            MutualAidModifiedUsers = new HashSet<MutualAid>();
            PartnerCreatedUsers = new HashSet<Partner>();
            PartnerModifiedUsers = new HashSet<Partner>();
            PartnersContactCreatedUsers = new HashSet<PartnersContact>();
            PartnersContactModifiedUsers = new HashSet<PartnersContact>();
            ProjectParticipantCreatedUsers = new HashSet<ProjectParticipant>();
            ProjectParticipantModifiedUsers = new HashSet<ProjectParticipant>();
            RoleCreatedUsers = new HashSet<Role>();
            RoleModifiedUsers = new HashSet<Role>();
            ServiceGroupCreatedUsers = new HashSet<ServiceGroup>();
            ServiceGroupModifiedUsers = new HashSet<ServiceGroup>();
            UserContactCreatedUsers = new HashSet<UserContact>();
            UserContactModifiedUsers = new HashSet<UserContact>();
            UserContactUsers = new HashSet<UserContact>();
            UserDetailCreatedUsers = new HashSet<UserDetail>();
            UserDetailModifiedUsers = new HashSet<UserDetail>();
            UserDetailUsers = new HashSet<UserDetail>();
            UserRoleCreatedUsers = new HashSet<UserRole>();
            UserRoleModifiedUsers = new HashSet<UserRole>();
            UserRoleUsers = new HashSet<UserRole>();
            UtilityContactCreatedUsers = new HashSet<UtilityContact>();
            UtilityContactModifiedUsers = new HashSet<UtilityContact>();
            UtilityCreatedUsers = new HashSet<Utility>();
            UtilityModifiedUsers = new HashSet<Utility>();
        }

        public long UserId { get; set; }
        public string? UserName { get; set; }
        public string? PassWord { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public bool? IsAdmin { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedUserId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User? CreatedUser { get; set; }
        public virtual User? ModifiedUser { get; set; }
        public virtual ICollection<AreaOfWork> AreaOfWorkCreatedUsers { get; set; }
        public virtual ICollection<AreaOfWork> AreaOfWorkModifiedUsers { get; set; }
        public virtual ICollection<CommunityContact> CommunityContactCreatedUsers { get; set; }
        public virtual ICollection<CommunityContact> CommunityContactModifiedUsers { get; set; }
        public virtual ICollection<Community> CommunityCreatedUsers { get; set; }
        public virtual ICollection<Community> CommunityModifiedUsers { get; set; }
        public virtual ICollection<CommunityMutualAid> CommunityMutualAidCreatedUsers { get; set; }
        public virtual ICollection<CommunityMutualAid> CommunityMutualAidModifiedUsers { get; set; }
        public virtual ICollection<CommunityProjectParticipation> CommunityProjectParticipationCreatedUsers { get; set; }
        public virtual ICollection<CommunityProjectParticipation> CommunityProjectParticipationModifiedUsers { get; set; }
        public virtual ICollection<CommunityServiceGroup> CommunityServiceGroupCreatedUsers { get; set; }
        public virtual ICollection<CommunityServiceGroup> CommunityServiceGroupModifiedUsers { get; set; }
        public virtual ICollection<CommunityUser> CommunityUserCreatedUsers { get; set; }
        public virtual ICollection<CommunityUser> CommunityUserModifiedUsers { get; set; }
        public virtual ICollection<CommunityUser> CommunityUserUsers { get; set; }
        public virtual ICollection<User> InverseCreatedUser { get; set; }
        public virtual ICollection<User> InverseModifiedUser { get; set; }
        public virtual ICollection<MepsCategory> MepsCategoryCreatedUsers { get; set; }
        public virtual ICollection<MepsCategory> MepsCategoryModifiedUsers { get; set; }
        public virtual ICollection<MutualAid> MutualAidCreatedUsers { get; set; }
        public virtual ICollection<MutualAid> MutualAidModifiedUsers { get; set; }
        public virtual ICollection<Partner> PartnerCreatedUsers { get; set; }
        public virtual ICollection<Partner> PartnerModifiedUsers { get; set; }
        public virtual ICollection<PartnersContact> PartnersContactCreatedUsers { get; set; }
        public virtual ICollection<PartnersContact> PartnersContactModifiedUsers { get; set; }
        public virtual ICollection<ProjectParticipant> ProjectParticipantCreatedUsers { get; set; }
        public virtual ICollection<ProjectParticipant> ProjectParticipantModifiedUsers { get; set; }
        public virtual ICollection<Role> RoleCreatedUsers { get; set; }
        public virtual ICollection<Role> RoleModifiedUsers { get; set; }
        public virtual ICollection<ServiceGroup> ServiceGroupCreatedUsers { get; set; }
        public virtual ICollection<ServiceGroup> ServiceGroupModifiedUsers { get; set; }
        public virtual ICollection<UserContact> UserContactCreatedUsers { get; set; }
        public virtual ICollection<UserContact> UserContactModifiedUsers { get; set; }
        public virtual ICollection<UserContact> UserContactUsers { get; set; }
        public virtual ICollection<UserDetail> UserDetailCreatedUsers { get; set; }
        public virtual ICollection<UserDetail> UserDetailModifiedUsers { get; set; }
        public virtual ICollection<UserDetail> UserDetailUsers { get; set; }
        public virtual ICollection<UserRole> UserRoleCreatedUsers { get; set; }
        public virtual ICollection<UserRole> UserRoleModifiedUsers { get; set; }
        public virtual ICollection<UserRole> UserRoleUsers { get; set; }
        public virtual ICollection<UtilityContact> UtilityContactCreatedUsers { get; set; }
        public virtual ICollection<UtilityContact> UtilityContactModifiedUsers { get; set; }
        public virtual ICollection<Utility> UtilityCreatedUsers { get; set; }
        public virtual ICollection<Utility> UtilityModifiedUsers { get; set; }
    }
}
