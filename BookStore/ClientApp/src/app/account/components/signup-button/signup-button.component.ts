import { Component, OnDestroy, OnInit } from '@angular/core';
import { AuthService } from '@auth0/auth0-angular';
import { Subscription } from 'rxjs';
import { ApiResponseHelper } from 'src/app/models/bases/ApiResponse';
import { AuthUserDto } from '../../../models/dtos/users/AuthUserDto';
import { UsersService } from '../../../services/users.service';

@Component({
  selector: 'app-signup-button',
  templateUrl: './signup-button.component.html',
  styleUrls: ['./signup-button.component.css']
})
export class SignupButtonComponent implements OnInit, OnDestroy {

  constructor(private auth: AuthService, private usersService: UsersService) { }

  createUpdateSubscription: Subscription;
  authUserSubscription: Subscription;

  ngOnInit(): void {
  }
  ngOnDestroy() {
    this.createUpdateSubscription?.unsubscribe();
    this.authUserSubscription?.unsubscribe();
  }
  signUp() {
    this.auth.loginWithPopup({
      screen_hint: "signup"
    }).subscribe(() => {
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
