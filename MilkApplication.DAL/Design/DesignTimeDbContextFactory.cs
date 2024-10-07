using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MilkApplication.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkApplication.DAL.Design
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(//"server=(local);database=MilkApplication_DB;uid=sa;pwd=123456;TrustServerCertificate=True;" +
                "server=Data Source=milkapplicationdbserver.database.windows.net,1433;Initial Catalog=MilkApplication_db;User ID=Chisi;Password=Trung1234;TrustServerCertificate=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
