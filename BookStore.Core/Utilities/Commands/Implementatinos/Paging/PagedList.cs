using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Utilities.Commands.Implementatinos.Paging
{
    public class PagedList<T>
    {
        public PagedList(List<T> data, int pageNumber, int pagesCount, int pageSize, int totalCount)
        {
            PagedData = data;
            PageNumber = pageNumber;
            PagesCount = pagesCount;
            PageSize = pageSize;
            TotalCount = totalCount;
        }

        public int PageNumber { get; private set; }
        public int PageSize { get; } 
        public int PagesCount { get; }
        public int TotalCount { get; }
        public List<T> PagedData { get; }

        #region helpers

        public static PagedList<T> GetPaged(List<T> data, int pageNumber, int pageSize, int pagesCount, int totalCount)
        {
            return new PagedList<T>(data, pageNumber, pagesCount, pageSize, totalCount);
        }
        public static PagedList<T2> CopyFrom<T1,T2>(PagedList<T1> oldPagedData, List<T2> newData)
        {
            return new PagedList<T2>(newData, oldPagedData.PageNumber, oldPagedData.PagesCount, oldPagedData.PageSize, oldPagedData.TotalCount);
        }
        #endregion

    }
}
