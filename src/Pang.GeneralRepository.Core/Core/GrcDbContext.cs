using Microsoft.EntityFrameworkCore;

namespace Pang.GeneralRepository.Core.Core
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class GRCDbContext : DbContext
    {
        /// <summary>
        /// </summary>
        /// <param name="options"> </param>
        public GRCDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="modelBuilder"> </param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.AddEntityTypes();

            base.OnModelCreating(modelBuilder);
        }
    }
}