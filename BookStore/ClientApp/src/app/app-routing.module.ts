import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard, AuthHttpInterceptor, AuthModule, HttpMethod } from '@auth0/auth0-angular';
import { ProfileComponent } from './components/account/profile/profile.component';
import { BookDetailsComponent } from './components/gallery/book-details/book-details.component';
import { HomeComponent } from './components/home/home.component';
import { PageNotFoundComponent } from './components/shared/page-not-found/page-not-found.component';

const routes: Routes = [
    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'details/:id', component: BookDetailsComponent },
    { path: 'profile', component: ProfileComponent, canActivate: [AuthGuard], },
    { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes),
    AuthModule.forRoot({
      domain: 'dev-o8ed6rfw.auth0.com',
      clientId: '1P7T9Sa35TBWQl9KwCDJ9OCdovCZjWj7',
      audience: 'https://book.store.apis',
      httpInterceptor: {
        allowedList: [
          {
            uri: 'api/Books/EditBookDetails',
            httpMethod: HttpMethod.Post,
            tokenOptions: {
              audience: 'https://book.store.apis',
              scope: 'edit:bookdetails'
            }
          }
        ]
      }
    }),
  ],
  exports: [RouterModule],
  providers: [{
    provide: HTTP_INTERCEPTORS,
    useClass: AuthHttpInterceptor,
    multi: true
  }]
})
export class AppRoutingModule { }
