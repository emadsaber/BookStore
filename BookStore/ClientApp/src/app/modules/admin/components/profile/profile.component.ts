import { AfterViewInit, Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '@auth0/auth0-angular';
import { Subscription } from 'rxjs';
import { ApiResponseHelper } from '../../../models/bases/ApiResponse';
import { UserDto } from '../../../models/dtos/UserDto';
import { UsersService } from '../../../services/users.service';
import { GenericValidator } from '../../../shared/generic-validator';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit, OnDestroy, AfterViewInit {
  authSubscription: Subscription;
  getUserSubscription: Subscription;
  userDto: UserDto;
  formControls: FormGroup;
  displayMessage: { [key: string]: string } = {};
  validationMessages: { [key: string]: { [key: string]: string } };
  genericValidator: GenericValidator;

  constructor(public auth: AuthService, private usersService: UsersService,
    private fb: FormBuilder) {

    this.validationMessages = {
      firstName: {
        required: "First name is required",
        maxlength: "First name should be at most 50 characters"
      }
    }

    this.genericValidator = new GenericValidator(this.validationMessages);
  }

  ngOnInit(): void {
    //async data
    this.authSubscription = this.auth.user$.subscribe(x => {

      this.getUserSubscription = this.usersService.getUserByAuthUserId(x.sub).subscribe(res => {
        if (res.success) {
          console.log(res.data);
          this.userDto = res.data;
          this.formControls.setValue({
            id: res.data.id,
            firstName: res.data.firstName,
            lastName: res.data.lastName,
            nickName: res.data.nickname,
            pictureUrl: res.data.pictureUrl,
            email: res.data.email,
            emailVerified: res.data.emailVerified
          });
        } else {
          console.error(ApiResponseHelper.getErrorsString(res));
        }
      })

    });

    this.formControls = this.fb.group(
      {
        id: [''],
        firstName: ['', [Validators.required, Validators.maxLength(50)]],
        lastName: ['', [Validators.required, Validators.maxLength(50)]],
        nickName: '',
        email: ['', [Validators.required, Validators.email]],
        pictureUrl: ['', [Validators.required]],
        emailVerified: ['']
      }
    )
  }

  onSubmit() {
    if (this.formControls.valid) {
      //todo : update user data
      console.log(this.formControls.value);
    }
  }

  ngAfterViewInit() {
    this.formControls.valueChanges.subscribe(() => {
      this.displayMessage = this.genericValidator.processMessages(this.formControls);
    })
  }

  ngOnDestroy(): void {
    this.authSubscription.unsubscribe();
    this.getUserSubscription.unsubscribe();
  }
}
