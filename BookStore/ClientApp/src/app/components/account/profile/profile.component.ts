import { Component, OnDestroy, OnInit } from '@angular/core';
import { AuthService } from '@auth0/auth0-angular';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit, OnDestroy {
  authSubscription: Subscription;
  profileJson: string;

  constructor(public auth: AuthService) { }
  
  ngOnInit(): void {
    this.authSubscription = this.auth.user$.subscribe(x => {
      console.log(x.profile);
      this.profileJson = JSON.stringify(x.profile, null, 2);
      console.log(this.profileJson);
    })
  }

  ngOnDestroy(): void {
    this.authSubscription.unsubscribe();
  }
}
