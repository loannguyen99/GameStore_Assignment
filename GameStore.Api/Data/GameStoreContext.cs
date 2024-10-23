using System;
using System.Net.Http.Headers;
using GameStore.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) 
:DbContext(options)
{
    public DbSet<Game> Games =>Set<Game>();

    public DbSet <Gener> Genres =>Set<Gener>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.Entity<Gener>().HasData(
        new {Id = 1, Name = "Fighting"},
        new {Id = 2,Name ="Roleplaying"},
        new {Id = 3,Name = "Sports"},
        new {Id = 4, Name = "Racing"},
        new {Id = 5, Name = "Kids and Family"}       
       );
    }
}
