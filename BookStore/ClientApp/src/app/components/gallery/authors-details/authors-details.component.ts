import { Component, Input, OnInit } from '@angular/core';
import { AuthorDto } from '../../../models/dtos/AuthorDto';

@Component({
  selector: 'app-authors-details',
  templateUrl: './authors-details.component.html',
  styleUrls: ['./authors-details.component.css']
})
export class AuthorsDetailsComponent implements OnInit {

  @Input() authors: AuthorDto[];

  constructor() { }

  ngOnInit(): void {
    console.log(this.authors);
  }

}
