using Microsoft.EntityFrameworkCore;
using myLabWebApi.Models;

namespace myLabWebApi.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public virtual DbSet<UserMasterModel> UserMaster { get; set; }
    }
}