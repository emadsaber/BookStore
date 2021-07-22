"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ApiRequest = void 0;
var ApiRequest = /** @class */ (function () {
    function ApiRequest(data, userId) {
        this.Data = data;
        this.UserId = userId;
        this.RequestedAt = new Date().toISOString();
    }
    return ApiRequest;
}());
exports.ApiRequest = ApiRequest;
//# sourceMappingURL=ApiRequest.js.map