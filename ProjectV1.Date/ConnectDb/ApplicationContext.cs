using Microsoft.EntityFrameworkCore;
using ProjectV1.Date.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectV1.Date.ConnectDb
{

    public class ApplicationContext : DbContext
    {
        private const string _connString = "Data Source=ALEX;Initial Catalog=MonsterDb;Persist Security Info=True;User ID=Use1;Password=***********;Trust Server Certificate=True";

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Отключение множественных имен таблиц (аналогично PluralizingTableNameConvention)
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.DisplayName());
            }
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Achievement> Achievement { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<UserAchievement> UserAchievement { get; set; }


    }
}
