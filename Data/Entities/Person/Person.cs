using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposableRepositories.Data
{
	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime? BirthDate { get; set; }
		public ICollection<Address> Addresses { get; set; }
	}
}
