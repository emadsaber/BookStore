import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { BookDto } from '../../../models/dtos/BookDto';
import { BooksService } from '../../../services/books.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit, OnDestroy {

  dashboardBooks: BookDto[];
  pageNumber: number;
  pagesCount: number;
  getDashboardBooksSubscription: Subscription;

  constructor(private booksService: BooksService) { }
    

  ngOnInit(): void {
    this.getDashboardBooksSubscription = this.booksService.getDashboardBooks().subscribe(r => {
      if (r.success) {
        this.dashboardBooks = r.data.pagedData;
        this.pageNumber = r.data.pageNumber;
        this.pagesCount = r.data.pagesCount;
      } else {
        console.error(`error getting dashboard books : success : ${r.getErrorsString()}`);
      }
    });
  }

  ngOnDestroy(): void {
    this.getDashboardBooksSubscription.unsubscribe();
  }
}
