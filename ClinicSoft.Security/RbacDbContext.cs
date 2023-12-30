using System;
//using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using ClinicSoft.ServerModel;
using Audit.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Audit.Core;
using ClinicSoft.Security.Helpers;

namespace ClinicSoft.Security
{
    public class RbacDbContext : AuditDbContext
    {
        //public RbacDbContext(string connString)
        //    : base(connString)
        //{
        //    this.Configuration.LazyLoadingEnabled = true;
        //    this.Configuration.ProxyCreationEnabled = false;
        //}
        //public RbacDbContext()
        //{
                
        //}
        private readonly ConnectionString _configuration;

        private readonly string connStr = null;
        public RbacDbContext(string conn)
        {
            connStr = conn;
        }
        public RbacDbContext(DbContextOptions<RbacDbContext> options, ConnectionString configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //var connectionString = connStr;
                optionsBuilder.UseSqlServer(connStr);
            }
        }
        public DbSet<RbacApplication> Applications { get; set; }
        public DbSet<RbacPermission> Permissions { get; set; }
        public DbSet<RbacRole> Roles { get; set; }
        public DbSet<RbacUser> Users { get; set; }
       // public DbSet<RbacUser> UserProfile { get; set; }
        public DbSet<UserRoleMap> UserRoleMaps { get; set; }
        public DbSet<RolePermissionMap> RolePermissionMaps { get; set; }
        public DbSet<DanpheRoute> Routes { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; } = null!;
        public DbSet<PHRMStoreModel> Store { get; set; }
        public DbSet<StoreVerificationMapModel> StoreVerificationMapModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RbacApplication>().ToTable("RBAC_Application");
            modelBuilder.Entity<RbacPermission>().ToTable("RBAC_Permission");
            modelBuilder.Entity<DanpheRoute>().ToTable("RBAC_RouteConfig");
            modelBuilder.Entity<RbacRole>().ToTable("RBAC_Role");
            modelBuilder.Entity<RolePermissionMap>().ToTable("RBAC_MAP_RolePermission");
            modelBuilder.Entity<RbacUser>().ToTable("RBAC_User");
            //modelBuilder.Entity<RbacUser>().ToTable("RBAC_User");
            modelBuilder.Entity<UserRoleMap>().ToTable("RBAC_MAP_UserRole");
            //modelBuilder.Entity<EmployeeModel>().ToTable("EMP_Employee");
            modelBuilder.Entity<PHRMStoreModel>().ToTable("PHRM_MST_Store");
            modelBuilder.Entity<StoreVerificationMapModel>().ToTable("MST_MAP_StoreVerification");

            //modelBuilder.Entity<RbacUser>(entity =>
            //{
            //    entity.HasKey(e => e.UserId)
            //        .HasName("PK__RBAC_Use__1788CC4CBD1007FE");

            //    entity.ToTable("RBAC_User");

            //    entity.HasIndex(e => e.EmployeeId, "UK_RBAC_EmployeeId")
            //        .IsUnique();

            //    entity.HasIndex(e => e.UserName, "UK_RBAC_User")
            //        .IsUnique();

            //    entity.HasIndex(e => e.Email, "UK_RBAC_User_Email")
            //        .IsUnique();

            //    entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            //    entity.Property(e => e.Password).HasMaxLength(100);

            //    entity.Property(e => e.UserName)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    //entity.HasOne(d => d.Employee)
            //    //    //.WithOne(p => p.RbacUser)
            //    //    .HasForeignKey<RbacUser>(d => d.EmployeeId)
            //    //    .HasConstraintName("FK_RBAC_User_EMP_Employee");
            //});

            //modelBuilder.Entity<RbacRole>(entity =>
            //{
            //    entity.HasKey(e => e.RoleId);

            //    entity.ToTable("RBAC_Role");

            //    entity.HasIndex(e => new { e.ApplicationId, e.RoleName }, "UK_RBAC_Role")
            //        .IsUnique();

            //    entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            //    entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            //    entity.Property(e => e.IsSysAdmin).HasDefaultValueSql("((0))");

            //    entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            //    entity.Property(e => e.RoleDescription)
            //        .HasMaxLength(250)
            //        .IsUnicode(false);

            //    entity.Property(e => e.RoleName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.RoleType)
            //        .HasMaxLength(20)
            //        .IsUnicode(false)
            //        .HasDefaultValueSql("('custom')");

            //    entity.HasOne(d => d.Application)
            //        .WithMany(p => p.Roles)
            //        .HasForeignKey(d => d.ApplicationId)
            //        .HasConstraintName("FK__RBAC_Role__Appli__0ABD916C");

            //    entity.HasOne(d => d.Route)
            //        .WithMany(p => p.Roles)
            //        .HasForeignKey(d => d.DefaultRouteId)
            //        .HasConstraintName("FK_RBAC_Role_Rbac_RouteConfig");
            //});
            modelBuilder.Entity<EmployeeModel>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__EMP_Employee");

                entity.ToTable("EMP_Employee");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DateOfJoining).HasColumnType("datetime");

                entity.Property(e => e.DriverLicenseNo).HasMaxLength(40);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HealthProfessionalCertificationNo).HasMaxLength(40);

                entity.Property(e => e.ImageFullPath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LabSignature).HasMaxLength(500);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LongSignature).HasMaxLength(1000);

                entity.Property(e => e.LPNo)
                    .HasMaxLength(50)
                    .HasColumnName("LPNo");

                entity.Property(e => e.MedCertificationNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NursingCertificationNo).HasMaxLength(40);

                entity.Property(e => e.OfficeHour)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PANNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PANNumber");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RadiologySignature).HasMaxLength(500);

                entity.Property(e => e.RoomNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SignatoryImageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Signature).HasMaxLength(1000);

                entity.Property(e => e.TDSPercent).HasColumnName("TDSPercent");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmpEmployees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__EMP_Emplo__Depar__24285DB4");

                entity.HasOne(d => d.EmployeeRole)
                    .WithMany(p => p.EmpEmployees)
                    .HasForeignKey(d => d.EmployeeRoleId)
                    .HasConstraintName("FK_EMP_Employee_EMP_EmployeeRole");

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.EmpEmployees)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .HasConstraintName("FK_EMP_Employee_EMP_EmployeeType");
            });
            //application and permission mapping
            //modelBuilder.Entity<RbacPermission>()
            //    .HasRequired<RbacApplication>(p => p.Application)
            //    .WithMany(a => a.Permissions)
            //    .HasForeignKey(p => p.ApplicationId);
            //application and permission mapping



            //// Patient address mapping
            //modelBuilder.Entity<AddressModel>().ToTable("PAT_PatientAddress");
            //modelBuilder.Entity<AddressModel>()
            //       .HasRequired<PatientModel>(s => s.Patient) // Address entity requires Patient
            //       .WithMany(s => s.Addresses) // Patient entity includes many Addresses entities
            //        .HasForeignKey(s => s.PatientId);


            //modelBuilder.Entity<RbacPermission>()
            //    .HasMany(e => e.Roles)
            //    .WithMany(e => e.Permissions)
            //    .Map(m => m.ToTable("LNK_ROLE_PERMISSION").MapLeftKey("Permission_Id").MapRightKey("Role_Id"));

            //modelBuilder.Entity<RbacRole>()
            //    .HasMany(e => e.Users)
            //    .WithMany(e => e.Roles)
            //    .Map(m => m.ToTable("LNK_USER_ROLE").MapLeftKey("Role_Id").MapRightKey("User_Id"));
        }
    }
}
