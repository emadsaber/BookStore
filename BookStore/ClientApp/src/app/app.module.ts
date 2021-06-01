import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginButtonComponent } from './components/account//login-button/login-button.component';
import { AuthenticationButtonComponent } from './components/account/authentication-button/authentication-button.component';
import { LogoutButtonComponent } from './components/account/logout-button/logout-button.component';
import { ProfileComponent } from './components/account/profile/profile.component';
import { SignupButtonComponent } from './components/account/signup-button/signup-button.component';
import { AuthorsDetailsComponent } from './components/gallery/authors-details/authors-details.component';
import { BookDetailsComponent } from './components/gallery/book-details/book-details.component';
import { BookReviewsComponent } from './components/gallery/book-reviews/book-reviews.component';
import { DashboardBookComponent } from './components/gallery/dashboard-book/dashboard-book.component';
import { DashboardComponent } from './components/gallery/dashboard/dashboard.component';
import { HomeComponent } from './components/home/home.component';
import { NavMenuComponent } from './components/shared/nav-menu/nav-menu.component';
import { PageNotFoundComponent } from './components/shared/page-not-found/page-not-found.component';



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
    
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
