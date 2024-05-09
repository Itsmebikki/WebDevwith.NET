using Microsoft.EntityFrameworkCore;
public class VidhyalayaDbContext: DbContext 
{
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Student> Students  { get; set; }
    public DbSet<Guardian> Guardians { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Vidhyalaya.db");
    } 
       protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasOne<Grade>(s => s.Grade)
            .WithMany(g => g.Students)
            .HasForeignKey(s => s.GradeId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Student>()
            .HasOne<Guardian>(s => s.Guardian)
            .WithMany(g => g.Students)
            .HasForeignKey(s => s.GuardianId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}