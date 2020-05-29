using Microsoft.EntityFrameworkCore;
using MovieMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMvc.Data
{
    public class MvcMovieContext :DbContext
    {

        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            :base(options)
        {
        }

        public DbSet<Movie> Movies{ get; set; }
    }
}
