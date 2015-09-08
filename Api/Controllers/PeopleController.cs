using ComposableRepositories.Api.Models;
using ComposableRepositories.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Data.Entity;

namespace ComposableRepositories.Api.Controllers
{
	public class PeopleController : ApiController
	{
		[HttpGet]
		public IEnumerable<PersonModel> Get(string region, int page)
		{
			using(var ctx = new ComposibleRepositoryContext())//in a real app we would dependancy inject this
			{
				return ctx.People
					.InRegion(region)
					.OrderByName()
					.Page(page)
					.ToViewModels()
					.ToArray();
			}
		}
	}
}
