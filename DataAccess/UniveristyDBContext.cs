﻿using Microsoft.EntityFrameworkCore;
using University.Models.DataModels;

namespace University.DataAccess
{
    public class UniveristyDBContext: DbContext
    {
        public UniveristyDBContext(DbContextOptions<UniveristyDBContext> options):base(options) { }

        // TODO: Add DbSets (Tables of our database)
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        
    }
}
