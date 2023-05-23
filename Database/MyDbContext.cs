using Microsoft.EntityFrameworkCore;

namespace Database.Migrations;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }
}