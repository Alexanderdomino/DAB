using Microsoft.EntityFrameworkCore;

namespace EFGetStartedLib;

public class MyDBContext : DbContext
{
    private const string DbName = "EFGetstartedDB";
    private const string ConnectionString = $"Data Source=localhost;Initial Catalog={DbName};User ID=sa;Password=Hejhans22015;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
 
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(ConnectionString);
    //recheck connectionString if issue connecting to db
    //can reuse connection string from week 3 using your new database
}