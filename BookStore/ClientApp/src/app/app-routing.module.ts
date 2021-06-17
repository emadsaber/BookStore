import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard, AuthHttpInterceptor, AuthModule, HttpMethod } from '@auth0/auth0-angular';
import { ProfileComponent } from './components/account/profile/profile.component';
import { BookDetailsComponent } from './components/gallery/book-details/book-details.component';
import { HomeComponent } from './components/home/home.component';
import { PageNotFoundComponent } from './components/shared/page-not-found/page-not-found.component';
import { environment as env } from '../environments/environment';
import { apiConfig } from '../../api_config';
import { ControlPanelHomeComponent } from './components/admin/control-panel-home/control-panel-home.component';

const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'details/:id', component: BookDetailsComponent },
  {
    path: 'admin',
    component: ControlPanelHomeComponent,
    canActivate: [AuthGuard],
    children: [
      { path: 'profile', component: ProfileComponent, canActivate: [AuthGuard], },
    ]
  },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes),
    AuthModule.forRoot({
      ...env.auth,
      httpInterceptor: {
        allowedList: [
          apiConfig.books.edit
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
