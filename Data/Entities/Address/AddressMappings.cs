using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposableRepositories.Data
{
	internal class AddressMappings : EntityTypeConfiguration<Address>
	{
		public AddressMappings()
		{
		}
	}
}
