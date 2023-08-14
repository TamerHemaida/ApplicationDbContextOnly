using ApplicationDbContextOnly.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApplicationDbContextOnly.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        #region Domain Models
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<PdfFile> Files { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<PhotoCopyCenter> PhotoCopyCenters { get; set; }
        public virtual DbSet<PrintOrder> PrintOrders { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EnglishWord> EnglishWords { get; set; }
        public virtual DbSet<PrintOrderModelView> PrintOrderModelView { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PrintOrderModelView>(e => { e.HasNoKey().ToView(null); });
            #region Change Basic Tables
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").Ignore(c => c.PhoneNumber).Ignore(c => c.PhoneNumberConfirmed);

           builder.Entity<PdfFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_FileId");

                entity.Property(e => e.FileName)
                    .HasMaxLength(400)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");


                entity.Property(e => e.PhysicalFileName)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.UploadDate).HasColumnType("datetime");
            });

           builder.Entity<Major>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.MajorArName)
                    .IsRequired()
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.MajorEnName)
                    .IsRequired()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

           builder.Entity<PhotoCopyCenter>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(150)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");


                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.IsDefaultForApplicationDbContextOnly)
                   .IsRequired()
                   .IsUnicode(false)
                   .HasDefaultValueSql("0")
                   .HasColumnType("bit");
            });

           builder.Entity<PrintOrder>(entity =>
            {
                entity.HasKey(e => new { e.PrintOrderId })
                    .HasName("PK_PrintOrder_PrintOrderId");

                entity.Property(e => e.PrintOrderId).ValueGeneratedOnAdd();

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(true)
                    .UseCollation("Arabic_CI_AS");


                entity.Property(e => e.DepartmentManagerDecision)
                    .IsRequired()
                    .HasMaxLength(15)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");


                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.OrderRegisterDate).HasColumnType("datetime");

                entity.Property(e => e.Orientation)
                    .IsRequired()
                    .HasMaxLength(10)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PageSize)
                 .IsRequired()
                 .HasMaxLength(3)
                 .IsUnicode(false)
                 .UseCollation("SQL_Latin1_General_CP1_CI_AS");


                entity.Property(e => e.PrintSide)
                    .IsRequired()
                    .HasMaxLength(10)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Stapling)
                    .IsRequired()
                    .HasMaxLength(3)
                    .UseCollation("Arabic_CI_AS");
            });
            #endregion


            SeedUsers(builder);
            builder.Entity<IdentityRole>().HasData(
               new IdentityRole()
               {
                   Id = "c94eb536-cba2-4d3e-95e5-148277072706",
                   ConcurrencyStamp = "c94eb536-cba2-4d3e-95e5-148277072706",
                   Name = "Users",
                   NormalizedName = "Users".ToUpper()
               },
               new IdentityRole()
               {
                   Id = "7c5ea8c3-1ba4-4845-b173-e874682de4f2",
                   ConcurrencyStamp = "7c5ea8c3-1ba4-4845-b173-e874682de4f2",
                   Name = "Admins",
                   NormalizedName = "Admins".ToUpper(),
               });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "7c5ea8c3-1ba4-4845-b173-e874682de4f2", UserId = "326aaa65-f69d-48ca-8bb7-031bb7fb8abb" }
                );        
        }

        private void SeedUsers(ModelBuilder builder)
        {
            ApplicationUser user = new ApplicationUser()
            {
                Id = "326aaa65-f69d-48ca-8bb7-031bb7fb8abb",
                UserName = "sysadmin@sysadmin.com",
                NormalizedUserName = "sysadmin@sysadmin.com".ToUpper(),
                Email = "sysadmin@sysadmin.com",
                NormalizedEmail = "sysadmin@sysadmin.com".ToUpper(),
                LockoutEnabled = false,
                EmailConfirmed = true,
            };
            user.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(user, "Aa@123321");
            builder.Entity<ApplicationUser>().HasData(user);
        }

    }
}
