import { Component, OnDestroy, OnInit } from '@angular/core';
import { AuthService } from '@auth0/auth0-angular';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-authentication-button',
  templateUrl: './authentication-button.component.html',
  styleUrls: ['./authentication-button.component.css']
})
export class AuthenticationButtonComponent implements OnInit, OnDestroy {
  authUserSubscription: Subscription;
  displayName: string;
  picture: string;

  constructor(public auth: AuthService) { }
    

  ngOnInit(): void {
    this.authUserSubscription = this.auth.user$.subscribe(x => {
      console.log(x);
      this.displayName = x.given_name;
      this.picture = x.picture;
    });
  }

  ngOnDestroy(): void {
    this.authUserSubscription.unsubscribe();
  }

}
