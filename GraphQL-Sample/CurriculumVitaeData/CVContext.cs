using CurriculumVitaeModel.Models;
using Microsoft.EntityFrameworkCore;

namespace CurriculumVitaeData
{
    /// <summary>
    /// Database Context for the CV system.
    /// </summary>
    public class CVContext : DbContext
    {
        public CVContext(DbContextOptions options)
            : base(options)
        {
        }

        /// <summary>
        /// List of all CVs
        /// </summary>
        public virtual DbSet<CV> CVs { get; set; }
        /// <summary>
        /// List of all educations
        /// </summary>
        public virtual DbSet<Education> Educations { get; set; }
        /// <summary>
        /// List of all companies
        /// </summary>
        public virtual DbSet<Company> Companies { get; set; }
        /// <summary>
        /// List of all projects
        /// </summary>
        public virtual DbSet<Project> Projects { get; set; }
        /// <summary>
        /// List of all skills
        /// </summary>
        public virtual DbSet<Skill> Skills { get; set; }
        /// <summary>
        /// List of all links
        /// </summary>
        public virtual DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region CV
            modelBuilder.Entity<CV>()
                .Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<CV>()
                .Property(x => x.Name)
                .HasColumnName("name")
                .IsRequired(true)
                .HasMaxLength(50);

            modelBuilder.Entity<CV>()
                .ToTable("cv");
            #endregion CV

            #region Education
            modelBuilder.Entity<Education>()
                .Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Education>()
                .Property(x => x.Title)
                .HasColumnName("title")
                .IsRequired(true)
                .HasMaxLength(255);

            modelBuilder.Entity<Education>()
                .Property(x => x.School)
                .HasColumnName("school")
                .IsRequired(true)
                .HasMaxLength(255);

            modelBuilder.Entity<Education>()
                .Property(x => x.StartDate)
                .HasColumnName("start_dt")
                .IsRequired(true);

            modelBuilder.Entity<Education>()
                .Property(x => x.EndDate)
                .HasColumnName("end_dt")
                .IsRequired(true);

            modelBuilder.Entity<Education>()
                .HasOne(e => e.CV)
                .WithMany(c => c.Education)
                .HasForeignKey("cv_id");

            modelBuilder.Entity<Education>()
                .ToTable("education");
            #endregion Education

            #region Companies
            modelBuilder.Entity<Company>()
                .Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Company>()
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired(true);

            modelBuilder.Entity<Company>()
                .Property(x => x.Position)
                .HasColumnName("position")
                .HasMaxLength(50)
                .IsRequired(true);

            modelBuilder.Entity<Company>()
                .Property(x => x.StartDate)
                .HasColumnName("start_dt")
                .IsRequired(true);

            modelBuilder.Entity<Company>()
                .Property(x => x.EndDate)
                .HasColumnName("end_dt")
                .IsRequired(true);

            modelBuilder.Entity<Company>()
                .HasOne(c => c.CV)
                .WithMany(c => c.Companies)
                .HasForeignKey("cv_id");

            modelBuilder.Entity<Company>()
                .ToTable("company");
            #endregion Companies

            #region Projects
            modelBuilder.Entity<Project>()
               .Property(x => x.Id)
               .HasColumnName("id")
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<Project>()
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired(true);

            modelBuilder.Entity<Project>()
                .Property(x => x.Description)
                .HasColumnName("description")
                .HasMaxLength(500)
                .IsRequired(true);

            modelBuilder.Entity<Project>()
                .HasOne(p => p.Company)
                .WithMany(c => c.Projects)
                .HasForeignKey("company_id");

            modelBuilder.Entity<Project>()
                .ToTable("project");
            #endregion Projects

            #region Skills
            modelBuilder.Entity<Skill>()
               .Property(x => x.Id)
               .HasColumnName("id")
               .ValueGeneratedOnAdd();

            modelBuilder.Entity<Skill>()
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired(true);

            modelBuilder.Entity<Skill>()
                .Property(x => x.Experience)
                .HasColumnName("experience")
                .HasConversion(
                    v => (int)v,
                    v => (Experience)v
                )
                .IsRequired(true);

            modelBuilder.Entity<Skill>()
                .HasOne(s => s.CV)
                .WithMany(c => c.Skills)
                .HasForeignKey("cv_id");

            modelBuilder.Entity<Skill>()
                .ToTable("skill");
            #endregion Skills

            #region Links
            modelBuilder.Entity<Link>()
                .Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Link>()
                .Property(x => x.Url)
                .HasColumnName("url")
                .HasMaxLength(255)
                .IsRequired(true);

            modelBuilder.Entity<Link>()
                .Property(x => x.Description)
                .HasColumnName("description")
                .HasMaxLength(500)
                .IsRequired(true);

            modelBuilder.Entity<Link>()
                .HasOne(s => s.CV)
                .WithMany(c => c.Links)
                .HasForeignKey("cv_id");

            modelBuilder.Entity<Link>()
                .ToTable("link");
            #endregion
        }
    }
}
