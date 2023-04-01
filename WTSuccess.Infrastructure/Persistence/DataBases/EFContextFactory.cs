using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTSuccess.Infrastructure.Persistence.DataBases
{
    public class EFContextFactory : IDesignTimeDbContextFactory<EFContext>
    {
        public EFContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<EFContext>();
            optionBuilder.UseNpgsql("Host=localhost;Port=5432;Database=WTSuccess;Username=postgres;Password=2415");
            return new EFContext(optionBuilder.Options);
        }
    }
}
