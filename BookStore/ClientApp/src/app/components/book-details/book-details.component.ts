import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Guid } from 'guid-typescript';
import { BookDto } from '../../models/dtos/BookDto';
import { BooksService } from '../../services/books.service';

@Component({
  selector: 'app-book-details',
  templateUrl: './book-details.component.html',
  styleUrls: ['./book-details.component.css']
})
export class BookDetailsComponent implements OnInit {
  id: string;
  book: BookDto;

  constructor(private route: ActivatedRoute, private booksService: BooksService) { }

  ngOnInit(): void {
    this.id = Guid.parse(this.route.snapshot.paramMap.get("id"));

    this.booksService.getBookDetails(id).subscribe(x => {
      //this.book = x
    });
  }

}
