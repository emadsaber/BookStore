import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';


import { AppComponent } from './app.component';
import { NavMenuComponent } from './components/shared/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { DashboardComponent } from './components/gallery/dashboard/dashboard.component';
import { DashboardBookComponent } from './components/gallery/dashboard-book/dashboard-book.component';
import { BookDetailsComponent } from './components/gallery/book-details/book-details.component';
import { PageNotFoundComponent } from './components/shared/page-not-found/page-not-found.component';
import { AuthorsDetailsComponent } from './components/gallery/authors-details/authors-details.component';
import { BookReviewsComponent } from './components/gallery/book-reviews/book-reviews.component';
import { AuthGuard, AuthModule } from '@auth0/auth0-angular';
import { environment as env } from '../environments/environment';
import { LoginButtonComponent } from './components/account//login-button/login-button.component';
import { SignupButtonComponent } from './components/account/signup-button/signup-button.component';
import { LogoutButtonComponent } from './components/account/logout-button/logout-button.component';
import { AuthenticationButtonComponent } from './components/account/authentication-button/authentication-button.component';
import { ProfileComponent } from './components/account/profile/profile.component';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { AuthHttpInterceptor } from '@auth0/auth0-angular'

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    DashboardComponent,
    DashboardBookComponent,
    BookDetailsComponent,
    PageNotFoundComponent,
    AuthorsDetailsComponent,
    BookReviewsComponent,
    LoginButtonComponent,
    SignupButtonComponent,
    LogoutButtonComponent,
    AuthenticationButtonComponent,
    ProfileComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'details/:id', component: BookDetailsComponent },
      { path: 'profile', component: ProfileComponent, canActivate: [AuthGuard] },
      { path: '**', component: PageNotFoundComponent},
    ]),
    AuthModule.forRoot({
      ...env.auth,
      httpInterceptor: {
        allowedList: [{
          uri: `${env.dev.serverUrl}/api/Home/GetBookDetails`,
          tokenOptions: {
            audience: "read:bookdetails"
          }
        }]
      }
    })
  ],
  providers: [{
    provide: HTTP_INTERCEPTORS,
    useClass: AuthHttpInterceptor,
    multi: true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
