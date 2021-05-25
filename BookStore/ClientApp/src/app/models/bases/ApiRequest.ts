import { Guid } from "guid-typescript";

export class ApiRequest<T> {
  Data: T;
  RequestedAt: string;
  UserId: Guid;

  constructor(data: T, userId: Guid) {
    this.Data = data;
    this.UserId = userId;
    this.RequestedAt = new Date().toISOString();
  }
}
