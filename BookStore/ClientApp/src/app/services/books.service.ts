import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Guid } from 'guid-typescript';
import { Observable } from 'rxjs';
import { ApiRequest } from '../models/bases/ApiRequest';
import { ApiRequestHelper } from '../models/bases/ApiRequestHelper';
import { ApiResponse } from '../models/bases/ApiResponse';
import { PagedList } from '../models/bases/PagedList';
import { BookDto } from '../models/dtos/BookDto';

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
    let request = ApiRequestHelper.Create<object>(null, null);//Todo : Pass user id

    return this.http.post<ApiResponse<PagedList<BookDto>>>('/api/Home/GetDashboardBooks', {}, httpOptions);
  }

  getBookDetails(id: string): Observable<ApiResponse<BookDto>> {
    let request = ApiRequestHelper.Create<string>(id, null);//Todo : Pass user id
    return this.http.post<ApiResponse<BookDto>>(`api/Home/GetBookDetails`, request, httpOptions);
  }
}
