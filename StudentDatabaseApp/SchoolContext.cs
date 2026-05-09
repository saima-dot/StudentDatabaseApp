using System.Data.Entity;

namespace StudentDatabaseApp
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("StudentDB")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}