"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.apiConfig = void 0;
var auth_config_1 = require("./auth_config");
exports.apiConfig = {
    books: {
        edit: {
            uri: 'api/Books/EditBookDetails',
            httpMethod: "POST" /* Post */,
            tokenOptions: {
                audience: auth_config_1.authConfig.audience,
                scope: 'edit:bookdetails'
            }
        }
    }
};
//# sourceMappingURL=api_config.js.map