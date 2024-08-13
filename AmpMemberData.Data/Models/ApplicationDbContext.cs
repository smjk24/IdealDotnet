using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AmpMemberData.Data.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AreaOfWork> AreaOfWorks { get; set; } = null!;
        public virtual DbSet<Community> Communities { get; set; } = null!;
        public virtual DbSet<CommunityContact> CommunityContacts { get; set; } = null!;
        public virtual DbSet<CommunityMutualAid> CommunityMutualAids { get; set; } = null!;
        public virtual DbSet<CommunityProjectParticipation> CommunityProjectParticipations { get; set; } = null!;
        public virtual DbSet<CommunityServiceGroup> CommunityServiceGroups { get; set; } = null!;
        public virtual DbSet<CommunityUser> CommunityUsers { get; set; } = null!;
        public virtual DbSet<ContactType> ContactTypes { get; set; } = null!;
        public virtual DbSet<MepsCategory> MepsCategories { get; set; } = null!;
        public virtual DbSet<MutualAid> MutualAids { get; set; } = null!;
        public virtual DbSet<Partner> Partners { get; set; } = null!;
        public virtual DbSet<PartnersContact> PartnersContacts { get; set; } = null!;
        public virtual DbSet<ProjectParticipant> ProjectParticipants { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<ServiceGroup> ServiceGroups { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserContact> UserContacts { get; set; } = null!;
        public virtual DbSet<UserDetail> UserDetails { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<Utility> Utilities { get; set; } = null!;
        public virtual DbSet<UtilityContact> UtilityContacts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.1.34,51626;Initial Catalog=AMPDev;Persist Security Info=True;User ID=sa;\nPassword=Cyspan123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreaOfWork>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.AreaOfWorkCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__AreaOfWor__Creat__4F7CD00D");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.AreaOfWorkModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__AreaOfWor__Modif__5070F446");
            });

            modelBuilder.Entity<Community>(entity =>
            {
                entity.ToTable("Community");

                entity.Property(e => e.CommunityName).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.CommunityCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__Community__Creat__0D7A0286");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.CommunityModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__Community__Modif__0E6E26BF");
            });

            modelBuilder.Entity<CommunityContact>(entity =>
            {
                entity.Property(e => e.ContactNumber).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.CommunityContacts)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("FK__Community__Commu__123EB7A3");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.CommunityContacts)
                    .HasForeignKey(d => d.ContactTypeId)
                    .HasConstraintName("FK__Community__Conta__1332DBDC");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.CommunityContactCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__Community__Creat__14270015");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.CommunityContactModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__Community__Modif__151B244E");
            });

            modelBuilder.Entity<CommunityMutualAid>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.CommunityMutualAids)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("FK__Community__Commu__25518C17");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.CommunityMutualAidCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__Community__Creat__2739D489");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.CommunityMutualAidModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__Community__Modif__282DF8C2");

                entity.HasOne(d => d.MutualAid)
                    .WithMany(p => p.CommunityMutualAids)
                    .HasForeignKey(d => d.MutualAidId)
                    .HasConstraintName("FK__Community__Mutua__2645B050");
            });

            modelBuilder.Entity<CommunityProjectParticipation>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.CommunityProjectParticipations)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("FK__Community__Commu__2BFE89A6");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.CommunityProjectParticipationCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__Community__Creat__2DE6D218");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.CommunityProjectParticipationModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__Community__Modif__2EDAF651");

                entity.HasOne(d => d.ProjectParticipant)
                    .WithMany(p => p.CommunityProjectParticipations)
                    .HasForeignKey(d => d.ProjectParticipantId)
                    .HasConstraintName("FK__Community__Proje__2CF2ADDF");
            });

            modelBuilder.Entity<CommunityServiceGroup>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.CommunityServiceGroups)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("FK__Community__Commu__32AB8735");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.CommunityServiceGroupCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__Community__Creat__3493CFA7");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.CommunityServiceGroupModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__Community__Modif__3587F3E0");

                entity.HasOne(d => d.ServiceGroup)
                    .WithMany(p => p.CommunityServiceGroups)
                    .HasForeignKey(d => d.ServiceGroupId)
                    .HasConstraintName("FK__Community__Servi__339FAB6E");
            });

            modelBuilder.Entity<CommunityUser>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.CommunityUsers)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("FK__Community__Commu__395884C4");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.CommunityUserCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__Community__Creat__3B40CD36");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.CommunityUserModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__Community__Modif__3C34F16F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CommunityUserUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Community__UserI__3A4CA8FD");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.Property(e => e.ContactTypeId).ValueGeneratedNever();

                entity.Property(e => e.ContactTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MepsCategory>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MepsName).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.MepsCategoryCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__MepsCateg__Creat__7D439ABD");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.MepsCategoryModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__MepsCateg__Modif__7E37BEF6");
            });

            modelBuilder.Entity<MutualAid>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MutualAidName).HasMaxLength(100);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.MutualAidCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__MutualAid__Creat__6EF57B66");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.MutualAidModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__MutualAid__Modif__6FE99F9F");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.Property(e => e.ContactNumber).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PartnerName).HasMaxLength(200);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.PartnerCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__Partners__Create__02FC7413");

                entity.HasOne(d => d.MepsCategory)
                    .WithMany(p => p.Partners)
                    .HasForeignKey(d => d.MepsCategoryId)
                    .HasConstraintName("FK__Partners__MepsCa__02084FDA");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.PartnerModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__Partners__Modifi__03F0984C");
            });

            modelBuilder.Entity<PartnersContact>(entity =>
            {
                entity.ToTable("PartnersContact");

                entity.Property(e => e.ContactNumber).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.PartnersContacts)
                    .HasForeignKey(d => d.ContactTypeId)
                    .HasConstraintName("FK__PartnersC__Conta__07C12930");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.PartnersContactCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__PartnersC__Creat__08B54D69");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.PartnersContactModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__PartnersC__Modif__09A971A2");
            });

            modelBuilder.Entity<ProjectParticipant>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectName).HasMaxLength(200);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ProjectParticipantCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__ProjectPa__Creat__73BA3083");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.ProjectParticipantModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__ProjectPa__Modif__74AE54BC");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RoleName).HasMaxLength(100);

                entity.Property(e => e.ViewInContact).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.RoleCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__Roles__CreatedUs__6383C8BA");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.RoleModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__Roles__ModifiedU__6477ECF3");
            });

            modelBuilder.Entity<ServiceGroup>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceGroupName).HasMaxLength(200);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ServiceGroupCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__ServiceGr__Creat__787EE5A0");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.ServiceGroupModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__ServiceGr__Modif__797309D9");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FullName).HasMaxLength(200);

                entity.Property(e => e.IsAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(200);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.InverseCreatedUser)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__Users__CreatedUs__4AB81AF0");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.InverseModifiedUser)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__Users__ModifiedU__4BAC3F29");
            });

            modelBuilder.Entity<UserContact>(entity =>
            {
                entity.Property(e => e.ContactNumber).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.UserContacts)
                    .HasForeignKey(d => d.ContactTypeId)
                    .HasConstraintName("FK__UserConta__Conta__5DCAEF64");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.UserContactCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__UserConta__Creat__5EBF139D");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.UserContactModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__UserConta__Modif__5FB337D6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserContactUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserConta__UserI__5CD6CB2B");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.AreaOfWork)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.AreaOfWorkId)
                    .HasConstraintName("FK__UserDetai__AreaO__5535A963");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.UserDetailCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__UserDetai__Creat__5629CD9C");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.UserDetailModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__UserDetai__Modif__571DF1D5");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDetailUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserDetai__UserI__5441852A");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.UserRoleCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__UserRoles__Creat__6A30C649");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.UserRoleModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__UserRoles__Modif__6B24EA82");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__UserRoles__RoleI__693CA210");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoleUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserRoles__UserI__68487DD7");
            });

            modelBuilder.Entity<Utility>(entity =>
            {
                entity.ToTable("Utility");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.Utilities)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("FK__Utility__Communi__18EBB532");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.UtilityCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__Utility__Created__19DFD96B");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.UtilityModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__Utility__Modifie__1AD3FDA4");
            });

            modelBuilder.Entity<UtilityContact>(entity =>
            {
                entity.Property(e => e.ContactNumber).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.UtilityContacts)
                    .HasForeignKey(d => d.ContactTypeId)
                    .HasConstraintName("FK__UtilityCo__Conta__1F98B2C1");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.UtilityContactCreatedUsers)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK__UtilityCo__Creat__208CD6FA");

                entity.HasOne(d => d.ModifiedUser)
                    .WithMany(p => p.UtilityContactModifiedUsers)
                    .HasForeignKey(d => d.ModifiedUserId)
                    .HasConstraintName("FK__UtilityCo__Modif__2180FB33");

                entity.HasOne(d => d.Utility)
                    .WithMany(p => p.UtilityContacts)
                    .HasForeignKey(d => d.UtilityId)
                    .HasConstraintName("FK__UtilityCo__Utili__1EA48E88");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
