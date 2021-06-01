﻿using System.Linq;

namespace LH.Core.Mvc.Pagination
{
    public static class ToPaginatedListExtension
    {
        public static PaginatedList<TEntity> ToPaginatedList<TEntity>(this IQueryable<TEntity> source, int page, int pageSize) where TEntity : class
        {
            PaginatedList<TEntity> paginatedList = new(source.Count(), page, pageSize);

            source = source.Skip(paginatedList.StartIndex).Take(paginatedList.PageSize);

            paginatedList.AddRange(source.ToList());

            return paginatedList;
        }
    }
}
