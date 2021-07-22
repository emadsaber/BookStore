import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthorsDetailsComponent } from './components/authors-details/authors-details.component';
import { BookReviewsComponent } from './components/book-reviews/book-reviews.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { DashboardBookComponent } from './components/dashboard-book/dashboard-book.component';
import { BookDetailsComponent } from './components/book-details/book-details.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', component: DashboardComponent, },
  { path: 'details/:id', component: BookDetailsComponent }
];

@NgModule({
  declarations: [
    AuthorsDetailsComponent,
    BookReviewsComponent,
    DashboardComponent,
    DashboardBookComponent,
    BookDetailsComponent,
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule,
    DashboardComponent
  ]
})
export class DashboardModule { }
