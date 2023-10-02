﻿using DotNetApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace DotNetApi.Infrastructure
{
    public class DataDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DataDbContext(DbContextOptions<DataDbContext> options) : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasIndex(prop => prop.Email).IsUnique(true);
        }
    }
}
