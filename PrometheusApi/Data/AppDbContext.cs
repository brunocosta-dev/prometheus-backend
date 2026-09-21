using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    AppDbContext(DbcontextOptions<AppDbContext> options) : base(options){}

    
}