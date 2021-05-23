export class PagedList<T>{
  pageNumber: number;
  pageSize: number;
  pagesCount: number;
  totalCount: number;
  pagedData: T[];
}
