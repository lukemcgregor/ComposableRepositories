using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposableRepositories.Data
{
	public class Address
	{
		public int Id { get; set; }
		public string PostalAddress { get; set; }
		public string Region { get; set; }
		public int PersonId { get; set; }
	}
}
