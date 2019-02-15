using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloMVCApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloMVCApp.DatabaseContext
{
    public class TrainingDbContext:DbContext
    {
        public DbSet<Trainee> Trainees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local);Database=TrainingDB;Integrated Security=true");
        }
    }
}
