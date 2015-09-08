using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposableRepositories.Data
{
	internal class PersonMappings : EntityTypeConfiguration<Person>
	{
		public PersonMappings()
		{
			HasMany(x => x.Addresses).WithRequired().HasForeignKey(x => x.PersonId);
		}
	}
}
