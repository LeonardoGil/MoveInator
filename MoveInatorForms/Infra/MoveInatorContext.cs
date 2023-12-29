using Microsoft.EntityFrameworkCore;

namespace MoveInatorForms.Infra
{
    public class MoveInatorContext : DbContext
    {
        public MoveInatorContext() { }

        public MoveInatorContext(DbContextOptions options) : base(options) { }
    }
}
