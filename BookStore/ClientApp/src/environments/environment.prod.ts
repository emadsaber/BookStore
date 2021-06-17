import { authConfig as authConf } from '../../auth_config';

export const environment = {
  production: true,
  auth: {
    clientId: authConf.clientId,
    domain: authConf.domain,
    redirectUri: window.location.origin,
    audience: authConf.audience,
  }
};
