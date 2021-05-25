import { Guid } from "guid-typescript";
import { AuthorDto } from "./AuthorDto";
import { ReviewDto } from "./ReviewDto";


export class BookDto {
  id: Guid;
  title: string;
  subtitle: string;
  description: string;
  rating: number;
  isbn: string;
  publisher: string;
  publishedAt: Date;
  website: string;
  pagesCount: number;
  authors: AuthorDto[];
  reviews: ReviewDto[];
}
