using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComposableRepositories.Api
{
	public static class GenericHelpers
	{
		public static IQueryable<T> Page<T>(this IOrderedQueryable<T> entities, int page, int pageSize = 3)
		{
			int skip = Math.Max(0, page - 1) * pageSize;
			return entities.Skip(skip).Take(pageSize);
		}
	}
}