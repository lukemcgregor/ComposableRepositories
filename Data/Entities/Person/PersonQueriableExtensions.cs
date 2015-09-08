using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposableRepositories.Data
{
	public static class PersonQueriableExtensions
	{
		public static IQueryable<Person> WithName(this IQueryable<Person> people, string name)
		{
			return people.Where(p => p.Name == name);
		}
		public static IQueryable<Person> InRegion(this IQueryable<Person> people, string region)
		{
			return people.Where(p => p.Addresses.Any(a => a.Region == region));
		}
		public static IOrderedQueryable<Person> OrderByName(this IQueryable<Person> people)
		{
			return people.OrderBy(x => x.Name);
		}
	}
}


