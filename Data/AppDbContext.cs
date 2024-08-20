
using BlazzShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazzShop.Data
{
    public class AppDbContext : DbContext
    {
        //Só vai receber ContextOptions desse dataContext e para esse DataContext
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)//passando as options para nossa classe pai DbContext
        {
            //alem da connection string, posso dizer que uso sqlserver, quero exec migration de x forma
        }

        /*Tabelas referenciadas*/
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
    }
}