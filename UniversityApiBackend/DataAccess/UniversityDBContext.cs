﻿using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext:DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options):base(options) 
        { 
        
        
        }
        //Add dbsets
        public DbSet<User>? Users { get; set; }

        public DbSet<Course>? Courses { get; set;}

    }
}
