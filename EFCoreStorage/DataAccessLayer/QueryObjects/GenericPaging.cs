using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.QueryObjects
{
    public static class GenericPaging
    {
        public static IQueryable<T> Page<T>(this IQueryable<T> query,
            int pageNumZeroStart, int pageSize)
        {
            if (pageSize == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pageSize),
                    "Page size must be greater than zero.");
            }

            if(pageNumZeroStart != 0)
            {
                query = query
                    .Skip(pageNumZeroStart * pageSize);
            }

            return query
                .Take(pageSize);
        }
    }
}
