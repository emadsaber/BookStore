"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ApiRequestHelper = void 0;
var ApiRequest_1 = require("./ApiRequest");
var ApiRequestHelper = /** @class */ (function () {
    function ApiRequestHelper() {
    }
    ApiRequestHelper.Create = function (data, userId) {
        return new ApiRequest_1.ApiRequest(data, userId);
    };
    return ApiRequestHelper;
}());
exports.ApiRequestHelper = ApiRequestHelper;
//# sourceMappingURL=ApiRequestHelper.js.map