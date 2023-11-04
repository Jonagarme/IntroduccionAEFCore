using Microsoft.EntityFrameworkCore;

namespace IntroduccionAEFCore
{
    public class ApplicactionDBContext : DbContext
    {
        public ApplicactionDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
