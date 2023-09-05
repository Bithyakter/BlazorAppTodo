using BlazorAppTodo.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BlazorAppTodo.Server.AppDbContext
{
   public class ApplicationDbContext : DbContext
   {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
      {

      }
      public DbSet<Country> Countries { get; set; }
   }
}
