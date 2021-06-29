import { Guid } from "guid-typescript";
import { AuthorDto } from "./AuthorDto";
import { ReviewDto } from "./ReviewDto";


export class BookDto {
  id: string;
  title: string;
  subtitle: string;
  description: string;
  rating: number;
  isbn: string;
  publisher: string;
  publishedAt: string;
  website: string;
  pagesCount: number;
  authors: AuthorDto[];
  reviews: ReviewDto[];
}
