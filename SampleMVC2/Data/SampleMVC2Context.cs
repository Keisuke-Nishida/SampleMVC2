using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleMVC2.Models;


namespace SampleMVC2.Data
{
    public class SampleMVC2Context : DbContext
    {
        public SampleMVC2Context(DbContextOptions<SampleMVC2Context> options)
            : base(options)
        {
        }


        public DbSet<Movie> Movie { get; set; }
    }
}
