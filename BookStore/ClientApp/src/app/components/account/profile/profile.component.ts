import { Component, OnDestroy, OnInit } from '@angular/core';
import { AuthService } from '@auth0/auth0-angular';
import { Subscription } from 'rxjs';
import { UserDto } from '../../../models/dtos/UserDto';
import { UsersService } from '../../../services/users.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit, OnDestroy {
  authSubscription: Subscription;
  getUserSubscription: Subscription;
  userDto: UserDto;

  constructor(public auth: AuthService, private usersService: UsersService) { }
  
  ngOnInit(): void {
    
    this.authSubscription = this.auth.user$.subscribe(x => {

      this.getUserSubscription = this.usersService.getUserByAuthUserId(x.sub).subscribe(res => {
        if (res.success) {
          console.log(res.data);
          this.userDto = res.data;
        } else {
          console.error(res.getErrorsString());
        }
      })
      
    })
  }

  ngOnDestroy(): void {
    this.authSubscription.unsubscribe();
    this.getUserSubscription.unsubscribe();
  }
}
