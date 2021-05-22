import { Guid } from "guid-typescript";
import { ErrorItem } from "../bases/ErrorItem";

export class ApiResponse<T> {
  data: T;
  success: boolean;
  errors: ErrorItem[];

  getErrorsString(): string {
    if (this.errors === null || this.errors === undefined) return null;

    return this.errors.join('-');
  }
}
