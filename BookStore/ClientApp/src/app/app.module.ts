import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
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
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'details/:id', component: BookDetailsComponent },
      { path: '**', component: PageNotFoundComponent},
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
