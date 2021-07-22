import { Component, OnDestroy, OnInit } from '@angular/core';
import { async } from '@angular/core/testing';
import { AuthService } from '@auth0/auth0-angular';
import { Subscription } from 'rxjs';
import { ApiResponseHelper } from '../../../models/bases/ApiResponse';
import { AuthUserDto } from '../../../models/dtos/users/AuthUserDto';
import { UsersService } from '../../../services/users.service';

@Component({
  selector: 'app-login-button',
  templateUrl: './login-button.component.html',
  styleUrls: ['./login-button.component.css']
})
export class LoginButtonComponent implements OnInit, OnDestroy {

  constructor(private auth: AuthService, private usersService: UsersService) { }

  createUpdateSubscription: Subscription;
  authUserSubscription: Subscription;

  ngOnInit(): void {
  }
  ngOnDestroy() {
    this.createUpdateSubscription?.unsubscribe();
    this.authUserSubscription?.unsubscribe();
  }
  loginWithRedirect() {
    this.auth.loginWithPopup().subscribe(() => {
      this.authUserSubscription = this.auth.user$.subscribe(x => {
        let userDto: AuthUserDto = {
          email: x.email,
          email_verified: x.email_verified,
          name: x.name,
          nickname: x.nickname,
          picture: x.picture,
          sub: x.sub
        };

        //create a user in database
        this.createUpdateSubscription = this.usersService.createOrUpdateUser(userDto).subscribe(x => {
          if (!x.success) {
            console.error(ApiResponseHelper.getErrorsString(x));
            console.error(x);
            window.alert(ApiResponseHelper.getErrorsString(x));
          }
        });
      });
    });
  }

}
