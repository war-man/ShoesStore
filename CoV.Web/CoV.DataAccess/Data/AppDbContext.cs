using Microsoft.EntityFrameworkCore;

namespace CoV.DataAccess.Data
{
    /// <summary>
    /// Construstor DbContext
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public  virtual  DbSet<User> Users { get; set; }
        public  virtual  DbSet<Role> Roles { get; set; }
        public  virtual  DbSet<Classes> Classeses { get; set; }
        public  virtual  DbSet<Student> Students { get; set; }
        public  virtual  DbSet<Product> Products { get; set; }
        public  virtual  DbSet<ColorProduct> ColorProducts { get; set; }
        public  virtual  DbSet<MakerProduct> MakerProducts { get; set; }
        public  virtual  DbSet<StatusProduct> StatusProducts { get; set; }
        public  virtual  DbSet<CategoryProduct> CategoryProducts { get; set; }
        public  virtual  DbSet<Gender> Genders { get; set; }
        
        /// <summary>
        /// Name Tabel
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {    
            modelBuilder.Entity<User>().ToTable("User");
            
            modelBuilder.Entity<Role>().ToTable("Role");
            
            modelBuilder.Entity<Classes>().ToTable("Classses");
            
            modelBuilder.Entity<Student>().ToTable("Student"); 
            
            modelBuilder.Entity<Product>().ToTable("Product"); 
            
            modelBuilder.Entity<ColorProduct>().ToTable("ColorProduct"); 
            
            modelBuilder.Entity<MakerProduct>().ToTable("MakerProduct"); 
            
            modelBuilder.Entity<StatusProduct>().ToTable("StatusProduct"); 
            
            modelBuilder.Entity<CategoryProduct>().ToTable("CategoryProduct");
            
            modelBuilder.Entity<Gender>().ToTable("Gender");   
        } 
    }
}