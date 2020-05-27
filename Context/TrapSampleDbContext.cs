using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstExercise.Context
{
    public class TrapSampleContext : DbContext
    {
        public TrapSampleContext(DbContextOptions<TrapSampleContext> options): base(options)
        {

        }

        public DbSet<TrapSample> TrapSamples { get; set; }
        public DbSet<Specimen> Specimens { get; set; }
    }
}
