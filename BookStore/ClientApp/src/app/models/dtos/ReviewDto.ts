import { UserDto } from './UserDto';

export class ReviewDto {
  id: string;
  userId: string;
  reviewText: string;
  rating: string;
  user: UserDto;
}
