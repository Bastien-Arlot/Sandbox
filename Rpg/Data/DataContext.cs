﻿using Microsoft.EntityFrameworkCore;
using Rpg.Models;

namespace Rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Character> Characters => Set<Character>();
        public DbSet<User> Users => Set<User>();

    }
}
