using Microsoft.EntityFrameworkCore;

namespace SearchCompany.Models
{
    public class SearchCompanyContext : DbContext
    {
        public SearchCompanyContext(DbContextOptions<SearchCompanyContext> options)
            : base(options)
        {
        }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PessoaJuridica>().ToTable("PessoaJuridica");
        }
    }
}