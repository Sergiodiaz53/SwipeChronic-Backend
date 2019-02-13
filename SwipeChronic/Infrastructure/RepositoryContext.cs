using System;
using Microsoft.EntityFrameworkCore;
using SwipeChronic.Models;

//Los DBsets traducen lo que escribo a consola SQL, se comunican con la BD y transforman la respuesta en entidades.

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