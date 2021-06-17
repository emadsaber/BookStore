"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.environment = void 0;
var auth_config_1 = require("../../auth_config");
exports.environment = {
    production: true,
    auth: {
        clientId: auth_config_1.authConfig.clientId,
        domain: auth_config_1.authConfig.domain,
        redirectUri: window.location.origin,
        audience: auth_config_1.authConfig.audience,
    }
};
//# sourceMappingURL=environment.prod.js.map