using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityProject.Entities;

namespace EntityProject.Entities
{
    class RelationContext:DbContext
    {
        public DbSet<cihazlar> cihazlars { get; set; }
        public DbSet<iadeedilenler> iadeedilenlers { get; set; }
        public DbSet<musteriler> musterilers { get; set; }
        public DbSet<teslimedilenler> teslimedilenlers { get; set; }
    }
}
