import { Guid } from "guid-typescript";
import { ApiRequest } from "./ApiRequest";

export class ApiRequestHelper {
  static Create<T>(data: T, userId: Guid): ApiRequest<T> {
    return new ApiRequest<T>(data, userId);
  }
}
