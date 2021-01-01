using DL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DL
{
    public class LabContext:DbContext
    {

        public DbSet<Message> Message { get; set; }

        public DbSet<UserMessage> UserMessages { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<UserRight> UserRights { get; set; }
        public DbSet<Right> Right { get; set; }

        public LabContext() : base()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =DESKTOP-P54RJ2G\\SQLEXPRESS;Database=Lab1_7;; Trusted_Connection = True; MultipleActiveResultSets = true", x => x.MigrationsAssembly("DL"));
        }

    }

}
