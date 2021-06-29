import { Observable } from 'rxjs';
import { of } from 'rxjs'
import { ApiResponse } from '../models/bases/ApiResponse';
import { UserDto } from '../models/dtos/UserDto';
import { AuthUserDto } from '../models/dtos/users/AuthUserDto';

export class UsersMock {
    static createOrUpdateUserMock(userDto: AuthUserDto): Observable<ApiResponse<boolean>> {
        let res: ApiResponse<boolean> = {
            data: true,
            success: true,
            errors: null
        }

        return of(res);
    }

    static getUserByAuthUserIdMock(sub: string = 'google-oauth2|108514010743921152783'): Observable<ApiResponse<UserDto>> {
        let res: ApiResponse<UserDto> = {
            "data": {
                "id": "56b64cba-eacd-4358-b443-438655054312",
                "firstName": "Emad",
                "lastName": "Saber",
                "authUserId": "google-oauth2|108514010743921152783",
                "email": "omda.sharkawy@gmail.com",
                "nickname": "omda.sharkawy",
                "name": "Emad Saber",
                "pictureUrl": "https://lh3.googleusercontent.com/a-/AOh14GiDVwed7LeGT3wNwHBlISVbPc2SQh2CqPZT3dE2Mw=s96-c",
                "emailVerified": true
            },
            "success": true,
            "errors": null
        };

        return of(res);

    }
}