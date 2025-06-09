using Microsoft.EntityFrameworkCore;

namespace kol2oficial.Data;

public class DataBaseContext : DbContext
{
    protected DataBaseContext()
    {
        
    }
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
}