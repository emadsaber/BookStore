"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.environment = void 0;
var auth_config_1 = require("../../auth_config");
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
exports.environment = {
    production: false,
    auth: {
        clientId: auth_config_1.authConfig.clientId,
        domain: auth_config_1.authConfig.domain,
        redirectUri: window.location.origin,
        audience: auth_config_1.authConfig.audience,
        scope: auth_config_1.authConfig.scope
    },
    dev: {
        serverUrl: auth_config_1.authConfig.serverUrl
    }
};
/*
 * In development mode, to ignore zone related error stack frames such as
 * `zone.run`, `zoneDelegate.invokeTask` for easier debugging, you can
 * import the following file, but please comment it out in production mode
 * because it will have performance impact when throw error
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
//# sourceMappingURL=environment.js.map