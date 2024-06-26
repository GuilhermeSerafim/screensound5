﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;

namespace ScreenSound5.Banco;

internal class ScreenSoundContext : DbContext
{
    // Artistas - Precisa ter o mesmo nome da tabela
    // DbSet - Abstração do Entity framework que permite interagir com a tabelade forma concisa
    public DbSet<Artista> Artistas { get; set; }
    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound5;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }
}