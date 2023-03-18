using Microsoft.EntityFrameworkCore;

namespace Blog.DLL.Data
{
   public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            :base(options) { }
    }
}
