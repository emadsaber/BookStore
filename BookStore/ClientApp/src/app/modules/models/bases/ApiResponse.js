"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ApiResponse = void 0;
var ApiResponse = /** @class */ (function () {
    function ApiResponse() {
    }
    ApiResponse.prototype.getErrorsString = function () {
        if (this.errors === null || this.errors === undefined)
            return null;
        return this.errors.join('-');
    };
    return ApiResponse;
}());
exports.ApiResponse = ApiResponse;
//# sourceMappingURL=ApiResponse.js.map