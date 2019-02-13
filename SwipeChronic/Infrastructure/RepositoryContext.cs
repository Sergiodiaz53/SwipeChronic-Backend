using System;
using Microsoft.EntityFrameworkCore;
using SwipeChronic.Models;

namespace SwipeChronic.Infrastructure
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }

    public DbSet<Question> Questions { get; set; }
    public DbSet<Response> Responses { get; set; }

    }
}