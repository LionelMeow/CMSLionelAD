using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CMSLionelAD.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserTokenCache> UserTokenCacheList { get; set; }

        public System.Data.Entity.DbSet<CMSLionelAD.Models.Container> Containers { get; set; }

        public System.Data.Entity.DbSet<CMSLionelAD.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<CMSLionelAD.Models.Ship> Ships { get; set; }

        public System.Data.Entity.DbSet<CMSLionelAD.Models.Shipyard> Shipyards { get; set; }

        public System.Data.Entity.DbSet<CMSLionelAD.Models.Schedule> Schedules { get; set; }
    }

    public class UserTokenCache
    {
        [Key]
        public int UserTokenCacheId { get; set; }
        public string webUserUniqueId { get; set; }
        public byte[] cacheBits { get; set; }
        public DateTime LastWrite { get; set; }
    }
}