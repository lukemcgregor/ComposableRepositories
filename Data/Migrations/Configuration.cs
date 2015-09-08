namespace ComposableRepositories.Data.Migrations
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<ComposableRepositories.Data.ComposibleRepositoryContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
			ContextKey = "ComposableRepositories.Data.ComposibleRepositoryContext";
		}

		protected override void Seed(ComposableRepositories.Data.ComposibleRepositoryContext context)
		{
			context.People.AddOrUpdate(
			  p => p.Name,
			  new Person { Name = "Bilbo Baggins", Addresses = new List<Address> { new Address { Region = "Shire", PostalAddress = "Bag End, Hobbiton" } } },
			  new Person { Name = "Frodo Baggins", Addresses = new List<Address> { new Address { Region = "Shire", PostalAddress = "Bag End, Hobbiton" } } },
			  new Person { Name = "Peregrin Took", Addresses = new List<Address> { new Address { Region = "Shire", PostalAddress = "Hobbiton" } } },
			  new Person { Name = "Samwise Gamgee", Addresses = new List<Address> { new Address { Region = "Shire", PostalAddress = "Bagshot Row, Hobbiton" } } },
			  new Person { Name = "Legolas", Addresses = new List<Address> { new Address { Region = "Mirkwood", PostalAddress = "Mirkwood" } } },
			  new Person { Name = "Sauron", Addresses = new List<Address> { new Address { Region = "Mordor", PostalAddress = "Mt Doom" } } }
			);
		}
	}
}
