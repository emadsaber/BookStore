import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AuthService } from '@auth0/auth0-angular';
import { Subscription } from 'rxjs';
import { ApiResponseHelper } from 'src/app/models/bases/ApiResponse';
import { BookDto } from '../../../models/dtos/BookDto';
import { BooksService } from '../../../services/books.service';

@Component({
  selector: 'app-book-details',
  templateUrl: './book-details.component.html',
  styleUrls: ['./book-details.component.css']
})
export class BookDetailsComponent implements OnInit, OnDestroy {

  id: string;
  book: BookDto;
  getBookSubscription: Subscription;

  constructor(private route: ActivatedRoute, private booksService: BooksService,
    private auth: AuthService) { }


  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get("id");
    this.auth.error$.subscribe(x => console.log(x));

    this.getBookSubscription = this.booksService.getBookDetails(this.id).subscribe(x => {
      if (x.success) {
        this.book = x.data;
      } else {
        console.error(ApiResponseHelper.getErrorsString(x));
      }
    });

  }

  ngOnDestroy(): void {
    this.getBookSubscription.unsubscribe();
  }
}
