using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataLayer
{
  public  class SpacePowerResourceContext:DbContext
    {
        public DbSet<Facilities> facility { get; set; }
    }
}
