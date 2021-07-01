import { Component, Input, OnInit } from '@angular/core';
import { ReviewDto } from '../../../models/dtos/ReviewDto';

@Component({
  selector: 'app-book-reviews',
  templateUrl: './book-reviews.component.html',
  styleUrls: ['./book-reviews.component.css']
})
export class BookReviewsComponent implements OnInit {

  @Input() reviews: ReviewDto[];

  constructor() { }

  ngOnInit(): void {
  }

}
