import { Guid } from "guid-typescript";

export class ApiRequest<T> {
  Data: T;
  RequestedAt: Date;
  UserId: Guid;
}
