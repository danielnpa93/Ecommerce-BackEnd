using System;
using System.Collections.Generic;

namespace ECommerce.API.Utils
{
    public class PaginatedList<T> : List<T>
    {
        public int TotalItems { get; private set; }
        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }
        public int Limit { get; private set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            TotalItems = count;
            CurrentPage = pageIndex;
            Limit = pageSize;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize, int totalPages)
        {
            TotalItems = count;
            CurrentPage = pageIndex;
            Limit = pageSize;
            TotalPages = totalPages;

            this.AddRange(items);
        }
    }
}
