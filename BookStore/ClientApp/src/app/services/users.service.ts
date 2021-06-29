import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { apiConfig } from '../../../api_config';
import { ApiRequest } from '../models/bases/ApiRequest';
import { ApiRequestHelper } from '../models/bases/ApiRequestHelper';
import { ApiResponse } from '../models/bases/ApiResponse';
import { UserDto } from '../models/dtos/UserDto';
import { AuthUserDto } from '../models/dtos/users/AuthUserDto';
import { environment as env } from 'src/environments/environment';
import { UsersMock } from '../mocks/users.mock';

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

  createOrUpdateUser(userDto: AuthUserDto): Observable<ApiResponse<boolean>> {
    if (!env.production) return UsersMock.createOrUpdateUserMock(userDto);

    let request = ApiRequestHelper.Create<AuthUserDto>(userDto, null);

    return this.http.post<ApiResponse<boolean>>(apiConfig.users.createOrUpdate.uri, request, httpOptions);
  }

  getUserByAuthUserId(sub: string): Observable<ApiResponse<UserDto>> {
    if (!env.production) return UsersMock.getUserByAuthUserIdMock(sub);

    let request = ApiRequestHelper.Create<string>(sub, null);

    return this.http.post<ApiResponse<UserDto>>(apiConfig.users.getUser.uri, request, httpOptions);
  }
}
