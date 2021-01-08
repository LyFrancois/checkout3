using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint_3
{
    public class Checkpoint3DbContext : DbContext
    {
        public Checkpoint3DbContext(DbContextOptions<Checkpoint3DbContext> options)
          : base(options)
        {
        }

        public Checkpoint3DbContext()
        {
        }
    }
}
