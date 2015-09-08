using ComposableRepositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComposableRepositories.Api.Models
{
	public class PersonModel
	{
		public string Name { get; set; }
		public IEnumerable<string> Addresses { get; set; }
	}

	public static class PersonModelMappings
	{
	public static IQueryable<PersonModel> ToViewModels(this IQueryable<Person> people)
	{
		return people.Select(person => new PersonModel
		{
			Name = person.Name,
			Addresses = person.Addresses.Select(a => a.PostalAddress)
		});
	}
	}
}