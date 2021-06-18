import { Component, OnDestroy, OnInit } from '@angular/core';
import { AuthService } from '@auth0/auth0-angular';
import { Subscription } from 'rxjs';
import { UsersService } from '../../../services/users.service'
import { AuthUserDto } from '../../../models/dtos/users/AuthUserDto';

@Component({
  selector: 'app-authentication-button',
  templateUrl: './authentication-button.component.html',
  styleUrls: ['./authentication-button.component.css']
})
export class AuthenticationButtonComponent implements OnInit, OnDestroy {
  authUserSubscription: Subscription;
  displayName: string;
  picture: string;

  constructor(public auth: AuthService, private usersService: UsersService) { }


  ngOnInit(): void {
    this.authUserSubscription = this.auth.user$.subscribe(x => {
      if (x !== null) {
        //console.log(x);

        this.displayName = x.given_name ?? x.name;
        this.picture = x.picture;

        let userDto: AuthUserDto = {
          email: x.email,
          email_verified: x.email_verified,
          name: x.name,
          nickname: x.nickname,
          picture: x.picture,
          sub: x.sub
        };

        this.usersService.createOrUpdateUser(userDto).subscribe(x => {
          if (!x.success) {
            console.error(x.getErrorsString());
            console.error(x);
          }
        })
      } else {
        console.info("---[ No Logged in user ]---");
      }
    });

    //this.auth.error$.subscribe(x => console.log(x));
  }

  ngOnDestroy(): void {
    this.authUserSubscription.unsubscribe();
  }

}
