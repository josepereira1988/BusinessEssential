using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DATA.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            string connectionString = $"server=localhost;uid=ajc;pwd=Paralela09;database=dbapi;port=3306";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySQL(connectionString);
            //optionsBuilder.UseMySQL(DBInforme.connectionString());
            return new MyContext(optionsBuilder.Options);
        }
    }
}
