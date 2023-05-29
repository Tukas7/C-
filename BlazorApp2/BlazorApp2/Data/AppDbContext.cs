﻿using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<EventWidget> EventWidgets { get; set; }
    }
}