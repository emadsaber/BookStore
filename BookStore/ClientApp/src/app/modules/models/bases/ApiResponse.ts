import { ErrorItem } from "../bases/ErrorItem";

export interface ApiResponse<T> {
  data: T;
  success: boolean;
  errors: ErrorItem[];
}

export class ApiResponseHelper {

  static getErrorsString<T>(response: ApiResponse<T>): string {
    if (response.errors === null || response.errors === undefined) return null;

    return response.errors.join('-');
  }
}
