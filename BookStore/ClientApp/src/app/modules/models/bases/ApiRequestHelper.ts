import { ApiRequest } from "./ApiRequest";

export class ApiRequestHelper {
  static Create<T>(data: T, userId: string): ApiRequest<T> {
    return new ApiRequest<T>(data, userId);
  }
}
