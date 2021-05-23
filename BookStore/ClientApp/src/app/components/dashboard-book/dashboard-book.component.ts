import { Component, Input, OnInit } from '@angular/core';
import { BookDto } from '../../models/dtos/BookDto';

@Component({
  selector: 'app-dashboard-book',
  templateUrl: './dashboard-book.component.html',
  styleUrls: ['./dashboard-book.component.css']
})
export class DashboardBookComponent implements OnInit {

  @Input() book: BookDto;

  constructor() { }

  ngOnInit(): void {
  }

}
