using FilmDatabase.Areas.Identity.Data;
using FilmDatabase.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace FilmDatabase.Data
{
	public class FilmdatabaseDbContext : IdentityDbContext<CustomUser>
	{
		public FilmdatabaseDbContext(DbContextOptions<FilmdatabaseDbContext> options)
			: base(options)
		{
		}
		public DbSet<Acteur> Acteur { get; set; }
		public DbSet<Favoriet> Favoriet { get; set; }
		public DbSet<Film> Film { get; set; }

		public DbSet<FilmActeur> FilmActeur { get; set; }
		public DbSet<FilmProducent> FilmProducent { get; set; }
		public DbSet<FilmRegisseur> FilmRegisseur { get; set; }
		
		public DbSet<Producent> Producent { get; set; }
		public DbSet<Regisseur> Regisseur { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("Films");

			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Acteur>().ToTable("Acteur");

			modelBuilder.Entity<Film>().ToTable("Film");

			modelBuilder.Entity<Producent>().ToTable("Producent");
			modelBuilder.Entity<Regisseur>().ToTable("Regisseur");
			modelBuilder.Entity<FilmActeur>().ToTable("FilmActeur");
			modelBuilder.Entity<FilmActeur>()
				.HasOne<Acteur>(fa => fa.Acteur)
				.WithMany(f => f.FilmActeurs)
				.HasForeignKey(fa => fa.ActeurId)
				.IsRequired();
			modelBuilder.Entity<FilmActeur>()
				.HasOne<Film>(fa => fa.Film)
				.WithMany(f => f.FilmActeurs)
				.HasForeignKey(fa => fa.FilmId)
				.IsRequired();

			modelBuilder.Entity<FilmProducent>().ToTable("FilmProducent");
			modelBuilder.Entity<FilmProducent>()
				.HasOne<Producent>(fp => fp.Producenten)
				.WithMany(p => p.FilmProducenten)
				.HasForeignKey(fp => fp.ProducentId)
				.IsRequired();


			modelBuilder.Entity<FilmProducent>()
				.HasOne<Film>(fp => fp.Films)
				.WithMany(p => p.FilmProducenten)
				.HasForeignKey(fp => fp.FilmId)
				.IsRequired();


			modelBuilder.Entity<FilmRegisseur>().ToTable("FilmRegisseur");

			modelBuilder.Entity<FilmRegisseur>()
				.HasOne<Film>(fp => fp.Films)
				.WithMany(p => p.FilmRegisseurs)
				.HasForeignKey(fp => fp.FilmId)
				.IsRequired();

			modelBuilder.Entity<FilmRegisseur>()
				.HasOne<Regisseur>(fp => fp.Regisseurs)
				.WithMany(p => p.FilmRegisseurs)
				.HasForeignKey(fp => fp.RegisseurId)
				.IsRequired();

			modelBuilder.Entity<Favoriet>().ToTable("Favoriet");

			modelBuilder.Entity<Favoriet>()
				.HasOne<Film>(fa => fa.Films)
				.WithMany(f => f.Favorieten)
				.HasForeignKey(fa => fa.FilmId)
				.IsRequired();

			//modelBuilder.Entity<Favoriet>()
			//	.HasOne<CustomUser>(u => u.CustomUsers)
			//	.WithMany(f => f.Favorieten)
			//	.HasForeignKey(f => f.CustomUserId)
			//	.IsRequired();
		}
	}
}
