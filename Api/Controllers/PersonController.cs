using ComposableRepositories.Api.Models;
using ComposableRepositories.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Data.Entity;

namespace ComposableRepositories.Api.Controllers
{
	public class PersonController : ApiController
	{
		[HttpGet]
		public PersonModel Get(string region, string name)
		{
			using(var ctx = new ComposibleRepositoryContext())//in a real app we would dependancy inject this
			{
				return ctx.People
					.InRegion(region)
					.WithName(name)
					.ToViewModels()
					.FirstOrDefault();
			}
		}
	}
}
