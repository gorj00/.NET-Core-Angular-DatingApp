using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        // ctor + tab
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> Values { get; set; }
        // dotnet ef migrations add AddUserEntity
        // dotnet ef database update
        public DbSet<User> Users { get; set; }
    }
}