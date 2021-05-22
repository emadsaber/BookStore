import { Component, OnInit } from '@angular/core';
import { BookDto } from '../../models/dtos/BookDto';
import { BooksService } from '../../services/books.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  dashboardBooks: BookDto[];
  pageNumber: number;
  pagesCount: number;

  constructor(private booksService: BooksService) { }

  ngOnInit(): void {
    this.booksService.getDashboardBooks().subscribe(r => {
      if (r.success) {
        this.dashboardBooks = r.data.pagedData;
        this.pageNumber = r.data.pageNumber;
        this.pagesCount = r.data.pagesCount;
        console.log(this.dashboardBooks);
      } else {
        console.log(`error getting dashboard books : success : ${r.getErrorsString()}`);
      }
    });
  }



}
