import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { apiConfig } from '../../../api_config';
import { ApiRequestHelper } from '../models/bases/ApiRequestHelper';
import { ApiResponse } from '../models/bases/ApiResponse';
import { AuthUserDto } from '../models/dtos/users/AuthUserDto';

const httpOptions = {
  headers: new HttpHeaders({
    "Content-Type": "application/json"
  })
};

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private http: HttpClient) { }

  createOrUpdateUser(userDto: AuthUserDto): Observable<ApiResponse<boolean>>{
    let request = ApiRequestHelper.Create<AuthUserDto>(userDto, null);

    return this.http.post<ApiResponse<boolean>>(apiConfig.users.createOrUpdate.uri, request, httpOptions);
  }
}