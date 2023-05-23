using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database;

public class MyDbContext : DbContext
{
    public DbSet<User> User { get; set; }
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }
}