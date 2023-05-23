using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Database;

public class MyDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
{
    public MyDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=TestDB;User Id=sa;Password=Qwer@1234;TrustServerCertificate=True;MultipleActiveResultSets=true");

        return new MyDbContext(optionsBuilder.Options);
    }
}