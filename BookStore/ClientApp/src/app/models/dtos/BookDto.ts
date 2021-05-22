import { Guid } from "guid-typescript";

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
}
