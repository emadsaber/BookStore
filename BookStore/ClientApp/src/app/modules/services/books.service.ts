import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Guid } from 'guid-typescript';
import { Observable } from 'rxjs';
import { ApiRequest } from '../models/bases/ApiRequest';
import { ApiRequestHelper } from '../models/bases/ApiRequestHelper';
import { ApiResponse } from '../models/bases/ApiResponse';
import { PagedList } from '../models/bases/PagedList';
import { BookDto } from '../models/dtos/BookDto';
import { environment as env } from '../../../environments/environment';
import { BooksMocks } from '../mocks/books.mock';

const httpOptions = {
  headers: new HttpHeaders({
    "Content-Type": "application/json"
  })
};

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor(private http: HttpClient) { }

  getDashboardBooks(): Observable<ApiResponse<PagedList<BookDto>>> {
    if (!env.production) return BooksMocks.getBooksMock();

    let request = ApiRequestHelper.Create<object>(null, null);//Todo : Pass user id

    return this.http.post<ApiResponse<PagedList<BookDto>>>('/api/Home/GetDashboardBooks', {}, httpOptions);
  }

  getBookDetails(id: string): Observable<ApiResponse<BookDto>> {
    if (!env.production) return BooksMocks.getBookMock(id);

    let request = ApiRequestHelper.Create<string>(id, null);//Todo : Pass user id
    return this.http.post<ApiResponse<BookDto>>(`api/Home/GetBookDetails`, request, httpOptions);
  }
}
