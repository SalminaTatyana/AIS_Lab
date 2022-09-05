using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AIS_Lab.Database
{
    public partial class ScientiaDBContext : DbContext
    {
        public ScientiaDBContext()
        {
        }

        public ScientiaDBContext(DbContextOptions<ScientiaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<ApplicationsView> ApplicationsViews { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<FilesView> FilesViews { get; set; }
        public virtual DbSet<Right> Rights { get; set; }
        public virtual DbSet<RightView> RightViews { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SectionsOfTheSite> SectionsOfTheSites { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRight> UserRights { get; set; }
        public virtual DbSet<UserRightsView> UserRightsViews { get; set; }
        public virtual DbSet<UsersView> UsersViews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server = Dev1-srv.aisgorod.ru; Database = hacks; User= dev; Password = f,shdfku; TrustServerCertificate=True; Trusted_Connection = False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Application>(entity =>
            {
                entity.Property(e => e.Course).IsUnicode(false);

                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FacultyName).IsUnicode(false);

                entity.Property(e => e.FieldOfActivity).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.GitLink).IsUnicode(false);

                entity.Property(e => e.InstituteName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MiddleName).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.SkypeName).IsUnicode(false);

                entity.Property(e => e.SpecializationName).IsUnicode(false);

                entity.Property(e => e.WorkExperience).IsUnicode(false);

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Applications_SectionsOfTheSite");
            });

            modelBuilder.Entity<ApplicationsView>(entity =>
            {
                entity.ToView("ApplicationsView", "scientia");

                entity.Property(e => e.Course).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FacultyName).IsUnicode(false);

                entity.Property(e => e.FieldOfActivity).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.GitLink).IsUnicode(false);

                entity.Property(e => e.InstituteName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MiddleName).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.SectionName).IsUnicode(false);

                entity.Property(e => e.SkypeName).IsUnicode(false);

                entity.Property(e => e.SpecializationName).IsUnicode(false);

                entity.Property(e => e.WorkExperience).IsUnicode(false);
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.HasOne(d => d.FileSection)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.FileSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Files_SectionsOfTheSite");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Files_Users");
            });

            modelBuilder.Entity<FilesView>(entity =>
            {
                entity.ToView("FilesView", "scientia");

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.SectionName).IsUnicode(false);
            });

            modelBuilder.Entity<Right>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<RightView>(entity =>
            {
                entity.ToView("RightView", "scientia");

                entity.Property(e => e.RightName).IsUnicode(false);

                entity.Property(e => e.RoleName).IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<SectionsOfTheSite>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MiddleName).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Roles");
            });

            modelBuilder.Entity<UserRight>(entity =>
            {
                entity.HasOne(d => d.Right)
                    .WithMany(p => p.UserRights)
                    .HasForeignKey(d => d.RightId)
                    .HasConstraintName("FK_UserRights_Right");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRights)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRights_Users");
            });

            modelBuilder.Entity<UserRightsView>(entity =>
            {
                entity.ToView("UserRightsView", "scientia");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Fio).IsUnicode(false);

                entity.Property(e => e.RightName).IsUnicode(false);
            });

            modelBuilder.Entity<UsersView>(entity =>
            {
                entity.ToView("UsersView", "scientia");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MiddleName).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.RoleName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
