using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FirstEF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connectionString = new ConfigService().GetConfig().ConnectionString.DefaultConnection;
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder.UseSqlServer(connectionString).Options;
            using (var db = new ApplicationContext(options))
            {
            }

            Console.Read();
        }
    }
}
