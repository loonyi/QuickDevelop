using QuickDevelop.EntityFramework;

namespace QuickDevelop.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly QuickDevelopDbContext _context;

        public InitialDataBuilder(QuickDevelopDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
        }
    }
}
