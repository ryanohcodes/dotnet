using System;
using Microsoft.EntityFrameworkCore;

namespace superHeroes.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();
			

	}
}

