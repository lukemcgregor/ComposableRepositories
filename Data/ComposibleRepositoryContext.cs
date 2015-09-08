using System.Data.Entity;

namespace ComposableRepositories.Data
{
	public class ComposibleRepositoryContext : DbContext, IComposibleRepositoryContext
	{
		static ComposibleRepositoryContext()
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<ComposibleRepositoryContext, Migrations.Configuration>());
		}
		public ComposibleRepositoryContext()
			: base("ComposibleRepositories")
		{
			Database.Initialize(false);
		}
		public IDbSet<Person> People { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new AddressMappings());
			modelBuilder.Configurations.Add(new PersonMappings());
		}
	}

	/// <summary>
	/// We will use this for DI and Testing
	/// </summary>
	public interface IComposibleRepositoryContext
	{
		IDbSet<Person> People { get; }
		int SaveChanges();
	}
}
