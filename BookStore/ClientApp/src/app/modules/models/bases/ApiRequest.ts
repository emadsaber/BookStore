import { Guid } from "guid-typescript";

export class ApiRequest<T> {
  Data: T;
  RequestedAt: string;
  UserId: string;

  constructor(data: T, userId: string) {
    this.Data = data;
    this.UserId = userId;
    this.RequestedAt = new Date().toISOString();
  }
}
