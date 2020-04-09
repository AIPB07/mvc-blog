using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc_blog.Models;

namespace mvc_blog.Data
{
    public class mvc_blogContext : DbContext
    {
        public mvc_blogContext (DbContextOptions<mvc_blogContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }
    }
}
