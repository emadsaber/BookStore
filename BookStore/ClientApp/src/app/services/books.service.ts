import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
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
    return this.http.post<ApiResponse<PagedList<BookDto>>>('/api/Home/GetDashboardBooks', {}, httpOptions);
  }
}
