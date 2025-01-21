﻿using ActionResults.entities;
using Microsoft.EntityFrameworkCore;

namespace ActionResults.Context
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext( DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}
