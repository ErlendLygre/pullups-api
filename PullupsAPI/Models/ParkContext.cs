﻿using Microsoft.EntityFrameworkCore;

namespace PullupsAPI.Models
{
    public class ParkContext : DbContext
    {
        public ParkContext(DbContextOptions<ParkContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }
    }
}