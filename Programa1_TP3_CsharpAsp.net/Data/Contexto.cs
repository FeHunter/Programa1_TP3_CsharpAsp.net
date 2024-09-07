using Microsoft.EntityFrameworkCore;
using Programa1_TP3_CsharpAsp.net.Models;

namespace Programa1_TP3_CsharpAsp.net.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base (options) { }
        public DbSet<Produto> Produtos { get; set; }
    }
}
