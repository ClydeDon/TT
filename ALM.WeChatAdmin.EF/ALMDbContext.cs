namespace ALM.WeChatAdmin.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ALMDbContext : DbContext
    {
        public ALMDbContext()
            : base("name=ALMDB")
        {
        }

        public virtual DbSet<Sys_User> Sys_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
